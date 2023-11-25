using eLibra.Models;

namespace eLibra.AddEditForms;

public partial class UserEditForm : Form
{
    public User NewUser { get; private set; }

    public UserEditForm()
    {
        InitializeComponent();
        NewUser = new User();
    }

    public UserEditForm(User existingUser)
    {
        InitializeComponent();
        NewUser = new User
        {
            Name = existingUser.Name,
            Email = existingUser.Email
        };
        textBoxName.Text = existingUser.Name;
        textBoxEmail.Text = existingUser.Email;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            MessageBox.Show("Пожалуйста, введите имя пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!IsValidEmail(textBoxEmail.Text))
        {
            MessageBox.Show("Пожалуйста, введите корректный email.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        NewUser.Name = textBoxName.Text;
        NewUser.Email = textBoxEmail.Text;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}
