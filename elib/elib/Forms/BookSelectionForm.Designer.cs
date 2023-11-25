namespace eLibra.Forms;

partial class BookSelectionForm
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
        labelPrompt = new Label();
        comboBoxBooks = new ComboBox();
        btnOK = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // labelPrompt
        // 
        labelPrompt.AutoSize = true;
        labelPrompt.Location = new Point(79, 46);
        labelPrompt.Name = "labelPrompt";
        labelPrompt.Size = new Size(38, 15);
        labelPrompt.TabIndex = 0;
        labelPrompt.Text = "label1";
        // 
        // comboBoxBooks
        // 
        comboBoxBooks.FormattingEnabled = true;
        comboBoxBooks.Location = new Point(174, 43);
        comboBoxBooks.Name = "comboBoxBooks";
        comboBoxBooks.Size = new Size(121, 23);
        comboBoxBooks.TabIndex = 1;
        // 
        // btnOK
        // 
        btnOK.Location = new Point(99, 88);
        btnOK.Name = "btnOK";
        btnOK.Size = new Size(74, 24);
        btnOK.TabIndex = 2;
        btnOK.Text = "Сохранить";
        btnOK.UseVisualStyleBackColor = true;
        btnOK.Click += BtnOK_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(188, 89);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(75, 23);
        btnCancel.TabIndex = 3;
        btnCancel.Text = "Отменить";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += BtnCancel_Click;
        // 
        // BookSelectionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(356, 129);
        Controls.Add(btnCancel);
        Controls.Add(btnOK);
        Controls.Add(comboBoxBooks);
        Controls.Add(labelPrompt);
        Name = "BookSelectionForm";
        Text = "Выбор книги";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelPrompt;
    private ComboBox comboBoxBooks;
    private Button btnOK;
    private Button btnCancel;
}