using eLibra.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibra.AddEditForms;

public partial class BookEditForm : Form
{
    public Book NewBook { get; private set; }

    // Списки существующих авторов и жанров
    private List<Author> existingAuthors;
    private List<Genre> existingGenres;

    public BookEditForm(List<Author> authors, List<Genre> genres)
    {
        InitializeComponent();
        existingAuthors = authors;
        existingGenres = genres;
        InitializeComboBoxes();
        NewBook = new Book();
    }

    public BookEditForm(Book existingBook, List<Author> authors, List<Genre> genres)
    {
        InitializeComponent();
        existingAuthors = authors;
        existingGenres = genres;
        InitializeComboBoxes();
        NewBook = new Book
        {
            Title = existingBook.Title,
            Author = existingBook.Author,
            Genre = existingBook.Genre
        };
        textBoxTitle.Text = existingBook.Title;
    }

    private void InitializeComboBoxes()
    {
        // Заполнение выпадающих списков существующими авторами и жанрами
        comboBoxAuthor.DataSource = existingAuthors;
        comboBoxAuthor.DisplayMember = "Name";

        comboBoxGenre.DataSource = existingGenres;
        comboBoxGenre.DisplayMember = "Name";
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
        {
            MessageBox.Show("Заполните поле названия книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (comboBoxAuthor.SelectedItem is Author selectedAuthor)
        {
            NewBook.Author = selectedAuthor;
        }
        else if (!string.IsNullOrWhiteSpace(textBoxNewAuthor.Text))
        {
            NewBook.Author = new Author { Name = textBoxNewAuthor.Text };
        }
        else
        {
            MessageBox.Show("Выберите существующего автора или создайте нового", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (comboBoxGenre.SelectedItem is Genre selectedGenre)
        {
            NewBook.Genre = selectedGenre;
        }
        else if (!string.IsNullOrWhiteSpace(textBoxNewGenre.Text))
        {
            NewBook.Genre = new Genre { Name = textBoxNewGenre.Text };
        }
        else
        {
            MessageBox.Show("Выберите существующий жанр или создайте новый", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        NewBook.Title = textBoxTitle.Text;

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
    private void ComboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
    {
        textBoxNewAuthor.Clear();
    }

    private void ComboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
    {
        textBoxNewGenre.Clear();
    }

    private void TextBoxNewAuthor_TextChanged(object sender, EventArgs e)
    {
        comboBoxAuthor.SelectedItem = null;
    }
    private void TextBoxNewGenre_TextChanged(object sender, EventArgs e)
    {
        comboBoxGenre.SelectedItem = null;
    }
}
