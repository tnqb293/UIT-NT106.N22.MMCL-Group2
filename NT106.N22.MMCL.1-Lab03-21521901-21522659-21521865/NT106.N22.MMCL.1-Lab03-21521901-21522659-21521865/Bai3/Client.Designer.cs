namespace Bai3
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
            lbClient = new ListBox();
            txtSend = new TextBox();
            Connect = new Button();
            Disconnect = new Button();
            Send = new Button();
            SuspendLayout();
            // 
            // lbClient
            // 
            lbClient.FormattingEnabled = true;
            lbClient.ItemHeight = 20;
            lbClient.Location = new Point(23, 21);
            lbClient.Name = "lbClient";
            lbClient.Size = new Size(529, 344);
            lbClient.TabIndex = 0;
            // 
            // txtSend
            // 
            txtSend.Location = new Point(23, 387);
            txtSend.Multiline = true;
            txtSend.Name = "txtSend";
            txtSend.Size = new Size(529, 51);
            txtSend.TabIndex = 1;
            // 
            // Connect
            // 
            Connect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Connect.Location = new Point(603, 63);
            Connect.Name = "Connect";
            Connect.Size = new Size(152, 48);
            Connect.TabIndex = 2;
            Connect.Text = "CONNECT";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // Disconnect
            // 
            Disconnect.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Disconnect.Location = new Point(603, 131);
            Disconnect.Name = "Disconnect";
            Disconnect.Size = new Size(152, 48);
            Disconnect.TabIndex = 3;
            Disconnect.Text = "DISCONNECT";
            Disconnect.UseVisualStyleBackColor = true;
            Disconnect.Click += Disconnect_Click;
            // 
            // Send
            // 
            Send.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Send.Location = new Point(603, 387);
            Send.Name = "Send";
            Send.Size = new Size(152, 48);
            Send.TabIndex = 4;
            Send.Text = "SEND";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Send);
            Controls.Add(Disconnect);
            Controls.Add(Connect);
            Controls.Add(txtSend);
            Controls.Add(lbClient);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbClient;
        private TextBox txtSend;
        private Button Connect;
        private Button Disconnect;
        private Button Send;
    }
}