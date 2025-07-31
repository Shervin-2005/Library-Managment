using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Rock_Paper_Scissors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Managment
{
    public partial class EnterOTP : MaterialForm
    {

        MainMenu mainmenu;
        string code;
        public EnterOTP(string code, MainMenu mainmenu)
        {
            InitializeComponent();

            this.mainmenu = mainmenu;
            this.code = code;

        }
        
        //Change Focus if Clicked on enter
        private void txtOTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //prevent of beep sound
                e.Handled = true;

            }
        }

        //if code was true continue
        private void mbtnContinue_Click(object sender, EventArgs e)
        {

            if (txtOTP.Text == code)
            {
                EnterOTP.ActiveForm.Close();
                mainmenu.adi.Show();
                mainmenu.adi.Location = this.Location;

            }
            else
                lblCodeNotTrue.Visible = true;
        }
    }
}
