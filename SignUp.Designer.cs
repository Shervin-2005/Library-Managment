namespace Library_Managment
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblPasswordAgain = new Label();
            txtPasswordAgain = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblHaveAnAcount = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            lblOnlyGmail = new Label();
            lblUserName8Ch = new Label();
            lblPassword8Ch = new Label();
            lblPasswordsMatch = new Label();
            mbtnHidePass = new MaterialSkin.Controls.MaterialButton();
            mbtnShowPass = new MaterialSkin.Controls.MaterialButton();
            mbtnSignUp = new MaterialSkin.Controls.MaterialButton();
            mbtnSigIn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lblEmail
            // 
            resources.ApplyResources(lblEmail, "lblEmail");
            lblEmail.Name = "lblEmail";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyPress += textBox1_KeyPress;
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox2_TextChanged;
            txtPassword.KeyPress += textBox2_KeyPress;
            // 
            // lblPassword
            // 
            resources.ApplyResources(lblPassword, "lblPassword");
            lblPassword.Name = "lblPassword";
            // 
            // lblPasswordAgain
            // 
            resources.ApplyResources(lblPasswordAgain, "lblPasswordAgain");
            lblPasswordAgain.Name = "lblPasswordAgain";
            // 
            // txtPasswordAgain
            // 
            resources.ApplyResources(txtPasswordAgain, "txtPasswordAgain");
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.UseSystemPasswordChar = true;
            txtPasswordAgain.TextChanged += txtPasswordAgain_TextChanged;
            txtPasswordAgain.KeyPress += textBox3_KeyPress;
            // 
            // lblPhoneNumber
            // 
            resources.ApplyResources(lblPhoneNumber, "lblPhoneNumber");
            lblPhoneNumber.Name = "lblPhoneNumber";
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(txtPhoneNumber, "txtPhoneNumber");
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.KeyPress += textBox4_KeyPress;
            // 
            // lblHaveAnAcount
            // 
            resources.ApplyResources(lblHaveAnAcount, "lblHaveAnAcount");
            lblHaveAnAcount.Name = "lblHaveAnAcount";
            // 
            // txtUserName
            // 
            resources.ApplyResources(txtUserName, "txtUserName");
            txtUserName.Name = "txtUserName";
            txtUserName.TextChanged += textBox1_TextChanged;
            txtUserName.KeyPress += txtUserName_KeyPress;
            // 
            // lblUserName
            // 
            resources.ApplyResources(lblUserName, "lblUserName");
            lblUserName.Name = "lblUserName";
            // 
            // lblOnlyGmail
            // 
            resources.ApplyResources(lblOnlyGmail, "lblOnlyGmail");
            lblOnlyGmail.ForeColor = Color.Red;
            lblOnlyGmail.Name = "lblOnlyGmail";
            // 
            // lblUserName8Ch
            // 
            resources.ApplyResources(lblUserName8Ch, "lblUserName8Ch");
            lblUserName8Ch.ForeColor = Color.Red;
            lblUserName8Ch.Name = "lblUserName8Ch";
            // 
            // lblPassword8Ch
            // 
            resources.ApplyResources(lblPassword8Ch, "lblPassword8Ch");
            lblPassword8Ch.ForeColor = Color.Red;
            lblPassword8Ch.Name = "lblPassword8Ch";
            // 
            // lblPasswordsMatch
            // 
            resources.ApplyResources(lblPasswordsMatch, "lblPasswordsMatch");
            lblPasswordsMatch.ForeColor = Color.Red;
            lblPasswordsMatch.Name = "lblPasswordsMatch";
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
            // mbtnSigIn
            // 
            resources.ApplyResources(mbtnSigIn, "mbtnSigIn");
            mbtnSigIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSigIn.Depth = 0;
            mbtnSigIn.HighEmphasis = true;
            mbtnSigIn.Icon = null;
            mbtnSigIn.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnSigIn.Name = "mbtnSigIn";
            mbtnSigIn.NoAccentTextColor = Color.Empty;
            mbtnSigIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSigIn.UseAccentColor = false;
            mbtnSigIn.UseVisualStyleBackColor = true;
            mbtnSigIn.Click += mbtnSigIn_Click;
            // 
            // SignUp
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mbtnSigIn);
            Controls.Add(mbtnSignUp);
            Controls.Add(mbtnShowPass);
            Controls.Add(mbtnHidePass);
            Controls.Add(lblPasswordsMatch);
            Controls.Add(lblPassword8Ch);
            Controls.Add(lblUserName8Ch);
            Controls.Add(lblOnlyGmail);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Controls.Add(lblHaveAnAcount);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPasswordAgain);
            Controls.Add(lblPasswordAgain);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUp";
            Sizable = false;
            FormClosing += SignUp_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label lblEmail;
        internal TextBox txtEmail;
        internal TextBox txtPassword;
        internal Label lblPassword;
        internal Label lblPasswordAgain;
        internal TextBox txtPasswordAgain;
        internal Label lblPhoneNumber;
        internal TextBox txtPhoneNumber;
        internal Label lblHaveAnAcount;
        internal TextBox txtUserName;
        internal Label lblUserName;
        internal Label lblOnlyGmail;
        internal Label lblUserName8Ch;
        internal Label lblPassword8Ch;
        internal Label lblPasswordsMatch;
        internal MaterialSkin.Controls.MaterialButton mbtnHidePass;
        internal MaterialSkin.Controls.MaterialButton mbtnShowPass;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        internal MaterialSkin.Controls.MaterialButton mbtnSignUp;
        internal MaterialSkin.Controls.MaterialButton mbtnSigIn;
    }
}