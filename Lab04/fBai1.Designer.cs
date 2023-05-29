namespace Lab04
{
    partial class fBai1
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(56, 39);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(821, 26);
            this.tbURL.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(912, 39);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(220, 38);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(56, 105);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(1076, 503);
            this.rtbResult.TabIndex = 2;
            this.rtbResult.Text = "";
            // 
            // fBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 651);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.tbURL);
            this.Name = "fBai1";
            this.Text = "fBai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox rtbResult;
    }
}