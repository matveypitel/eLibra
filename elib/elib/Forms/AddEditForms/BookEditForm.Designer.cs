namespace eLibra.AddEditForms;

partial class BookEditForm
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
        labelGenre = new Label();
        labelTitle = new Label();
        btnSave = new Button();
        btnCancel = new Button();
        textBoxTitle = new TextBox();
        comboBoxGenre = new ComboBox();
        comboBoxAuthor = new ComboBox();
        labelAuthor = new Label();
        textBoxNewGenre = new TextBox();
        textBoxNewAuthor = new TextBox();
        SuspendLayout();
        // 
        // labelGenre
        // 
        labelGenre.AutoSize = true;
        labelGenre.Location = new Point(79, 90);
        labelGenre.Name = "labelGenre";
        labelGenre.Size = new Size(44, 15);
        labelGenre.TabIndex = 11;
        labelGenre.Text = "Жанр: ";
        labelGenre.TextAlign = ContentAlignment.TopRight;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Location = new Point(79, 48);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(65, 15);
        labelTitle.TabIndex = 10;
        labelTitle.Text = "Название: ";
        // 
        // btnSave
        // 
        btnSave.Location = new Point(145, 192);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(80, 26);
        btnSave.TabIndex = 9;
        btnSave.Text = "Сохранить";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += BtnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(242, 192);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(82, 26);
        btnCancel.TabIndex = 8;
        btnCancel.Text = "Отменить";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += BtnCancel_Click;
        // 
        // textBoxTitle
        // 
        textBoxTitle.Location = new Point(145, 45);
        textBoxTitle.Name = "textBoxTitle";
        textBoxTitle.Size = new Size(179, 23);
        textBoxTitle.TabIndex = 6;
        // 
        // comboBoxGenre
        // 
        comboBoxGenre.FormattingEnabled = true;
        comboBoxGenre.Location = new Point(145, 87);
        comboBoxGenre.Name = "comboBoxGenre";
        comboBoxGenre.Size = new Size(80, 23);
        comboBoxGenre.TabIndex = 12;
        // 
        // comboBoxAuthor
        // 
        comboBoxAuthor.FormattingEnabled = true;
        comboBoxAuthor.Location = new Point(145, 129);
        comboBoxAuthor.Name = "comboBoxAuthor";
        comboBoxAuthor.Size = new Size(80, 23);
        comboBoxAuthor.TabIndex = 13;
        // 
        // labelAuthor
        // 
        labelAuthor.AutoSize = true;
        labelAuthor.Location = new Point(79, 132);
        labelAuthor.Name = "labelAuthor";
        labelAuthor.Size = new Size(43, 15);
        labelAuthor.TabIndex = 14;
        labelAuthor.Text = "Автор:";
        labelAuthor.TextAlign = ContentAlignment.TopRight;
        // 
        // textBoxNewGenre
        // 
        textBoxNewGenre.Location = new Point(242, 87);
        textBoxNewGenre.Name = "textBoxNewGenre";
        textBoxNewGenre.Size = new Size(82, 23);
        textBoxNewGenre.TabIndex = 15;
        // 
        // textBoxNewAuthor
        // 
        textBoxNewAuthor.Location = new Point(242, 129);
        textBoxNewAuthor.Name = "textBoxNewAuthor";
        textBoxNewAuthor.Size = new Size(82, 23);
        textBoxNewAuthor.TabIndex = 16;
        // 
        // BookEditForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(453, 230);
        Controls.Add(textBoxNewAuthor);
        Controls.Add(textBoxNewGenre);
        Controls.Add(labelAuthor);
        Controls.Add(comboBoxAuthor);
        Controls.Add(comboBoxGenre);
        Controls.Add(labelGenre);
        Controls.Add(labelTitle);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Controls.Add(textBoxTitle);
        Name = "BookEditForm";
        Text = "Добавление/Изменение книги";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelGenre;
    private Label labelTitle;
    private Button btnSave;
    private Button btnCancel;
    private TextBox textBoxTitle;
    private ComboBox comboBoxGenre;
    private ComboBox comboBoxAuthor;
    private Label labelAuthor;
    private TextBox textBoxNewGenre;
    private TextBox textBoxNewAuthor;
}