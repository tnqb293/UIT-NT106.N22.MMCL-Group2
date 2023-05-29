namespace Lab04
{
    partial class fBai3
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
            this.btnGet = new System.Windows.Forms.Button();
            this.btnHtmlDown = new System.Windows.Forms.Button();
            this.btnSourceDown = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(53, 39);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(242, 36);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnHtmlDown
            // 
            this.btnHtmlDown.Location = new System.Drawing.Point(53, 95);
            this.btnHtmlDown.Name = "btnHtmlDown";
            this.btnHtmlDown.Size = new System.Drawing.Size(242, 36);
            this.btnHtmlDown.TabIndex = 1;
            this.btnHtmlDown.Text = "HTML DOWNLOAD";
            this.btnHtmlDown.UseVisualStyleBackColor = true;
            this.btnHtmlDown.Click += new System.EventHandler(this.btnHtmlDown_Click);
            // 
            // btnSourceDown
            // 
            this.btnSourceDown.Location = new System.Drawing.Point(53, 152);
            this.btnSourceDown.Name = "btnSourceDown";
            this.btnSourceDown.Size = new System.Drawing.Size(242, 36);
            this.btnSourceDown.TabIndex = 2;
            this.btnSourceDown.Text = "SOURCE DOWNLOAD";
            this.btnSourceDown.UseVisualStyleBackColor = true;
            this.btnSourceDown.Click += new System.EventHandler(this.btnSourceDown_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(329, 39);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(1034, 26);
            this.txtURL.TabIndex = 3;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(53, 219);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1320, 402);
            this.webView.TabIndex = 4;
            this.webView.ZoomFactor = 1D;
            // 
            // fBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 655);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnSourceDown);
            this.Controls.Add(this.btnHtmlDown);
            this.Controls.Add(this.btnGet);
            this.Name = "fBai3";
            this.Text = "fBai3";
            this.Load += new System.EventHandler(this.fBai3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnHtmlDown;
        private System.Windows.Forms.Button btnSourceDown;
        private System.Windows.Forms.TextBox txtURL;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}