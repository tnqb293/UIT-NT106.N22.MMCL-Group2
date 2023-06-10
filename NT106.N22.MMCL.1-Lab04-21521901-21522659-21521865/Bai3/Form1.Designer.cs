namespace Bai3
{
    partial class Form1
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
            messageListBox = new ListBox();
            serverTextBox = new TextBox();
            PortTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            connectionButton = new Button();
            disconnectionButton = new Button();
            messageTextBox = new TextBox();
            statusTextBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // messageListBox
            // 
            messageListBox.FormattingEnabled = true;
            messageListBox.ItemHeight = 20;
            messageListBox.Location = new Point(12, 148);
            messageListBox.Name = "messageListBox";
            messageListBox.Size = new Size(938, 264);
            messageListBox.TabIndex = 0;
            messageListBox.SelectedIndexChanged += messageListBox_SelectedIndexChanged;
            // 
            // serverTextBox
            // 
            serverTextBox.Location = new Point(95, 25);
            serverTextBox.Name = "serverTextBox";
            serverTextBox.Size = new Size(256, 27);
            serverTextBox.TabIndex = 1;
            // 
            // PortTextBox
            // 
            PortTextBox.Location = new Point(95, 71);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(256, 27);
            PortTextBox.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(496, 25);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(256, 27);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(496, 71);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(256, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 32);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "HOST:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 78);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "PORT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(401, 31);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 7;
            label3.Text = "USERNAME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(400, 78);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 8;
            label4.Text = "PASSWORD:";
            // 
            // connectionButton
            // 
            connectionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            connectionButton.Location = new Point(807, 24);
            connectionButton.Name = "connectionButton";
            connectionButton.Size = new Size(128, 29);
            connectionButton.TabIndex = 9;
            connectionButton.Text = "CONNECT";
            connectionButton.UseVisualStyleBackColor = true;
            connectionButton.Click += connectionButton_Click;
            // 
            // disconnectionButton
            // 
            disconnectionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            disconnectionButton.Location = new Point(807, 71);
            disconnectionButton.Name = "disconnectionButton";
            disconnectionButton.Size = new Size(128, 29);
            disconnectionButton.TabIndex = 10;
            disconnectionButton.Text = "DISCONNECT";
            disconnectionButton.UseVisualStyleBackColor = true;
            disconnectionButton.Click += disconnectionButton_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 418);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(938, 227);
            messageTextBox.TabIndex = 11;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(95, 108);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(256, 27);
            statusTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 113);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 13;
            label5.Text = "STATUS:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 657);
            Controls.Add(label5);
            Controls.Add(statusTextBox);
            Controls.Add(messageTextBox);
            Controls.Add(disconnectionButton);
            Controls.Add(connectionButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(PortTextBox);
            Controls.Add(serverTextBox);
            Controls.Add(messageListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox messageListBox;
        private TextBox serverTextBox;
        private TextBox PortTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button connectionButton;
        private Button disconnectionButton;
        private TextBox messageTextBox;
        private TextBox statusTextBox;
        private Label label5;
    }
}