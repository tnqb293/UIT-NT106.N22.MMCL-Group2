namespace Bai1
{
    partial class Client
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
            StartClient = new Button();
            txtSendClient = new TextBox();
            Send = new Button();
            txtServerPort = new TextBox();
            txtServerIP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbMessClient = new ListBox();
            SuspendLayout();
            // 
            // StartClient
            // 
            StartClient.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            StartClient.Location = new Point(718, 197);
            StartClient.Name = "StartClient";
            StartClient.Size = new Size(168, 54);
            StartClient.TabIndex = 1;
            StartClient.Text = "Start Client";
            StartClient.UseVisualStyleBackColor = true;
            StartClient.Click += StartClient_Click;
            // 
            // txtSendClient
            // 
            txtSendClient.Location = new Point(25, 363);
            txtSendClient.Multiline = true;
            txtSendClient.Name = "txtSendClient";
            txtSendClient.Size = new Size(317, 48);
            txtSendClient.TabIndex = 2;
            // 
            // Send
            // 
            Send.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Send.Location = new Point(369, 363);
            Send.Name = "Send";
            Send.Size = new Size(168, 48);
            Send.TabIndex = 3;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // txtServerPort
            // 
            txtServerPort.Location = new Point(690, 151);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(214, 27);
            txtServerPort.TabIndex = 4;
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(690, 94);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(214, 27);
            txtServerIP.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(553, 97);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 6;
            label1.Text = "Nhập IP(127.0.0.1):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 154);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 7;
            label2.Text = "Nhập Port(16211):";
            // 
            // lbMessClient
            // 
            lbMessClient.FormattingEnabled = true;
            lbMessClient.ItemHeight = 20;
            lbMessClient.Location = new Point(12, 17);
            lbMessClient.Name = "lbMessClient";
            lbMessClient.Size = new Size(525, 324);
            lbMessClient.TabIndex = 8;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 437);
            Controls.Add(lbMessClient);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtServerIP);
            Controls.Add(txtServerPort);
            Controls.Add(Send);
            Controls.Add(txtSendClient);
            Controls.Add(StartClient);
            Name = "Client";
            Text = "Client";
            FormClosing += Client_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button StartClient;
        private TextBox txtSendClient;
        private Button Send;
        private TextBox txtServerPort;
        private TextBox txtServerIP;
        private Label label1;
        private Label label2;
        private ListBox lbMessClient;
    }
}