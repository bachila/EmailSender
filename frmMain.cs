using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using ExcleRange = Microsoft.Office.Interop.Excel.Range;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Configuration;
using System.Xml;
using System.Collections.Specialized;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

// http://www.intmain.ru/otpravka-e-mail.html - Отправка E-Mail
// http://www.gotdotnet.ru/blogs/msdn/6439/ - Объектная модель Excel с точки зрения разработчика под .NET
// http://wladm.narod.ru/C_Sharp/comword.html - Работа с COM сервером Word
// http://dev.ezoterik.info/otsylka-e-mail-cherez-c-sharp/ - Отсылка e-mail через C#
namespace SendSpan
{
    public partial class frmMain : Form
    {
        LinkedResource file_temp_img;
        string temp = System.IO.Path.GetTempFileName();
        public Microsoft.Office.Interop.Excel.ApplicationClass excel = null;
        public Microsoft.Office.Interop.Word.ApplicationClass word = null;
        List<String> list_temp_file = new List<String>(); // Список с времеными файлами
        string input;
        /// <summary>
        /// Сохранить текст сообщения письма в HTML формате
        /// </summary>
        /// <returns>Вовзращает временный файл с HTML текстом</returns>
        public string SaveMailInHtml()
        {
            Program.log.Trace("SaveMailInHtml - begin");
            string file_temp_rtf;
            string file_temp_htm;
            try
            {
                if (chWordBodyMail.Checked) // Берем Word документ как основу письма
                    file_temp_rtf = edWordBodyMail.Text;
                else // берем rtf
                {
                    file_temp_rtf = System.IO.Path.GetTempFileName();
                    rtbMail.SaveFile(file_temp_rtf);
                }
                
                file_temp_htm = temp + ".htm";
                InitWord();
                word.Visible = false;

                Object obj_file_temp_rtf = file_temp_rtf;
                Object obj_file_temp_htm = file_temp_htm;
                Object obj_file_format = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatFilteredHTML;
                Object obj_null = Type.Missing;

                // Открываем документ и пересохраняем его в HTML
                Microsoft.Office.Interop.Word.Document worddocument;
                worddocument = word.Documents.Open(ref obj_file_temp_rtf, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null);
                worddocument.SaveAs(ref obj_file_temp_htm, ref obj_file_format, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null, ref obj_null);
                worddocument.Close(ref obj_null, ref obj_null, ref obj_null);
                //file_temp_img = new LinkedResource(temp + ".files\\image001.jpg");
                if (word != null) word.Quit(ref obj_null, ref obj_null, ref obj_null);

                try
                {
                    if (!chWordBodyMail.Checked && System.IO.File.Exists(file_temp_rtf))
                        System.IO.File.Delete(file_temp_rtf);
                }
                catch (Exception ex)
                {
                    list_temp_file.Add(file_temp_rtf);
                };

            }
            catch (Exception e)
            {
                file_temp_htm = "";
                string err_msg = string.Format("Ошибка преобразования в HTML\n{0}", e.Message);
                MessageBox.Show(err_msg);
                return "";
            }

            return file_temp_htm;
        }

