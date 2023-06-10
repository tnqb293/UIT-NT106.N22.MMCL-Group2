namespace Bai4_1
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddressImap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPortImap = new System.Windows.Forms.NumericUpDown();
            this.tbPortSmtp = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddressSmtp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sequenceNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datetime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.gbSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPortImap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPortSmtp)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogOff);
            this.gbLogin.Controls.Add(this.btnRefresh);
            this.gbLogin.Controls.Add(this.btnSendMail);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.tbUsername);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Location = new System.Drawing.Point(13, 13);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(277, 104);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(84, 17);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(187, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(83, 42);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(187, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(157, 68);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.tbPortSmtp);
            this.gbSetting.Controls.Add(this.label5);
            this.gbSetting.Controls.Add(this.tbAddressSmtp);
            this.gbSetting.Controls.Add(this.label6);
            this.gbSetting.Controls.Add(this.tbPortImap);
            this.gbSetting.Controls.Add(this.label3);
            this.gbSetting.Controls.Add(this.tbAddressImap);
            this.gbSetting.Controls.Add(this.label4);
            this.gbSetting.Location = new System.Drawing.Point(307, 13);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(390, 104);
            this.gbSetting.TabIndex = 1;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "Cài đặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // tbAddressImap
            // 
            this.tbAddressImap.Location = new System.Drawing.Point(46, 16);
            this.tbAddressImap.Name = "tbAddressImap";
            this.tbAddressImap.Size = new System.Drawing.Size(129, 20);
            this.tbAddressImap.TabIndex = 1;
            this.tbAddressImap.Text = "imap.gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IMAP";
            // 
            // tbPortImap
            // 
            this.tbPortImap.Location = new System.Drawing.Point(46, 42);
            this.tbPortImap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbPortImap.Name = "tbPortImap";
            this.tbPortImap.Size = new System.Drawing.Size(129, 20);
            this.tbPortImap.TabIndex = 4;
            this.tbPortImap.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
            // 
            // tbPortSmtp
            // 
            this.tbPortSmtp.Location = new System.Drawing.Point(242, 42);
            this.tbPortSmtp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbPortSmtp.Name = "tbPortSmtp";
            this.tbPortSmtp.Size = new System.Drawing.Size(129, 20);
            this.tbPortSmtp.TabIndex = 8;
            this.tbPortSmtp.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // tbAddressSmtp
            // 
            this.tbAddressSmtp.Location = new System.Drawing.Point(242, 17);
            this.tbAddressSmtp.Name = "tbAddressSmtp";
            this.tbAddressSmtp.Size = new System.Drawing.Size(129, 20);
            this.tbAddressSmtp.TabIndex = 6;
            this.tbAddressSmtp.Text = "smtp.gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SMTP";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sequenceNumber,
            this.From,
            this.subject,
            this.Datetime});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(684, 353);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // sequenceNumber
            // 
            this.sequenceNumber.Text = "#";
            this.sequenceNumber.Width = 50;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 210;
            // 
            // subject
            // 
            this.subject.Text = "Subject";
            this.subject.Width = 210;
            // 
            // Datetime
            // 
            this.Datetime.Text = "Datetime";
            this.Datetime.Width = 200;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(6, 68);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(76, 23);
            this.btnSendMail.TabIndex = 5;
            this.btnSendMail.Text = "Gửi mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Visible = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(102, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(194, 68);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(76, 23);
            this.btnLogOff.TabIndex = 7;
            this.btnLogOff.Text = "Đăng xuất";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Visible = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 489);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.gbLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPortImap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPortSmtp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.NumericUpDown tbPortImap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddressImap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader sequenceNumber;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader Datetime;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSendMail;
        public System.Windows.Forms.NumericUpDown tbPortSmtp;
        public System.Windows.Forms.TextBox tbAddressSmtp;
        public System.Windows.Forms.TextBox tbUsername;
        public System.Windows.Forms.TextBox tbPassword;
    }
}

