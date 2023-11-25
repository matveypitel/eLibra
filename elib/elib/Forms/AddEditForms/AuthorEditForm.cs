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

public partial class AuthorEditForm : Form
{
    public Author NewAuthor { get; private set; }

    public AuthorEditForm()
    {
        InitializeComponent();
        NewAuthor = new Author();
    }
    public AuthorEditForm(Author existingAuthor)
    {
        InitializeComponent();
        NewAuthor = new Author
        {
            Name = existingAuthor.Name,
        };
    }

    private void BtnOK_Click(object sender, EventArgs e)
    {
        string authorName = textBoxAuthorName.Text.Trim();

        if (string.IsNullOrWhiteSpace(authorName))
        {
            MessageBox.Show("Введите ФИО автора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (NewAuthor != null && !string.IsNullOrWhiteSpace(NewAuthor.Name))
        {
            NewAuthor.Name = authorName;
        }
        else
        {
            // Добавление нового автора в коллекцию, если это создание нового автора
            NewAuthor = new Author { Name = authorName };
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
