using eLibra.Models;
using eLibra.AddEditForms;
using eLibra.Controllers;
using eLibra.Forms;

namespace eLibra;

public partial class MainForm : Form
{
    private Library library;
    private string libraryFileName = Path.Combine("Data", "eLibraData.xml");
    private DataGridViewRow selectedRow;
    private bool formattingEnabled = true;

    public MainForm()
    {
        InitializeComponent();
        LoadLibrary();
    }
    private void ShowDataGridView()
    {
        dataGridView.Visible = true;
    }
    private void HideDataGridViewMenuStrip()
    {
        dataGridView.Visible = false;
        menuStripMain.Visible = false;
    }
    private void HideMainMenu()
    {
        btnLogin.Visible = false;
        btnHelp.Visible = false;
        btnExit.Visible = false;
    }
    private void ShowMainMenu() 
    {
        btnLogin.Visible = true;
        btnHelp.Visible = true;
        btnExit.Visible = true;
    }
    private void LoadLibrary()
    {
        try
        {
            if (File.Exists(libraryFileName))
            {
                library = LibraryLoader.LoadLibrary(libraryFileName);
            }
            else
            {
                library = new Library();
                SaveLibrary();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки библиотеки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            library = new Library();
        }
    }
    private void SaveLibrary()
    {
        try
        {
            LibraryLoader.SaveLibrary(library, libraryFileName);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения библиотеки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void MainForm_Load(object sender, EventArgs e)
    {
        HideDataGridViewMenuStrip();

        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        menuStripMain.Dock = DockStyle.Top;
    }
    private void DisableFormatting()
    {
        formattingEnabled = false;
    }
    private void EnableFormatting()
    {
        formattingEnabled = true;
    }
    private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (!formattingEnabled)
        {
            e.FormattingApplied = false;
            return;
        }
        if (e.ColumnIndex == dataGridView.Columns["Author"].Index && e.Value is Author author)
        {
            e.Value = author.Name;
        }
        else if (e.ColumnIndex == dataGridView.Columns["Genre"].Index && e.Value is Genre genre)
        {
            e.Value = genre.Name;
        }
    }
    private void ShowMenu()
    {
        menuStripMain.Visible = true;
    }
    private void ClearButtons()
    {
        foreach (Control control in Controls.OfType<Button>().ToList())
        {
            // Проверка, что кнопка не принадлежит к числу исключаемых
            if (control.Name != "btnLogin" && control.Name != "btnHelp" && control.Name != "btnExit")
            {
                Controls.Remove(control);
                control.Dispose();
            }
        }
    }
    private void ShowUserButtons()
    {
        ClearButtons();

        Button btnAddUser = new();
        btnAddUser.Text = "Добавить";
        btnAddUser.Click += BtnAddUser_Click;

        Button btnEditUser = new();
        btnEditUser.Text = "Изменить";
        btnEditUser.Click += BtnEditUser_Click;

        Button btnRemoveUser = new();
        btnRemoveUser.Text = "Удалить";
        btnRemoveUser.Click += BtnRemoveUser_Click;

        Button btnTake = new();
        btnTake.Text = "Взять книгу";
        btnTake.Click += BtnTake_Click;

        Button btnReturn = new();
        btnReturn.Text = "Вернуть книгу";
        btnReturn.Click += BtnReturn_Click;

        int buttonWidth = 100;
        int buttonHeight = 30;

        btnAddUser.Location = new Point(10, 410);
        btnEditUser.Location = new Point(110, 410);
        btnRemoveUser.Location = new Point(210, 410);
        btnTake.Location = new Point(310, 410);
        btnReturn.Location = new Point(410, 410);

        btnAddUser.Size = new Size(buttonWidth, buttonHeight);
        btnEditUser.Size = new Size(buttonWidth, buttonHeight);
        btnRemoveUser.Size = new Size(buttonWidth, buttonHeight);
        btnTake.Size = new Size(buttonWidth, buttonHeight);
        btnReturn.Size = new Size(buttonWidth, buttonHeight);

        Controls.Add(btnAddUser);
        Controls.Add(btnEditUser);
        Controls.Add(btnRemoveUser);
        Controls.Add(btnTake);
        Controls.Add(btnReturn);
    }
    private void ShowBooksButtons()
    {
        ClearButtons();

        Button btnAddBook = new();
        btnAddBook.Text = "Добавить";
        btnAddBook.Click += BtnAddBook_Click;

        Button btnEditBook = new();
        btnEditBook.Text = "Изменить";
        btnEditBook.Click += BtnEditBook_Click;

        Button btnRemoveBook = new();
        btnRemoveBook.Text = "Удалить";
        btnRemoveBook.Click += BtnRemoveBook_Click;

        int buttonWidth = 100;
        int buttonHeight = 30;

        btnAddBook.Location = new Point(10, 410);
        btnEditBook.Location = new Point(110, 410);
        btnRemoveBook.Location = new Point(210, 410);

        btnAddBook.Size = new Size(buttonWidth, buttonHeight);
        btnEditBook.Size = new Size(buttonWidth, buttonHeight);
        btnRemoveBook.Size = new Size(buttonWidth, buttonHeight);

        Controls.Add(btnAddBook);
        Controls.Add(btnEditBook);
        Controls.Add(btnRemoveBook);
    }
    private void ShowGenresButtons()
    {
        ClearButtons();

        Button btnAddGenre = new();
        btnAddGenre.Text = "Добавить";
        btnAddGenre.Click += BtnAddGenre_Click;

        Button btnEditGenre = new();
        btnEditGenre.Text = "Изменить";
        btnEditGenre.Click += BtnEditGenre_Click;

        Button btnRemoveGenre = new();
        btnRemoveGenre.Text = "Удалить";
        btnRemoveGenre.Click += BtnRemoveGenre_Click;

        int buttonWidth = 100;
        int buttonHeight = 30;

        btnAddGenre.Location = new Point(10, 410);
        btnEditGenre.Location = new Point(110, 410);
        btnRemoveGenre.Location = new Point(210, 410);

        btnAddGenre.Size = new Size(buttonWidth, buttonHeight);
        btnEditGenre.Size = new Size(buttonWidth, buttonHeight);
        btnRemoveGenre.Size = new Size(buttonWidth, buttonHeight);

        Controls.Add(btnAddGenre);
        Controls.Add(btnEditGenre);
        Controls.Add(btnRemoveGenre);
    }
    private void ShowAuthorsButtons()
    {
        ClearButtons();

        Button btnAddAuthor = new();
        btnAddAuthor.Text = "Добавить";
        btnAddAuthor.Click += BtnAddAuthor_Click;

        Button btnEditAuthor = new();
        btnEditAuthor.Text = "Изменить";
        btnEditAuthor.Click += BtnEditAuthor_Click;

        Button btnRemoveAuthor = new();
        btnRemoveAuthor.Text = "Удалить";
        btnRemoveAuthor.Click += BtnRemoveAuthor_Click;

        int buttonWidth = 100;
        int buttonHeight = 30;

        btnAddAuthor.Location = new Point(10, 410);
        btnEditAuthor.Location = new Point(110, 410);
        btnRemoveAuthor.Location = new Point(210, 410);

        btnAddAuthor.Size = new Size(buttonWidth, buttonHeight);
        btnEditAuthor.Size = new Size(buttonWidth, buttonHeight);
        btnRemoveAuthor.Size = new Size(buttonWidth, buttonHeight);

        Controls.Add(btnAddAuthor);
        Controls.Add(btnEditAuthor);
        Controls.Add(btnRemoveAuthor);
    }
    private void BooksDisplay()
    {
        DisableFormatting();
        dataGridView.DataSource = null;
        dataGridView.DataSource = library.Books;
        EnableFormatting();
        dataGridView.CellFormatting += DataGridView_CellFormatting;
    }

    private void BtnRemoveGenre_Click(object? sender, EventArgs e)
    {
        Genre selectedGenre = GetSelectedGenre();
        if (selectedGenre != null)
        {
            library.Genres.Remove(selectedGenre);
            SaveLibrary();
            dataGridView.DataSource = null;
            dataGridView.DataSource = library.Genres;
        }
    }

    private void BtnEditGenre_Click(object? sender, EventArgs e)
    {
        Genre selectedGenre = GetSelectedGenre();
        if (selectedGenre != null)
        {
            GenreEditForm genreEditForm = new(selectedGenre);
            if (genreEditForm.ShowDialog() == DialogResult.OK)
            {
                int index = library.Genres.IndexOf(selectedGenre);
                library.Genres[index] = genreEditForm.NewGenre;
                SaveLibrary();
                dataGridView.DataSource = null;
                dataGridView.DataSource = library.Genres;
            }
        }
    }

    private void BtnAddGenre_Click(object? sender, EventArgs e)
    {
        GenreEditForm genreEditForm = new();
        if (genreEditForm.ShowDialog() == DialogResult.OK)
        {
            library.Genres.Add(genreEditForm.NewGenre);
            SaveLibrary();
            dataGridView.DataSource = null;
            dataGridView.DataSource = library.Genres;
        }
    }

    private void BtnRemoveAuthor_Click(object? sender, EventArgs e)
    {
        Author selectedAuthor = GetSelectedAuthor();
        if (selectedAuthor != null)
        {
            library.Authors.Remove(selectedAuthor);
            SaveLibrary();

            dataGridView.DataSource = null;
            dataGridView.DataSource = library.Authors;

        }
    }

    private void BtnEditAuthor_Click(object? sender, EventArgs e)
    {
        Author selectedAuthor = GetSelectedAuthor();
        if (selectedAuthor != null)
        {
            AuthorEditForm authorEditForm = new(selectedAuthor);
            if (authorEditForm.ShowDialog() == DialogResult.OK)
            {
                int index = library.Authors.IndexOf(selectedAuthor);
                library.Authors[index] = authorEditForm.NewAuthor;
                SaveLibrary();

                dataGridView.DataSource = null;
                dataGridView.DataSource = library.Authors;
            }
        }
    }

    private void BtnAddAuthor_Click(object? sender, EventArgs e)
    {
        AuthorEditForm authorEditForm = new();
        if (authorEditForm.ShowDialog() == DialogResult.OK)
        {
            library.Authors.Add(authorEditForm.NewAuthor);
            SaveLibrary();

            dataGridView.DataSource = null;
            dataGridView.DataSource = library.Authors;
        }
    }

    private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DisableFormatting();
        ShowUserButtons();
        dataGridView.DataSource = null;
        dataGridView.DataSource = library.Users;

        bool borrowedBooksColumnExists = dataGridView.Columns.Cast<DataGridViewColumn>().Any(col => col.DataPropertyName == "BorrowedBooksDisplay");

        if (!borrowedBooksColumnExists)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = library.Users;
            DataGridViewTextBoxColumn borrowedBooksColumn = new DataGridViewTextBoxColumn();
            borrowedBooksColumn.DataPropertyName = "BorrowedBooksDisplay";
            borrowedBooksColumn.HeaderText = "Borrowed Books";
            borrowedBooksColumn.Name = "BorrowedBooksDisplay";
            dataGridView.Columns.Add(borrowedBooksColumn);
        }

    }
    private void BtnAddUser_Click(object sender, EventArgs e)
    {
        UserEditForm userEditForm = new();
        if (userEditForm.ShowDialog() == DialogResult.OK)
        {
            library.Users.Add(userEditForm.NewUser);
            SaveLibrary();
            dataGridView.DataSource = null;
            dataGridView.DataSource = library.Users;
        }
    }

