using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Library_Managment
{
    public partial class ChooseBackground : MaterialForm
    {

        //refreshing forms so colors will change immediately
        public void RefreshForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                foreach (Control control in form.Controls)
                {

                    control.Invalidate();
                    control.Refresh();
                   

                    if (control.HasChildren)
                    {
                        control.Invalidate();
                        control.Refresh();
                    }
                }
                form.Invalidate();
                form.Update();
            }
        }


        MainMenu mainmenu;
        public ChooseBackground(MainMenu mainmenu)
        {
            InitializeComponent();
            this.mainmenu = mainmenu;


        }

        //Changing Background of mainmenu & professor library :btnBg3 Event
        private void button3_Click(object sender, EventArgs e)
        {
            mainmenu.BackgroundImageBox.Image = btnBg3.BackgroundImage;
            mainmenu.pl.BackgroundImageBox.Image = btnBg3.BackgroundImage;
        }

        //Changing Background of mainmenu & professor library :btnBg1 Event
        private void button1_Click(object sender, EventArgs e)
        {
            mainmenu.BackgroundImageBox.Image = btnBg1.BackgroundImage;
            mainmenu.pl.BackgroundImageBox.Image = btnBg1.BackgroundImage;
        }

        //Changing Background of mainmenu & professor library :btnBg2 Event
        private void button2_Click(object sender, EventArgs e)
        {
            mainmenu.BackgroundImageBox.Image = btnBg2.BackgroundImage;
            mainmenu.pl.BackgroundImageBox.Image = btnBg2.BackgroundImage;
        }

        //Changing Background of mainmenu & professor library :btnBg4 Event
        private void button4_Click(object sender, EventArgs e)
        {
            mainmenu.BackgroundImageBox.Image = btnBg4.BackgroundImage;
            mainmenu.pl.BackgroundImageBox.Image = btnBg4.BackgroundImage;
        }

        //Changing Background of mainmenu & professor library :btnBg5 Event
        private void button5_Click(object sender, EventArgs e)
        {
            mainmenu.BackgroundImageBox.Image = btnBg5.BackgroundImage;
            mainmenu.pl.BackgroundImageBox.Image = btnBg5.BackgroundImage;
        }

        //Uploading Background :btnUploadBg Event
        private void button6_Click(object sender, EventArgs e)
        {    
            //using OpenFile Dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose a Picture";
                openFileDialog.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    Image selectedImage = Image.FromFile(openFileDialog.FileName);


                    mainmenu.BackgroundImageBox.Image = selectedImage;
                    mainmenu.pl.BackgroundImageBox.Image = selectedImage;

                }
            }

        }

        //Changing Theme Color to Orange : btnOrange Event
        private void btnOrange_Click_1(object sender, EventArgs e)
        {
            mainmenu.materialSkinManager.ColorScheme = new ColorScheme(
                  Primary.DeepOrange500, Primary.DeepOrange700,
                  Primary.DeepOrange100, Accent.DeepOrange200,
                  TextShade.BLACK
                  );
            //Refreshing Forms
            RefreshForms();
            //Some of the Controls won't Change 
            mainmenu.settings.ForceColors();
        }

        //Changing Theme Color to Red : btnRed Event
        private void button1_Click_1(object sender, EventArgs e)
        {
            mainmenu.materialSkinManager.ColorScheme = new ColorScheme(
           Primary.Red600,
           Primary.Red700,
           Primary.Red200,
           Accent.Red400,
           TextShade.WHITE
           );

            RefreshForms();
            mainmenu.settings.ForceColors();
        }

        //Changing Theme Color to Green : btnGreen Event
        private void btnGreen_Click(object sender, EventArgs e)
        {
            mainmenu.materialSkinManager.ColorScheme = new ColorScheme(
          Primary.Green600,
          Primary.Green700,
          Primary.Green200,
          Accent.Green400,
          TextShade.WHITE
          );

            RefreshForms();
            mainmenu.settings.ForceColors();
        }

        //Changing Theme Color to Blue : btnBlue Event
        private void btnBlue_Click(object sender, EventArgs e)
        {
            mainmenu.materialSkinManager.ColorScheme = new ColorScheme(
          Primary.Blue700,
          Primary.Blue800,
          Primary.Blue300,
          Accent.LightBlue200,
          TextShade.WHITE
          );

            RefreshForms();
            mainmenu.settings.ForceColors();
        }

        //Changing Theme Color to Purple : btnPurple Event
        private void btnPurple_Click(object sender, EventArgs e)
        {
            mainmenu.materialSkinManager.ColorScheme = new ColorScheme(
            Primary.DeepPurple600,
            Primary.DeepPurple700,
            Primary.DeepPurple200,
            Accent.DeepPurple400,
            TextShade.WHITE
            );

            RefreshForms();
            mainmenu.settings.ForceColors();
        }

        //Changing Theme Color to Gray : btnGray Event
        private void btnGrey_Click(object sender, EventArgs e)
        {
            mainmenu.materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Grey800,
            Primary.Grey900,
            Primary.Grey500,
            Accent.Yellow700,
            TextShade.WHITE
            );

            RefreshForms();
            mainmenu.settings.ForceColors();
        }

        //Instead of closing the ChooseBackground form, just hide it and show the Settings form again
        private void ChooseBackground_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            mainmenu.chbg.Hide();

            mainmenu.settings.Show();
            mainmenu.settings.Location = this.Location;
        }
    }
}
