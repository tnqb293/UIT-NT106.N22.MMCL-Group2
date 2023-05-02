namespace Bai3
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
            lbServer = new ListBox();
            Listen = new Button();
            SuspendLayout();
            // 
            // lbServer
            // 
            lbServer.FormattingEnabled = true;
            lbServer.ItemHeight = 20;
            lbServer.Location = new Point(21, 23);
            lbServer.Name = "lbServer";
            lbServer.Size = new Size(529, 404);
            lbServer.TabIndex = 0;
            // 
            // Listen
            // 
            Listen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Listen.Location = new Point(607, 47);
            Listen.Name = "Listen";
            Listen.Size = new Size(152, 48);
            Listen.TabIndex = 3;
            Listen.Text = "LISTEN";
            Listen.UseVisualStyleBackColor = true;
            Listen.Click += Listen_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Listen);
            Controls.Add(lbServer);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbServer;
        private Button Listen;
    }
}