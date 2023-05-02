namespace Bai1
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
            Server = new Button();
            Client = new Button();
            SuspendLayout();
            // 
            // Server
            // 
            Server.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Server.Location = new Point(89, 128);
            Server.Name = "Server";
            Server.Size = new Size(158, 54);
            Server.TabIndex = 0;
            Server.Text = "UDP Server";
            Server.UseVisualStyleBackColor = true;
            Server.Click += Server_Click;
            // 
            // Client
            // 
            Client.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Client.Location = new Point(338, 128);
            Client.Name = "Client";
            Client.Size = new Size(158, 54);
            Client.TabIndex = 1;
            Client.Text = "UDP Client";
            Client.UseVisualStyleBackColor = true;
            Client.Click += Client_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 315);
            Controls.Add(Client);
            Controls.Add(Server);
            Name = "Start";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Server;
        private Button Client;
    }
}