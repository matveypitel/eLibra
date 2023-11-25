namespace eLibra;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStripMain = new MenuStrip();
        usersToolStripMenuItem = new ToolStripMenuItem();
        genresToolStripMenuItem = new ToolStripMenuItem();
        booksToolStripMenuItem = new ToolStripMenuItem();
        authorsToolStripMenuItem = new ToolStripMenuItem();
        exitToolStripMenuItem = new ToolStripMenuItem();
        btnLogin = new Button();
        btnHelp = new Button();
        btnExit = new Button();
        dataGridView = new DataGridView();
        menuStripMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, genresToolStripMenuItem, booksToolStripMenuItem, authorsToolStripMenuItem, exitToolStripMenuItem });
        menuStripMain.Location = new Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Size = new Size(800, 24);
        menuStripMain.TabIndex = 0;
        menuStripMain.Text = "menuStrip1";
        // 
        // usersToolStripMenuItem
        // 
        usersToolStripMenuItem.Name = "usersToolStripMenuItem";
        usersToolStripMenuItem.Size = new Size(97, 20);
        usersToolStripMenuItem.Text = "Пользователи";
        usersToolStripMenuItem.Click += UsersToolStripMenuItem_Click;
        // 
        // genresToolStripMenuItem
        // 
        genresToolStripMenuItem.Name = "genresToolStripMenuItem";
        genresToolStripMenuItem.Size = new Size(59, 20);
        genresToolStripMenuItem.Text = "Жанры";
        genresToolStripMenuItem.Click += GenresToolStripMenuItem_Click;
        // 
        // booksToolStripMenuItem
        // 
        booksToolStripMenuItem.Name = "booksToolStripMenuItem";
        booksToolStripMenuItem.Size = new Size(52, 20);
        booksToolStripMenuItem.Text = "Книги";
        booksToolStripMenuItem.Click += BooksToolStripMenuItem_Click;
        // 
        // authorsToolStripMenuItem
        // 
        authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
        authorsToolStripMenuItem.Size = new Size(61, 20);
        authorsToolStripMenuItem.Text = "Авторы";
        authorsToolStripMenuItem.Click += AuthorsToolStripMenuItem_Click;
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(98, 20);
        exitToolStripMenuItem.Text = "Выйти в меню";
        exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(326, 190);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(136, 54);
        btnLogin.TabIndex = 1;
        btnLogin.Text = "Войти";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += BtnLogin_Click;
        // 
        // btnHelp
        // 
        btnHelp.Location = new Point(326, 280);
        btnHelp.Name = "btnHelp";
        btnHelp.Size = new Size(136, 54);
        btnHelp.TabIndex = 2;
        btnHelp.Text = "Помощь";
        btnHelp.UseVisualStyleBackColor = true;
        btnHelp.Click += BtnHelp_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(326, 372);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(136, 54);
        btnExit.TabIndex = 3;
        btnExit.Text = "Выйти";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += BtnExit_Click;
        // 
        // dataGridView
        // 
        dataGridView.BackgroundColor = SystemColors.Control;
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView.Location = new Point(12, 27);
        dataGridView.Name = "dataGridView";
        dataGridView.RowTemplate.Height = 25;
        dataGridView.Size = new Size(776, 373);
        dataGridView.TabIndex = 4;
        dataGridView.CellClick += DataGridView_CellClick;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dataGridView);
        Controls.Add(btnExit);
        Controls.Add(btnHelp);
        Controls.Add(btnLogin);
        Controls.Add(menuStripMain);
        MainMenuStrip = menuStripMain;
        Name = "MainForm";
        Text = "eLibra";
        FormClosing += MainForm_FormClosing;
        Load += MainForm_Load;
        menuStripMain.ResumeLayout(false);
        menuStripMain.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStripMain;
    private Button btnLogin;
    private Button btnHelp;
    private Button btnExit;
    private ToolStripMenuItem usersToolStripMenuItem;
    private ToolStripMenuItem genresToolStripMenuItem;
    private ToolStripMenuItem booksToolStripMenuItem;
    private ToolStripMenuItem authorsToolStripMenuItem;
    private DataGridView dataGridView;
    private ToolStripMenuItem exitToolStripMenuItem;
}
