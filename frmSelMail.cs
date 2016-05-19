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
    public partial class frmSelMail : Form
    {
        public System.Windows.Forms.ListView lvData{ 
            get { return lvMail; }
        }

        public frmSelMail()
        {
            InitializeComponent();
        }

        private void butCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMail.Items)
            {
                item.Checked = true;
            }
        }

        private void butUnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMail.Items)
            {
                item.Checked = false;
            }
        }

        private void butSendMail_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMail.Items)
            {
                // Если хоть одна почта помечена то выходим
                if (item.Checked)
                {
                    DialogResult = DialogResult.OK;
                    return;
                }
            }
            MessageBox.Show("Укажите хоть один почтовый адрес", "Нечего отправлять", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }


    }
}
