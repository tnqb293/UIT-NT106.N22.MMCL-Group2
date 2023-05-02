namespace Lab03
{
    partial class fUDPServer
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
            this.lbPort = new System.Windows.Forms.Label();
            this.lbRecMessage = new System.Windows.Forms.Label();
            this.txtbPort = new System.Windows.Forms.TextBox();
            this.rtbRecMessage = new System.Windows.Forms.RichTextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(142, 92);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(38, 20);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "Port";
            // 
            // lbRecMessage
            // 
            this.lbRecMessage.AutoSize = true;
            this.lbRecMessage.Location = new System.Drawing.Point(142, 141);
            this.lbRecMessage.Name = "lbRecMessage";
            this.lbRecMessage.Size = new System.Drawing.Size(144, 20);
            this.lbRecMessage.TabIndex = 0;
            this.lbRecMessage.Text = "Received Message";
            // 
            // txtbPort
            // 
            this.txtbPort.Location = new System.Drawing.Point(243, 89);
            this.txtbPort.Name = "txtbPort";
            this.txtbPort.Size = new System.Drawing.Size(100, 26);
            this.txtbPort.TabIndex = 1;
            // 
            // rtbRecMessage
            // 
            this.rtbRecMessage.Location = new System.Drawing.Point(146, 196);
            this.rtbRecMessage.Name = "rtbRecMessage";
            this.rtbRecMessage.Size = new System.Drawing.Size(498, 156);
            this.rtbRecMessage.TabIndex = 2;
            this.rtbRecMessage.Text = "";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(502, 92);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(142, 45);
            this.btnListen.TabIndex = 3;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // fUDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.rtbRecMessage);
            this.Controls.Add(this.txtbPort);
            this.Controls.Add(this.lbRecMessage);
            this.Controls.Add(this.lbPort);
            this.Name = "fUDPServer";
            this.Text = "udpServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbRecMessage;
        private System.Windows.Forms.TextBox txtbPort;
        private System.Windows.Forms.RichTextBox rtbRecMessage;
        private System.Windows.Forms.Button btnListen;
    }
}