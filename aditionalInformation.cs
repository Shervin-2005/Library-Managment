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

namespace Library_Managment
{
    public partial class aditionalInformation : MaterialForm
    {
        public aditionalInformation()
        {
            InitializeComponent();
        }

        //The Professor Won't Choose any Major
        private void rBtnProfessor_CheckedChanged(object sender, EventArgs e)
        {
            lblSpecialization.Enabled = false;
            cmbxSpecialzation.Enabled = false;
            lblMajor.Enabled = false;
            cmbxMajor.Enabled = false;
        }

        //The Student Will Choose a Major
        private void rBtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            lblSpecialization.Enabled = true;
            cmbxSpecialzation.Enabled = true;
            lblMajor.Enabled = true;
            cmbxMajor.Enabled = true;
        }

        //31 days for first 6 months and 30 for second 6 months
        private void cmbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int monthIndex = cmbxMonth.SelectedIndex;

            if (monthIndex > 5)
            {

                cmbxDay.Items.Remove("31");

            }
            else if (monthIndex <= 5)
            {

                int day31 = cmbxDay.Items.IndexOf("31");

                if (day31 == -1)
                {
                    cmbxDay.Items.Add("31");
                }

            }


        }

        //if user writes a wrong year it'll be deleted
        private void cmbxYear_KeyPress(object sender, KeyPressEventArgs e)
        {  

            if (e.KeyChar == (char)Keys.Enter)
            {   //prevent of beep sound
                e.Handled = true;

                if (cmbxYear.Items.IndexOf(cmbxYear.Text) == -1)
                {
                    cmbxYear.Text = "";
                    cmbxYear.Focus();
                }
                else
                {
                    cmbxYear.SelectedIndex = cmbxYear.Items.IndexOf(cmbxYear.Text);
                    cmbxMonth.Focus();
                }
            }
        }

        //if user writes a wrong month it'll be deleted
        private void cmbxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (cmbxMonth.Items.IndexOf(cmbxMonth.Text) == -1)
                {
                    cmbxMonth.Text = "";
                    cmbxMonth.Focus();
                }
                else
                {
                    cmbxMonth.SelectedIndex = cmbxMonth.Items.IndexOf(cmbxMonth.Text);
                    cmbxDay.Focus();
                }
            }
        }

        //if user writes a wrong day it'll be deleted 
        private void cmbxDay_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (cmbxDay.Items.IndexOf(cmbxDay.Text) == -1)
                {
                    cmbxDay.Text = "";
                    cmbxDay.Focus();
                }
                else
                {
                    cmbxDay.SelectedIndex = cmbxDay.Items.IndexOf(cmbxDay.Text);
                    rBtnProfessor.Focus();
                }
            }
        }

        //After Pressing on Enter Focus on cmbxYear
        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            { 
                e.Handled = true;
                cmbxYear.Focus();
            }
        }

        //After Choosing Major Focus on cmbxSpecialzation
        private void cmbxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxSpecialzation.Focus();
            cmbxSpecialzation.Text = "";


            switch (cmbxMajor.SelectedIndex)
            {
                //Subfields of Humanities and Social Sciences
                case 0:
                    cmbxSpecialzation.Items.Clear();
                    string[] Specialization0 = { "law", "Education", "Psychology", "Sociology", "Philosophy", "Literature and Linguistics" };
                    for (int i = 0; i < Specialization0.Length; i++)
                    {

                        cmbxSpecialzation.Items.Add(Specialization0[i]);
                    }

                    break;

                //Subfields of Natural Basic Sciences
                case 1:
                    cmbxSpecialzation.Items.Clear();
                    string[] Specialization1 = { "Mathematics", "Physics", "Chemistry", "Biology" };
                    for (int i = 0; i < Specialization1.Length; i++)
                    {
                        cmbxSpecialzation.Items.Add(Specialization1[i]);
                    }
                    break;

                //Subfields of Engineering & Technology
                case 2:
                    cmbxSpecialzation.Items.Clear();
                    string[] Specialization2 = { "Electrical Engineering", "Mechanical Engineering", "Civil Engineering", "Computer Engineering", "Industrial Engineering", "Chemical Engineering", "Architectural Engineering", "Materials Engineering" };
                    for (int i = 0; i < Specialization2.Length; i++)
                    {
                        cmbxSpecialzation.Items.Add(Specialization2[i]);
                    }
                    break;

                //Subfiels of Business & Economics
                case 3:
                    cmbxSpecialzation.Items.Clear();
                    string[] Specialization3 = { "gooz", "chos" };
                    for (int i = 0; i < Specialization3.Length; i++)
                    {
                        cmbxSpecialzation.Items.Add(Specialization3[i]);
                    }
                    break;

                //Subfields of Medical & Health Sciences
                case 4:
                    cmbxSpecialzation.Items.Clear();
                    string[] Specialization4 = { "General Medicine", "Dentistry", "Pharmacy", "Nursing", "Midwifery", "Physiotherapy", "Radiology", "Laboratory Sciences", "Public Health", "Nutrition", "Anesthesiology", "Surgery" };
                    for (int i = 0; i < Specialization4.Length; i++)
                    {
                        cmbxSpecialzation.Items.Add(Specialization4[i]);
                    }
                    break;

                //Subfields of Arts & Design
                case 5:
                    cmbxSpecialzation.Items.Clear();
                    string[] Specialization5 = { "Visual Arts", "Performing Arts", "Music", "Cinema" };
                    for (int i = 0; i < Specialization5.Length; i++)
                    {
                        cmbxSpecialzation.Items.Add(Specialization5[i]);
                    }
                    break;
            }
        }

        //After Choosing a Subfield focus on Terms of the Use
        private void cmbxSpecialzation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxTermsOfUse.Focus();
        }

        //If all informations Entered the sign up button will be enabled
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (txtFullName.Text.Length >= 4 && cmbxYear.SelectedIndex != -1 && cmbxMonth.SelectedIndex != -1 && cmbxDay.SelectedIndex != -1)
            {
                if ((rBtnProfessor.Checked == true && cmbxTermsOfUse.Checked == true) || (rBtnStudent.Checked == true && cmbxMajor.SelectedIndex != -1 && cmbxSpecialzation.SelectedIndex != -1 && cmbxTermsOfUse.Checked == true))

                {
                    mbtnSignUp.Enabled = true;
                }
                mbtnSignUp.Focus();
            }

            else
            {
                mbtnSignUp.Enabled = false;
            }
        }

        //Closing aditional Information
        private void mbtnSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
