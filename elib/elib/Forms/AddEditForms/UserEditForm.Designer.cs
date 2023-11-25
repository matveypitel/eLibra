namespace eLibra.AddEditForms;

partial class UserEditForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBoxName = new TextBox();
        textBoxEmail = new TextBox();
        btnCancel = new Button();
        btnSave = new Button();
        labelName = new Label();
        labelEmail = new Label();
        SuspendLayout();
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(97, 31);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(179, 23);
        textBoxName.TabIndex = 0;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Location = new Point(97, 83);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(179, 23);
        textBoxEmail.TabIndex = 1;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(194, 133);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(82, 26);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "Отменить";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += BtnCancel_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(97, 133);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(80, 26);
        btnSave.TabIndex = 3;
        btnSave.Text = "Сохранить";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += BtnSave_Click;
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Location = new Point(31, 34);
        labelName.Name = "labelName";
        labelName.Size = new Size(37, 15);
        labelName.TabIndex = 4;
        labelName.Text = "Имя: ";
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Location = new Point(31, 91);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(47, 15);
        labelEmail.TabIndex = 5;
        labelEmail.Text = "e-mail: ";
        labelEmail.TextAlign = ContentAlignment.TopRight;
        // 
        // UserEditForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(347, 171);
        Controls.Add(labelEmail);
        Controls.Add(labelName);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Controls.Add(textBoxEmail);
        Controls.Add(textBoxName);
        Name = "UserEditForm";
        Text = "Добавление/Изменение пользователя";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBoxName;
    private TextBox textBoxEmail;
    private Button btnCancel;
    private Button btnSave;
    private Label labelName;
    private Label labelEmail;
}