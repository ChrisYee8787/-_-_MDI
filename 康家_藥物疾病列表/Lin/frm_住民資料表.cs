using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 康家_藥物疾病列表
{
    public partial class frm_住民資料表 : Form
    {
        public frm_住民資料表()
        {
            InitializeComponent();
        }
        int num;
        private void Form1_Load(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            var Q = from Patient in db.PatientInfo
                    select new
                    {
                       
                            編號 = Patient.fid,
                            姓名 = Patient.fName,
                            身分證字號 = Patient.fIdnum,
                            床位 = Patient.fBednum,
                            地址 = Patient.fAddress
          };
       
            dataGridView1.DataSource = Q.ToList();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            num = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue);
            dbClassEntities db = new dbClassEntities();
            var q = from Patient in db.PatientInfo
                    where Patient.fid == num
                    select Patient;
            foreach (var P in q)
            {
                txtName.Text = P.fName;
                txtBedNum.Text = P.fBednum;
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            num = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue);
            dbClassEntities db = new dbClassEntities();
            var Q = from Patient in db.PatientInfo
                    where Patient.fid == num
                    select Patient;
            frm_DetailInfo c = new frm_DetailInfo();
            foreach(var B in Q)
            {
                c.textbox1.Text = B.fid.ToString();
                c.txtName.Text = B.fName;
                c.txtSex.Text = B.fSex;
                c.txtDate.Text = B.fCheckin;
                c.txtIDNumber.Text = B.fIdnum;
                c.txtBedNum.Text = B.fBednum;
                c.txtBirth.Text = B.fBirthday;
                c.txtPhone.Text = B.fHomeNum;
                c.txtMobile.Text = B.fPhone;
                c.txtedu.Text = B.fEdu;
                c.txtmarriage.Text = B.fMarried;
                c.txtAddress.Text = B.fAddress;
                c.txtRefHos.Text = B.fHos;
                c.txtIdentity.Text = B.fIDY;
                c.txtGrant.Text = B.fGrant;
            }
            c.button2.Visible = false;
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_DetailInfo d = new frm_DetailInfo();
            d.button4.Visible = false;
            d.ShowDialog();
            dbClassEntities db = new dbClassEntities();
            var Q = from Patient in db.PatientInfo
                    select new
                    {

                        編號 = Patient.fid,
                        姓名 = Patient.fName,
                        身分證字號 = Patient.fIdnum,
                        床位 = Patient.fBednum,
                        地址 = Patient.fAddress
                    };

            dataGridView1.DataSource = Q.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num == 0)
                return;
            dbClassEntities db = new dbClassEntities();
            var q = (from caller in db.PatientInfo.AsEnumerable()
                     where caller.fid == num
                     select caller).First();
            db.PatientInfo.Remove(q);
            db.SaveChanges();
            MessageBox.Show("刪除成功!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            var Q = from Patient in db.PatientInfo
                    select new
                    {

                        編號 = Patient.fid,
                        姓名 = Patient.fName,
                        身分證字號 = Patient.fIdnum,
                        床位 = Patient.fBednum,
                        地址 = Patient.fAddress
                    };

            dataGridView1.DataSource = Q.ToList();
        }
    }
}
