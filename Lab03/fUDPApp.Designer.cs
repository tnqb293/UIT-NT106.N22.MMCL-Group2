namespace Lab03
{
    partial class fUDPApp
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
            this.btnUDPServer = new System.Windows.Forms.Button();
            this.btnUDPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUDPServer
            // 
            this.btnUDPServer.Location = new System.Drawing.Point(108, 172);
            this.btnUDPServer.Name = "btnUDPServer";
            this.btnUDPServer.Size = new System.Drawing.Size(232, 60);
            this.btnUDPServer.TabIndex = 0;
            this.btnUDPServer.Text = "UDP Server";
            this.btnUDPServer.UseVisualStyleBackColor = true;
            this.btnUDPServer.Click += new System.EventHandler(this.btnUDPServer_Click);
            // 
            // btnUDPClient
            // 
            this.btnUDPClient.Location = new System.Drawing.Point(470, 172);
            this.btnUDPClient.Name = "btnUDPClient";
            this.btnUDPClient.Size = new System.Drawing.Size(232, 60);
            this.btnUDPClient.TabIndex = 0;
            this.btnUDPClient.Text = "UDP Client";
            this.btnUDPClient.UseVisualStyleBackColor = true;
            this.btnUDPClient.Click += new System.EventHandler(this.btnUDPClient_Click);
            // 
            // fUDPApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUDPClient);
            this.Controls.Add(this.btnUDPServer);
            this.Name = "fUDPApp";
            this.Text = "udpApp";
            this.Load += new System.EventHandler(this.fUDPApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUDPServer;
        private System.Windows.Forms.Button btnUDPClient;
    }
}