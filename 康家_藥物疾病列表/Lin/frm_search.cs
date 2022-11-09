using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_search : Form
    {
        public frm_search()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text))
                MessageBox.Show("請輸入欲搜尋的姓名");
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }
        public string get_search
        { 
            get { return txt_search.Text; }
        }
    }
}
