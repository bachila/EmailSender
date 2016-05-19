namespace SendSpan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.butLoadExcel = new System.Windows.Forms.Button();
            this.edExcel = new System.Windows.Forms.TextBox();
            this.butExcelSel = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numColumInfo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numColumEmail = new System.Windows.Forms.NumericUpDown();
            this.edMail_attach = new System.Windows.Forms.TextBox();
            this.butSendMail = new System.Windows.Forms.Button();
            this.chWordBodyMail = new System.Windows.Forms.CheckBox();
            this.butSelWordBodyMail = new System.Windows.Forms.Button();
            this.edWordBodyMail = new System.Windows.Forms.TextBox();
            this.butOpenSelWord = new System.Windows.Forms.Button();
            this.lbAvtor = new System.Windows.Forms.LinkLabel();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.cbExcelPage = new System.Windows.Forms.ComboBox();
            this.lpPage = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTextMain = new System.Windows.Forms.TabPage();
            this.butSelectAttach = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbMail = new System.Windows.Forms.RichTextBox();
            this.toolRTB = new System.Windows.Forms.ToolStrip();
            this.tools_but_Save = new System.Windows.Forms.ToolStripButton();
            this.tools_but_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tools_but_Bold = new System.Windows.Forms.ToolStripButton();
            this.tools_but_Italic = new System.Windows.Forms.ToolStripButton();
            this.tools_but_underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tools_but_left = new System.Windows.Forms.ToolStripButton();
            this.tools_but_center = new System.Windows.Forms.ToolStripButton();
            this.tools_but_right = new System.Windows.Forms.ToolStripButton();
            this.edMail_subject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edMail_from = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSetupMain = new System.Windows.Forms.TabPage();
            this.ch_protocol_SSL = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chFirstTitle = new System.Windows.Forms.CheckBox();
            this.edSMTP_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edSMTP_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edSMTP_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edSMTP_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColumInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumEmail)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabTextMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolRTB.SuspendLayout();
            this.tabSetupMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.butOpenFile);
            this.groupBox1.Controls.Add(this.butLoadExcel);
            this.groupBox1.Controls.Add(this.edExcel);
            this.groupBox1.Controls.Add(this.butExcelSel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel файл...";
            // 
            // butOpenFile
            // 
            this.butOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butOpenFile.Image = global::SendSpan.Properties.Resources.control_play_blue;
            this.butOpenFile.Location = new System.Drawing.Point(378, 17);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(26, 23);
            this.butOpenFile.TabIndex = 3;
            this.toolTip.SetToolTip(this.butOpenFile, "Открыть выбранный файл");
            this.butOpenFile.UseVisualStyleBackColor = true;
            this.butOpenFile.Click += new System.EventHandler(this.butOpenFile_Click);
            // 
            // butLoadExcel
            // 
            this.butLoadExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butLoadExcel.Location = new System.Drawing.Point(410, 17);
            this.butLoadExcel.Name = "butLoadExcel";
            this.butLoadExcel.Size = new System.Drawing.Size(77, 23);
            this.butLoadExcel.TabIndex = 2;
            this.butLoadExcel.Text = "Загрузить";
            this.toolTip.SetToolTip(this.butLoadExcel, "Загрузить ");
            this.butLoadExcel.UseVisualStyleBackColor = true;
            this.butLoadExcel.Click += new System.EventHandler(this.butLoadExcel_Click);
            // 
            // edExcel
            // 
            this.edExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edExcel.Location = new System.Drawing.Point(6, 19);
            this.edExcel.Name = "edExcel";
            this.edExcel.Size = new System.Drawing.Size(338, 20);
            this.edExcel.TabIndex = 1;
            // 
            // butExcelSel
            // 
            this.butExcelSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butExcelSel.ImageIndex = 1;
            this.butExcelSel.ImageList = this.imageList;
            this.butExcelSel.Location = new System.Drawing.Point(350, 16);
            this.butExcelSel.Name = "butExcelSel";
            this.butExcelSel.Size = new System.Drawing.Size(26, 23);
            this.butExcelSel.TabIndex = 0;
            this.toolTip.SetToolTip(this.butExcelSel, "Выбрать Excel файл...");
            this.butExcelSel.UseVisualStyleBackColor = true;
            this.butExcelSel.Click += new System.EventHandler(this.butExcelSel_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "email.png");
            this.imageList.Images.SetKeyName(1, "page_excel.png");
            // 
            // numColumInfo
            // 
            this.numColumInfo.Location = new System.Drawing.Point(92, 24);
            this.numColumInfo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumInfo.Name = "numColumInfo";
            this.numColumInfo.Size = new System.Drawing.Size(34, 20);
            this.numColumInfo.TabIndex = 8;
            this.toolTip.SetToolTip(this.numColumInfo, "Номер столбца с информацией");
            this.numColumInfo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Информация";
            this.toolTip.SetToolTip(this.label7, "Столбец с информацией");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Почта";
            this.toolTip.SetToolTip(this.label8, "Столбец с почтой");
            // 
            // numColumEmail
            // 
            this.numColumEmail.Location = new System.Drawing.Point(92, 49);
            this.numColumEmail.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumEmail.Name = "numColumEmail";
            this.numColumEmail.Size = new System.Drawing.Size(34, 20);
            this.numColumEmail.TabIndex = 11;
            this.toolTip.SetToolTip(this.numColumEmail, "Номе столбца с почтой");
            this.numColumEmail.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // edMail_attach
            // 
            this.edMail_attach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edMail_attach.Location = new System.Drawing.Point(76, 57);
            this.edMail_attach.Name = "edMail_attach";
            this.edMail_attach.Size = new System.Drawing.Size(374, 20);
            this.edMail_attach.TabIndex = 7;
            this.toolTip.SetToolTip(this.edMail_attach, "Прикрепляемые файлы. Через точку с запятой");
            // 
            // butSendMail
            // 
            this.butSendMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSendMail.ImageIndex = 0;
            this.butSendMail.ImageList = this.imageList;
            this.butSendMail.Location = new System.Drawing.Point(394, 71);
            this.butSendMail.Name = "butSendMail";
            this.butSendMail.Size = new System.Drawing.Size(115, 23);
            this.butSendMail.TabIndex = 4;
            this.butSendMail.Text = "Отправить...";
            this.toolTip.SetToolTip(this.butSendMail, "Отправить письмо адресатам на странице");
            this.butSendMail.UseVisualStyleBackColor = true;
            this.butSendMail.Click += new System.EventHandler(this.butSendMail_Click);
            // 
            // chWordBodyMail
            // 
            this.chWordBodyMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chWordBodyMail.AutoSize = true;
            this.chWordBodyMail.Location = new System.Drawing.Point(6, 260);
            this.chWordBodyMail.Name = "chWordBodyMail";
            this.chWordBodyMail.Size = new System.Drawing.Size(161, 17);
            this.chWordBodyMail.TabIndex = 9;
            this.chWordBodyMail.Text = "Содержимое Word файла: ";
            this.toolTip.SetToolTip(this.chWordBodyMail, "Содержимое Word файла будет отослоно как письмо");
            this.chWordBodyMail.UseVisualStyleBackColor = true;
            this.chWordBodyMail.CheckedChanged += new System.EventHandler(this.chWordBodyMail_CheckedChanged);
            // 
            // butSelWordBodyMail
            // 
            this.butSelWordBodyMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelWordBodyMail.Enabled = false;
            this.butSelWordBodyMail.Location = new System.Drawing.Point(428, 256);
            this.butSelWordBodyMail.Name = "butSelWordBodyMail";
            this.butSelWordBodyMail.Size = new System.Drawing.Size(27, 23);
            this.butSelWordBodyMail.TabIndex = 11;
            this.butSelWordBodyMail.Text = "...";
            this.toolTip.SetToolTip(this.butSelWordBodyMail, "Выбрать Word файл");
            this.butSelWordBodyMail.UseVisualStyleBackColor = true;
            this.butSelWordBodyMail.Click += new System.EventHandler(this.butSelWordBodyMail_Click);
            // 
            // edWordBodyMail
            // 
            this.edWordBodyMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edWordBodyMail.Enabled = false;
            this.edWordBodyMail.Location = new System.Drawing.Point(163, 257);
            this.edWordBodyMail.Name = "edWordBodyMail";
            this.edWordBodyMail.Size = new System.Drawing.Size(259, 20);
            this.edWordBodyMail.TabIndex = 10;
            this.toolTip.SetToolTip(this.edWordBodyMail, "Содержимое Word файла будет отослоно как письмо");
            // 
            // butOpenSelWord
            // 
            this.butOpenSelWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butOpenSelWord.Enabled = false;
            this.butOpenSelWord.Image = global::SendSpan.Properties.Resources.control_play_blue;
            this.butOpenSelWord.Location = new System.Drawing.Point(457, 256);
            this.butOpenSelWord.Name = "butOpenSelWord";
            this.butOpenSelWord.Size = new System.Drawing.Size(26, 23);
            this.butOpenSelWord.TabIndex = 12;
            this.toolTip.SetToolTip(this.butOpenSelWord, "Открыть выбранный файл");
            this.butOpenSelWord.UseVisualStyleBackColor = true;
            this.butOpenSelWord.Click += new System.EventHandler(this.butOpenSelWord_Click);
            // 
            // lbAvtor
            // 
            this.lbAvtor.AutoSize = true;
            this.lbAvtor.Location = new System.Drawing.Point(55, 20);
            this.lbAvtor.Name = "lbAvtor";
            this.lbAvtor.Size = new System.Drawing.Size(83, 13);
            this.lbAvtor.TabIndex = 0;
            this.lbAvtor.TabStop = true;
            this.lbAvtor.Text = "Бачила Никита";
            this.toolTip.SetToolTip(this.lbAvtor, "Можете письмо написать :)");
            this.lbAvtor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbAvtor_LinkClicked);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "*.xls|*.xls, *.xlsx";
            // 
            // cbExcelPage
            // 
            this.cbExcelPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExcelPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExcelPage.FormattingEnabled = true;
            this.cbExcelPage.Location = new System.Drawing.Point(145, 71);
            this.cbExcelPage.Name = "cbExcelPage";
            this.cbExcelPage.Size = new System.Drawing.Size(243, 21);
            this.cbExcelPage.TabIndex = 1;
            // 
            // lpPage
            // 
            this.lpPage.AutoSize = true;
            this.lpPage.Location = new System.Drawing.Point(15, 74);
            this.lpPage.Name = "lpPage";
            this.lpPage.Size = new System.Drawing.Size(124, 13);
            this.lpPage.TabIndex = 2;
            this.lpPage.Text = "Страницы Excel файла:";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabTextMain);
            this.tabControl.Controls.Add(this.tabSetupMain);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Location = new System.Drawing.Point(12, 98);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(497, 312);
            this.tabControl.TabIndex = 3;
            // 
            // tabTextMain
            // 
            this.tabTextMain.Controls.Add(this.butOpenSelWord);
            this.tabTextMain.Controls.Add(this.butSelWordBodyMail);
            this.tabTextMain.Controls.Add(this.edWordBodyMail);
            this.tabTextMain.Controls.Add(this.chWordBodyMail);
            this.tabTextMain.Controls.Add(this.butSelectAttach);
            this.tabTextMain.Controls.Add(this.edMail_attach);
            this.tabTextMain.Controls.Add(this.label9);
            this.tabTextMain.Controls.Add(this.panel1);
            this.tabTextMain.Controls.Add(this.edMail_subject);
            this.tabTextMain.Controls.Add(this.label6);
            this.tabTextMain.Controls.Add(this.edMail_from);
            this.tabTextMain.Controls.Add(this.label5);
            this.tabTextMain.Location = new System.Drawing.Point(4, 22);
            this.tabTextMain.Name = "tabTextMain";
            this.tabTextMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabTextMain.Size = new System.Drawing.Size(489, 286);
            this.tabTextMain.TabIndex = 0;
            this.tabTextMain.Text = "Текcт письма";
            this.tabTextMain.UseVisualStyleBackColor = true;
            // 
            // butSelectAttach
            // 
            this.butSelectAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelectAttach.Location = new System.Drawing.Point(456, 55);
            this.butSelectAttach.Name = "butSelectAttach";
            this.butSelectAttach.Size = new System.Drawing.Size(27, 23);
            this.butSelectAttach.TabIndex = 8;
            this.butSelectAttach.Text = "...";
            this.butSelectAttach.UseVisualStyleBackColor = true;
            this.butSelectAttach.Click += new System.EventHandler(this.butSelectAttach_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Прикрепить:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rtbMail);
            this.panel1.Controls.Add(this.toolRTB);
            this.panel1.Location = new System.Drawing.Point(2, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 171);
            this.panel1.TabIndex = 5;
            // 
            // rtbMail
            // 
            this.rtbMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMail.Location = new System.Drawing.Point(0, 25);
            this.rtbMail.Name = "rtbMail";
            this.rtbMail.Size = new System.Drawing.Size(481, 146);
            this.rtbMail.TabIndex = 5;
            this.rtbMail.Text = "";
            // 
            // toolRTB
            // 
            this.toolRTB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools_but_Save,
            this.tools_but_Open,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.tools_but_Bold,
            this.tools_but_Italic,
            this.tools_but_underline,
            this.toolStripSeparator2,
            this.tools_but_left,
            this.tools_but_center,
            this.tools_but_right});
            this.toolRTB.Location = new System.Drawing.Point(0, 0);
            this.toolRTB.Name = "toolRTB";
            this.toolRTB.Size = new System.Drawing.Size(481, 25);
            this.toolRTB.TabIndex = 0;
            this.toolRTB.Text = "toolStrip1";
            // 
            // tools_but_Save
            // 
            this.tools_but_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_but_Save.Image = ((System.Drawing.Image)(resources.GetObject("tools_but_Save.Image")));
            this.tools_but_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_but_Save.Name = "tools_but_Save";
            this.tools_but_Save.Size = new System.Drawing.Size(23, 22);
            this.tools_but_Save.Text = "Сохранить макет письма";
            this.tools_but_Save.Click += new System.EventHandler(this.tools_but_Save_Click);
            // 
            // tools_but_Open
            // 
            this.tools_but_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_but_Open.Image = ((System.Drawing.Image)(resources.GetObject("tools_but_Open.Image")));
            this.tools_but_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_but_Open.Name = "tools_but_Open";
            this.tools_but_Open.Size = new System.Drawing.Size(23, 22);
            this.tools_but_Open.Text = "Открыть макет письма";
            this.tools_but_Open.Click += new System.EventHandler(this.tools_but_Open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Шрифт";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tools_but_Bold
            // 
            this.tools_but_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_but_Bold.Image = ((System.Drawing.Image)(resources.GetObject("tools_but_Bold.Image")));
            this.tools_but_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_but_Bold.Name = "tools_but_Bold";
            this.tools_but_Bold.Size = new System.Drawing.Size(23, 22);
            this.tools_but_Bold.Text = "Жирный";
            this.tools_but_Bold.Click += new System.EventHandler(this.tools_but_Bold_Click);
            // 
            // tools_but_Italic
            // 
            this.tools_but_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_but_Italic.Image = ((System.Drawing.Image)(resources.GetObject("tools_but_Italic.Image")));
            this.tools_but_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_but_Italic.Name = "tools_but_Italic";
            this.tools_but_Italic.Size = new System.Drawing.Size(23, 22);
            this.tools_but_Italic.Text = "Наклонный";
            this.tools_but_Italic.Click += new System.EventHandler(this.tools_but_Italic_Click);
            // 
            // tools_but_underline
            // 
            this.tools_but_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_but_underline.Image = ((System.Drawing.Image)(resources.GetObject("tools_but_underline.Image")));
            this.tools_but_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_but_underline.Name = "tools_but_underline";
            this.tools_but_underline.Size = new System.Drawing.Size(23, 22);
            this.tools_but_underline.Text = "Подчеркнутый";
            this.tools_but_underline.Click += new System.EventHandler(this.tools_but_underline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tools_but_left
            // 
            this.tools_but_left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_but_left.Image = ((System.Drawing.Image)(resources.GetObject("tools_but_left.Image")));
            this.tools_but_left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_but_left.Name = "tools_but_left";
            this.tools_but_left.Size = new System.Drawing.Size(23, 22);
            this.tools_but_left.Text = "Выровнить текст по левому краю";
            this.tools_but_left.Click += new System.EventHandler(this.tools_but_left_Click);
            // 
            // tools_but_center
            // 
            this.tools_but_center.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_but_center.Image = ((System.Drawing.Image)(resources.GetObject("tools_but_center.Image")));
            this.tools_but_center.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_but_center.Name = "tools_but_center";
            this.tools_but_center.Size = new System.Drawing.Size(23, 22);
            this.tools_but_center.Text = "Выровнить текст по центру";
            this.tools_but_center.Click += new System.EventHandler(this.tools_but_center_Click);
            // 
            // tools_but_right
            // 
            this.tools_but_right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_but_right.Image = ((System.Drawing.Image)(resources.GetObject("tools_but_right.Image")));
            this.tools_but_right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_but_right.Name = "tools_but_right";
            this.tools_but_right.Size = new System.Drawing.Size(23, 22);
            this.tools_but_right.Text = "Выровнить текст по правому краю";
            this.tools_but_right.Click += new System.EventHandler(this.tools_but_right_Click);
            // 
            // edMail_subject
            // 
            this.edMail_subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edMail_subject.Location = new System.Drawing.Point(76, 32);
            this.edMail_subject.Name = "edMail_subject";
            this.edMail_subject.Size = new System.Drawing.Size(407, 20);
            this.edMail_subject.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Тема:";
            // 
            // edMail_from
            // 
            this.edMail_from.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edMail_from.Location = new System.Drawing.Point(76, 6);
            this.edMail_from.Name = "edMail_from";
            this.edMail_from.Size = new System.Drawing.Size(407, 20);
            this.edMail_from.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Письмо от:";
            // 
            // tabSetupMain
            // 
            this.tabSetupMain.Controls.Add(this.ch_protocol_SSL);
            this.tabSetupMain.Controls.Add(this.groupBox2);
            this.tabSetupMain.Controls.Add(this.edSMTP_pwd);
            this.tabSetupMain.Controls.Add(this.label4);
            this.tabSetupMain.Controls.Add(this.edSMTP_user);
            this.tabSetupMain.Controls.Add(this.label3);
            this.tabSetupMain.Controls.Add(this.edSMTP_port);
            this.tabSetupMain.Controls.Add(this.label2);
            this.tabSetupMain.Controls.Add(this.edSMTP_server);
            this.tabSetupMain.Controls.Add(this.label1);
            this.tabSetupMain.Location = new System.Drawing.Point(4, 22);
            this.tabSetupMain.Name = "tabSetupMain";
            this.tabSetupMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetupMain.Size = new System.Drawing.Size(489, 286);
            this.tabSetupMain.TabIndex = 1;
            this.tabSetupMain.Text = "Настройка";
            this.tabSetupMain.UseVisualStyleBackColor = true;
            // 
            // ch_protocol_SSL
            // 
            this.ch_protocol_SSL.AutoSize = true;
            this.ch_protocol_SSL.Location = new System.Drawing.Point(9, 72);
            this.ch_protocol_SSL.Name = "ch_protocol_SSL";
            this.ch_protocol_SSL.Size = new System.Drawing.Size(98, 17);
            this.ch_protocol_SSL.TabIndex = 13;
            this.ch_protocol_SSL.Text = "Протокол SSL";
            this.ch_protocol_SSL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chFirstTitle);
            this.groupBox2.Controls.Add(this.numColumInfo);
            this.groupBox2.Controls.Add(this.numColumEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(9, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 99);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Столбцы";
            // 
            // chFirstTitle
            // 
            this.chFirstTitle.AutoSize = true;
            this.chFirstTitle.Checked = true;
            this.chFirstTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chFirstTitle.Location = new System.Drawing.Point(8, 75);
            this.chFirstTitle.Name = "chFirstTitle";
            this.chFirstTitle.Size = new System.Drawing.Size(135, 17);
            this.chFirstTitle.TabIndex = 12;
            this.chFirstTitle.Text = "1-я строка заголовок";
            this.chFirstTitle.UseVisualStyleBackColor = true;
            // 
            // edSMTP_pwd
            // 
            this.edSMTP_pwd.Location = new System.Drawing.Point(279, 40);
            this.edSMTP_pwd.Name = "edSMTP_pwd";
            this.edSMTP_pwd.PasswordChar = '*';
            this.edSMTP_pwd.Size = new System.Drawing.Size(68, 20);
            this.edSMTP_pwd.TabIndex = 7;
            this.edSMTP_pwd.Text = "sportdesign1991";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль:";
            // 
            // edSMTP_user
            // 
            this.edSMTP_user.Location = new System.Drawing.Point(91, 40);
            this.edSMTP_user.Name = "edSMTP_user";
            this.edSMTP_user.Size = new System.Drawing.Size(129, 20);
            this.edSMTP_user.TabIndex = 5;
            this.edSMTP_user.Text = "info@sportfamily.by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пользователь:";
            // 
            // edSMTP_port
            // 
            this.edSMTP_port.Location = new System.Drawing.Point(279, 14);
            this.edSMTP_port.Name = "edSMTP_port";
            this.edSMTP_port.Size = new System.Drawing.Size(68, 20);
            this.edSMTP_port.TabIndex = 3;
            this.edSMTP_port.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Порт:";
            // 
            // edSMTP_server
            // 
            this.edSMTP_server.Location = new System.Drawing.Point(91, 14);
            this.edSMTP_server.Name = "edSMTP_server";
            this.edSMTP_server.Size = new System.Drawing.Size(129, 20);
            this.edSMTP_server.TabIndex = 1;
            this.edSMTP_server.Text = "smtp.mail.ru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP сервер:";
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.linkLabel3);
            this.tabAbout.Controls.Add(this.linkLabel2);
            this.tabAbout.Controls.Add(this.linkLabel1);
            this.tabAbout.Controls.Add(this.label11);
            this.tabAbout.Controls.Add(this.label10);
            this.tabAbout.Controls.Add(this.lbAvtor);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(489, 286);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "О программе";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(55, 116);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(71, 13);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Fatcow Icons";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(55, 92);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(162, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "NLog – Advanced .NET Logging";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(55, 69);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(197, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Microsoft Visual C#2008 Express Edition";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Использовано для создания:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Автор:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 422);
            this.Controls.Add(this.butSendMail);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lpPage);
            this.Controls.Add(this.cbExcelPage);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendSpam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColumInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumEmail)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabTextMain.ResumeLayout(false);
            this.tabTextMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolRTB.ResumeLayout(false);
            this.toolRTB.PerformLayout();
            this.tabSetupMain.ResumeLayout(false);
            this.tabSetupMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edExcel;
        private System.Windows.Forms.Button butExcelSel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.ComboBox cbExcelPage;
        private System.Windows.Forms.Label lpPage;
        private System.Windows.Forms.Button butLoadExcel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTextMain;
        private System.Windows.Forms.TabPage tabSetupMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edSMTP_server;
        private System.Windows.Forms.TextBox edSMTP_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edSMTP_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edSMTP_pwd;
        private System.Windows.Forms.TextBox edMail_from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edMail_subject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbMail;
        private System.Windows.Forms.ToolStrip toolRTB;
        private System.Windows.Forms.ToolStripButton tools_but_Bold;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripButton tools_but_Italic;
        private System.Windows.Forms.ToolStripButton tools_but_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tools_but_Save;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.ToolStripButton tools_but_underline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tools_but_left;
        private System.Windows.Forms.ToolStripButton tools_but_center;
        private System.Windows.Forms.ToolStripButton tools_but_right;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.Button butSendMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numColumInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numColumEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chFirstTitle;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.CheckBox ch_protocol_SSL;
        private System.Windows.Forms.TextBox edMail_attach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butSelectAttach;
        private System.Windows.Forms.CheckBox chWordBodyMail;
        private System.Windows.Forms.Button butSelWordBodyMail;
        private System.Windows.Forms.TextBox edWordBodyMail;
        private System.Windows.Forms.Button butOpenSelWord;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel lbAvtor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

