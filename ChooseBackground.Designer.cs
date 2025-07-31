namespace Library_Managment
{
    partial class ChooseBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseBackground));
            btnBg1 = new Button();
            btnBg2 = new Button();
            btnBg3 = new Button();
            btnBg4 = new Button();
            btnBg5 = new Button();
            btnUploadBg = new Button();
            btnOrange = new Button();
            btnRed = new Button();
            btnGreen = new Button();
            btnBlue = new Button();
            btnPurple = new Button();
            btnGrey = new Button();
            SuspendLayout();
            // 
            // btnBg1
            // 
            btnBg1.BackgroundImage = Properties.Resources.bg1;
            resources.ApplyResources(btnBg1, "btnBg1");
            btnBg1.Name = "btnBg1";
            btnBg1.UseVisualStyleBackColor = true;
            btnBg1.Click += button1_Click;
            // 
            // btnBg2
            // 
            btnBg2.BackgroundImage = Properties.Resources.bg2;
            resources.ApplyResources(btnBg2, "btnBg2");
            btnBg2.Name = "btnBg2";
            btnBg2.UseVisualStyleBackColor = true;
            btnBg2.Click += button2_Click;
            // 
            // btnBg3
            // 
            btnBg3.BackgroundImage = Properties.Resources.bg3;
            resources.ApplyResources(btnBg3, "btnBg3");
            btnBg3.Name = "btnBg3";
            btnBg3.UseVisualStyleBackColor = true;
            btnBg3.Click += button3_Click;
            // 
            // btnBg4
            // 
            btnBg4.BackgroundImage = Properties.Resources.bg4;
            resources.ApplyResources(btnBg4, "btnBg4");
            btnBg4.Name = "btnBg4";
            btnBg4.UseVisualStyleBackColor = true;
            btnBg4.Click += button4_Click;
            // 
            // btnBg5
            // 
            btnBg5.BackgroundImage = Properties.Resources.bg5;
            resources.ApplyResources(btnBg5, "btnBg5");
            btnBg5.Name = "btnBg5";
            btnBg5.UseVisualStyleBackColor = true;
            btnBg5.Click += button5_Click;
            // 
            // btnUploadBg
            // 
            btnUploadBg.BackgroundImage = Properties.Resources.UploadImage;
            resources.ApplyResources(btnUploadBg, "btnUploadBg");
            btnUploadBg.Name = "btnUploadBg";
            btnUploadBg.UseVisualStyleBackColor = true;
            btnUploadBg.Click += button6_Click;
            // 
            // btnOrange
            // 
            btnOrange.BackColor = Color.OrangeRed;
            resources.ApplyResources(btnOrange, "btnOrange");
            btnOrange.Name = "btnOrange";
            btnOrange.UseVisualStyleBackColor = false;
            btnOrange.Click += btnOrange_Click_1;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            resources.ApplyResources(btnRed, "btnRed");
            btnRed.Name = "btnRed";
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += button1_Click_1;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            resources.ApplyResources(btnGreen, "btnGreen");
            btnGreen.Name = "btnGreen";
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            resources.ApplyResources(btnBlue, "btnBlue");
            btnBlue.Name = "btnBlue";
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnPurple
            // 
            btnPurple.BackColor = Color.BlueViolet;
            resources.ApplyResources(btnPurple, "btnPurple");
            btnPurple.Name = "btnPurple";
            btnPurple.UseVisualStyleBackColor = false;
            btnPurple.Click += btnPurple_Click;
            // 
            // btnGrey
            // 
            btnGrey.BackColor = Color.Gray;
            resources.ApplyResources(btnGrey, "btnGrey");
            btnGrey.Name = "btnGrey";
            btnGrey.UseVisualStyleBackColor = false;
            btnGrey.Click += btnGrey_Click;
            // 
            // ChooseBackground
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGrey);
            Controls.Add(btnPurple);
            Controls.Add(btnBlue);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Controls.Add(btnOrange);
            Controls.Add(btnUploadBg);
            Controls.Add(btnBg5);
            Controls.Add(btnBg4);
            Controls.Add(btnBg3);
            Controls.Add(btnBg2);
            Controls.Add(btnBg1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChooseBackground";
            Sizable = false;
            FormClosing += ChooseBackground_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBg1;
        private Button btnBg2;
        private Button btnBg3;
        private Button btnBg4;
        private Button btnBg5;
        private Button btnUploadBg;
        public MaterialSkin.Controls.MaterialFloatingActionButton mbtnColor3;
        public MaterialSkin.Controls.MaterialButton mbtnRed;
        public Button btnOrange;
        public Button btnRed;
        public Button btnGreen;
        public Button btnBlue;
        public Button btnPurple;
        public Button btnGrey;
    }
}