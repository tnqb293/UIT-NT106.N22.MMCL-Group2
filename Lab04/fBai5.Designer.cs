namespace Lab04
{
    partial class fBai5
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
            this.lbURL = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(61, 44);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(42, 20);
            this.lbURL.TabIndex = 0;
            this.lbURL.Text = "URL";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(61, 107);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(83, 20);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(61, 179);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(78, 20);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(162, 37);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(591, 26);
            this.tbURL.TabIndex = 3;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(162, 107);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(427, 26);
            this.tbUsername.TabIndex = 4;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(162, 179);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(427, 26);
            this.tbPass.TabIndex = 5;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(624, 107);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(129, 98);
            this.btnPost.TabIndex = 7;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(65, 242);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(688, 196);
            this.rtbDisplay.TabIndex = 8;
            this.rtbDisplay.Text = "";
            // 
            // fBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbURL);
            this.Name = "fBai5";
            this.Text = "fBai5";
            this.Load += new System.EventHandler(this.fBai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}