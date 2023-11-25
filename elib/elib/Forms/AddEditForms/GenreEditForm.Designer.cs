namespace eLibra.AddEditForms;

partial class GenreEditForm
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
        labelName = new Label();
        btnSave = new Button();
        btnCancel = new Button();
        textBoxGenreName = new TextBox();
        SuspendLayout();
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Location = new Point(31, 55);
        labelName.Name = "labelName";
        labelName.Size = new Size(37, 15);
        labelName.TabIndex = 8;
        labelName.Text = "Имя: ";
        // 
        // btnSave
        // 
        btnSave.Location = new Point(97, 113);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(80, 26);
        btnSave.TabIndex = 7;
        btnSave.Text = "Сохранить";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += BtnOK_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(194, 113);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(82, 26);
        btnCancel.TabIndex = 6;
        btnCancel.Text = "Отменить";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += BtnCancel_Click;
        // 
        // textBoxGenreName
        // 
        textBoxGenreName.Location = new Point(97, 52);
        textBoxGenreName.Name = "textBoxGenreName";
        textBoxGenreName.Size = new Size(179, 23);
        textBoxGenreName.TabIndex = 5;
        // 
        // GenreEditForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(339, 187);
        Controls.Add(labelName);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Controls.Add(textBoxGenreName);
        Name = "GenreEditForm";
        Text = "Добавление/Изменение жанра";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private Button btnSave;
    private Button btnCancel;
    private TextBox textBoxGenreName;
}