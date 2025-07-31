namespace Library_Managment
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            rdbtnLight = new RadioButton();
            rdbtnDark = new RadioButton();
            grpbx = new GroupBox();
            lblLanguage = new Label();
            cmbxLanguage = new ComboBox();
            lblDataLocation = new Label();
            txtDataLocation = new TextBox();
            btnBrowse = new Button();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            grpbx.SuspendLayout();
            SuspendLayout();
            // 
            // rdbtnLight
            // 
            resources.ApplyResources(rdbtnLight, "rdbtnLight");
            rdbtnLight.Name = "rdbtnLight";
            rdbtnLight.TabStop = true;
            rdbtnLight.UseVisualStyleBackColor = true;
            rdbtnLight.CheckedChanged += rdbtnLight_CheckedChanged;
            // 
            // rdbtnDark
            // 
            resources.ApplyResources(rdbtnDark, "rdbtnDark");
            rdbtnDark.Name = "rdbtnDark";
            rdbtnDark.TabStop = true;
            rdbtnDark.UseVisualStyleBackColor = true;
            // 
            // grpbx
            // 
            resources.ApplyResources(grpbx, "grpbx");
            grpbx.Controls.Add(rdbtnLight);
            grpbx.Controls.Add(rdbtnDark);
            grpbx.Name = "grpbx";
            grpbx.TabStop = false;
            // 
            // lblLanguage
            // 
            resources.ApplyResources(lblLanguage, "lblLanguage");
            lblLanguage.Name = "lblLanguage";
            // 
            // cmbxLanguage
            // 
            resources.ApplyResources(cmbxLanguage, "cmbxLanguage");
            cmbxLanguage.FormattingEnabled = true;
            cmbxLanguage.Items.AddRange(new object[] { resources.GetString("cmbxLanguage.Items"), resources.GetString("cmbxLanguage.Items1") });
            cmbxLanguage.Name = "cmbxLanguage";
            cmbxLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // lblDataLocation
            // 
            resources.ApplyResources(lblDataLocation, "lblDataLocation");
            lblDataLocation.Name = "lblDataLocation";
            // 
            // txtDataLocation
            // 
            resources.ApplyResources(txtDataLocation, "txtDataLocation");
            txtDataLocation.Name = "txtDataLocation";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(btnBrowse, "btnBrowse");
            btnBrowse.Name = "btnBrowse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            resources.ApplyResources(materialButton1, "materialButton1");
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(materialButton1);
            Controls.Add(btnBrowse);
            Controls.Add(cmbxLanguage);
            Controls.Add(txtDataLocation);
            Controls.Add(lblDataLocation);
            Controls.Add(lblLanguage);
            Controls.Add(grpbx);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            Sizable = false;
            FormClosing += Settings_FormClosing;
            grpbx.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal RadioButton rdbtnLight;
        internal RadioButton rdbtnDark;
        public GroupBox grpbx;
        public Label lblLanguage;
        public ComboBox cmbxLanguage;
        public Label lblDataLocation;
        public TextBox txtDataLocation;
        public Button btnBrowse;
        public MaterialSkin.Controls.MaterialButton materialButton1;
    }
}