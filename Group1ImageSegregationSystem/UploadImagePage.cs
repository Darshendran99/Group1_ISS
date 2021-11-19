using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Group1ImageSegregationSystem
{
    public partial class UploadImagePage : Form
    {
        
        public UploadImagePage()
        {
            InitializeComponent();
        }

        private void homeBtnMenu_Click(object sender, EventArgs e)
        {
            var homeBtnMenu = new HomePage();
            homeBtnMenu.Show();
            this.Hide();
        }

        private void idleBtnMenu_Click(object sender, EventArgs e)
        {
            var idleBtnMenu = new WelcomePage();
            idleBtnMenu.Show();
            this.Hide();
        }

        private void uploadBtnMenu_Click(object sender, EventArgs e)
        {
            var uploadBtnMenu = new UploadImagePage();
            uploadBtnMenu.Show();
            this.Hide();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();


            //Add filter, if you want to allow all extenssions just remove it.

            openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG*;.| jpg files(*.jpg)| *.jpg | PNG files(*png) | *.png | TIFF files(*.tif) | *.tif | GIF files(*.gif) | *gif | PDF files(*.pdf) | *pdf | RAW files(*.raw) | *.raw | jpeg files(*.jpeg) | *.jpeg";

            // Set multiselect true for slecting multiple files

            openFileDialog.Multiselect = true;


            // Show open file dialog and check if Open button is pressed.

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                // Set directory name and create it.


                // Read all files.

                foreach (string fileName in openFileDialog.FileNames)

                {
                   
                    string directory =  Path.Combine(Environment.CurrentDirectory, @"Images\", Path.GetFileName(fileName));

                    // Copy file to specific directory.

                    File.Copy(fileName, directory, true);           
                }
                MessageBox.Show("Images Sucessfully Moved Into \n \n bin...Debug...Images");
            }
            else
            {
                MessageBox.Show("Something Happend \n \n Unsucessfull Moving Images");
            }
        }

        private void screeningBtnMenu_Click(object sender, EventArgs e)
        {
            var screeningBtnMenu = new ImageVerificationPage();
            screeningBtnMenu.Show();
            this.Hide();
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            var statusBtn = new ImageVerificationPage();
            statusBtn.Show();
            this.Hide();
        }

        private void logOutBtnMenu_Click(object sender, EventArgs e)
        {
            var logOutBtnMenu = new LoginForm();
            logOutBtnMenu.Show();
            this.Hide();
        }
    }
}
