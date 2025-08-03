using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Rock_Paper_Scissors;

namespace Library_Managment
{
    public partial class About : MaterialForm
    {
        public About()
        {
            InitializeComponent();
        }
        //Shervin
        //if User Closed don't close the Form Just Hide it (Because of Disposing)
        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        //Showing Youtube Channel
        private void btnYoutube_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/@ShervinShayanShams-o9i7o";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                if (this.Text == "About")
                {
                    MessageBox.Show("Failded to Open the Link");
                }
                else
                {
                    MessageBox.Show("خطا در باز کردن لینک");
                }
            }
        }

        //Showing Telegram Channel
        private void btnTelegram_Click(object sender, EventArgs e)
        {
            string url = "https://t.me/ShervinShayanShams";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                if (this.Text == "About")
                {
                    MessageBox.Show("Failded to Open the Link");
                }
                else
                {
                    MessageBox.Show("خطا در باز کردن لینک");
                }
            }
        }

        //Showing LinkedIn Profile
        private void btnLinkedin_Click(object sender, EventArgs e)
        {
            string url = "http://www.linkedin.com/in/shayan-shams-6a0051375";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                if (this.Text == "About")
                {
                    MessageBox.Show("Failded to Open the Link");
                }
                else
                {
                    MessageBox.Show("خطا در باز کردن لینک");
                }
            }
        }

        //Showing Github Profile
        private void btnGithub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Shayan-Shams-2005";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
                if (this.Text == "About")
                {
                    MessageBox.Show("Failded to Open the Link");
                }
                else
                {
                    MessageBox.Show("خطا در باز کردن لینک");
                }
            }
        }

    }
}
