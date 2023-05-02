namespace Lab03
{
    partial class fUDPClient
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
            this.lbIPRemoteHost = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.txtbIPRemoteHost = new System.Windows.Forms.TextBox();
            this.txtbPort = new System.Windows.Forms.TextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIPRemoteHost
            // 
            this.lbIPRemoteHost.AutoSize = true;
            this.lbIPRemoteHost.Location = new System.Drawing.Point(92, 57);
            this.lbIPRemoteHost.Name = "lbIPRemoteHost";
            this.lbIPRemoteHost.Size = new System.Drawing.Size(123, 20);
            this.lbIPRemoteHost.TabIndex = 0;
            this.lbIPRemoteHost.Text = "IP Remote Host";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(483, 57);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(38, 20);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "Port";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(92, 164);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(74, 20);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Message";
            // 
            // txtbIPRemoteHost
            // 
            this.txtbIPRemoteHost.Location = new System.Drawing.Point(96, 97);
            this.txtbIPRemoteHost.Name = "txtbIPRemoteHost";
            this.txtbIPRemoteHost.Size = new System.Drawing.Size(139, 26);
            this.txtbIPRemoteHost.TabIndex = 1;
            // 
            // txtbPort
            // 
            this.txtbPort.Location = new System.Drawing.Point(487, 97);
            this.txtbPort.Name = "txtbPort";
            this.txtbPort.Size = new System.Drawing.Size(139, 26);
            this.txtbPort.TabIndex = 1;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(96, 205);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(530, 114);
            this.rtbMessage.TabIndex = 2;
            this.rtbMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(96, 351);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(119, 47);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // fUDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.txtbPort);
            this.Controls.Add(this.txtbIPRemoteHost);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIPRemoteHost);
            this.Name = "fUDPClient";
            this.Text = "udpClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIPRemoteHost;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox txtbIPRemoteHost;
        private System.Windows.Forms.TextBox txtbPort;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnSend;
    }
}