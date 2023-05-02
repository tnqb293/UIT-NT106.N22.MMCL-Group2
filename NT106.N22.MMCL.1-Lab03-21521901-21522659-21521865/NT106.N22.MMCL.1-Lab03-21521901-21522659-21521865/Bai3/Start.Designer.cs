namespace Bai3
{
    partial class Start
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
            OpenServer = new Button();
            NewClient = new Button();
            SuspendLayout();
            // 
            // OpenServer
            // 
            OpenServer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            OpenServer.Location = new Point(129, 54);
            OpenServer.Name = "OpenServer";
            OpenServer.Size = new Size(248, 50);
            OpenServer.TabIndex = 0;
            OpenServer.Text = "Open TCP Server";
            OpenServer.UseVisualStyleBackColor = true;
            OpenServer.Click += OpenServer_Click;
            // 
            // NewClient
            // 
            NewClient.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewClient.Location = new Point(129, 125);
            NewClient.Name = "NewClient";
            NewClient.Size = new Size(248, 50);
            NewClient.TabIndex = 1;
            NewClient.Text = "Open new TCP Client";
            NewClient.UseVisualStyleBackColor = true;
            NewClient.Click += NewClient_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 232);
            Controls.Add(NewClient);
            Controls.Add(OpenServer);
            Name = "Start";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button OpenServer;
        private Button NewClient;
    }
}