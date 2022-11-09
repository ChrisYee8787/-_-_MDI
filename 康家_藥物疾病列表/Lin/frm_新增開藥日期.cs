using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 康家_藥物疾病列表
{
    public partial class frm_新增開藥日期 : Form
    {
        public frm_新增開藥日期()
        {
            InitializeComponent();
        }
        public int fid { get; set; }
        public string drugDate { get; set; }
        public string entry { get; set; }
        List<int> list_id = new List<int>();
        private void frm_新增開藥日期_Load(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            var q = from c in db.PatientInfo
                    orderby c.fid
                    select c;
            
            foreach (var r  in q.ToList())
            {
                list_id.Add(r.fid);
                listBox1.Items.Add(r.fid+" "+r.fName);
            }
            listBox1.SelectedIndex = -1;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(txt_住民id或姓名.Text.Trim() == "")
            {
                MessageBox.Show("請於左側選單點選住民資訊");
                return;
            }
            fid = list_id[listBox1.SelectedIndex];
            drugDate = dateTimePicker1.Value.ToShortDateString();
            DialogResult = DialogResult.OK;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_住民id或姓名.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
            catch
            {
                MessageBox.Show("錯誤:未正確點選清單內容");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            if (txt_search.Text.Trim() == "")
            {
                MessageBox.Show("請輸入查詢文字");
                return;
            }
            int id;
            var q = from c in  db.PatientInfo.AsEnumerable()
                    where c.fName.Contains(txt_search.Text.Trim())
                    select new
                    {
                        c.fid,
                        c.fName
                    };
            if (int.TryParse(txt_search.Text, out id))
            {
                q = from c in db.PatientInfo.AsEnumerable()
                    where c.fid == Convert.ToInt32(txt_search.Text.Trim())
                    select new
                    {
                        c.fid,
                        c.fName
                    };
            }
            if (q.ToList().Count <= 0)
            {
                MessageBox.Show("查無資料(英文有分大小寫)");
                return;
            }
            listBox1.Items.Clear();
            foreach (var r in q.ToList())
            {
                list_id.Add(r.fid);
                listBox1.Items.Add(r.fid+" "+r.fName);
            }
            listBox1.SelectedIndex = -1;
        }
    }
}
