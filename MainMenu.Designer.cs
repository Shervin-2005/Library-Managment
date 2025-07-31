namespace Library_Managment
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            mbtnSettings = new MaterialSkin.Controls.MaterialButton();
            mbtnSeeLibrary = new MaterialSkin.Controls.MaterialButton();
            mbtnSignIn = new MaterialSkin.Controls.MaterialButton();
            mbtnAbout = new MaterialSkin.Controls.MaterialButton();
            mbtnExit = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // mbtnSettings
            // 
            resources.ApplyResources(mbtnSettings, "mbtnSettings");
            mbtnSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSettings.Depth = 0;
            mbtnSettings.HighEmphasis = true;
            mbtnSettings.Icon = null;
            mbtnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnSettings.Name = "mbtnSettings";
            mbtnSettings.NoAccentTextColor = Color.Empty;
            mbtnSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSettings.UseAccentColor = false;
            mbtnSettings.UseVisualStyleBackColor = true;
            mbtnSettings.Click += materialButton1_Click;
            // 
            // mbtnSeeLibrary
            // 
            resources.ApplyResources(mbtnSeeLibrary, "mbtnSeeLibrary");
            mbtnSeeLibrary.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSeeLibrary.Depth = 0;
            mbtnSeeLibrary.HighEmphasis = true;
            mbtnSeeLibrary.Icon = null;
            mbtnSeeLibrary.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnSeeLibrary.Name = "mbtnSeeLibrary";
            mbtnSeeLibrary.NoAccentTextColor = Color.Empty;
            mbtnSeeLibrary.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSeeLibrary.UseAccentColor = false;
            mbtnSeeLibrary.UseVisualStyleBackColor = true;
            mbtnSeeLibrary.Click += materialButton2_Click;
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
            mbtnSignIn.Click += mbtnSignIn_Click;
            // 
            // mbtnAbout
            // 
            resources.ApplyResources(mbtnAbout, "mbtnAbout");
            mbtnAbout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAbout.Depth = 0;
            mbtnAbout.HighEmphasis = true;
            mbtnAbout.Icon = null;
            mbtnAbout.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAbout.Name = "mbtnAbout";
            mbtnAbout.NoAccentTextColor = Color.Empty;
            mbtnAbout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAbout.UseAccentColor = false;
            mbtnAbout.UseVisualStyleBackColor = true;
            mbtnAbout.Click += materialButton1_Click_1;
            // 
            // mbtnExit
            // 
            resources.ApplyResources(mbtnExit, "mbtnExit");
            mbtnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnExit.Depth = 0;
            mbtnExit.HighEmphasis = true;
            mbtnExit.Icon = null;
            mbtnExit.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnExit.Name = "mbtnExit";
            mbtnExit.NoAccentTextColor = Color.Empty;
            mbtnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnExit.UseAccentColor = false;
            mbtnExit.UseVisualStyleBackColor = true;
            mbtnExit.Click += mbtnExit_Click;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mbtnExit);
            Controls.Add(mbtnAbout);
            Controls.Add(mbtnSignIn);
            Controls.Add(mbtnSeeLibrary);
            Controls.Add(mbtnSettings);
            Name = "MainMenu";
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            Resize += MainMenu_Resize;
            ResumeLayout(false);
        }

        #endregion
        private Button btnSettings;
        private MaterialSkin.Controls.MaterialButton mbtnSettings;
        private MaterialSkin.Controls.MaterialButton mbtnSeeLibrary;
        private MaterialSkin.Controls.MaterialButton mbtnSignIn;
        private MaterialSkin.Controls.MaterialButton mbtnAbout;
        private MaterialSkin.Controls.MaterialButton mbtnExit;
    }
}
