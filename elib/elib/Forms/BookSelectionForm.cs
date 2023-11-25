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

namespace eLibra.Forms;

public partial class BookSelectionForm : Form
{
    public Book SelectedBook { get; private set; }

    public BookSelectionForm(List<Book> books, string prompt = "Выбор книги:")
    {
        InitializeComponent();

        labelPrompt.Text = prompt;
        comboBoxBooks.DataSource = books;
        comboBoxBooks.DisplayMember = "Title";
    }

    private void BtnOK_Click(object sender, EventArgs e)
    {
        SelectedBook = comboBoxBooks.SelectedItem as Book;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
