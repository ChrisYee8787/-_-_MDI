using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 康家_藥物疾病列表
{
    public partial class frm_藥物表單 : Form
    {
        dbClassEntities db = new dbClassEntities();
        List<int> list = new List<int>();
        public frm_藥物表單()
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
            if (txt_search.Text == "")
            {
                MessageBox.Show("請輸入欲搜尋之藥物ID或中文名稱", "錯誤");
                return;
            }
            listBox1.Items.Clear();
            string search = txt_search.Text.Trim().ToUpper();

            var q = from c in db.藥物資訊清單
                    where c.MedicineChineseName.Contains(search)
                    select c;

            if (q.ToList().Count == 0)
            {
                DialogResult check = MessageBox.Show("查無資料，是否新增?", "錯誤", MessageBoxButtons.YesNo);
                if (check == DialogResult.Yes)
                {
                    Frm_新增藥物資訊 frm = new Frm_新增藥物資訊();
                    frm.settextbox(txt_search.Text);
                    frm.name = txt_search.Text;
                    frm.ShowDialog();
                }
            }
            foreach (var r in q.ToList())
            {
                listBox1.Items.Add(r.ID_Medicine.ToString() + " " + r.MedicineChineseName.ToString());
            }
            ShowMedicineInfo(search);
        }
        private void ShowMedicineInfo(string search)
        {
            var q = from c in db.藥物資訊清單
                    select c;
            foreach (var r in q.ToList())
            {
                listBox1.Items.Add(r.ID_Medicine.ToString() + " " + r.MedicineChineseName.ToString());
            }
            if (q.ToList().Count==0)
            {
                DialogResult check = MessageBox.Show("查無資料，是否新增?", "錯誤", MessageBoxButtons.YesNo);
                if (check == DialogResult.Yes)
                {
                    Frm_新增藥物資訊 frm = new Frm_新增藥物資訊();
                    frm.settextbox(txt_search.Text);
                    frm.Show();
                }
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_insert(object sender, EventArgs e)
        {
            Frm_新增藥物資訊 frm = new Frm_新增藥物資訊();
            frm.name = txt_search.Text;
            frm.Show();
            ShowAllMedicine();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                listBox1.SelectedIndex = 0;
            select = listBox1.SelectedItem.ToString();
        }
        private void btn_藥物詳情_Click(object sender, EventArgs e)
        {
            var q = (from c in db.藥物資訊清單.AsEnumerable()
                    where c.ID_Medicine == list[listBox1.SelectedIndex]
                    select c).First();
            MessageBox.Show(q.MedicineInformation,"藥物詳情");
        }

        private void frm_藥物表單_Load(object sender, EventArgs e)
        {
            ShowAllMedicine();
        }

        private void ShowAllMedicine()
        {
            listBox1.Items.Clear();
            var q = from c in db.藥物資訊清單
                    select c;
            foreach (var r in q.ToList())
            {
                list.Add(r.ID_Medicine);
                listBox1.Items.Add(r.ID_Medicine.ToString() + " " + r.MedicineChineseName.ToString());
            }
        }
    }
}
