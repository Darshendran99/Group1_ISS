
namespace Group1ImageSegregationSystem
{
    partial class ImageVerificationPage
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
            this.pbxBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameTXT = new System.Windows.Forms.Label();
            this.logOutBtnMenu = new System.Windows.Forms.Button();
            this.idleBtnMenu = new System.Windows.Forms.Button();
            this.screeningBtnMenu = new System.Windows.Forms.Button();
            this.uploadBtnMenu = new System.Windows.Forms.Button();
            this.homeBtnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passCounter = new System.Windows.Forms.Label();
            this.failCounter = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bar1 = new System.Windows.Forms.Panel();
            this.bar2 = new System.Windows.Forms.Panel();
            this.bar3 = new System.Windows.Forms.Panel();
            this.bar4 = new System.Windows.Forms.Panel();
            this.blurFailBtn = new System.Windows.Forms.Button();
            this.distortedFailBtn = new System.Windows.Forms.Button();
            this.waterMarkBtn = new System.Windows.Forms.Button();
            this.redEyeFailBtn = new System.Windows.Forms.Button();
            this.missingItemFailBtn = new System.Windows.Forms.Button();
            this.unableToLoadFaillBtn = new System.Windows.Forms.Button();
            this.extensionFailBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBox
            // 
            this.pbxBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.pbxBox.Location = new System.Drawing.Point(343, 214);
            this.pbxBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxBox.Name = "pbxBox";
            this.pbxBox.Size = new System.Drawing.Size(380, 478);
            this.pbxBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBox.TabIndex = 5;
            this.pbxBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pass/Fail Status";
            // 
            // passBtn
            // 
            this.passBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.passBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passBtn.Location = new System.Drawing.Point(36, 359);
            this.passBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(211, 100);
            this.passBtn.TabIndex = 7;
            this.passBtn.Text = "Pass";
            this.passBtn.UseVisualStyleBackColor = false;
            this.passBtn.Click += new System.EventHandler(this.passBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Counter: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(968, 671);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Counter:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.nameTXT);
            this.panel1.Controls.Add(this.logOutBtnMenu);
            this.panel1.Controls.Add(this.idleBtnMenu);
            this.panel1.Controls.Add(this.screeningBtnMenu);
            this.panel1.Controls.Add(this.uploadBtnMenu);
            this.panel1.Controls.Add(this.homeBtnMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 116);
            this.panel1.TabIndex = 12;
            // 
            // nameTXT
            // 
            this.nameTXT.AutoSize = true;
            this.nameTXT.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTXT.Location = new System.Drawing.Point(1021, 46);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(126, 32);
            this.nameTXT.TabIndex = 8;
            this.nameTXT.Text = "[NAME]***";
            // 
            // logOutBtnMenu
            // 
            this.logOutBtnMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtnMenu.Location = new System.Drawing.Point(867, 41);
            this.logOutBtnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutBtnMenu.Name = "logOutBtnMenu";
            this.logOutBtnMenu.Size = new System.Drawing.Size(123, 39);
            this.logOutBtnMenu.TabIndex = 7;
            this.logOutBtnMenu.Text = "Log Out";
            this.logOutBtnMenu.UseVisualStyleBackColor = true;
            this.logOutBtnMenu.Click += new System.EventHandler(this.logOutBtnMenu_Click_1);
            // 
            // idleBtnMenu
            // 
            this.idleBtnMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idleBtnMenu.Location = new System.Drawing.Point(749, 41);
            this.idleBtnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idleBtnMenu.Name = "idleBtnMenu";
            this.idleBtnMenu.Size = new System.Drawing.Size(97, 39);
            this.idleBtnMenu.TabIndex = 6;
            this.idleBtnMenu.Text = "Idle";
            this.idleBtnMenu.UseVisualStyleBackColor = true;
            this.idleBtnMenu.Click += new System.EventHandler(this.idleBtnMenu_Click);
            // 
            // screeningBtnMenu
            // 
            this.screeningBtnMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screeningBtnMenu.Location = new System.Drawing.Point(536, 41);
            this.screeningBtnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.screeningBtnMenu.Name = "screeningBtnMenu";
            this.screeningBtnMenu.Size = new System.Drawing.Size(140, 39);
            this.screeningBtnMenu.TabIndex = 5;
            this.screeningBtnMenu.Text = "Screening";
            this.screeningBtnMenu.UseVisualStyleBackColor = true;
            this.screeningBtnMenu.Click += new System.EventHandler(this.screeningBtnMenu_Click);
            // 
            // uploadBtnMenu
            // 
            this.uploadBtnMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtnMenu.Location = new System.Drawing.Point(371, 41);
            this.uploadBtnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uploadBtnMenu.Name = "uploadBtnMenu";
            this.uploadBtnMenu.Size = new System.Drawing.Size(121, 39);
            this.uploadBtnMenu.TabIndex = 4;
            this.uploadBtnMenu.Text = "Upload";
            this.uploadBtnMenu.UseVisualStyleBackColor = true;
            this.uploadBtnMenu.Click += new System.EventHandler(this.uploadBtnMenu_Click);
            // 
            // homeBtnMenu
            // 
            this.homeBtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeBtnMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtnMenu.Location = new System.Drawing.Point(245, 41);
            this.homeBtnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeBtnMenu.Name = "homeBtnMenu";
            this.homeBtnMenu.Size = new System.Drawing.Size(99, 39);
            this.homeBtnMenu.TabIndex = 3;
            this.homeBtnMenu.Text = "Home";
            this.homeBtnMenu.UseVisualStyleBackColor = true;
            this.homeBtnMenu.Click += new System.EventHandler(this.homeBtnMenu_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group1ImageSegregationSystem.Properties.Resources.Ideal_Vision_Logo_with_TM;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // passCounter
            // 
            this.passCounter.AutoSize = true;
            this.passCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passCounter.Location = new System.Drawing.Point(196, 481);
            this.passCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passCounter.Name = "passCounter";
            this.passCounter.Size = new System.Drawing.Size(18, 20);
            this.passCounter.TabIndex = 13;
            this.passCounter.Text = "0";
            // 
            // failCounter
            // 
            this.failCounter.AutoSize = true;
            this.failCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failCounter.Location = new System.Drawing.Point(1052, 672);
            this.failCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.failCounter.Name = "failCounter";
            this.failCounter.Size = new System.Drawing.Size(18, 20);
            this.failCounter.TabIndex = 14;
            this.failCounter.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(343, 715);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(380, 28);
            this.progressBar1.TabIndex = 15;
            // 
            // bar1
            // 
            this.bar1.Location = new System.Drawing.Point(792, 231);
            this.bar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(467, 6);
            this.bar1.TabIndex = 16;
            // 
            // bar2
            // 
            this.bar2.Location = new System.Drawing.Point(792, 640);
            this.bar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(467, 6);
            this.bar2.TabIndex = 17;
            // 
            // bar3
            // 
            this.bar3.Location = new System.Drawing.Point(792, 234);
            this.bar3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(7, 406);
            this.bar3.TabIndex = 18;
            // 
            // bar4
            // 
            this.bar4.Location = new System.Drawing.Point(1255, 235);
            this.bar4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(7, 406);
            this.bar4.TabIndex = 19;
            // 
            // blurFailBtn
            // 
            this.blurFailBtn.BackColor = System.Drawing.Color.Maroon;
            this.blurFailBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blurFailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blurFailBtn.Location = new System.Drawing.Point(813, 271);
            this.blurFailBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blurFailBtn.Name = "blurFailBtn";
            this.blurFailBtn.Size = new System.Drawing.Size(207, 59);
            this.blurFailBtn.TabIndex = 20;
            this.blurFailBtn.Text = "Blur";
            this.blurFailBtn.UseVisualStyleBackColor = false;
            this.blurFailBtn.Click += new System.EventHandler(this.FailBtn_Click);
            // 
            // distortedFailBtn
            // 
            this.distortedFailBtn.BackColor = System.Drawing.Color.Maroon;
            this.distortedFailBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distortedFailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.distortedFailBtn.Location = new System.Drawing.Point(1041, 359);
            this.distortedFailBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.distortedFailBtn.Name = "distortedFailBtn";
            this.distortedFailBtn.Size = new System.Drawing.Size(207, 59);
            this.distortedFailBtn.TabIndex = 21;
            this.distortedFailBtn.Text = "Distorted";
            this.distortedFailBtn.UseVisualStyleBackColor = false;
            this.distortedFailBtn.Click += new System.EventHandler(this.distortedFailBtn_Click);
            // 
            // waterMarkBtn
            // 
            this.waterMarkBtn.BackColor = System.Drawing.Color.Maroon;
            this.waterMarkBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterMarkBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.waterMarkBtn.Location = new System.Drawing.Point(813, 359);
            this.waterMarkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waterMarkBtn.Name = "waterMarkBtn";
            this.waterMarkBtn.Size = new System.Drawing.Size(207, 59);
            this.waterMarkBtn.TabIndex = 22;
            this.waterMarkBtn.Text = "Watermark";
            this.waterMarkBtn.UseVisualStyleBackColor = false;
            this.waterMarkBtn.Click += new System.EventHandler(this.waterMarkBtn_Click);
            // 
            // redEyeFailBtn
            // 
            this.redEyeFailBtn.BackColor = System.Drawing.Color.Maroon;
            this.redEyeFailBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redEyeFailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.redEyeFailBtn.Location = new System.Drawing.Point(1041, 271);
            this.redEyeFailBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redEyeFailBtn.Name = "redEyeFailBtn";
            this.redEyeFailBtn.Size = new System.Drawing.Size(207, 59);
            this.redEyeFailBtn.TabIndex = 23;
            this.redEyeFailBtn.Text = "Red Eye";
            this.redEyeFailBtn.UseVisualStyleBackColor = false;
            this.redEyeFailBtn.Click += new System.EventHandler(this.redEyeFailBtn_Click);
            // 
            // missingItemFailBtn
            // 
            this.missingItemFailBtn.BackColor = System.Drawing.Color.Maroon;
            this.missingItemFailBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingItemFailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.missingItemFailBtn.Location = new System.Drawing.Point(813, 457);
            this.missingItemFailBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.missingItemFailBtn.Name = "missingItemFailBtn";
            this.missingItemFailBtn.Size = new System.Drawing.Size(207, 59);
            this.missingItemFailBtn.TabIndex = 24;
            this.missingItemFailBtn.Text = "Missing Item";
            this.missingItemFailBtn.UseVisualStyleBackColor = false;
            this.missingItemFailBtn.Click += new System.EventHandler(this.missingItemFailBtn_Click);
            // 
            // unableToLoadFaillBtn
            // 
            this.unableToLoadFaillBtn.BackColor = System.Drawing.Color.Maroon;
            this.unableToLoadFaillBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unableToLoadFaillBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.unableToLoadFaillBtn.Location = new System.Drawing.Point(909, 560);
            this.unableToLoadFaillBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unableToLoadFaillBtn.Name = "unableToLoadFaillBtn";
            this.unableToLoadFaillBtn.Size = new System.Drawing.Size(233, 59);
            this.unableToLoadFaillBtn.TabIndex = 25;
            this.unableToLoadFaillBtn.Text = "Unable to Load";
            this.unableToLoadFaillBtn.UseVisualStyleBackColor = false;
            this.unableToLoadFaillBtn.Click += new System.EventHandler(this.unableToLoadFaillBtn_Click);
            // 
            // extensionFailBtn
            // 
            this.extensionFailBtn.BackColor = System.Drawing.Color.Maroon;
            this.extensionFailBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionFailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.extensionFailBtn.Location = new System.Drawing.Point(1041, 457);
            this.extensionFailBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extensionFailBtn.Name = "extensionFailBtn";
            this.extensionFailBtn.Size = new System.Drawing.Size(207, 59);
            this.extensionFailBtn.TabIndex = 26;
            this.extensionFailBtn.Text = "Extension Issue";
            this.extensionFailBtn.UseVisualStyleBackColor = false;
            this.extensionFailBtn.Click += new System.EventHandler(this.extensionFailBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(933, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fail Categories";
            // 
            // ImageVerificationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1268, 801);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.extensionFailBtn);
            this.Controls.Add(this.unableToLoadFaillBtn);
            this.Controls.Add(this.missingItemFailBtn);
            this.Controls.Add(this.redEyeFailBtn);
            this.Controls.Add(this.waterMarkBtn);
            this.Controls.Add(this.distortedFailBtn);
            this.Controls.Add(this.blurFailBtn);
            this.Controls.Add(this.bar4);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.failCounter);
            this.Controls.Add(this.passCounter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImageVerificationPage";
            this.Text = "Image Verification Page";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImageVerificationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button passBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameTXT;
        private System.Windows.Forms.Button logOutBtnMenu;
        private System.Windows.Forms.Button idleBtnMenu;
        private System.Windows.Forms.Button screeningBtnMenu;
        private System.Windows.Forms.Button uploadBtnMenu;
        private System.Windows.Forms.Button homeBtnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passCounter;
        private System.Windows.Forms.Label failCounter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Panel bar2;
        private System.Windows.Forms.Panel bar3;
        private System.Windows.Forms.Panel bar4;
        private System.Windows.Forms.Button blurFailBtn;
        private System.Windows.Forms.Button distortedFailBtn;
        private System.Windows.Forms.Button waterMarkBtn;
        private System.Windows.Forms.Button redEyeFailBtn;
        private System.Windows.Forms.Button missingItemFailBtn;
        private System.Windows.Forms.Button unableToLoadFaillBtn;
        private System.Windows.Forms.Button extensionFailBtn;
        private System.Windows.Forms.Label label4;
    }
}