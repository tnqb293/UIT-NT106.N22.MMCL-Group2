namespace ApplicationCallAPI
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
            CallAPI = new Button();
            DeleteAPI = new Button();
            rtbAPI = new RichTextBox();
            SuspendLayout();
            // 
            // CallAPI
            // 
            CallAPI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CallAPI.Location = new Point(25, 38);
            CallAPI.Name = "CallAPI";
            CallAPI.Size = new Size(134, 40);
            CallAPI.TabIndex = 0;
            CallAPI.Text = "CALL";
            CallAPI.UseVisualStyleBackColor = true;
            CallAPI.Click += CallAPI_Click;
            // 
            // DeleteAPI
            // 
            DeleteAPI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteAPI.Location = new Point(25, 119);
            DeleteAPI.Name = "DeleteAPI";
            DeleteAPI.Size = new Size(134, 40);
            DeleteAPI.TabIndex = 1;
            DeleteAPI.Text = "DELETE";
            DeleteAPI.UseVisualStyleBackColor = true;
            DeleteAPI.Click += DeleteAPI_Click;
            // 
            // rtbAPI
            // 
            rtbAPI.Location = new Point(172, 12);
            rtbAPI.Name = "rtbAPI";
            rtbAPI.Size = new Size(341, 482);
            rtbAPI.TabIndex = 2;
            rtbAPI.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 506);
            Controls.Add(rtbAPI);
            Controls.Add(DeleteAPI);
            Controls.Add(CallAPI);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CallAPI;
        private Button DeleteAPI;
        private RichTextBox rtbAPI;
    }
}