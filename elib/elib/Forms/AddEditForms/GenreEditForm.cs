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

public partial class GenreEditForm : Form
{
    public Genre NewGenre { get; private set; }

    public GenreEditForm()
    {
        InitializeComponent();
        NewGenre = new Genre();
    }
    public GenreEditForm(Genre existingGenre)
    {
        InitializeComponent();
        NewGenre = new Genre
        {
            Name = existingGenre.Name,
        };
    }

    private void BtnOK_Click(object sender, EventArgs e)
    {
        string genreName = textBoxGenreName.Text.Trim();

        if (string.IsNullOrWhiteSpace(genreName))
        {
            MessageBox.Show("Введите название жанра", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        NewGenre = new Genre { Name = genreName };

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
