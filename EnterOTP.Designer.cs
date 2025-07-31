namespace Library_Managment
{
    partial class EnterOTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterOTP));
            txtOTP = new TextBox();
            lblEnterCode = new Label();
            lblCodeNotTrue = new Label();
            mbtnContinue = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtOTP
            // 
            resources.ApplyResources(txtOTP, "txtOTP");
            txtOTP.Name = "txtOTP";
            // 
            // lblEnterCode
            // 
            resources.ApplyResources(lblEnterCode, "lblEnterCode");
            lblEnterCode.Name = "lblEnterCode";
            // 
            // lblCodeNotTrue
            // 
            resources.ApplyResources(lblCodeNotTrue, "lblCodeNotTrue");
            lblCodeNotTrue.ForeColor = Color.Red;
            lblCodeNotTrue.Name = "lblCodeNotTrue";
            // 
            // mbtnContinue
            // 
            resources.ApplyResources(mbtnContinue, "mbtnContinue");
            mbtnContinue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnContinue.Depth = 0;
            mbtnContinue.HighEmphasis = true;
            mbtnContinue.Icon = null;
            mbtnContinue.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnContinue.Name = "mbtnContinue";
            mbtnContinue.NoAccentTextColor = Color.Empty;
            mbtnContinue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnContinue.UseAccentColor = false;
            mbtnContinue.UseVisualStyleBackColor = true;
            mbtnContinue.Click += mbtnContinue_Click;
            // 
            // EnterOTP
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mbtnContinue);
            Controls.Add(lblCodeNotTrue);
            Controls.Add(lblEnterCode);
            Controls.Add(txtOTP);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EnterOTP";
            Sizable = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox txtOTP;
        internal Label lblEnterCode;
        internal Label lblCodeNotTrue;
        internal MaterialSkin.Controls.MaterialButton mbtnContinue;
    }
}