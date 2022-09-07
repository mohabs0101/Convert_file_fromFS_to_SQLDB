namespace convert_FS_to_DB
{
    partial class Form1
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
            this.BTN_OFD = new System.Windows.Forms.Button();
            this.BTN_upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_OFD
            // 
            this.BTN_OFD.Location = new System.Drawing.Point(364, 47);
            this.BTN_OFD.Name = "BTN_OFD";
            this.BTN_OFD.Size = new System.Drawing.Size(145, 38);
            this.BTN_OFD.TabIndex = 0;
            this.BTN_OFD.Text = "choos folder";
            this.BTN_OFD.UseVisualStyleBackColor = true;
            this.BTN_OFD.Click += new System.EventHandler(this.BTN_OFD_Click);
            // 
            // BTN_upload
            // 
            this.BTN_upload.Location = new System.Drawing.Point(364, 131);
            this.BTN_upload.Name = "BTN_upload";
            this.BTN_upload.Size = new System.Drawing.Size(145, 23);
            this.BTN_upload.TabIndex = 1;
            this.BTN_upload.Text = "upload";
            this.BTN_upload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_upload.UseVisualStyleBackColor = true;
            this.BTN_upload.Click += new System.EventHandler(this.BTN_upload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.BTN_upload);
            this.Controls.Add(this.BTN_OFD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_OFD;
        private System.Windows.Forms.Button BTN_upload;
    }
}

