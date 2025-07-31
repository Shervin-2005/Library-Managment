using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Rock_Paper_Scissors;

namespace Library_Managment
{


    public partial class Settings : MaterialForm
    {
        //Some of the Controls won't Change Color(See the Call to this method  in 'ChooseBackground.cs')
        public void ForceColors()
        {
            mainmenu.su.lblOnlyGmail.ForeColor = Color.Red;
            mainmenu.su.lblPassword8Ch.ForeColor = Color.Red;
            mainmenu.su.lblPasswordsMatch.ForeColor = Color.Red;
            mainmenu.su.lblUserName8Ch.ForeColor = Color.Red;


            mainmenu.chbg.btnOrange.BackColor = Color.OrangeRed;
            mainmenu.chbg.btnRed.BackColor = Color.Red;
            mainmenu.chbg.btnBlue.BackColor = Color.Blue;
            mainmenu.chbg.btnGreen.BackColor = Color.Green;
            mainmenu.chbg.btnGrey.BackColor = Color.Gray;
            mainmenu.chbg.btnPurple.BackColor = Color.BlueViolet;

            mainmenu.about.btnGithub.BackColor = Color.White;
            mainmenu.about.btnTelegram.BackColor = Color.White;
            mainmenu.about.btnYoutube.BackColor = Color.White;
            mainmenu.about.btnLinkedin.BackColor = Color.White;

        }


        MainMenu mainmenu;
        public Settings(MainMenu mainmenu)
        {
            InitializeComponent();

            this.mainmenu = mainmenu;
        }

        //This is for Changing Language
        LocallizationHelper lh = new LocallizationHelper();

        //The user have choice between English and Persian
        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbxLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa");

                    break;
            }
            //this is a method from Localization Helper Class to Reload The Form With the Chooosen Language
            lh.ReloadUI(mainmenu);
            lh.ReloadUI(mainmenu.settings);
            lh.ReloadUI(mainmenu.pl);
            lh.ReloadUI(mainmenu.si);
            lh.ReloadUI(mainmenu.su);
            lh.ReloadUI(mainmenu.adi);
            lh.ReloadUI(mainmenu.about);

        }
    
         //user can choose between lightmode and darkmode
        private void rdbtnLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDark.Checked)
            {
                mainmenu.DarkTheme(mainmenu);
                mainmenu.DarkTheme(mainmenu.settings);
                mainmenu.DarkTheme(mainmenu.su);
                mainmenu.DarkTheme(mainmenu.adi);
                mainmenu.DarkTheme(mainmenu.pl);
                mainmenu.DarkTheme(mainmenu.si);
                mainmenu.DarkTheme(mainmenu.chbg);
                mainmenu.DarkTheme(mainmenu.about);

                ForceColors();

            }
            else if (rdbtnLight.Checked)
            {
                mainmenu.LightTheme(mainmenu);
                mainmenu.LightTheme(mainmenu.settings);
                mainmenu.LightTheme(mainmenu.su);
                mainmenu.LightTheme(mainmenu.adi);
                mainmenu.LightTheme(mainmenu.pl);
                mainmenu.LightTheme(mainmenu.si);
                mainmenu.LightTheme(mainmenu.about);

                ForceColors();
            }
        }

        //ChooseBackground Showing Button Event
        private void materialButton1_Click(object sender, EventArgs e)
        {
            mainmenu.chbg.Show();
            mainmenu.chbg.Location = mainmenu.Location;
            this.Hide();
        }
       
        //Instead of closing make it Hide
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            mainmenu.settings.Hide();
        }
    }
}
