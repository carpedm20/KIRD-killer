namespace KIRD_Killer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.loginBut = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.killingLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.waitingLabel = new System.Windows.Forms.Label();
            this.leftTimeLabel = new System.Windows.Forms.Label();
            this.finishingLabel = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginOkLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.killBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.trimesterLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(85, 18);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTxt.MaxLength = 100;
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(118, 21);
            this.idTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(85, 48);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTxt.MaxLength = 100;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(118, 21);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aTextbox_KeyDown);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(335, 11);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(58, 59);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // loginBut
            // 
            this.loginBut.Location = new System.Drawing.Point(209, 16);
            this.loginBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(63, 53);
            this.loginBut.TabIndex = 5;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = true;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(87, 82);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Maximum = 180;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(322, 22);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            // 
            // killingLabel
            // 
            this.killingLabel.AutoSize = true;
            this.killingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.killingLabel.Location = new System.Drawing.Point(10, 86);
            this.killingLabel.Name = "killingLabel";
            this.killingLabel.Size = new System.Drawing.Size(50, 15);
            this.killingLabel.TabIndex = 1;
            this.killingLabel.Text = "Killing : ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(87, 117);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar2.Maximum = 480;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(229, 22);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 8;
            // 
            // waitingLabel
            // 
            this.waitingLabel.AutoSize = true;
            this.waitingLabel.Location = new System.Drawing.Point(10, 120);
            this.waitingLabel.Name = "waitingLabel";
            this.waitingLabel.Size = new System.Drawing.Size(54, 15);
            this.waitingLabel.TabIndex = 1;
            this.waitingLabel.Text = "Waiting :";
            // 
            // leftTimeLabel
            // 
            this.leftTimeLabel.AutoSize = true;
            this.leftTimeLabel.Location = new System.Drawing.Point(362, 121);
            this.leftTimeLabel.Name = "leftTimeLabel";
            this.leftTimeLabel.Size = new System.Drawing.Size(41, 15);
            this.leftTimeLabel.TabIndex = 10;
            this.leftTimeLabel.Text = "8m 0s";
            // 
            // finishingLabel
            // 
            this.finishingLabel.AutoSize = true;
            this.finishingLabel.Location = new System.Drawing.Point(10, 156);
            this.finishingLabel.Name = "finishingLabel";
            this.finishingLabel.Size = new System.Drawing.Size(63, 15);
            this.finishingLabel.TabIndex = 1;
            this.finishingLabel.Text = "Finishing :";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(87, 153);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar3.Maximum = 180;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(322, 22);
            this.progressBar3.Step = 1;
            this.progressBar3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(301, -4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(10, 20);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(44, 15);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login :";
            // 
            // loginOkLabel
            // 
            this.loginOkLabel.AutoSize = true;
            this.loginOkLabel.Location = new System.Drawing.Point(87, 20);
            this.loginOkLabel.Name = "loginOkLabel";
            this.loginOkLabel.Size = new System.Drawing.Size(178, 15);
            this.loginOkLabel.TabIndex = 14;
            this.loginOkLabel.Text = "You have to click Login button :)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.killBtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Controls.Add(this.trimesterLabel);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.loginOkLabel);
            this.groupBox1.Controls.Add(this.killingLabel);
            this.groupBox1.Controls.Add(this.loginLabel);
            this.groupBox1.Controls.Add(this.waitingLabel);
            this.groupBox1.Controls.Add(this.progressBar3);
            this.groupBox1.Controls.Add(this.finishingLabel);
            this.groupBox1.Controls.Add(this.leftTimeLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(419, 187);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "학기";
            // 
            // killBtn
            // 
            this.killBtn.Enabled = false;
            this.killBtn.Location = new System.Drawing.Point(334, 48);
            this.killBtn.Name = "killBtn";
            this.killBtn.Size = new System.Drawing.Size(75, 23);
            this.killBtn.TabIndex = 18;
            this.killBtn.Text = "Kill";
            this.killBtn.UseVisualStyleBackColor = true;
            this.killBtn.Click += new System.EventHandler(this.killBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(155, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 23);
            this.comboBox1.TabIndex = 17;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(87, 52);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(34, 15);
            this.yearLabel.TabIndex = 16;
            this.yearLabel.Text = " 년도";
            // 
            // trimesterLabel
            // 
            this.trimesterLabel.AutoSize = true;
            this.trimesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.trimesterLabel.Location = new System.Drawing.Point(10, 52);
            this.trimesterLabel.Name = "trimesterLabel";
            this.trimesterLabel.Size = new System.Drawing.Size(68, 15);
            this.trimesterLabel.TabIndex = 15;
            this.trimesterLabel.Text = "Trimester : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.idTxt);
            this.groupBox2.Controls.Add(this.passwordTxt);
            this.groupBox2.Controls.Add(this.loginBut);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(283, 102);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(155, 76);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 19);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Save Password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Save ID";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Designed by \r\n           carpedm20";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mozo Killer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label killingLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label waitingLabel;
        private System.Windows.Forms.Label leftTimeLabel;
        private System.Windows.Forms.Label finishingLabel;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label loginOkLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label trimesterLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button killBtn;
    }
}

