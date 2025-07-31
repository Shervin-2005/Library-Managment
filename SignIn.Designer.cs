namespace Library_Managment
{
    partial class SignIn
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            bindingSource1 = new BindingSource(components);
            lblPassword = new Label();
            lblDontHaveAccount = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mbtnHidePass = new MaterialSkin.Controls.MaterialButton();
            mbtnShowPass = new MaterialSkin.Controls.MaterialButton();
            mbtnSignIn = new MaterialSkin.Controls.MaterialButton();
            mbtnSignUp = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // txtUserName
            // 
            resources.ApplyResources(txtUserName, "txtUserName");
            txtUserName.Name = "txtUserName";
            txtUserName.KeyPress += textBox1_KeyPress;
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox3_TextChanged;
            txtPassword.KeyPress += textBox3_KeyPress;
            // 
            // lblUserName
            // 
            resources.ApplyResources(lblUserName, "lblUserName");
            lblUserName.Name = "lblUserName";
            // 
            // lblPassword
            // 
            resources.ApplyResources(lblPassword, "lblPassword");
            lblPassword.Name = "lblPassword";
            // 
            // lblDontHaveAccount
            // 
            resources.ApplyResources(lblDontHaveAccount, "lblDontHaveAccount");
            lblDontHaveAccount.Name = "lblDontHaveAccount";
            // 
            // mbtnHidePass
            // 
            resources.ApplyResources(mbtnHidePass, "mbtnHidePass");
            mbtnHidePass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnHidePass.Depth = 0;
            mbtnHidePass.HighEmphasis = true;
            mbtnHidePass.Icon = null;
            mbtnHidePass.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnHidePass.Name = "mbtnHidePass";
            mbtnHidePass.NoAccentTextColor = Color.Empty;
            mbtnHidePass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnHidePass.UseAccentColor = false;
            mbtnHidePass.UseVisualStyleBackColor = true;
            mbtnHidePass.Click += mbtnHidePass_Click;
            // 
            // mbtnShowPass
            // 
            resources.ApplyResources(mbtnShowPass, "mbtnShowPass");
            mbtnShowPass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnShowPass.Depth = 0;
            mbtnShowPass.HighEmphasis = true;
            mbtnShowPass.Icon = null;
            mbtnShowPass.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnShowPass.Name = "mbtnShowPass";
            mbtnShowPass.NoAccentTextColor = Color.Empty;
            mbtnShowPass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnShowPass.UseAccentColor = false;
            mbtnShowPass.UseVisualStyleBackColor = true;
            mbtnShowPass.Click += mbtnShowPass_Click;
            // 
            // mbtnSignIn
            // 
            resources.ApplyResources(mbtnSignIn, "mbtnSignIn");
            mbtnSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSignIn.Depth = 0;
            mbtnSignIn.HighEmphasis = true;
            mbtnSignIn.Icon = null;
            mbtnSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnSignIn.Name = "mbtnSignIn";
            mbtnSignIn.NoAccentTextColor = Color.Empty;
            mbtnSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSignIn.UseAccentColor = false;
            mbtnSignIn.UseVisualStyleBackColor = true;
            // 
            // mbtnSignUp
            // 
            resources.ApplyResources(mbtnSignUp, "mbtnSignUp");
            mbtnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSignUp.Depth = 0;
            mbtnSignUp.HighEmphasis = true;
            mbtnSignUp.Icon = null;
            mbtnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnSignUp.Name = "mbtnSignUp";
            mbtnSignUp.NoAccentTextColor = Color.Empty;
            mbtnSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSignUp.UseAccentColor = false;
            mbtnSignUp.UseVisualStyleBackColor = true;
            mbtnSignUp.Click += mbtnSignUp_Click;
            // 
            // SignIn
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mbtnSignUp);
            Controls.Add(mbtnSignIn);
            Controls.Add(mbtnShowPass);
            Controls.Add(mbtnHidePass);
            Controls.Add(lblDontHaveAccount);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignIn";
            Sizable = false;
            FormClosing += SignIn_FormClosing;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal TextBox txtUserName;
        internal TextBox txtPassword;
        internal Label lblUserName;
        internal Label lblPassword;
        internal Label lblDontHaveAccount;
        internal MaterialSkin.Controls.MaterialButton mbtnHidePass;
        internal MaterialSkin.Controls.MaterialButton mbtnShowPass;
        internal MaterialSkin.Controls.MaterialButton mbtnSignIn;
        internal MaterialSkin.Controls.MaterialButton mbtnSignUp;
    }
}