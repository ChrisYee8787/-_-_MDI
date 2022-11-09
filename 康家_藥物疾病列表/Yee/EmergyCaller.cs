using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 康家_藥物疾病列表
{
    public partial class EmergyCaller : Form
    {
        int num;
     
        List<PatientInfo> patientInfos = new List<PatientInfo>();
        public EmergyCaller()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            var Q = from Patient in db.PatientInfo.AsEnumerable()
                    select Patient;
            patientInfos.AddRange(Q);
            foreach(var ID in Q)
            {
                LB_NAME.Items.Add(ID.fName);
            }
            LB_NAME.SelectedIndex = 0;
        }

        private void LB_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LB_NAME.SelectedIndex = -1;
            dbClassEntities db = new dbClassEntities();
            //if (LB_NAME.SelectedIndex > -1)
            //{
                var id = patientInfos[LB_NAME.SelectedIndex].fid.ToString();

                var q = from Caller in db.EmergenceCaller.AsEnumerable()
                        where Caller.fPatientId == Convert.ToInt32(id)
                        select new
                        {
                            Caller.fid,
                            Caller.fEmergencyName,
                            Caller.frelation,
                            Caller.fPhone,
                            Caller.fPatientId
                        };

                dataGridView1.DataSource = q.ToList();
            
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            ADDCALLER a = new ADDCALLER();
            a.textBox4.Text=patientInfos[LB_NAME.SelectedIndex].fName.ToString();
            a.textBox5.Text = patientInfos[LB_NAME.SelectedIndex].fid.ToString();
            a.ShowDialog();
            dbClassEntities db = new dbClassEntities();
            var q = from caller in db.EmergenceCaller.AsEnumerable()
                    select caller;
            dataGridView1.DataSource = q.ToList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            

        }

        private void 固定資料()
        {
            ADDCALLER a = new ADDCALLER();
            a.textBox4.Text = patientInfos[LB_NAME.SelectedIndex].fName.ToString();
            a.textBox5.Text = patientInfos[LB_NAME.SelectedIndex].fid.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            UPDATECALLER call = new UPDATECALLER();
            call.textBox4.Text = patientInfos[LB_NAME.SelectedIndex].fName.ToString();
            call.textBox5.Text = patientInfos[LB_NAME.SelectedIndex].fid.ToString();
            num= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue);
            call.aa = num;
            var Q = from caller in db.EmergenceCaller
                    where caller.fid == num
                    select caller;
            foreach (var caller in Q)
            {
                call.textBox1.Text = caller.fEmergencyName is null ? "":caller.fEmergencyName.ToString();
                call.textBox2.Text= caller.frelation is null ? "":caller.frelation.ToString();
                call.textBox3.Text= caller.fPhone is null ? "":caller.fPhone.ToString();
            }
            call.ShowDialog();
            var q = from caller in db.EmergenceCaller.AsEnumerable()
                    select caller;
            dataGridView1.DataSource = q.ToList();
            db.SaveChanges();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            var q = from caller in db.EmergenceCaller.AsEnumerable()
                    select caller;
            dataGridView1.DataSource = q.ToList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (num == 0)
                return;
            dbClassEntities db = new dbClassEntities();
            var q = (from caller in db.EmergenceCaller.AsEnumerable()
                    where caller.fid == num
                    select caller).First();
            db.EmergenceCaller.Remove(q);
            db.SaveChanges();
            var C = from caller in db.EmergenceCaller.AsEnumerable()
                    select caller;
            dataGridView1.DataSource = C.ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         num = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LB_NAME.Items.Clear();
            patientInfos.Clear();
            dbClassEntities db = new dbClassEntities();
            var q = from p in db.PatientInfo.AsEnumerable()
                    where p.fName.Contains(txt_search.Text.Trim())
                    select p;
            patientInfos.AddRange(q);
            if (q.ToList().Count <= 0)
            {
                MessageBox.Show("查無資料");
                return;
            }
            foreach (var c in q)
            {
                
                LB_NAME.Items.Add(c.fName);
            }
            
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = string.Empty;
        }
    }
}
