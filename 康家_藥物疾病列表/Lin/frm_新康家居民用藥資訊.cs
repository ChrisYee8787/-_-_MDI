using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 康家_藥物疾病列表.Model;

namespace 康家_藥物疾病列表
{
    public partial class frm_康家居民用藥資訊_新 : Form
    {
        dbClassEntities db = new dbClassEntities();

        public frm_康家居民用藥資訊_新()
        {
            InitializeComponent();
        }
        List<int> list_日期id = new List<int>();
        List<int> list_個人資訊id = new List<int>();
        int open_data_id;
        private void frm_用藥紀錄表單_日期_Load(object sender, EventArgs e)
        {
            reloadListbox();
        }
        void GridViewReset()
        {
            if (DGV_Detail.Rows.Count <= 0) return;
            DGV_Detail.Columns[0].Width = Width / 7;
            DGV_Detail.Columns[1].Width = Width / 6;
            DGV_Detail.Columns[2].Width = Width / 5;
            DGV_Detail.Columns[3].Width = Width / 10;
            DGV_Detail.Columns[4].Width = Width / 5;
            bool ischanges = true;
            foreach (DataGridViewRow row in DGV_Detail.Rows)
            {
                row.DefaultCellStyle.Font = new Font("微軟正黑體", 15);
                if (ischanges)
                    row.DefaultCellStyle.BackColor = Color.White;
                else
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                ischanges = !ischanges;
            }
        }
        private void reloadListbox()
        {
            listBox1.Items.Clear();
            var q = from c in db.病人開藥日期
                    join p in db.PatientInfo
                    on c.fid equals p.fid
                    select new
                    {
                        c.fid,
                        c.ID_GetMedicineDate,
                        c.Date_GetMedicine,
                        p.fName
                    };          
            foreach (var r in q.ToList())
            {                
                list_日期id.Add(r.ID_GetMedicineDate);
                listBox1.Items.Add(r.fName + " " + r.Date_GetMedicine);
            }
            listBox1.SelectedIndex = -1;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            frm_新增開藥日期 f = new frm_新增開藥日期();
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK) return;
            db.病人開藥日期.Add(new 病人開藥日期
            {
                fid = f.fid,
                Date_GetMedicine = f.drugDate
            });
            list_日期id.Clear();
            db.SaveChanges();
            reloadListbox();
            f.Dispose();
        }
        

