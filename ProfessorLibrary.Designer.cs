namespace Library_Managment
{
    partial class ProfessorLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorLibrary));
            lstbxBooks = new ListBox();
            txtSearchBooks = new TextBox();
            txtSearchStudents = new TextBox();
            lstbxStudents = new ListBox();
            mbtnReturnMainMenu = new MaterialSkin.Controls.MaterialButton();
            mbtnUserAcount = new MaterialSkin.Controls.MaterialButton();
            mbtnUploadBook = new MaterialSkin.Controls.MaterialButton();
            mbtnDeleteBook = new MaterialSkin.Controls.MaterialButton();
            mbtnAddStudent = new MaterialSkin.Controls.MaterialButton();
            mbtnDeleteStudent = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lstbxBooks
            // 
            lstbxBooks.FormattingEnabled = true;
            resources.ApplyResources(lstbxBooks, "lstbxBooks");
            lstbxBooks.Name = "lstbxBooks";
            lstbxBooks.SelectedIndexChanged += lstbxBooks_SelectedIndexChanged;
            lstbxBooks.DoubleClick += lstbxBooks_DoubleClick;
            // 
            // txtSearchBooks
            // 
            resources.ApplyResources(txtSearchBooks, "txtSearchBooks");
            txtSearchBooks.Name = "txtSearchBooks";
            txtSearchBooks.TextChanged += txtSearchBooks_TextChanged;
            txtSearchBooks.MouseDown += txtSearchBooks_MouseDown;
            // 
            // txtSearchStudents
            // 
            resources.ApplyResources(txtSearchStudents, "txtSearchStudents");
            txtSearchStudents.Name = "txtSearchStudents";
            txtSearchStudents.MouseDown += textBox1_MouseDown;
            // 
            // lstbxStudents
            // 
            lstbxStudents.FormattingEnabled = true;
            resources.ApplyResources(lstbxStudents, "lstbxStudents");
            lstbxStudents.Name = "lstbxStudents";
            // 
            // mbtnReturnMainMenu
            // 
            resources.ApplyResources(mbtnReturnMainMenu, "mbtnReturnMainMenu");
            mbtnReturnMainMenu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnReturnMainMenu.Depth = 0;
            mbtnReturnMainMenu.HighEmphasis = true;
            mbtnReturnMainMenu.Icon = null;
            mbtnReturnMainMenu.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnReturnMainMenu.Name = "mbtnReturnMainMenu";
            mbtnReturnMainMenu.NoAccentTextColor = Color.Empty;
            mbtnReturnMainMenu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnReturnMainMenu.UseAccentColor = false;
            mbtnReturnMainMenu.UseVisualStyleBackColor = true;
            mbtnReturnMainMenu.Click += mbtnReturnMainMenu_Click;
            // 
            // mbtnUserAcount
            // 
            resources.ApplyResources(mbtnUserAcount, "mbtnUserAcount");
            mbtnUserAcount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnUserAcount.Depth = 0;
            mbtnUserAcount.HighEmphasis = true;
            mbtnUserAcount.Icon = null;
            mbtnUserAcount.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnUserAcount.Name = "mbtnUserAcount";
            mbtnUserAcount.NoAccentTextColor = Color.Empty;
            mbtnUserAcount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnUserAcount.UseAccentColor = false;
            mbtnUserAcount.UseVisualStyleBackColor = true;
            // 
            // mbtnUploadBook
            // 
            resources.ApplyResources(mbtnUploadBook, "mbtnUploadBook");
            mbtnUploadBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnUploadBook.Depth = 0;
            mbtnUploadBook.HighEmphasis = true;
            mbtnUploadBook.Icon = null;
            mbtnUploadBook.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnUploadBook.Name = "mbtnUploadBook";
            mbtnUploadBook.NoAccentTextColor = Color.Empty;
            mbtnUploadBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnUploadBook.UseAccentColor = false;
            mbtnUploadBook.UseVisualStyleBackColor = true;
            mbtnUploadBook.Click += mbtnUploadBook_Click;
            // 
            // mbtnDeleteBook
            // 
            resources.ApplyResources(mbtnDeleteBook, "mbtnDeleteBook");
            mbtnDeleteBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnDeleteBook.Depth = 0;
            mbtnDeleteBook.HighEmphasis = true;
            mbtnDeleteBook.Icon = null;
            mbtnDeleteBook.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnDeleteBook.Name = "mbtnDeleteBook";
            mbtnDeleteBook.NoAccentTextColor = Color.Empty;
            mbtnDeleteBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnDeleteBook.UseAccentColor = false;
            mbtnDeleteBook.UseVisualStyleBackColor = true;
            mbtnDeleteBook.Click += mbtnDeleteBook_Click;
            // 
            // mbtnAddStudent
            // 
            resources.ApplyResources(mbtnAddStudent, "mbtnAddStudent");
            mbtnAddStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAddStudent.Depth = 0;
            mbtnAddStudent.HighEmphasis = true;
            mbtnAddStudent.Icon = null;
            mbtnAddStudent.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAddStudent.Name = "mbtnAddStudent";
            mbtnAddStudent.NoAccentTextColor = Color.Empty;
            mbtnAddStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAddStudent.UseAccentColor = false;
            mbtnAddStudent.UseVisualStyleBackColor = true;
            // 
            // mbtnDeleteStudent
            // 
            resources.ApplyResources(mbtnDeleteStudent, "mbtnDeleteStudent");
            mbtnDeleteStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnDeleteStudent.Depth = 0;
            mbtnDeleteStudent.HighEmphasis = true;
            mbtnDeleteStudent.Icon = null;
            mbtnDeleteStudent.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnDeleteStudent.Name = "mbtnDeleteStudent";
            mbtnDeleteStudent.NoAccentTextColor = Color.Empty;
            mbtnDeleteStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnDeleteStudent.UseAccentColor = false;
            mbtnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // ProfessorLibrary
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mbtnDeleteStudent);
            Controls.Add(mbtnAddStudent);
            Controls.Add(mbtnDeleteBook);
            Controls.Add(mbtnUploadBook);
            Controls.Add(mbtnUserAcount);
            Controls.Add(mbtnReturnMainMenu);
            Controls.Add(txtSearchStudents);
            Controls.Add(lstbxStudents);
            Controls.Add(txtSearchBooks);
            Controls.Add(lstbxBooks);
            Name = "ProfessorLibrary";
            FormClosing += ProfessorLibrary_FormClosing;
            Load += ProfessorLibrary_Load;
            MouseDown += ProfessorLibrary_MouseDown;
            Resize += ProfessorLibrary_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal ListBox lstbxBooks;
        internal TextBox txtSearchBooks;
        internal TextBox txtSearchStudents;
        internal ListBox lstbxStudents;
        internal MaterialSkin.Controls.MaterialButton mbtnReturnMainMenu;
        internal MaterialSkin.Controls.MaterialButton mbtnUserAcount;
        internal MaterialSkin.Controls.MaterialButton mbtnUploadBook;
        internal MaterialSkin.Controls.MaterialButton mbtnDeleteBook;
        internal MaterialSkin.Controls.MaterialButton mbtnAddStudent;
        internal MaterialSkin.Controls.MaterialButton mbtnDeleteStudent;
    }
}