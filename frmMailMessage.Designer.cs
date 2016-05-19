namespace SendSpan
{
    partial class frmMailMessage
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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.rbInfo = new System.Windows.Forms.RichTextBox();
            this.butClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(12, 12);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(479, 23);
            this.progress.TabIndex = 0;
            // 
            // rbInfo
            // 
            this.rbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rbInfo.AutoWordSelection = true;
            this.rbInfo.Location = new System.Drawing.Point(12, 41);
            this.rbInfo.Name = "rbInfo";
            this.rbInfo.ReadOnly = true;
            this.rbInfo.Size = new System.Drawing.Size(479, 123);
            this.rbInfo.TabIndex = 1;
            this.rbInfo.Text = "";
            this.rbInfo.WordWrap = false;
            // 
            // butClose
            // 
            this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butClose.Enabled = false;
            this.butClose.Location = new System.Drawing.Point(416, 170);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // frmMailMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 205);
            this.ControlBox = false;
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.rbInfo);
            this.Controls.Add(this.progress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMailMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отправка писем...";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar progress;
        public System.Windows.Forms.RichTextBox rbInfo;
        public System.Windows.Forms.Button butClose;

    }
}