        /// <summary>
        /// Иницилизация Word
        /// </summary>
        /// <returns></returns>
        public bool InitWord()
        {
            Program.log.Trace("InitWord - begin");
            try
            {
                //Word.Document Doc= new Microsoft.Office.Interop.Word.Document()
                // иницилизация
                word = new Microsoft.Office.Interop.Word.ApplicationClass();
                word.Visible = false;
                return true;
            }
            catch (Exception e)
            {
                string str = string.Format("Ошибка иницилизации Word:\n{0}", e.Message);
                Program.log.Debug(str);
                MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /// <summary>
        /// Иницилизация Excel
        /// </summary>
        /// <returns></returns>
        public bool InitExcel()
        {
            Program.log.Trace("InitExcel - begin ");
            try
            {
                // иницилизация                
                excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                excel.Visible = false;
                return true;
            }
            catch (Exception e)
            {
                string str = string.Format("Ошибка иницилизации Excel:\n{0}", e.Message);
                Program.log.Debug(str);
                MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Проверка параметров перед отправкой почты
        /// </summary>
        /// <returns></returns>
        public bool TestParamSendMail()
        {
            Program.log.Trace("TestParamSendMail - begin");
            string err_msg = "";

            if (edExcel.Text.Trim() == string.Empty)
            {
                edExcel.Focus();
                err_msg = "Укажите Excel файл...";
            }
            else if (!System.IO.File.Exists(edExcel.Text))
            {
                err_msg = string.Format("Файл не найден\n{0}", edExcel.Text);
            }
            else if (cbExcelPage.SelectedIndex < 0)
            {
                cbExcelPage.Focus();
                err_msg = "Укажите страницу в Excel файле";
            }
            else if (edMail_from.Text.Trim() == string.Empty)
            {
                edMail_from.Focus();
                err_msg = "На закаладке \"Текст письма\" укажите от кого посылается письмо.";
            }
            else if (edSMTP_server.Text.Trim() == string.Empty)
            {
                edSMTP_server.Focus();
                err_msg = "На закаладке \"Настройка\" укажите \"SMPT сервер\"";
            }
            else if (edSMTP_port.Text.Trim() == string.Empty)
            {
                edSMTP_port.Focus();
                err_msg = "На закаладке \"Настройка\" укажите \"порт\" SMTP";
            }
            else if (edSMTP_user.Text.Trim() == string.Empty)
            {
                edSMTP_user.Focus();
                err_msg = "На закаладке \"Настройка\" укажите \"Пользователь\" SMTP";
            }
            else if (edSMTP_pwd.Text.Trim() == string.Empty)
            {
                edSMTP_pwd.Focus();
                err_msg = "На закаладке \"Настройка\" укажите \"Пароль\" пользователя SMTP";
            }
            else if (chWordBodyMail.Checked && !System.IO.File.Exists(edWordBodyMail.Text))
            {
                edWordBodyMail.Focus();
                err_msg = "На закаладке \"Настройка\" укажите Word-документ из которого будет браться текст письма.";
            }


            if (err_msg.Trim() != string.Empty)
            {
                Program.log.Trace(err_msg);
                MessageBox.Show(err_msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Редактируем список атачей к письму
        /// </summary>
        /// <param name="line_attach_path">Список файлов прикрепленные к письму. Идут через точку с запятой</param>
        public void EditAttach(string line_attach_path)
        {
            Program.log.Trace(string.Format("EditAttach({0}) - begin", line_attach_path));
            frmAttach dlgAttach = new frmAttach();
            dlgAttach.FileAttach = line_attach_path;
            if (dlgAttach.ShowDialog() == DialogResult.OK)
            {
                edMail_attach.Text = dlgAttach.FileAttach;
                Program.log.Trace(string.Format("edMail_attach.Text={0}", edMail_attach.Text));
            }
        }

        /// <summary>
        /// Посылка E-mail из данных по закладке
        /// </summary>
        /// <returns></returns>
        public bool SendEmail()
        {
            Program.log.Trace("=== SendEmail - begin");
            string err_msg = "";
            string msg = "";

            /// === Проверка входных данных ===
            if (!TestParamSendMail())
                return false;

            if (edMail_subject.Text.Trim() == string.Empty)
            {
                msg = "Поле \"Тема письма\" не заполнена.\nБудете отправлять письмо без темы?";
                DialogResult rez = MessageBox.Show(msg, "Не указана тема", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez != DialogResult.Yes) return false;
            }

            // === Работа с Excel ===

            if (!InitExcel()) return false;

            try
            {
                // Открываем Excel и проходимся по закладкам
                Workbook ObjWorkBook = excel.Workbooks.Open(edExcel.Text, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                bool isFind = false; // флаг найдености страницы
                Worksheet sheet = null; // искомая страница                

                // Ищем нужную страницу
                for (int i = 1; i <= ObjWorkBook.Sheets.Count && !isFind; i++)
                {
                    sheet = (Worksheet)ObjWorkBook.Sheets[i];
                    isFind = (sheet.Name == cbExcelPage.Text);
                }

                if (!isFind)
                {
                    err_msg = string.Format("Не смог найти страницу с именем \"{0}\" ", cbExcelPage.Text);
                    throw new Exception(err_msg);
                }

                int excel_rows = sheet.UsedRange.Rows.Count;           // строк занято
                int excel_columns = sheet.UsedRange.Columns.Count;     // столбцов занято

                if (excel_columns < numColumInfo.Value)
                {
                    string str = string.Format("На закладке \"{0}\" нет данных в столбце {1}\nСтолбец с информацией по почте", cbExcelPage.Text, numColumInfo.Value);
                    throw new Exception(str);
                }

                if (excel_columns < numColumEmail.Value)
                {
                    string str = string.Format("На закладке \"{0}\" нет данных в столбце {1}\nСтолбец с информацией по почте", cbExcelPage.Text, numColumEmail.Value);
                    throw new Exception(str);
                }

                // Запрос диалога выбора почты
                frmSelMail dlgSend = new frmSelMail();
                string str_info = "";
                string str_email = "";
                int iInfo = (int)numColumInfo.Value;     // столбец с инфорй
                int iMail = (int)numColumEmail.Value;    // стобец с почтой

                int start_line = chFirstTitle.Checked ? 2 : 1;

                // проходимся по табличке
                for (int i = start_line; i <= excel_rows; i++)
                {
                    str_info = (string)(sheet.Cells[i, iInfo] as ExcleRange).Value2;
                    str_email = (string)(sheet.Cells[i, iMail] as ExcleRange).Value2;

                    ListViewItem lvItem = new ListViewItem();
                    lvItem.Checked = true;
                    lvItem.Text = str_info;
                    lvItem.SubItems.Add(str_email);
                    dlgSend.lvMail.Items.Add(lvItem);
                }

                if (dlgSend.ShowDialog() == DialogResult.OK)
                {
                    string faile_html = SaveMailInHtml(); // Сохранили текст в HTML

                    if (faile_html == "") return false;

                    frmMailMessage dlgMailMessage = new frmMailMessage();

                    dlgMailMessage.Show();
                    SmtpClient Smtp;
                    dlgMailMessage.rbInfo.Text = dlgMailMessage.rbInfo.Text + "Авторизация SMTP...";
                    try
                    {
                        //Авторизация на SMTP сервере                    
                        int port = int.Parse(edSMTP_port.Text);
                        string user = edSMTP_user.Text;
                        string pas = edSMTP_pwd.Text;

                        Smtp = new SmtpClient(edSMTP_server.Text, port);
                        Smtp.Credentials = new NetworkCredential(user, pas);
                        Smtp.EnableSsl = ch_protocol_SSL.Checked;
                        dlgMailMessage.rbInfo.Text = dlgMailMessage.rbInfo.Text + "OK\n";
                    }
                    catch (Exception ex)
                    {
                        err_msg = string.Format("{0}\nОщибка иницилизация SMTP:\n{1}", dlgMailMessage.rbInfo.Text, ex.Message);
                        Program.log.Debug(err_msg);
                        dlgMailMessage.rbInfo.Text = err_msg;
                        dlgMailMessage.butClose.Enabled = true;
                        return false;
                    }

                    dlgMailMessage.progress.Maximum = dlgSend.lvMail.Items.Count;
                    foreach (ListViewItem item in dlgSend.lvMail.Items)
                    {

                        dlgMailMessage.progress.Value = dlgMailMessage.progress.Value + 1;
                        if (item.Checked)
                            try
                            {
                                Program.log.Trace(item.SubItems[1].Text);
                                string lastName;
                                string firstName;

                                msg = string.Format("{0}Отправляем письмо {1}...", dlgMailMessage.rbInfo.Text, item.SubItems[1].Text);
                                dlgMailMessage.rbInfo.Text = msg;
                                System.Windows.Forms.Application.DoEvents();


                                //Формирование письма
                                System.Net.Mail.MailMessage Message = new System.Net.Mail.MailMessage();
                                Message.From = new MailAddress(edMail_from.Text);

                                Message.BodyEncoding = System.Text.Encoding.UTF8;
                                Message.To.Clear();
                                Message.To.Add(new MailAddress(item.SubItems[1].Text));
                               // Message.SubjectEncoding = Encoding.GetEncoding(1251);
                                string tempSubject = edMail_subject.Text;
                                tempSubject = tempSubject.Replace("(Name)", item.SubItems[0].Text);
                                Message.Subject = tempSubject;
                                Message.IsBodyHtml = true;
                                System.IO.StreamReader sRead = new System.IO.StreamReader(faile_html, System.Text.Encoding.GetEncoding(1251));

                                string message = sRead.ReadToEnd();
                                string pattern = @"\w*\.\w*\.\w*\/\w*\.\w*";
                                int count = 0;
                                string id;

                                Regex rgx = new Regex(pattern);

                                MatchCollection matches = rgx.Matches(message);
                                List<string> listImages = new List<string>();
                                if (matches.Count > 0)
                                {
                                    foreach (Match match in matches)
                                    {
                                        listImages.Add(match.Value);
                                        id = string.Format("cid:uniq{0}", count++);
                                        message = message.Replace(String.Format("\"{0}\"", match.Value), id);
                                    }
                                }
                                AlternateView html_view = AlternateView.CreateAlternateViewFromString(message, null, "text/html");
                                
                                Message.BodyEncoding = Encoding.GetEncoding(1251);

                                List<AlternateView> altPic = new List<AlternateView>();
                                Message.Body = message;
                                for (int i = 0; i < matches.Count; i++)
                                {
                                    AlternateView jpeg_view = new AlternateView(Path.GetTempPath() + listImages[i], MediaTypeNames.Image.Jpeg);
                                    jpeg_view.ContentId = string.Format("uniq{0}", i);
                                    jpeg_view.TransferEncoding = TransferEncoding.Base64;
                                    altPic.Add(jpeg_view);
                                    Message.AlternateViews.Add(jpeg_view);
                                }
                                
                                //for (int i = 0; i < altPic.Count; i++)
                                //{
                                //    Message.AlternateViews.Add(altPic[i]);
                                //}
                                Message.AlternateViews.Add(html_view);
                                //var view = AlternateView.CreateAlternateViewFromString(Message.Body, null, "text/html");
                                //view.LinkedResources.Add(file_temp_img);
                                //Message.AlternateViews.Add(view);

                                //Прикрепляем файл 
                                if (edMail_attach.Text.Trim() != string.Empty)
                                {
                                    Message.Attachments.Clear();
                                    string[] listAttach = edMail_attach.Text.Split(';');
                                    foreach (string sFile in listAttach)
                                        if (sFile.Trim() != "")
                                        {
                                            if (!System.IO.File.Exists(sFile))
                                            {
                                                err_msg = string.Format("{0}\nПрикрепляемый файл не найден:\n{1}", dlgMailMessage.rbInfo.Text, sFile);
                                                dlgMailMessage.rbInfo.Text = err_msg;

                                            }
                                            else
                                            {
                                                Attachment attach = new Attachment(sFile);
                                                Message.Attachments.Add(attach);
                                            }

                                            //System.Net.Mime.ContentType ct = attach.ContentType;
                                            //ct.CharSet = "windows-1251";

                                            // Добавляем информацию для файла
                                            //ContentDisposition disposition = attach.ContentDisposition;                    
                                            // disposition.CreationDate = System.IO.File.GetCreationTime(file);
                                            // disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
                                            // disposition.ReadDate = System.IO.File.GetLastAccessTime(file);                                    
                                        }
                                }

                                Smtp.Send(Message);//отправка
                                Thread.Sleep(500);

                                msg = string.Format("{0}OK\n", dlgMailMessage.rbInfo.Text);
                                dlgMailMessage.rbInfo.Text = msg;
                                System.Windows.Forms.Application.DoEvents();
                                sRead.Close();
                            }
                            catch (Exception ex)
                            {
                                err_msg = string.Format("{0}\nОшибка отправки почты:\n{1}\n", dlgMailMessage.rbInfo.Text, ex.Message);
                                Program.log.Debug(err_msg);
                                dlgMailMessage.rbInfo.Text = err_msg;
                                System.Windows.Forms.Application.DoEvents();
                            }
                    }
                    dlgMailMessage.progress.Value = 0;
                    dlgMailMessage.butClose.Enabled = true;

                    try
                    {
                        if (System.IO.File.Exists(faile_html))
                            System.IO.File.Delete(faile_html);
                    }
                    catch (Exception ex)
                    {
                        list_temp_file.Add(faile_html);
                    }
                };
            }
            catch (Exception e)
            {
                excel.Quit();
                string str = string.Format("Ошибка работы с Excel файлом:\n{0}\n", e.Message);
                Program.log.Debug(str);
                MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            excel.Quit();
            Program.log.Trace("=== SendEmail - end");
            return true;
        }

        /// <summary>
        /// Загрузка Excel файла
        /// </summary>
        /// <returns>Загрузились ли данные</returns>
        bool LoadExcel()
        {
            Program.log.Trace("=== LoadExcel - begin");
            cbExcelPage.Items.Clear();

            /// === Проверка входных данных ===
            string err_msg = "";
            if (edExcel.Text.Trim() == string.Empty)
            {
                err_msg = "Укажите Excel файл...";
            }
            else if (!System.IO.File.Exists(edExcel.Text))
            {
                err_msg = string.Format("Файл не найден\n{0}", edExcel.Text);
            }

            if (err_msg.Trim() != string.Empty)
            {
                Program.log.Trace(err_msg);
                MessageBox.Show(err_msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // === Работа с Excel ===

            if (!InitExcel()) return false;

            try
            {
                // Открываем Excel и проходимся по закладкам
                Workbook ObjWorkBook = excel.Workbooks.Open(edExcel.Text, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                for (int i = 1; i <= ObjWorkBook.Sheets.Count; i++)
                {
                    Worksheet sheet = (Worksheet)ObjWorkBook.Sheets[i];
                    cbExcelPage.Items.Add(sheet.Name);
                }

            }
            catch (Exception e)
            {
                string str = string.Format("Ошибка открытия Excel файла:\n {0}", e.Message);
                Program.log.Debug(str);
                MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            excel.Quit();
            Program.log.Trace("=== LoadExcel - end");
            return true;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void butExcelSel_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "*.xls|*.xls";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                edExcel.Text = dlgOpenFile.FileName;
                LoadExcel();
            }
        }

        private void butLoadExcel_Click(object sender, EventArgs e)
        {
            LoadExcel();
        }

        private void tools_but_Save_Click(object sender, EventArgs e)
        {
            dlgSaveFile.Filter = "*.rtf|*.rtf";
            dlgSaveFile.DefaultExt = "rtf";
            if (dlgSaveFile.ShowDialog() == DialogResult.OK || dlgSaveFile.FileName.Length > 0)
            {
                rtbMail.SaveFile(dlgSaveFile.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void tools_but_Open_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "*.rtf|*.rtf";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                rtbMail.LoadFile(dlgOpenFile.FileName);
            }
        }

        private void tools_but_Bold_Click(object sender, EventArgs e)
        {
            rtbMail.SelectionFont = new System.Drawing.Font(rtbMail.SelectionFont, rtbMail.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void tools_but_Italic_Click(object sender, EventArgs e)
        {
            rtbMail.SelectionFont = new System.Drawing.Font(rtbMail.SelectionFont, rtbMail.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void tools_but_underline_Click(object sender, EventArgs e)
        {
            rtbMail.SelectionFont = new System.Drawing.Font(rtbMail.SelectionFont, rtbMail.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void tools_but_left_Click(object sender, EventArgs e)
        {
            rtbMail.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tools_but_center_Click(object sender, EventArgs e)
        {
            rtbMail.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tools_but_right_Click(object sender, EventArgs e)
        {
            rtbMail.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (rtbMail.SelectionFont != null)
                dlgFont.Font = rtbMail.SelectionFont;
            else
                dlgFont.Font = rtbMail.Font;

            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                if (rtbMail.SelectionFont != null)
                    rtbMail.SelectionFont = dlgFont.Font;
                else
                    rtbMail.Font = dlgFont.Font;
            }
        }

        private void butSendMail_Click(object sender, EventArgs e)
        {
            SendEmail();
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.log.Trace("frmMain_FormClosing() - begin");
            string sTemplate = System.Windows.Forms.Application.StartupPath + "\\template.tmp";
            try
            {
                rtbMail.SaveFile(sTemplate);
            }
            catch (Exception ex)
            {
                string err_msg = string.Format("Не смог сохранить шаблон.\n{0}\n{1}", sTemplate, ex.Message);
                Program.log.Trace(err_msg);
                MessageBox.Show(err_msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Удаляем временные не удаленные файлы
            try
            {
                foreach (string s in list_temp_file)
                    if (System.IO.File.Exists(s))
                        System.IO.File.Delete(s);
            }
            catch (Exception ex)
            {
                Program.log.Trace(string.Format("Не смог удалить временный файл.\n{0}", ex.Message));
            }

            Object obj_null = Type.Missing;
            if (excel != null) excel.Quit();

            Program.log.Trace("frmMain_FormClosing() - end");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Program.log.Trace("=== frmMain_Load - begin");
            string template = System.Windows.Forms.Application.StartupPath + "\\template.tmp";
            if (System.IO.File.Exists(template))
                rtbMail.LoadFile(template);

            // Читаем настройки 
            string xml_file = System.IO.Path.ChangeExtension(System.Windows.Forms.Application.ExecutablePath, ".xml");
            if (System.IO.File.Exists(xml_file))
            {
                Program.log.Trace("Читаем настройки:");
                XmlTextReader xml = new XmlTextReader(xml_file);
                try
                {
                    xml.ReadStartElement("option");

                    while (!xml.EOF && xml.Name != "option")
                    {
                        string name = xml.Name;
                        string value = xml.ReadElementContentAsString();

                        Program.log.Trace(string.Format("{0}={1}", name, value));

                        switch (name)
                        {
                            case "edMail_from":
                                edMail_from.Text = value;
                                break;
                            case "edMail_subject":
                                edMail_subject.Text = value;
                                break;
                            case "edMail_attach":
                                edMail_attach.Text = value;
                                break;
                            case "edSMTP_server":
                                edSMTP_server.Text = value;
                                break;
                            case "edSMTP_port":
                                edSMTP_port.Text = value;
                                break;
                            case "edSMTP_user":
                                edSMTP_user.Text = value;
                                break;
                            case "edSMTP_pwd":
                                edSMTP_pwd.Text = value;
                                break;
                            case "ch_protocol_SSL":
                                ch_protocol_SSL.Checked = bool.Parse(value);
                                break;
                            case "numColumInfo":
                                numColumInfo.Value = int.Parse(value);
                                break;
                            case "numColumEmail":
                                numColumEmail.Value = int.Parse(value);
                                break;
                            case "chFirstTitle":
                                chFirstTitle.Checked = bool.Parse(value);
                                break;
                            case "chWordBodyMail":
                                chWordBodyMail.Checked = bool.Parse(value);
                                break;
                            case "edWordBodyMail":
                                edWordBodyMail.Text = value;
                                break;
                        }
                    }
                    xml.Close();
                }
                catch (Exception ex)
                {
                    string msg = string.Format("Ощибка чтения настроек из файла\n{0}\nОшибка:{1}", xml_file, ex.Message);
                    Program.log.Debug(msg);
                    MessageBox.Show(msg, "Ошибка записи");
                }
                Program.log.Trace("=== frmMain_Load - end");
            }

        }

        private void butOpenFile_Click(object sender, EventArgs e)
        {
            string err_mag = "";
            if (edExcel.Text.Trim() == string.Empty)
            {
                err_mag = "Не указан Excel файл";
                edExcel.Focus();
            }

            if (!System.IO.File.Exists(edExcel.Text))
            {
                err_mag = string.Format("Файл не найден\n{0}", edExcel.Text);
                edExcel.Focus();
            }

            if (err_mag != "")
            {
                MessageBox.Show(err_mag, "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(edExcel.Text);
            }
            catch (Exception ex)
            {
                err_mag = string.Format("Ошибка открытия файла\n{0}\n{1}", edExcel.Text, ex.Message);
                Program.log.Debug(err_mag);
                MessageBox.Show(err_mag, "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.log.Trace("=== frmMain_FormClosed - begin");
            // пишем настройки
            string xml_file = System.IO.Path.ChangeExtension(System.Windows.Forms.Application.ExecutablePath, ".xml");
            XmlTextWriter xml = new XmlTextWriter(xml_file, System.Text.Encoding.Unicode);

            try
            {
                Program.log.Trace("Пишем настройки...");
                xml.WriteStartDocument();
                xml.WriteStartElement("option");

                xml.WriteElementString("edMail_from", edMail_from.Text);
                xml.WriteElementString("edMail_subject", edMail_subject.Text);
                xml.WriteElementString("edSMTP_server", edSMTP_server.Text);
                xml.WriteElementString("edSMTP_port", edSMTP_port.Text);
                xml.WriteElementString("edSMTP_user", edSMTP_user.Text);
                xml.WriteElementString("edSMTP_pwd", edSMTP_pwd.Text);
                xml.WriteElementString("ch_protocol_SSL", ch_protocol_SSL.Checked.ToString());

                xml.WriteElementString("numColumInfo", numColumInfo.Value.ToString());
                xml.WriteElementString("numColumEmail", numColumEmail.Value.ToString());
                xml.WriteElementString("chFirstTitle", chFirstTitle.Checked.ToString());
                xml.WriteElementString("edMail_attach", edMail_attach.Text);

                xml.WriteElementString("chWordBodyMail", chWordBodyMail.Checked.ToString());
                xml.WriteElementString("edWordBodyMail", edWordBodyMail.Text);

                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Close();
            }
            catch (Exception ex)
            {
                string msg = string.Format("Ощибка записи настроек в файл \n{0}\nОшибка:{1}", xml_file, ex.Message);
                Program.log.Debug(msg);
                MessageBox.Show(msg, "Ошибка записи");
            }
            Program.log.Trace("=== frmMain_FormClosed - end");
        }

        private void butSelectAttach_Click(object sender, EventArgs e)
        {
            EditAttach(edMail_attach.Text);
        }

        private void chWordBodyMail_CheckedChanged(object sender, EventArgs e)
        {
            edWordBodyMail.Enabled = chWordBodyMail.Checked;
            butSelWordBodyMail.Enabled = chWordBodyMail.Checked;
            butOpenSelWord.Enabled = chWordBodyMail.Checked;
            rtbMail.Enabled = !chWordBodyMail.Checked;
            toolRTB.Enabled = !chWordBodyMail.Checked;
            if (chWordBodyMail.Checked)
                edWordBodyMail.Focus();
            else
                rtbMail.Focus();

        }

        private void butSelWordBodyMail_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "*.doc|*.doc|*.docx|*.docx";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                edWordBodyMail.Text = dlgOpenFile.FileName;
            }
        }

        private void butOpenSelWord_Click(object sender, EventArgs e)
        {
            string err_mag = "";
            if (edWordBodyMail.Text.Trim() == string.Empty)
            {
                err_mag = "Не указан Word файл";
                edWordBodyMail.Focus();
            }

            if (!System.IO.File.Exists(edWordBodyMail.Text))
            {
                err_mag = string.Format("Файл не найден\n{0}", edExcel.Text);
                edWordBodyMail.Focus();
            }

            if (err_mag != "")
            {
                MessageBox.Show(err_mag, "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(edWordBodyMail.Text);
            }
            catch (Exception ex)
            {
                err_mag = string.Format("Ошибка открытия файла\n{0}\n{1}", edWordBodyMail.Text, ex.Message);
                Program.log.Debug(err_mag);
                MessageBox.Show(err_mag, "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbAvtor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:sprightly2007@mail.ru");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://msdn.microsoft.com/vstudio/express/default.aspx");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://nlog-project.org/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.fatcow.com/free-icons");
        }




    }
}
