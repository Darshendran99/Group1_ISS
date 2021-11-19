
namespace Group1ImageSegregationSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_GoToLogin = new System.Windows.Forms.Button();
            this.panel_login = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel_login_bar = new System.Windows.Forms.Panel();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // button_GoToLogin
            // 
            this.button_GoToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_GoToLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button_GoToLogin.FlatAppearance.BorderSize = 0;
            this.button_GoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GoToLogin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoToLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_GoToLogin.Location = new System.Drawing.Point(158, 46);
            this.button_GoToLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_GoToLogin.Name = "button_GoToLogin";
            this.button_GoToLogin.Size = new System.Drawing.Size(283, 130);
            this.button_GoToLogin.TabIndex = 0;
            this.button_GoToLogin.Text = "Login";
            this.button_GoToLogin.UseVisualStyleBackColor = false;
            this.button_GoToLogin.Click += new System.EventHandler(this.button_GoToLogin_Click);
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel_login.Controls.Add(this.loginBtn);
            this.panel_login.Controls.Add(this.passWord);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.userName);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Location = new System.Drawing.Point(11, 187);
            this.panel_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(587, 463);
            this.panel_login.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(220, 268);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(260, 84);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // passWord
            // 
            this.passWord.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.Location = new System.Drawing.Point(220, 166);
            this.passWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(260, 31);
            this.passWord.TabIndex = 3;
            this.passWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(220, 92);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(260, 31);
            this.userName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.ImageLocation = "../../closeBtn/x.png";
            this.pictureBox_close.Location = new System.Drawing.Point(571, 12);
            this.pictureBox_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(24, 25);
            this.pictureBox_close.TabIndex = 2;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // panel_login_bar
            // 
            this.panel_login_bar.Location = new System.Drawing.Point(158, 172);
            this.panel_login_bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_login_bar.Name = "panel_login_bar";
            this.panel_login_bar.Size = new System.Drawing.Size(283, 4);
            this.panel_login_bar.TabIndex = 7;
            this.panel_login_bar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_bar_Paint);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(605, 668);
            this.Controls.Add(this.panel_login_bar);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.button_GoToLogin);
            this.Controls.Add(this.panel_login);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "LoginAndRegisterForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.LoginAndRegisterForm_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_GoToLogin;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel_login_bar;
    }
}

