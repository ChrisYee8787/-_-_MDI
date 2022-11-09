using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace 康家_藥物疾病列表
{
    public partial class frm_疾病選單 : Form
    {
        dbClassEntities db = new dbClassEntities();

        public frm_疾病選單()
        {
            InitializeComponent();
        }
        
        private string select;
        
        public string selected
        {
            get { return select; }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_search.Text == "")
            {
                MessageBox.Show("請輸入欲搜尋之疾病編碼或中文名稱", "錯誤");
                return;
            }
            
            listBox1.Items.Clear();
            string search = txt_search.Text.Trim().ToUpper();
            string sql = $"select * from 疾病總表 where 疾病ID like @search " +
                         $"or 疾病中文名 like @search";

            ShowDiseaseInfo(sql, search);
        }
        private void ShowDiseaseInfo(string sql,string search)
        {
            var q = from d in db.疾病總表
                    where d.ID_Disease.Contains(txt_search.Text.Trim().ToUpper())
                    select d;
            foreach(var c in q.ToList())
            {
                listBox1.Items.Add(c.ID_Disease+" "+c.DiseaseChineseName);
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (select == null)
            {
                MessageBox.Show("尚未選擇目標疾病","警告");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                listBox1.SelectedIndex = 0;
            select = listBox1.SelectedItem.ToString();
        }
    }
}
