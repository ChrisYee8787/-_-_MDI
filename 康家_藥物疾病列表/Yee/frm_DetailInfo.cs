using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 康家_藥物疾病列表

{
    public partial class frm_DetailInfo : Form
    {
        public frm_DetailInfo()
        {
            InitializeComponent();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            int num = Convert.ToInt32(textbox1.Text);
            var q = from Patient in db.PatientInfo
                    where Patient.fid==num
                    select Patient;
            foreach (var caller in q)
            {
                 caller.fName=txtName.Text;
                 caller.fSex=txtSex.Text;
                caller.fCheckin=txtDate.Text;
                 caller.fIdnum=txtIDNumber.Text;
                caller.fBednum= txtBedNum.Text;
                 caller.fBirthday=txtBirth.Text;
                caller.fHomeNum =txtPhone.Text;
                 caller.fPhone=txtMobile.Text;
                 caller.fEdu=txtedu.Text;
              caller.fMarried =txtmarriage.Text  ;
                 caller.fAddress=txtAddress.Text;
                  caller.fHos=txtRefHos.Text;
                  caller.fIDY=txtIdentity.Text;
                  caller.fGrant=txtGrant.Text;
            }
            db.SaveChanges();
            MessageBox.Show("資料修改完成");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbClassEntities db = new dbClassEntities();
            PatientInfo p = new PatientInfo
            {
                fName = txtName.Text,
                fSex = txtSex.Text,
                fCheckin = txtDate.Text,
                fIdnum = txtIDNumber.Text,
                fBednum = txtBedNum.Text,
                fBirthday = txtBirth.Text,
                fHomeNum = txtPhone.Text,
                fPhone = txtMobile.Text,
                fEdu = txtedu.Text,
                fMarried = txtmarriage.Text,
                fAddress = txtAddress.Text,
                fHos = txtRefHos.Text,
                fIDY = txtIdentity.Text,
                fGrant = txtGrant.Text
            };
            db.PatientInfo.Add(p);
            db.SaveChanges();

            MessageBox.Show("新增資料成功");
           
            Close();
        }
    }
}
