namespace SendSpan
{
    partial class frmAttach
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
            this.components = new System.ComponentModel.Container();
            this.butClose = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lvFile = new System.Windows.Forms.ListView();
            this.colFile = new System.Windows.Forms.ColumnHeader();
            this.colSize = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.butAddFile = new System.Windows.Forms.ToolStripButton();
            this.butReplaceFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.butDelFile = new System.Windows.Forms.ToolStripButton();
            this.butDelAllFile = new System.Windows.Forms.ToolStripButton();
            this.dlgSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.lbAllSize = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butClose
            // 
            this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butClose.Location = new System.Drawing.Point(446, 222);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 1;
            this.butClose.Text = "Отмена";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butOK
            // 
            this.butOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butOK.Location = new System.Drawing.Point(365, 222);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 3;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // lvFile
            // 
            this.lvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colSize});
            this.lvFile.FullRowSelect = true;
            this.lvFile.HideSelection = false;
            this.lvFile.HoverSelection = true;
            this.lvFile.Location = new System.Drawing.Point(0, 28);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(533, 188);
            this.lvFile.TabIndex = 4;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // colFile
            // 
            this.colFile.Text = "Файл";
            this.colFile.Width = 429;
            // 
            // colSize
            // 
            this.colSize.Text = "Размер";
            this.colSize.Width = 97;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butAddFile,
            this.butReplaceFile,
            this.toolStripSeparator1,
            this.butDelFile,
            this.butDelAllFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // butAddFile
            // 
            this.butAddFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butAddFile.Image = global::SendSpan.Properties.Resources.email_attach;
            this.butAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butAddFile.Name = "butAddFile";
            this.butAddFile.Size = new System.Drawing.Size(23, 22);
            this.butAddFile.Text = "Добавить файл";
            this.butAddFile.Click += new System.EventHandler(this.butAddFile_Click);
            // 
            // butReplaceFile
            // 
            this.butReplaceFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butReplaceFile.Image = global::SendSpan.Properties.Resources.page_edit;
            this.butReplaceFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butReplaceFile.Name = "butReplaceFile";
            this.butReplaceFile.Size = new System.Drawing.Size(23, 22);
            this.butReplaceFile.Text = "Заменить файл другим";
            this.butReplaceFile.Click += new System.EventHandler(this.butReplaceFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // butDelFile
            // 
            this.butDelFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butDelFile.Image = global::SendSpan.Properties.Resources.package_delete;
            this.butDelFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butDelFile.Name = "butDelFile";
            this.butDelFile.Size = new System.Drawing.Size(23, 22);
            this.butDelFile.Text = "Удалить выбранный файл";
            this.butDelFile.Click += new System.EventHandler(this.butDelFile_Click);
            // 
            // butDelAllFile
            // 
            this.butDelAllFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butDelAllFile.Image = global::SendSpan.Properties.Resources.delete;
            this.butDelAllFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butDelAllFile.Name = "butDelAllFile";
            this.butDelAllFile.Size = new System.Drawing.Size(23, 22);
            this.butDelAllFile.Text = "Удалить все файлы";
            this.butDelAllFile.Click += new System.EventHandler(this.butDelAllFile_Click);
            // 
            // dlgSelectFile
            // 
            this.dlgSelectFile.FileName = "openFileDialog1";
            // 
            // lbAllSize
            // 
            this.lbAllSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAllSize.AutoSize = true;
            this.lbAllSize.Location = new System.Drawing.Point(12, 227);
            this.lbAllSize.Name = "lbAllSize";
            this.lbAllSize.Size = new System.Drawing.Size(159, 13);
            this.lbAllSize.TabIndex = 8;
            this.lbAllSize.Text = "Общий размер файлов 0 байт";
            // 
            // frmAttach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 257);
            this.Controls.Add(this.lbAllSize);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.butClose);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAttach";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Прикрепляемые файлы...";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmAttach_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton butAddFile;
        private System.Windows.Forms.ToolStripButton butReplaceFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton butDelFile;
        private System.Windows.Forms.ToolStripButton butDelAllFile;
        private System.Windows.Forms.OpenFileDialog dlgSelectFile;
        private System.Windows.Forms.Label lbAllSize;
    }
}