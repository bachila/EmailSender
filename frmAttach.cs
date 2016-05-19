using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SendSpan
{
    public partial class frmAttach : Form
    {

        /// <summary>
        /// Возвращает размерность
        /// </summary>
        /// <param name="sizeFile">Размер файла</param>
        /// <param name="razmer">В какой размерности</param>
        public void GetRazmernost(ref long sizeFile, ref string razmer)
        {
            if (sizeFile > 1024)
            {
                sizeFile = sizeFile / 1024;
                razmer = "Кб";
            }

            if (sizeFile > 1024)
            {
                sizeFile = sizeFile / 1024;
                razmer = "Мб";
            }

            if (sizeFile > 1024)
            {
                sizeFile = sizeFile / 1024;
                razmer = "Гб";
            }
        }
        

        /// <summary>
        /// Проставляет размер файла
        /// </summary>
        public void SetSizeFile()
        {
            long allSize = 0;
            string razmer = "байт";

            foreach (ListViewItem item in lvFile.Items)
            {
                string sFile = item.Text;
                if(item.SubItems.Count < 2)
                    item.SubItems.Add("");

                if (!System.IO.File.Exists(sFile))
                {
                    item.SubItems[1].Text = "Нету";
                }
                else
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(sFile);
                    long sizeFile = fi.Length;
                    allSize = allSize + sizeFile;
                    razmer = "байт";
                    GetRazmernost(ref sizeFile, ref razmer);
                    item.SubItems[1].Text = string.Format("{0} {1}", sizeFile, razmer);
                }
            }
            razmer = "байт";
            GetRazmernost(ref allSize, ref razmer);
            lbAllSize.Text = string.Format("Общий размер файлов {0} {1}", allSize, razmer);
        }

        /// <summary>
        /// Добавить в список файл
        /// </summary>
        public void AddAttachFile()
        {
            dlgSelectFile.Filter = "*.*|*.*";
            dlgSelectFile.Title = "Добавление файла";
            dlgSelectFile.Multiselect = true;
            ListViewItem[] listItem;
            if (dlgSelectFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string sFile in dlgSelectFile.FileNames)
                    if (sFile.Trim() != string.Empty)
                    { 
                        listItem = lvFile.Items.Find(sFile,true);
                        if (listItem.Count() > 0)
                        { 
                            string msg = string.Format("Файл уже есть в списке...\n{0}",sFile);
                            MessageBox.Show(msg, "Уже есть", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            continue;
                        }
                        ListViewItem item = new ListViewItem();
                        item.Text = sFile;
                        item.Name = sFile;
                        item.SubItems.Add("");
                        lvFile.Items.Add(item);
                    }
                SetSizeFile(); // Указываем размеры файлов
            }
            
        }

        /// <summary>
        /// Удалить один файл из спика
        /// </summary>
        public void DelAttachFile()
        {
            if (lvFile.SelectedItems.Count == 0)
            {
                MessageBox.Show("Нет выбранного файла для замены", "Выберите файл", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sFile = lvFile.SelectedItems[0].Text;
            string msg = string.Format("Хотите удалить файл из списка?\n{0}", sFile);
            DialogResult rez = MessageBox.Show(msg, "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
            {
                lvFile.Items.Remove(lvFile.SelectedItems[0]);
                SetSizeFile();
            }

        }

        /// <summary>
        /// Удалить все файлы в списке
        /// </summary>
        public void DelAllAttachFile()
        {
            int count_item = lvFile.Items.Count - 1;
            if (count_item < 0)
            {
                MessageBox.Show("Нет файлов в списке","Нечего удалять...",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            DialogResult rez = MessageBox.Show("Хотите удалить ВСЕ файлы из списка", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
            {
                for (int i = count_item; i >= 0; i--)
                {
                    ListViewItem item = lvFile.Items[i];
                    lvFile.Items.Remove(item);
                }
                SetSizeFile();
            }
        }

        /// <summary>
        /// Заменить файл на другой
        /// </summary>
        public void EditAttachFile()
        {
            if (lvFile.SelectedItems.Count == 0)
            {
                MessageBox.Show("Нет выбранного файла для замены","Выберите файл",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            string sFile = lvFile.SelectedItems[0].Text;
            sFile = System.IO.Path.GetFileName(sFile);

            dlgSelectFile.Filter = "*.*|*.*";
            dlgSelectFile.Title = string.Format("Замена файла {0}", sFile);
            dlgSelectFile.Multiselect = false;
            ListViewItem[] listItem;
            if (dlgSelectFile.ShowDialog() == DialogResult.OK)
            {
                sFile = dlgSelectFile.FileName;
                listItem = lvFile.Items.Find(sFile,true);

                if (listItem.Count() > 0)
                {
                    string msg = string.Format("Файл уже есть в списке...\n{0}", sFile);
                    MessageBox.Show(msg, "Уже есть", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ListViewItem item = lvFile.SelectedItems[0];
                item.Text = sFile;
                item.Name = sFile;       
            }

        }

        public string FileAttach 
        {
            get 
            {
                string result = "";
                foreach (ListViewItem item in lvFile.Items)                
                    result = result + item.Text + ";";                
                return result;
            }
            set 
            {
                lvFile.Items.Clear();
                string[] list = value.Split(';');
                foreach (string sFile in list)
                    if (sFile.Trim() != string.Empty)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = sFile;
                        item.Name = sFile;
                        lvFile.Items.Add(item);
                    }
                SetSizeFile();
            }        
        }

        public frmAttach()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butAddFile_Click(object sender, EventArgs e)
        {
            AddAttachFile();
        }

        private void butReplaceFile_Click(object sender, EventArgs e)
        {
            EditAttachFile();
        }

        private void butDelFile_Click(object sender, EventArgs e)
        {
            DelAttachFile();
        }

        private void butDelAllFile_Click(object sender, EventArgs e)
        {
            DelAllAttachFile();
        }

        private void frmAttach_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Delete: 
                    DelAttachFile();
                    break;
                case Keys.Insert:
                    AddAttachFile();
                    break;
                 
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            return;            
        }



    }
}
