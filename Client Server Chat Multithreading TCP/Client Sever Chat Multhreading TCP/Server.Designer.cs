namespace Client_Sever_Chat_Multhreading_TCP
{
    partial class Server
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
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(57, 27);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(148, 25);
            this.tbPort.TabIndex = 3;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(16, 30);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(35, 17);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(211, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(66, 33);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.ItemHeight = 17;
            this.lbMessage.Location = new System.Drawing.Point(10, 88);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(466, 191);
            this.lbMessage.TabIndex = 5;
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(355, 22);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(96, 33);
            this.btnCreateClient.TabIndex = 8;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(283, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(66, 33);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 287);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lbPort);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Button btnStop;
    }
}

