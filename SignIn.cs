using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Rock_Paper_Scissors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Library_Managment
{

    public partial class SignIn : MaterialForm
    {

        MainMenu mainmenu;
        public SignIn(MainMenu mainmenu)
        {
            InitializeComponent();

            this.mainmenu = mainmenu;
        }

        //clicking on enter will send you to the next textbox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //prevent of beep sound
                e.Handled = true;
                txtPassword.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //prevent of beep sound
                e.Handled = true;
                mbtnSignIn.Focus();
                mbtnSignIn.PerformClick();
            }
        }

        //visible-true : show password buuton
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            mbtnShowPass.Visible = true;
        }

        //Showing Password button event
        private void mbtnShowPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;

            mbtnShowPass.Visible = false;
            mbtnHidePass.Visible = true;
            txtPassword.Focus();
        }
        
        //Hiding password button event
        private void mbtnHidePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

            mbtnShowPass.Visible = true;
            mbtnHidePass.Visible = false;
            txtPassword.Focus();
        }

        //Showing Sign Up button event
        private void mbtnSignUp_Click(object sender, EventArgs e)
        {
            mainmenu.si.Hide();
            mainmenu.su.Show();
            mainmenu.su.Location = this.Location;

        }

        //Instead of closing make it hide
        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            mainmenu.si.Hide();
        }
    }
}
