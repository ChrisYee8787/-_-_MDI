using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using 康家_藥物疾病列表;

namespace WindowsFormsApp1
{
    public partial class frm_疾病診斷表 : Form
    {
        public frm_疾病診斷表()
        {
            InitializeComponent();

        }
        private cDisease disease = new cDisease();

        public string patient_name { get; set; }
        public int fid { get; set; }
        public cDisease out_disease
        {
            get { return disease; }
            set {
               // out_disease = value;
                
                txt_病人id.Text = value.dis_PatientID.ToString();
                txt_疾病ID.Text = value.dis_DiseaseID.ToString();
             //   txt_class.Text = value.dis_類別;
                txt_ChineseName.Text = value.dis_中文名稱;
                txt_section.Text = value.dis_科別;
                txt_Remark.Text = value.dis_備註;
            }
        }
        private void frm_產品資料編輯_Load(object sender, EventArgs e)
        {
            txt_病人id.Text = patient_name;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_病人id.Text))
            {
                MessageBox.Show("病人ID不得為空");
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
            disease.dis_PatientID = fid;
            disease.dis_DiseaseID = txt_疾病ID.Text;
            disease.dis_中文名稱 = txt_ChineseName.Text;
            disease.dis_備註 = txt_Remark.Text;
            
            this.Close();
        }
        public string[] GetStrings()
        {

            string[] str = new string[4];
            str[0] = txt_病人id.Text;
            str[1] = txt_class.Text;
            str[2] = txt_section.Text;
            str[3] = txt_ChineseName.Text;
            return str;
        }

        private void frm_產品資料編輯_Resize(object sender, EventArgs e)
        {
       
        }

        private void txt_疾病ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            frm_疾病選單 f = new frm_疾病選單();
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK)
            {
                string inpt = f.selected;
                string id="";
                char[] cname = inpt.ToCharArray();
                for (int i = 0; i < cname.Length; i++)
                {
                    if (cname[i] == ' ')
                    {
                        id = inpt.Remove(i);
                        inpt = inpt.Remove(0, i+1);
                        break;
                    }
                }
                txt_疾病ID.Text = id;
                txt_ChineseName.Text = inpt;
            }
        }
    }
}
