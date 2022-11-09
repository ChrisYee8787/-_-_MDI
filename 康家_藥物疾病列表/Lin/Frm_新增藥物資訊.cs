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
    public partial class Frm_新增藥物資訊 : Form
    {
        public Frm_新增藥物資訊()
        {
            InitializeComponent();
        }
        dbClassEntities db = new dbClassEntities();
        public string name { get; set; }
         int iriguchi =0;
        public void settextbox(string set)
        {
            iriguchi = 1;
            txt_DrugChineseName.Text = set;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(txt_DrugChineseName.Text == "")
            {
                MessageBox.Show("請輸入藥品名稱");
                txt_DrugChineseName.Focus();
                return;
            }
            else if(txt_DrugInfo.Text == ""){
                MessageBox.Show("請輸入藥品資訊");
                txt_DrugInfo.Focus();
                return;
            }
            var q = from c in db.藥物資訊清單.AsEnumerable()
                    where c.MedicineChineseName == txt_DrugChineseName.Text
                    select c;
            
            if (q.ToList().Count!=0)
            {
                MessageBox.Show("錯誤:已有同名藥物");
            }
            else
            {
                db.藥物資訊清單.Add(new 藥物資訊清單
                {
                    MedicineChineseName = txt_DrugChineseName.Text,
                    MedicineInformation = txt_DrugInfo.Text
                }) ;
                db.SaveChanges();
                MessageBox.Show("新增成功");
                //如果是從查詢表單進來，新增完就關閉
                if (iriguchi == 1) Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_新增藥物資訊_Load(object sender, EventArgs e)
        {
            txt_DrugChineseName.Text = name;
        }
    }
}
