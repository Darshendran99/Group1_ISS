
namespace Group1ImageSegregationSystem
{
    partial class WelcomePage
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
            this.enterBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.uhbjink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.Green;
            this.enterBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.ForeColor = System.Drawing.Color.White;
            this.enterBtn.Location = new System.Drawing.Point(348, 153);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(158, 68);
            this.enterBtn.TabIndex = 1;
            this.enterBtn.Text = "Enter ->";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Red;
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(348, 298);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(158, 68);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.Text = "<- Logout";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // uhbjink
            // 
            this.uhbjink.AutoSize = true;
            this.uhbjink.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uhbjink.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uhbjink.Location = new System.Drawing.Point(11, 9);
            this.uhbjink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uhbjink.Name = "uhbjink";
            this.uhbjink.Size = new System.Drawing.Size(158, 45);
            this.uhbjink.TabIndex = 3;
            this.uhbjink.Text = "Welcome";
            this.uhbjink.Click += new System.EventHandler(this.label1_Click);
            // 
            // WelcomePage
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Group1ImageSegregationSystem.Properties.Resources.la_nature;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 545);
            this.Controls.Add(this.uhbjink);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.enterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomePage";
            this.Text = "Welcome Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label uhbjink;
    }
}

