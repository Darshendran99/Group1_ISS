using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1ImageSegregationSystem
{
    public partial class ImageVerificationPage : Form
    {
        string filepath = Path.Combine(Environment.CurrentDirectory, @"Images\");
        string[] images = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, @"Images\"));
        string[] images1 = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, @"Images\"));
        int counter1 = 0;


        public ImageVerificationPage()
        {
            InitializeComponent();
            pbxBox.Image = Image.FromFile(images1[counter1]);
            bar1.BackColor = Color.DarkRed;
            bar2.BackColor = Color.DarkRed;
            bar3.BackColor = Color.DarkRed;
            bar4.BackColor = Color.DarkRed;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void homeBtnMenu_Click_1(object sender, EventArgs e)
        {
            var homeBtnMenu = new HomePage();
            homeBtnMenu.Show();
            this.Hide();
        }

        private void uploadBtnMenu_Click(object sender, EventArgs e)
        {
            var uploadBtnMenu = new UploadImagePage();
            uploadBtnMenu.Show();
            this.Hide();
        }

        private void screeningBtnMenu_Click(object sender, EventArgs e)
        {
            var screeningBtnMenu = new ImageVerificationPage();
            screeningBtnMenu.Show();
            this.Hide();
        }

        private void idleBtnMenu_Click(object sender, EventArgs e)
        {
            var idleBtnMenu = new WelcomePage();
            idleBtnMenu.Show();
            this.Hide();
        }

        private void failBtn_Click(object sender, EventArgs e)
        {

        }

        private void passBtn_Click(object sender, EventArgs e)
        {

            string directoryPass = Path.Combine(Environment.CurrentDirectory, @"Passed_Images\", Path.GetFileName(images[counter1]));

            File.Copy(filepath + Path.GetFileName(images[counter1]), directoryPass);

            counter1++;
            
            pbxBox.Image = new Bitmap(images[counter1]);

            int counter = Convert.ToInt32(passCounter.Text);
            counter = counter + 1;
            passCounter.Text = counter.ToString();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(filepath + Path.GetFileName(images[counter1 - 1]));

            MessageBox.Show("Image Passed and Saved into Passed Images Folder");
            

            ProgressBar();

        }

        private void ImageVerificationPage_Load(object sender, EventArgs e)
        {
            ProgressBar();
        }

        private void ProgressBar()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(filepath);
            int total = dir.GetFiles().Length;
            int completed = Convert.ToInt32(passCounter.Text) + Convert.ToInt32(failCounter.Text);

            progressBar1.Minimum = 0;
            progressBar1.Value = completed;
            progressBar1.Maximum = total + 5;

        }

        private void logOutBtnMenu_Click_1(object sender, EventArgs e)
        {
            var logOutBtnMenu = new LoginForm();
            logOutBtnMenu.Show();
            this.Hide();
        }

        private void FailBtn_Click(object sender, EventArgs e)
        {

            string directoryFail_1 = Path.Combine(Environment.CurrentDirectory, @"Failed_Images\Blur", Path.GetFileName(images[counter1]));

            File.Copy(filepath + Path.GetFileName(images[counter1]), directoryFail_1);

            counter1++;

            pbxBox.Image = new Bitmap(images[counter1]);

            int counter = Convert.ToInt32(failCounter.Text);
            counter = counter + 1;
            failCounter.Text = counter.ToString();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(filepath + Path.GetFileName(images[counter1 - 1]));

            MessageBox.Show("Image Stored in Blur Folder");

            ProgressBar();
        }

        private void redEyeFailBtn_Click(object sender, EventArgs e)
        {
            string directoryFail_2 = Path.Combine(Environment.CurrentDirectory, @"Failed_Images\RedEye", Path.GetFileName(images[counter1]));

            File.Copy(filepath + Path.GetFileName(images[counter1]), directoryFail_2);

            counter1++;

            pbxBox.Image = new Bitmap(images[counter1]);

            int counter = Convert.ToInt32(failCounter.Text);
            counter = counter + 1;
            failCounter.Text = counter.ToString();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(filepath + Path.GetFileName(images[counter1 - 1]));

            MessageBox.Show("Image Stored in Red Eye Folder");

            ProgressBar();
        }


        private void waterMarkBtn_Click(object sender, EventArgs e)
        {
            string directoryFail_3 = Path.Combine(Environment.CurrentDirectory, @"Failed_Images\WaterMark", Path.GetFileName(images[counter1]));

            File.Copy(filepath + Path.GetFileName(images[counter1]), directoryFail_3);

            counter1++;

            pbxBox.Image = new Bitmap(images[counter1]);

            int counter = Convert.ToInt32(failCounter.Text);
            counter = counter + 1;
            failCounter.Text = counter.ToString();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(filepath + Path.GetFileName(images[counter1 - 1]));

            MessageBox.Show("Image Stored in Watermark Folder");

            ProgressBar();
        }

        private void distortedFailBtn_Click(object sender, EventArgs e)
        {
            string directoryFail_4 = Path.Combine(Environment.CurrentDirectory, @"Failed_Images\Distorted", Path.GetFileName(images[counter1]));

            File.Copy(filepath + Path.GetFileName(images[counter1]), directoryFail_4);

            counter1++;

            pbxBox.Image = new Bitmap(images[counter1]);

            int counter = Convert.ToInt32(failCounter.Text);
            counter = counter + 1;
            failCounter.Text = counter.ToString();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(filepath + Path.GetFileName(images[counter1 - 1]));

            MessageBox.Show("Image Stored in Distorted Folder");

            ProgressBar();
        }

        private void missingItemFailBtn_Click(object sender, EventArgs e)
        {
            string directoryFail_5 = Path.Combine(Environment.CurrentDirectory, @"Failed_Images\MissingItem", Path.GetFileName(images[counter1]));

            File.Copy(filepath + Path.GetFileName(images[counter1]), directoryFail_5);

            counter1++;

            pbxBox.Image = new Bitmap(images[counter1]);

            int counter = Convert.ToInt32(failCounter.Text);
            counter = counter + 1;
            failCounter.Text = counter.ToString();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(filepath + Path.GetFileName(images[counter1 - 1]));

            MessageBox.Show("Image Stored in Missing Item Folder");

            ProgressBar();
        }

        private void extensionFailBtn_Click(object sender, EventArgs e)
        {
            string directoryFail_6 = Path.Combine(Environment.CurrentDirectory, @"Failed_Images\FailExtension", Path.GetFileName(images[counter1]));

            File.Copy(filepath + Path.GetFileName(images[counter1]), directoryFail_6);

            counter1++;

            pbxBox.Image = new Bitmap(images[counter1]);

            int counter = Convert.ToInt32(failCounter.Text);
            counter = counter + 1;
            failCounter.Text = counter.ToString();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(filepath + Path.GetFileName(images[counter1 - 1]));

            MessageBox.Show("Image Stored in Extension Issue Folder");

            ProgressBar();
        }

        private void unableToLoadFaillBtn_Click(object sender, EventArgs e)
        {
            string directoryFail_7 = Path.Combine(Environment.CurrentDirectory, @"Failed_Images\UnableToLoad", Path.GetFileName(images[counter1]));

            File.Copy(filepath + Path.GetFileName(images[counter1]), directoryFail_7);

            counter1++;

            pbxBox.Image = new Bitmap(images[counter1]);

            int counter = Convert.ToInt32(failCounter.Text);
            counter = counter + 1;
            failCounter.Text = counter.ToString();

            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(filepath + Path.GetFileName(images[counter1 - 1]));

            MessageBox.Show("Image Stored in Unable to Load Folder");

            ProgressBar();
        }
    }
}
