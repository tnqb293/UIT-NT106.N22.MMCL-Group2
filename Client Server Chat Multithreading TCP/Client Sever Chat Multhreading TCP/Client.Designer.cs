namespace Client_Sever_Chat_Multhreading_TCP
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lbPortClient = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(383, 305);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 40);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbSend
            // 
            this.tbSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSend.Location = new System.Drawing.Point(7, 292);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(367, 61);
            this.tbSend.TabIndex = 15;
            // 
            // lbMessage
            // 
            this.lbMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.ItemHeight = 17;
            this.lbMessage.Location = new System.Drawing.Point(5, 112);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(453, 174);
            this.lbMessage.TabIndex = 14;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(287, 16);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 47);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPort.Location = new System.Drawing.Point(95, 39);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(169, 25);
            this.tbPort.TabIndex = 12;
            // 
            // lbPortClient
            // 
            this.lbPortClient.AutoSize = true;
            this.lbPortClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPortClient.Location = new System.Drawing.Point(14, 42);
            this.lbPortClient.Name = "lbPortClient";
            this.lbPortClient.Size = new System.Drawing.Size(35, 17);
            this.lbPortClient.TabIndex = 11;
            this.lbPortClient.Text = "Port:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(95, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 25);
            this.tbName.TabIndex = 18;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(14, 73);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(43, 17);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "Name";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(383, 16);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 47);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.Location = new System.Drawing.Point(95, 8);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(169, 25);
            this.tbIP.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "IPAddress";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 357);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lbPortClient);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbPortClient;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label1;
    }
}