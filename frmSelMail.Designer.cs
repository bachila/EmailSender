namespace SendSpan
{
    partial class frmSelMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelMail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butUnCheckAll = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.butCheckAll = new System.Windows.Forms.Button();
            this.butSendMail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvMail = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butUnCheckAll);
            this.panel1.Controls.Add(this.butCheckAll);
            this.panel1.Controls.Add(this.butSendMail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 39);
            this.panel1.TabIndex = 0;
            // 
            // butUnCheckAll
            // 
            this.butUnCheckAll.ImageIndex = 2;
            this.butUnCheckAll.ImageList = this.imageList;
            this.butUnCheckAll.Location = new System.Drawing.Point(36, 6);
            this.butUnCheckAll.Name = "butUnCheckAll";
            this.butUnCheckAll.Size = new System.Drawing.Size(27, 23);
            this.butUnCheckAll.TabIndex = 2;
            this.toolTip1.SetToolTip(this.butUnCheckAll, "Убрать выбор со всех адресов");
            this.butUnCheckAll.UseVisualStyleBackColor = true;
            this.butUnCheckAll.Click += new System.EventHandler(this.butUnCheckAll_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "email_go.png");
            this.imageList.Images.SetKeyName(1, "check_box.png");
            this.imageList.Images.SetKeyName(2, "email_delete.png");
            // 
            // butCheckAll
            // 
            this.butCheckAll.ImageIndex = 1;
            this.butCheckAll.ImageList = this.imageList;
            this.butCheckAll.Location = new System.Drawing.Point(3, 6);
            this.butCheckAll.Name = "butCheckAll";
            this.butCheckAll.Size = new System.Drawing.Size(27, 23);
            this.butCheckAll.TabIndex = 1;
            this.toolTip1.SetToolTip(this.butCheckAll, "Выбрать все адреса");
            this.butCheckAll.UseVisualStyleBackColor = true;
            this.butCheckAll.Click += new System.EventHandler(this.butCheckAll_Click);
            // 
            // butSendMail
            // 
            this.butSendMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSendMail.ImageIndex = 0;
            this.butSendMail.ImageList = this.imageList;
            this.butSendMail.Location = new System.Drawing.Point(187, 6);
            this.butSendMail.Name = "butSendMail";
            this.butSendMail.Size = new System.Drawing.Size(88, 23);
            this.butSendMail.TabIndex = 0;
            this.butSendMail.Text = "Отправить";
            this.butSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSendMail.UseVisualStyleBackColor = true;
            this.butSendMail.Click += new System.EventHandler(this.butSendMail_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvMail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 245);
            this.panel2.TabIndex = 1;
            // 
            // lvMail
            // 
            this.lvMail.CheckBoxes = true;
            this.lvMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMail.FullRowSelect = true;
            this.lvMail.HideSelection = false;
            this.lvMail.Location = new System.Drawing.Point(0, 0);
            this.lvMail.MultiSelect = false;
            this.lvMail.Name = "lvMail";
            this.lvMail.Size = new System.Drawing.Size(278, 245);
            this.lvMail.TabIndex = 0;
            this.lvMail.UseCompatibleStateImageBehavior = false;
            this.lvMail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Информация";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Почта";
            this.columnHeader2.Width = 116;
            // 
            // frmSelMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 284);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelMail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите получателя";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butSendMail;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ListView lvMail;
        private System.Windows.Forms.Button butCheckAll;
        private System.Windows.Forms.Button butUnCheckAll;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}