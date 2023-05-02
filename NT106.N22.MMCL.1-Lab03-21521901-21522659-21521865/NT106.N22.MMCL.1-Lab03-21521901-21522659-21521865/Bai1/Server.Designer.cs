namespace Bai1
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
            lbMessServer = new ListBox();
            StartServer = new Button();
            SuspendLayout();
            // 
            // lbMessServer
            // 
            lbMessServer.FormattingEnabled = true;
            lbMessServer.ItemHeight = 20;
            lbMessServer.Location = new Point(12, 12);
            lbMessServer.Name = "lbMessServer";
            lbMessServer.Size = new Size(525, 324);
            lbMessServer.TabIndex = 0;
            // 
            // StartServer
            // 
            StartServer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            StartServer.Location = new Point(649, 74);
            StartServer.Name = "StartServer";
            StartServer.Size = new Size(168, 54);
            StartServer.TabIndex = 2;
            StartServer.Text = "Start Server";
            StartServer.UseVisualStyleBackColor = true;
            StartServer.Click += StartServer_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 437);
            Controls.Add(StartServer);
            Controls.Add(lbMessServer);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbMessServer;
        private Button StartServer;
    }
}