namespace Bai2
{
    partial class Telnet
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
            lbTelnet = new ListBox();
            LISTEN = new Button();
            SuspendLayout();
            // 
            // lbTelnet
            // 
            lbTelnet.FormattingEnabled = true;
            lbTelnet.ItemHeight = 20;
            lbTelnet.Location = new Point(31, 103);
            lbTelnet.Name = "lbTelnet";
            lbTelnet.Size = new Size(514, 364);
            lbTelnet.TabIndex = 0;
            // 
            // LISTEN
            // 
            LISTEN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LISTEN.Location = new Point(205, 33);
            LISTEN.Name = "LISTEN";
            LISTEN.Size = new Size(180, 41);
            LISTEN.TabIndex = 1;
            LISTEN.Text = "LISTEN";
            LISTEN.UseVisualStyleBackColor = true;
            
            // 
            // Telnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 497);
            Controls.Add(LISTEN);
            Controls.Add(lbTelnet);
            Name = "Telnet";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbTelnet;
        private Button LISTEN;
    }
}