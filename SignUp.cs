using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Rock_Paper_Scissors;

namespace Library_Managment
{
    public partial class SignUp : MaterialForm
    {
        //Sending otp to user's email method
        public void SendVerificationCode(String toEmail, string Code)
        {
            var fromAdress = new MailAddress("shayanshams763@gmail.com", "Library Mnagment");
            var toAddress = new MailAddress(toEmail);

            const string fromPassword = "ibrcdvdvilkquphw";


            string subject = "";
            string body = "";
            if (mbtnSigIn.Text == "Sign In")
            {
                subject = "Signing Up In Library";
                body = $"Your Verification code :{Code}";
            }
            else
            {
                subject = "ورود به کتابخانه";
                body = $"کد تایید شما :{Code}";
            }
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAdress.Address, fromPassword)

            };

            using (var message = new MailMessage(fromAdress, toAddress))
            {
                message.Subject = subject;
                message.Body = body;
                smtp.Send(message);
            }
        }

        //Generating OTP
        public string GeneratorCode()
        {
            Random code = new Random();
            return code.Next(100000, 999999).ToString();
        }


        MainMenu mainmenu;
        public SignUp(MainMenu mainmenu)
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
                txtUserName.Focus();
            }
        }

        //clicking on enter will send you to the next textbox
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //prevent of beep sound
                e.Handled = true;
                txtPasswordAgain.Focus();
            }
        }

        //clicking on enter will send you to the next textbox
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //prevent of beep sound
                e.Handled = true;
                txtPhoneNumber.Focus();
            }
        }

        //clicking on enter will send you to the next textbox
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                //prevent of beep sound
                e.Handled = true;
                mbtnSignUp.Focus();
                mbtnSignUp.PerformClick();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //visible-true show passworrd button
            mbtnShowPass.Visible = true;

            //the password must have 8 to 12 characters
            if (txtPassword.TextLength >=8 && txtPassword.TextLength<=12)
            {
                txtPasswordAgain.Enabled = true;
                lblPassword8Ch.Visible = false;

            }
            else
            {
                txtPasswordAgain.Enabled = false;
                lblPassword8Ch.Visible = true;
            }
        }


        public string code1;
        
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //the email must have @gmail.com
            string text = txtEmail.Text;
            if (text.IndexOf("@gmail.com") > 0)
            {
                txtUserName.Enabled = true;
                lblOnlyGmail.Visible = false;

            }
            else
            {
                lblOnlyGmail.Visible = true;
                txtUserName.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //The UserName Must Have At least 8 characters

            if (txtUserName.TextLength >= 8)
            {
                txtPassword.Enabled = true;

                lblUserName8Ch.Visible = false;


            }
            else
            {
                txtPassword.Enabled = false;

                lblUserName8Ch.Visible = true;
            }
        }

        // clicking on Enter will send you to the next textbox
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //prevent of beep sound
                e.Handled = true;
                txtPassword.Focus();
            }
        }

        private void txtPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            //the passwords don't match

            string passWordAgain = txtPasswordAgain.Text;

            if (passWordAgain == txtPassword.Text)
            {
                txtPhoneNumber.Enabled = true;
                lblPasswordsMatch.Visible = false;

                mbtnSignUp.Enabled = true;
            }

            else
            {
                txtPhoneNumber.Enabled = false;
                lblPasswordsMatch.Visible = true;
            }
        }

        //Hiding Password Button Event
        private void mbtnHidePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPasswordAgain.UseSystemPasswordChar = true;

            mbtnShowPass.Visible = true;
            mbtnHidePass.Visible = false;
            txtPassword.Focus();
        }


        private void mbtnSignUp_Click(object sender, EventArgs e)
        {
            //Sending Code to Email
            string userEmail = txtEmail.Text;
            string code = GeneratorCode();
            code1 = code;

            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("The Passwords Does'nt Match");
            }


            //try-catch for sending email
            try
            {
                SendVerificationCode(userEmail, code);
                if (mbtnSigIn.Text == "Sign In")
                {
                    MessageBox.Show("We've Sent a Code to Your Email");
                }
                else
                {
                    MessageBox.Show("کد تایید به ایمیل شما ارسال شد");
                }
                SignUp.ActiveForm.Close();

                mainmenu.UpdateOtpCode(code);


            }
            catch (Exception ex)
            {
                if (mbtnSigIn.Text == "Sign In")
                {
                    MessageBox.Show("Email Sent With Error");
                }
                else
                {
                    MessageBox.Show("ایمیل با ارور فرستاده شد");
                }
            }

        }

        //Showing Password Button Event
        private void mbtnShowPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtPasswordAgain.UseSystemPasswordChar = false;

            mbtnShowPass.Visible = false;
            mbtnHidePass.Visible = true;
            txtPassword.Focus();
        }

        //Showing Sign form In Button Event
        private void mbtnSigIn_Click(object sender, EventArgs e)
        {
            mainmenu.su.Hide();
            mainmenu.si.Show();
            mainmenu.si.TopMost = true;
        }

        //Istead of closing Hide it
        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            mainmenu.su.Hide();
        }
    }
}
