using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using PdfiumViewer;
using Rock_Paper_Scissors;

namespace Library_Managment
{
    public partial class ProfessorLibrary : MaterialForm
    {
        ResizeHelper resizeHelper = new ResizeHelper();
        ScreenFixer screenFixer=new ScreenFixer();

        public PictureBox BackgroundImageBox;

        private Dictionary<string, string> pdfFiles = new Dictionary<string, string>();


        MainMenu mainmenu;
        public ProfessorLibrary(MainMenu mainmenu)
        {
            InitializeComponent();

            this.mainmenu = mainmenu;

            BackgroundImageBox = new PictureBox();
            BackgroundImageBox.Dock = DockStyle.Fill;
            BackgroundImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundImageBox.SendToBack();
            this.Controls.Add(BackgroundImageBox);

        }


        //Professor can search in books
        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {

            if (lstbxBooks.Items.IndexOf(txtSearchBooks.Text) >= 0)
            {
                lstbxBooks.SelectedIndex = lstbxBooks.Items.IndexOf(txtSearchBooks.Text);

            }

        }
        //if professor clicked on txtSearch it will be cleared
        private void txtSearchBooks_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchBooks.Clear();
        }
        //if professor clicked on txtSearch it will be cleared
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchStudents.Clear();
        }

        //Clicking anywhere except the txtSearches will restore the texts
        private void ProfessorLibrary_MouseDown(object sender, MouseEventArgs e)
        {
            if (mainmenu.Text == "منوی اصلی")
            {
                txtSearchBooks.Text = "...جستجو در کتاب ها";
                txtSearchStudents.Text = "...جستحو در دانشجویان";
            }
            else
            {
                txtSearchBooks.Text = "Search in Books ...";
                txtSearchStudents.Text = "Search in Students ....";
            }
        }

        //Reading Book by Professor using pdfium package
        private void lstbxBooks_DoubleClick(object sender, EventArgs e)
        {
            if (lstbxBooks.SelectedItem != null)
            {
                string selectedFile = lstbxBooks.SelectedItem.ToString();

                if (pdfFiles.TryGetValue(selectedFile, out string path))
                {
                    var viewer = new PdfViewer();
                    viewer.Dock = DockStyle.Fill;
                    viewer.Document = PdfiumViewer.PdfDocument.Load(path);

                    Form viewerForm = new Form();
                    viewerForm.Text = selectedFile;
                    viewerForm.Width = 800;
                    viewerForm.Height = 600;
                    viewerForm.Controls.Add(viewer);
                    viewerForm.Show();
                }
                else
                {
                    if (mainmenu.pl.Text == "Professor Library")
                    {
                        MessageBox.Show("Something Went Wrong!");
                    }
                    else
                    {
                        MessageBox.Show("!یک خطایی رخ داد");
                    }
                }
            }
        }

        //Enabling btnDeleteBook While selecting a book
        private void lstbxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxBooks.SelectedItem != null)
            {
                mbtnDeleteBook.Enabled = true;
            }
        }

       //Calling Resize Helper methods
        private void ProfessorLibrary_Load(object sender, EventArgs e)
        {
            resizeHelper.SetTargetForm(this);
            resizeHelper.RegisterControls(this.Controls.OfType<Control>().ToArray());
            
            screenFixer.setOnScreen(this);
        }

       //Deleting Book
        private void mbtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (lstbxBooks.SelectedItem != null)
            {
                string selectedFileName = lstbxBooks.SelectedItem.ToString();

                // Delete from listbox
                lstbxBooks.Items.Remove(selectedFileName);

                // Delete from Dictionary
                if (pdfFiles.ContainsKey(selectedFileName))
                {
                    pdfFiles.Remove(selectedFileName);
                }

                // Disabling the Delete Button
                mbtnDeleteBook.Enabled = false;
            }
        }

        //Uploading Book By OpenfileDialoge
        private void mbtnUploadBook_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files|*.pdf";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                string fileName = System.IO.Path.GetFileName(filePath);

                if (!pdfFiles.ContainsKey(fileName))
                {
                    pdfFiles.Add(fileName, filePath);
                    lstbxBooks.Items.Add(fileName);
                }
            }
        }

        //Return to main menu button event
        private void mbtnReturnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu.Show();

            mainmenu.Size = this.Size;
            mainmenu.Location = this.Location;
            mainmenu.WindowState = this.WindowState;
        }

        //Instead of closing hide it
        private void ProfessorLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            mainmenu.Show();

            mainmenu.Size = this.Size;
            mainmenu.Location = this.Location;
            mainmenu.WindowState = this.WindowState;

        }

        //Calling Resize Helper Method in resize event
        private void ProfessorLibrary_Resize(object sender, EventArgs e)
        {
            resizeHelper.ResizeControls();
        }
    }
}
