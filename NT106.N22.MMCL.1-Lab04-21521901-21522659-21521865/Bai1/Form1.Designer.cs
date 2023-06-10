namespace Bai1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtsenderEmail = new TextBox();
            txtRecipientEmail = new TextBox();
            txtSubject = new TextBox();
            txtBody = new TextBox();
            SEND = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtsenderPassword = new TextBox();
            label5 = new Label();
            txtPort = new TextBox();
            txtSmtpServer = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtsenderEmail
            // 
            txtsenderEmail.Location = new Point(98, 80);
            txtsenderEmail.Name = "txtsenderEmail";
            txtsenderEmail.Size = new Size(290, 27);
            txtsenderEmail.TabIndex = 0;
            // 
            // txtRecipientEmail
            // 
            txtRecipientEmail.Location = new Point(98, 113);
            txtRecipientEmail.Name = "txtRecipientEmail";
            txtRecipientEmail.Size = new Size(290, 27);
            txtRecipientEmail.TabIndex = 1;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(98, 153);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(618, 27);
            txtSubject.TabIndex = 2;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(99, 200);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(617, 253);
            txtBody.TabIndex = 3;
            // 
            // SEND
            // 
            SEND.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SEND.Location = new Point(722, 153);
            SEND.Name = "SEND";
            SEND.Size = new Size(83, 55);
            SEND.TabIndex = 4;
            SEND.Text = "SEND";
            SEND.UseVisualStyleBackColor = true;
            SEND.Click += SEND_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 85);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 5;
            label1.Text = "FROM:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 6;
            label2.Text = "TO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 156);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "SUBJECT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 200);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 8;
            label4.Text = "BODY:";
            // 
            // txtsenderPassword
            // 
            txtsenderPassword.Location = new Point(495, 80);
            txtsenderPassword.Name = "txtsenderPassword";
            txtsenderPassword.Size = new Size(152, 27);
            txtsenderPassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(394, 84);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 10;
            label5.Text = "PASSWORD:";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(98, 47);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 27);
            txtPort.TabIndex = 11;
            // 
            // txtSmtpServer
            // 
            txtSmtpServer.Location = new Point(98, 12);
            txtSmtpServer.Name = "txtSmtpServer";
            txtSmtpServer.Size = new Size(290, 27);
            txtSmtpServer.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 15);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 13;
            label6.Text = "SMTP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 50);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 14;
            label7.Text = "PORT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 476);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtSmtpServer);
            Controls.Add(txtPort);
            Controls.Add(label5);
            Controls.Add(txtsenderPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SEND);
            Controls.Add(txtBody);
            Controls.Add(txtSubject);
            Controls.Add(txtRecipientEmail);
            Controls.Add(txtsenderEmail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsenderEmail;
        private TextBox txtRecipientEmail;
        private TextBox txtSubject;
        private TextBox txtBody;
        private Button SEND;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtsenderPassword;
        private Label label5;
        private TextBox txtPort;
        private TextBox txtSmtpServer;
        private Label label6;
        private Label label7;
    }
}