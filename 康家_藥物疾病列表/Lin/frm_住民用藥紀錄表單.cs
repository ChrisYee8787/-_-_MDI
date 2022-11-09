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
using 康家_藥物疾病列表.Model;
using 康家_藥物疾病列表;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace 康家_藥物疾病列表
{
    public partial class frm_住民用藥紀錄表單 : Form
    {
        dbClassEntities db = new dbClassEntities();
        public c住民用藥 file = new c住民用藥();
        
        public frm_住民用藥紀錄表單()
        {
            InitializeComponent();

        }
        void resetall()
        {
            
            var q = from c in db.藥物服用時間
                    select c;
            foreach (var c in q)
            {
                cmb_服藥時間.Items.Add(c.MedicineTakeTime);
            }

            var q2 = from c in db.藥物使用方法
                    select c;
            foreach (var c in q2)
            {
                cmb_藥物用法.Items.Add(c.MedicineUsage);
            }

            var q3 = from c in db.藥物計量單位
                    select c;
            foreach (var c in q3)
            {
                cmb_計量單位.Items.Add(c.Medicine_Unit);
            }
        }

        private void btn_搜尋病人資料(object sender, EventArgs e)
        {

        }

        private void btn_ok(object sender, EventArgs e)
        {
            file.drug_name = txt_藥品名稱.Text;
            file.drug_taketime = cmb_服藥時間.Text.ToString();
            file.drug_usage = cmb_藥物用法.Text.ToString();
            file.drug_dosage = txt_藥物劑量.Text + cmb_計量單位.Text.ToString();
            file.remark = txt_Remark.Text;
            DialogResult = DialogResult.OK;
            Close();
        }


        private void btn_cancel2(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_藥物查詢(object sender, EventArgs e)
        {
            frm_藥物表單 f = new frm_藥物表單();
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK) return;
            string drug = f.selected;
            char[] ca = drug.ToCharArray();
            for(int i = 0; i < ca.Length; i++)
            {
                if (ca[i]==' ')
                {
                    drug = drug.Remove(0,i+1);
                    break;
                }
            }
            txt_藥品名稱.Text = drug;
        }

        private void frm_住民用藥紀錄表單_Load(object sender, EventArgs e)
        {
            resetall();
            update_insert();

        }

        private void update_insert()
        {
            int useless;
            if (file.drug_name != null)
            {
                //txt_病人id.Text = file.fid.ToString();
                txt_藥品名稱.Text = file.drug_name;
                txt_Remark.Text = file.remark;
                cmb_服藥時間.SelectedText = file.drug_taketime;
                cmb_藥物用法.SelectedText = file.drug_usage;
                string array = file.drug_dosage;
                for (int i = 0; i < array.Length;i++ )
                {
                    if (int.TryParse(array[i].ToString(),out useless)==false)
                    {
                        txt_藥物劑量.Text = file.drug_dosage.Remove(i);
                        cmb_計量單位.Text = file.drug_dosage.Remove(0,2);
                        break;

                    }
                }
                cmb_藥物用法.Text = file.drug_usage;
                cmb_服藥時間.Text = file.drug_taketime;
            }
        }

        private void cmb_藥物用法_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

}