        private void btn_open_Click(object sender, EventArgs e)
        {

        }
        //OK
        private void openView()
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("尚未選取欲展開的居民資訊");
                return;
            }
            btn_delete用藥紀錄.Enabled = true;
            btn_Insert用藥紀錄.Enabled = true;
            btn_update用藥紀錄.Enabled = true;
            open_data_id = list_日期id[listBox1.SelectedIndex];

            list_個人資訊id.Clear();
            var q = from c in db.病人用藥資訊
                where c.ID_GetMedicineDate == open_data_id
                select new{
                    藥物名稱 = c.MedicineChineseName,
                    藥物用法 = c.MedicineUsage,
                    服藥時間 = c.MedicineTakeTime,
                    藥物劑量 = c.MedicineDosage,
                    備註 = c.MedicineADDInfo
                };
            var q2 = from c in db.病人用藥資訊
                    where c.ID_GetMedicineDate == open_data_id
                    select new
                    {
                        編號 = c.ID_Patient_Medicine_Info,
                    };
            foreach (var r in q2.ToList())
            {
                list_個人資訊id.Add(r.編號);
            }
            DGV_Detail.DataSource = q.ToList();
            GridViewReset();
        }

        private void btn_insert_用藥紀錄(object sender, EventArgs e)
        {


            frm_住民用藥紀錄表單 frm = new frm_住民用藥紀錄表單();
            frm.ShowDialog();
            if (frm.DialogResult != DialogResult.OK) return;
            db.病人用藥資訊.Add(new 病人用藥資訊
            {
               ID_GetMedicineDate = open_data_id,
               MedicineChineseName = frm.file.drug_name,
               MedicineUsage = frm.file.drug_usage,
               MedicineTakeTime = frm.file.drug_taketime,
               MedicineDosage = frm.file.drug_dosage,
               MedicineADDInfo = frm.file.remark
            });
            db.SaveChanges();
            openView();
        }

        int position_detail = -1;

        private void btn_update_用藥紀錄(object sender, EventArgs e)
        {
            if (position_detail < 0) return;
            var r = (from s in db.病人用藥資訊.AsEnumerable()
                    where s.ID_Patient_Medicine_Info == list_個人資訊id[position_detail]
                    select s).First();
            
            c住民用藥 c = new c住民用藥();
            c.drug_name = r.MedicineChineseName.ToString();
            c.drug_taketime = r.MedicineTakeTime.ToString();
            c.drug_usage = r.MedicineUsage.ToString();
            c.drug_dosage = r.MedicineDosage.ToString();
            c.remark = r.MedicineADDInfo.ToString();

            frm_住民用藥紀錄表單 f = new frm_住民用藥紀錄表單();
            f.file = c;
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                r.MedicineChineseName = f.file.drug_name;
                r.MedicineTakeTime = f.file.drug_taketime;
                r.MedicineUsage = f.file.drug_usage;
                r.MedicineDosage = f.file.drug_dosage;
                r.MedicineADDInfo = f.file.remark;
            }
            db.SaveChanges();
            openView();
            
            f.Dispose();
        }

        private void btn_storage_detail(object sender, EventArgs e)
        {
        }

        private void DGV_Detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position_detail = e.RowIndex;
        }

        private void btn_delete_detail(object sender, EventArgs e)
        {
            if (position_detail < 0) return;
            var q = (from c in db.病人用藥資訊.AsEnumerable()
                     where c.ID_Patient_Medicine_Info == list_個人資訊id[position_detail]
                     select c).First();
            db.病人用藥資訊.Remove(q);
            db.SaveChanges();
            openView();
            position_detail = -1;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("刪除日期資訊時，會連帶刪除該日期下所有藥物資訊，是否刪除?", "警告", MessageBoxButtons.YesNo))
                return;
            var d = from c in db.病人用藥資訊.AsEnumerable()
                    where c.ID_GetMedicineDate == list_日期id[listBox1.SelectedIndex]
                     select c;
            var d2 = (from c in db.病人開藥日期.AsEnumerable()
                     where c.ID_GetMedicineDate == list_日期id[listBox1.SelectedIndex]
                     select c).First();
            foreach(var c in d)
                 db.病人用藥資訊.Remove(c);

            db.病人開藥日期.Remove(d2);
            
            db.SaveChanges();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox1.SelectedIndex = -1;
            DGV_Detail.DataSource = null;
            MessageBox.Show("刪除成功");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            frm_新增開藥日期 f = new frm_新增開藥日期();
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK) return;
            var q = (from c in db.病人開藥日期.AsEnumerable()
                    where c.ID_GetMedicineDate == list_日期id[listBox1.SelectedIndex]
                    select c).First();
            q.fid = f.fid;
            q.Date_GetMedicine = f.drugDate;

            db.SaveChanges();
            reloadListbox();
            f.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1) return;
            openView();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Trim() == "")
            {
                MessageBox.Show("請輸入查詢文字");
                return;
            }
            int id;
            var q = from c in db.病人開藥日期.AsEnumerable()
                    join p in db.PatientInfo
                    on c.fid equals p.fid
                    where p.fName.Contains(txt_search.Text.Trim())
                    select new
                    {
                        c.fid,
                        c.ID_GetMedicineDate,
                        c.Date_GetMedicine,
                        p.fName
                    };
            if (int.TryParse(txt_search.Text, out id))
            {
                q = from c in db.病人開藥日期.AsEnumerable()
                    join p in db.PatientInfo
                    on c.fid equals p.fid
                    where p.fid == Convert.ToInt32(txt_search.Text)
                    select new
                    {
                        c.fid,
                        c.ID_GetMedicineDate,
                        c.Date_GetMedicine,
                        p.fName
                    };
            }
            if (q.ToList().Count <= 0)
            {
                MessageBox.Show("查無資料(英文有分大小寫)");
                return;
            }
            listBox1.Items.Clear();
            list_日期id.Clear();
            foreach (var r in q.ToList())
            {
                list_日期id.Add(r.ID_GetMedicineDate);
                listBox1.Items.Add(r.fName + " " + r.Date_GetMedicine);
            }
            listBox1.SelectedIndex = -1;
            
        }

        private void btn_reset(object sender, EventArgs e)
        {
            reloadListbox();
            btn_delete用藥紀錄.Enabled = false;
            btn_Insert用藥紀錄.Enabled = false;
            btn_update用藥紀錄.Enabled = false;
            DGV_Detail.DataSource = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
