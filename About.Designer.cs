namespace Library_Managment
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            lblAbout2 = new Label();
            btnLinkedin = new Button();
            btnYoutube = new Button();
            label1 = new Label();
            btnGithub = new Button();
            btnTelegram = new Button();
            SuspendLayout();
            // 
            // lblAbout2
            // 
            resources.ApplyResources(lblAbout2, "lblAbout2");
            lblAbout2.Name = "lblAbout2";
            // 
            // btnLinkedin
            // 
            btnLinkedin.BackgroundImage = Properties.Resources.LinkedIn;
            resources.ApplyResources(btnLinkedin, "btnLinkedin");
            btnLinkedin.Name = "btnLinkedin";
            btnLinkedin.UseVisualStyleBackColor = true;
            btnLinkedin.Click += btnLinkedin_Click;
            // 
            // btnYoutube
            // 
            btnYoutube.BackColor = SystemColors.Control;
            btnYoutube.BackgroundImage = Properties.Resources.Youtube;
            resources.ApplyResources(btnYoutube, "btnYoutube");
            btnYoutube.Name = "btnYoutube";
            btnYoutube.UseVisualStyleBackColor = false;
            btnYoutube.Click += btnYoutube_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // btnGithub
            // 
            btnGithub.BackgroundImage = Properties.Resources.GitHub;
            resources.ApplyResources(btnGithub, "btnGithub");
            btnGithub.Name = "btnGithub";
            btnGithub.UseVisualStyleBackColor = true;
            btnGithub.Click += btnGithub_Click;
            // 
            // btnTelegram
            // 
            btnTelegram.BackgroundImage = Properties.Resources.Telegram;
            resources.ApplyResources(btnTelegram, "btnTelegram");
            btnTelegram.Name = "btnTelegram";
            btnTelegram.UseVisualStyleBackColor = true;
            btnTelegram.Click += btnTelegram_Click;
            // 
            // About
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTelegram);
            Controls.Add(btnGithub);
            Controls.Add(label1);
            Controls.Add(btnYoutube);
            Controls.Add(btnLinkedin);
            Controls.Add(lblAbout2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            Sizable = false;
            FormClosing += About_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnTelegram;
        public Label lblAbout2;
        public Button btnLinkedin;
        public Button btnYoutube;
        public Label label1;
        public Button btnGithub;
    }
}