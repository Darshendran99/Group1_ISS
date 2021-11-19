using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1ImageSegregationSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            var homeBtnMenu = new HomePage();
            homeBtnMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uploadIMGBtn = new UploadImagePage();
            uploadIMGBtn.Show();
            this.Hide();
        }

        private void idleBtn_Click(object sender, EventArgs e)
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

        private void screeningBtnMenu_Click(object sender, EventArgs e)
        {
            var screeningBtnMenu = new ImageVerificationPage();
            screeningBtnMenu.Show();
            this.Hide();
        }

        private void logOutBtnMenu_Click(object sender, EventArgs e)
        {
            var logOutBtnMenu = new LoginForm();
            logOutBtnMenu.Show();
            this.Hide();
        }

        private void screeningBtn_Click(object sender, EventArgs e)
        {
            var screeningBtn = new ImageVerificationPage();
            screeningBtn.Show();
            this.Hide();
        }
    }
}
