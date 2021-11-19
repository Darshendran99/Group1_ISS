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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Color select_color = Color.FromArgb(49, 46, 46);
        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            panel_login.BringToFront();
            button_GoToLogin.BackColor = select_color;
            panel_login_bar.BackColor = Color.Green;

        }


        private void LoginAndRegisterForm_Load(object sender, EventArgs e)
        {
            button_GoToLogin.PerformClick();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static int attempt = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.userName.Text == "idealvision") && (this.passWord.Text == "123"))
            {
                attempt = 0;
                MessageBox.Show("Sucessfully Logged In");
                var loginBtn = new HomePage();
                loginBtn.Show();
                this.Hide();
            }
            else if (this.userName.Text == "")
            {
                MessageBox.Show("PLease Enter Username");
            }
            else if (this.passWord.Text == "")
            {
                MessageBox.Show("PLease Enter Password");
            }
            else if ((attempt == 3) && (attempt > 0))
            {
                MessageBox.Show("Incorrect, You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
            }
            else
            {
                MessageBox.Show("you are not granted with access");
                
            }
        }

       

        private void panel_login_bar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

