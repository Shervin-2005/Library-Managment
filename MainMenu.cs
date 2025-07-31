using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using MaterialSkin;
using MaterialSkin.Controls;
using Rock_Paper_Scissors;
using System.Threading;



namespace Library_Managment
{


    public partial class MainMenu : MaterialForm
    {
        //Instantiation of two classes that handle window size ratio
        ScreenFixer screenfixer =new ScreenFixer();
        ResizeHelper resizeHelper = new ResizeHelper();

        //Instantiation of LocalizationHelper that handles Language Changes
        LocallizationHelper lh = new LocallizationHelper();

        //Instantiation of Material Skin for Designing
        internal readonly MaterialSkinManager materialSkinManager;

        //Instantiation of all of the forms
        internal ProfessorLibrary pl;
        internal SignIn si;
        internal SignUp su;
        internal Settings settings;
        internal ChooseBackground chbg;
        internal aditionalInformation adi;
        internal About about;
        
        //this for background you can see the changes in 'ChosseBackground.cs'
        public PictureBox BackgroundImageBox;

        //The Settings for EnterOTP is here Because of the code
        public void UpdateOtpCode(string newCode)
        {
            EnterOTP eo = new EnterOTP(newCode, this);
            //Changing Language for EnterOTP
            if (settings.cmbxLanguage.SelectedIndex == 0)
            {
                lh.ReloadUI(eo);

            }
            else if (settings.cmbxLanguage.SelectedIndex == 1)
            {
                lh.ReloadUI(eo);
            }

            //Chaanging Theme for EnterOTP
            if (settings.rdbtnLight.Checked)
            {
                LightTheme(eo);
                eo.lblCodeNotTrue.ForeColor = Color.Red;

            }
            if (settings.rdbtnDark.Checked)
            {
                DarkTheme(eo);
                eo.lblCodeNotTrue.ForeColor = Color.Red;
            }
            //Showing the EnterOTP in the Right Location
            eo.Show();
            eo.Location = su.Location;
            


        }

        //Chhange To Light Theme With Material Skin
        public void LightTheme(MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

        }



        //Chhange To Dark Theme With Material Skin
        public void DarkTheme(MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            //custom color for background
            form.BackColor = Color.FromArgb(48, 48, 48);

        }






        public MainMenu()
        {
            InitializeComponent();

            //Instantiation of all of the forms
            chbg = new ChooseBackground(this);
            si = new SignIn(this);
            su = new SignUp(this);
            pl = new ProfessorLibrary(this);
            settings = new Settings(this);
            adi = new aditionalInformation();
            about = new About();

            //Default Theme & Color 
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.DeepOrange500, Primary.DeepOrange700,
                    Primary.DeepOrange100, Accent.DeepOrange200,
                    TextShade.BLACK
                    );




        }



        //Exit Button Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu.ActiveForm.Close();
        }



        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Set Background Image that comes from 'ChooseBackground.cs'
            BackgroundImageBox = new PictureBox();
            BackgroundImageBox.Dock = DockStyle.Fill;
            BackgroundImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundImageBox.SendToBack();
            this.Controls.Add(BackgroundImageBox);

            //Methods from ResizeHelper & Screen Fixer to handle window size ratio
            resizeHelper.SetTargetForm(this);
            resizeHelper.RegisterControls(this.Controls.OfType<Control>().ToArray());

            screenfixer.setOnScreen(this);

        }

        //Writing a Method of Resize Helper in Resize Event 
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            resizeHelper.ResizeControls();
        }

       //btnSettings Showing Settings Event
        private void materialButton1_Click(object sender, EventArgs e)
        {
            settings.Show();
            settings.Location = this.Location;
            settings.TopMost = true;
        }    

        //btnProfessorLIbrary Showing Professor Library Event
        private void materialButton2_Click(object sender, EventArgs e)
        {
            pl.Show();
            this.Hide();
            pl.Size = this.Size;
            pl.Location = this.Location;
            pl.WindowState = this.WindowState;
        }

        //btnSignin Showing Sign In Window Event
        private void mbtnSignIn_Click(object sender, EventArgs e)
        {
            si.Show();
            int x = this.Location.X + this.Width - si.Width;
            int y = this.Location.Y;
            si.Location = new Point(x, y);
 
        }

        //btnAbout Showing About Window Event
        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            about.Show();
            int x = this.Location.X;
            int y = this.Location.Y + this.Height - about.Height;
            about.Location = new Point(x, y);
        }

        //btnExit For Exit :)
        private void mbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //Sowing a MessageBox When user is closing the App
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            
            //MessageBox in English
            if (mbtnAbout.Text=="About")
            {
                 result = MessageBox.Show(
                                                 "Are You Sure to Close the Library?",
                                                 "Closing Library",
                                                 MessageBoxButtons.YesNo);
            }
            //MessageBox iN Persion
            else 
            {
                 result = MessageBox.Show(
                                                    "واقعا میخوای از کتابخونه خارج بشی؟",
                                                    "بستن کتابخونه",
                                                    MessageBoxButtons.YesNo);
            }
            //cancel the  Exit if User clicked on No
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
