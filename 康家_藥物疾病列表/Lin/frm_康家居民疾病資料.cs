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
using 康家_藥物疾病列表;

namespace WindowsFormsApp1
{
    public partial class frm_康家居民疾病資料 : Form
    {
        dbClassEntities db = new dbClassEntities();
        List<int> list_id = new List<int>();
        List<int> list_gdv_diseaseID = new List<int>();
        List<string> list_name = new List<string>();
        int position = -1;

        public frm_康家居民疾病資料()
        {
            InitializeComponent();
        }

        private void frm_ProductList_Load(object sender, EventArgs e)
        {
            openListBox();
        }
        private void openListBox()
        {
            listbox_disease.Items.Clear();
            list_id.Clear();
            list_name.Clear();
            var q2 = from p in db.PatientInfo
                     select p;
            foreach (var c in q2)
            {
                list_id.Add(c.fid);
                list_name.Add(c.fName);
                listbox_disease.Items.Add(c.fid+" "+c.fName);
            }
            listbox_disease.SelectedIndex = -1;
        }
        private void openGridView()
        {           
            position = -1;
            list_gdv_diseaseID.Clear();
            var q = from c in db.疾病診斷.AsEnumerable()
                    where c.fid == list_id[listbox_disease.SelectedIndex]
                    select new
                    {
                        疾病編號 = c.ID_Disease,
                        疾病中文名 = c.DiseaseChineseName,
                        備註 = c.Remark
                    };
            var q2 = from c in db.疾病診斷.AsEnumerable()
                     where c.fid == list_id[listbox_disease.SelectedIndex]
                     select c.ID_Patient_Disease;
            foreach (var c in q2)
                list_gdv_diseaseID.Add(c);
            dataGridView1.DataSource = q.ToList();
        }

        void GridViewReset()
        {
            if(dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Columns[0].Width = Width / 7;
                dataGridView1.Columns[1].Width = Width / 3;
                dataGridView1.Columns[2].Width = Width / 2;
            }

            bool ischanges = true;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.Font = new Font("微軟正黑體", 15);
                if(ischanges)
                    row.DefaultCellStyle.BackColor = Color.White;
                else
                    row.DefaultCellStyle.BackColor= Color.LightGray;
                ischanges = !ischanges;
            }
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (listbox_disease.SelectedIndex < 0)
            {
                MessageBox.Show("請先選擇欲新增的住民", "錯誤");
                return;
            }
            frm_疾病診斷表 frm = new frm_疾病診斷表();
            frm.patient_name = list_name[listbox_disease.SelectedIndex];
            frm.fid = list_id[listbox_disease.SelectedIndex];
            frm.ShowDialog();


            if (frm.DialogResult != DialogResult.OK) return;
            db.疾病診斷.Add(new 疾病診斷
            {
                fid = frm.out_disease.dis_PatientID,
                ID_Disease = frm.out_disease.dis_DiseaseID,
                DiseaseChineseName = frm.out_disease.dis_中文名稱,
                Remark = frm.out_disease.dis_備註                
            }) ;
            db.SaveChanges();
            openGridView();
            GridViewReset();
            frm.Dispose();
        }
        private void btn_stored_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("資料更新失敗，放棄吧放棄吧");
            }
            finally
            {
                MessageBox.Show("資料更新成功");
            }
            openGridView();
            GridViewReset();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (position < 0) return; ;
            var q = (from c in db.疾病診斷.AsEnumerable()
                    where c.ID_Patient_Disease == list_gdv_diseaseID[position]
                    select c).First();
            db.疾病診斷.Remove(q);
            db.SaveChanges();
            openGridView();
            GridViewReset();
        }
        private void frm_ProductList_MaximumSizeChanged(object sender, EventArgs e)
        {
            GridViewReset();

        }

        private void frm_ProductList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult re = MessageBox.Show("是否儲存最後修改資訊?", "表單即將關閉", MessageBoxButtons.YesNo);
            //if (re == DialogResult.Yes)
            //{
                db.SaveChanges();
            //}
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (position < 0) return;
            cDisease p = new cDisease();
            var q = (from d in db.疾病診斷.AsEnumerable()
                     where d.ID_Patient_Disease == list_gdv_diseaseID[position]
                     select d).First();
            p.dis_PatientID = (int)q.fid;
            p.dis_DiseaseID = Convert.ToString(q.ID_Patient_Disease);
            //  p.dis_類別 = Convert.ToString(row["DiseaseClass"]);
            //  p.dis_科別 = Convert.ToString(row["Section"]);
            p.dis_中文名稱 = q.DiseaseChineseName;
            p.dis_備註 = q.Remark;

            frm_疾病診斷表 frm = new frm_疾病診斷表();
            frm.out_disease = p;
            frm.patient_name = list_name[listbox_disease.SelectedIndex];
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {               
                q.ID_Disease = frm.out_disease.dis_DiseaseID;
                q.ID_Patient_Disease = frm.out_disease.dis_PatientID;
                q.DiseaseChineseName = frm.out_disease.dis_中文名稱;
                q.Remark = frm.out_disease.dis_備註;
            }
            //    row["DiseaseClass"] = frm.out_disease.dis_類別;
            //   q. = frm.out_disease.dis_科別;
            openGridView();
            GridViewReset();
            frm.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            listbox_disease.Items.Clear();
            list_id.Clear();
            list_name.Clear();
            int id;

            var q = from p in db.PatientInfo.AsEnumerable()
                where p.fName.Contains(txt_search.Text.Trim().ToLower())
                select p;
            if (int.TryParse(txt_search.Text,out id))
            {
                q = from p in db.PatientInfo.AsEnumerable()
                        where p.fid == Convert.ToInt32(txt_search.Text)
                        select p;
            }

            if (q.ToList().Count <= 0)
            {
                MessageBox.Show("查無資料");
                return;
            }
            foreach (var c in q)
            {
                list_id.Add(c.fid);
                list_name.Add(c.fName);
                listbox_disease.Items.Add(c.fid + " " + c.fName);
            }
            listbox_disease.SelectedIndex = 0;        
        }

        private void listbox_disease_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_disease.SelectedIndex >= 0)
            {
                openGridView();
                GridViewReset();
            }
        }
        
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_ProductList_Resize(object sender, EventArgs e)
        {
        }

        private void frm_ProductList_ResizeEnd(object sender, EventArgs e)
        {
            GridViewReset();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            openListBox();
            dataGridView1.DataSource = null;
        }
    }
}