    private void BtnEditUser_Click(object sender, EventArgs e)
    {
        User selectedUser = GetSelectedUser();
        if (selectedUser != null)
        {
            UserEditForm userEditForm = new(selectedUser);
            if (userEditForm.ShowDialog() == DialogResult.OK)
            {
                int index = library.Users.IndexOf(selectedUser);
                library.Users[index] = userEditForm.NewUser;
                SaveLibrary();

                dataGridView.DataSource = null;
                dataGridView.DataSource = library.Users;
                selectedRow = null;
            }
        }
    }

    private void BtnRemoveUser_Click(object sender, EventArgs e)
    {
        User selectedUser = GetSelectedUser();
        if (selectedUser != null)
        {
            library.Users.Remove(selectedUser);
            SaveLibrary();

            dataGridView.DataSource = null;
            dataGridView.DataSource = library.Users;

            selectedRow = null;
        }
    }

    private void BtnTake_Click(object sender, EventArgs e)
    {
        User selectedUser = GetSelectedUser();

        if (selectedUser != null)
        {
            BookSelectionForm bookSelectionForm = new BookSelectionForm(library.Books);
            if (bookSelectionForm.ShowDialog() == DialogResult.OK)
            {
                Book selectedBook = bookSelectionForm.SelectedBook;

                if (selectedBook != null && !IsBookTaken(selectedBook))
                {
                    selectedUser.BorrowedBooks.Add(new BorrowedBook { UserName = selectedUser.Name, Book = selectedBook });
                    SaveLibrary();
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = library.Users;
                }
                else
                {
                    MessageBox.Show("Эта книга уже взята пользователем", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }

    private void BtnReturn_Click(object sender, EventArgs e)
    {
        User selectedUser = GetSelectedUser();

        if (selectedUser != null)
        {
            List<Book> userBorrowedBooks = selectedUser.BorrowedBooks.Select(b => b.Book).ToList();

            BookSelectionForm bookSelectionForm = new BookSelectionForm(userBorrowedBooks, "Выберите книгу для возврата:");
            if (bookSelectionForm.ShowDialog() == DialogResult.OK)
            {
                Book selectedBook = bookSelectionForm.SelectedBook;

                if (selectedBook != null)
                {
                    var borrowedBook = selectedUser.BorrowedBooks.FirstOrDefault(b => b.Book == selectedBook);

                    if (borrowedBook != null)
                    {
                        selectedUser.BorrowedBooks.Remove(borrowedBook);
                        SaveLibrary();
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = library.Users;
                    }
                    else
                    {
                        MessageBox.Show("Эта книга не взята пользователем", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Книга не выбрана для возврата", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
    private User GetSelectedUser()
    {
        if (dataGridView.SelectedRows.Count > 0)
        {
            return dataGridView.SelectedRows[0].DataBoundItem as User;
        }

        return null;
    }
    private bool IsBookTaken(Book book)
    {
        foreach (var user in library.Users)
        {
            if (user.BorrowedBooks.Any(b => b.Book == book))
            {
                return true;
            }
        }

        return false;
    }
    private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowBooksButtons();
        BooksDisplay();
    }
    private void BtnRemoveBook_Click(object? sender, EventArgs e)
    {
        Book selectedBook = GetSelectedBook();
        if (selectedBook != null)
        {
            library.Books.Remove(selectedBook);
            SaveLibrary();
            BooksDisplay();
        }
    }

    private void BtnEditBook_Click(object? sender, EventArgs e)
    {
        Book selectedBook = GetSelectedBook();
        if (selectedBook != null)
        {
            BookEditForm bookEditForm = new(selectedBook, library.Authors, library.Genres);
            if (bookEditForm.ShowDialog() == DialogResult.OK)
            {
                int index = library.Books.IndexOf(selectedBook);
                library.Books[index] = bookEditForm.NewBook;
                SaveLibrary();
                BooksDisplay();
            }
        }
    }

    private void BtnAddBook_Click(object? sender, EventArgs e)
    {
        BookEditForm bookEditForm = new(library.Authors, library.Genres);

        if (bookEditForm.ShowDialog() == DialogResult.OK)
        {
            Author existingAuthor = library.Authors.FirstOrDefault(a => a.Name == bookEditForm.NewBook.Author.Name);
            if (existingAuthor != null)
            {
                bookEditForm.NewBook.Author = existingAuthor;
            }
            else
            {
                library.Authors.Add(bookEditForm.NewBook.Author);
            }

            Genre existingGenre = library.Genres.FirstOrDefault(g => g.Name == bookEditForm.NewBook.Genre.Name);
            if (existingGenre != null)
            {
                bookEditForm.NewBook.Genre = existingGenre;
            }
            else
            {
                library.Genres.Add(bookEditForm.NewBook.Genre);
            }

            library.Books.Add(bookEditForm.NewBook);
            SaveLibrary();
            BooksDisplay();
        }
    }
    private Book GetSelectedBook()
    {
        if (dataGridView.SelectedRows.Count > 0)
        {
            return dataGridView.SelectedRows[0].DataBoundItem as Book;
        }

        return null;
    }
    private void GenresToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DisableFormatting();
        ShowGenresButtons();
        dataGridView.DataSource = null;
        dataGridView.DataSource = library.Genres;
    }
    private Genre GetSelectedGenre()
    {
        if (dataGridView.SelectedRows.Count > 0)
        {
            return dataGridView.SelectedRows[0].DataBoundItem as Genre;
        }

        return null;
    }
    private void AuthorsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DisableFormatting();
        ShowAuthorsButtons();
        dataGridView.DataSource = null;
        dataGridView.DataSource = library.Authors;
    }
    private Author GetSelectedAuthor()
    {
        if (dataGridView.SelectedRows.Count > 0)
        {
            var selectedAuthor = dataGridView.SelectedRows[0].DataBoundItem as Author;

            return selectedAuthor;

        }

        return null;
    }
    private void BtnLogin_Click(object sender, EventArgs e)
    {
        ShowMenu();
        ShowDataGridView();
        HideMainMenu();
    }

    private void BtnHelp_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Помощь по использованию приложения \"Электронная библиотека - eLibra\"\r\n\r\n1.Пользователи:\r\n\r\nДобавление пользователя: Нажмите кнопку \"Добавить\", введите необходимую информацию о новом пользователе, и нажмите \"Сохранить\".\r\nРедактирование пользователя: Выберите пользователя из списка, нажмите \"Изменить\", внесите необходимые изменения, и нажмите \"Сохранить\".\r\nУдаление пользователя: Выберите пользователя из списка, нажмите \"Удалить\", чтобы исключить пользователя из библиотеки.\r\n\n2.Жанры:\r\n\r\nДобавление жанра: Нажмите кнопку \"Добавить\", введите новый жанр, и нажмите \"Сохранить\".\r\nРедактирование жанра: Выберите жанр из списка, нажмите \"Изменить\", внесите изменения, и нажмите \"Сохранить\".\r\nУдаление жанра: Выберите жанр из списка, нажмите \"Удалить\", чтобы исключить жанр из библиотеки.\r\n\n3.Авторы:\r\n\r\nДобавление автора: Нажмите кнопку \"Добавить\", введите информацию о новом авторе, и нажмите \"Сохранить\".\r\nРедактирование автора: Выберите автора из списка, нажмите \"Изменить\", внесите изменения, и нажмите \"Сохранить\".\r\nУдаление автора: Выберите автора из списка, нажмите \"Удалить\", чтобы исключить автора из библиотеки.\r\n\n4.Книги:\r\n\r\nДобавление книги: Нажмите кнопку \"Добавить\", введите информацию о новой книге, выберите автора и жанр, и нажмите \"Сохранить\".\r\nРедактирование книги: Выберите книгу из списка, нажмите \"Изменить\", внесите изменения, и нажмите \"Сохранить\".\r\nУдаление книги: Выберите книгу из списка, нажмите \"Удалить\", чтобы исключить книгу из библиотеки.\r\n\n6.Взятие и возвращение книг:\r\n\r\nВзятие книги: Выберите пользователя и книгу, нажмите \"Взять\", чтобы добавить книгу в список взятых книг пользователя.\r\nВозвращение книги: Выберите пользователя и книгу, нажмите \"Вернуть\", чтобы убрать книгу из списка взятых книг пользователя.\r\n\n7.Помощь:\r\n\r\nПомощь по приложению: Нажмите \"Помощь\", чтобы получить дополнительную информацию по использованию приложения.\r\n\n8.Выход:\r\n\r\nЗавершение работы приложения: Нажмите \"Выход\", чтобы закрыть приложение.", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
        Close();
        Application.Exit();
    }
    private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            selectedRow = dataGridView.Rows[e.RowIndex];
        }
    }
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        SaveLibrary();
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        HideDataGridViewMenuStrip();
        ClearButtons();
        ShowMainMenu();
    }
}
