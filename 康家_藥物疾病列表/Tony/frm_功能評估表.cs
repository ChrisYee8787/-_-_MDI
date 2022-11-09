using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 康家_藥物疾病列表
{
    public partial class frm_功能評估表 : Form
    {
        public frm_功能評估表()
        {
            InitializeComponent();
            load_cmb(cmb_Question);
        }
        dbClassEntities db = new dbClassEntities();
        int num = 0;
        System.Windows.Forms.TextBox txt;
        List<System.Windows.Forms.Label> labels = new List<System.Windows.Forms.Label>();
        List<System.Windows.Forms.TextBox> txts = new List<System.Windows.Forms.TextBox>();
        List<int> list_id = new List<int>();
        //List<int> list_gdv_diseaseID = new List<int>();
        List<string> list_cmb_select = new List<string>();
        List<string> list_name = new List<string>();
        int position = -1;
        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_tall.Text == "" || txt_weight.Text == "")
            {
                MessageBox.Show("請輸入身高體重");
                txt_tall.Focus();
                return;
            }
            db.功能評估.Add(new 功能評估
            {
                fid = list_id[position],
                f日期 = dateTimePicker1.Value.ToShortDateString(),
                f身高 = decimal.Parse(txt_tall.Text.Trim()),
                f體重 = decimal.Parse(txt_weight.Text.Trim())
            }) ;
            db.SaveChanges();
            var q = (from c in db.功能評估.AsEnumerable()
                     where c.fid == list_id[position] && c.f日期 == dateTimePicker1.Value.ToShortDateString()
                     select c.f功能評估ID).First();
            int i = 0;
            int txt_now=0;
            while (txts.Count != 0)
            {
                db.功能評估個表.Add(new 功能評估個表
                {
                    f功能評估ID = q,
                    f評估項目 = list_cmb_select[i],
                    f現狀評估 = txts[txt_now].Text,
                    f問題 = txts[txt_now+1].Text,
                    f復健目標 = txts[txt_now+2].Text,
                    f復健計畫 = txts[txt_now+3].Text,
                }) ;
                i++;
                txts.RemoveRange(0,4);
            }
            db.SaveChanges();
            MessageBox.Show("儲存成功");
        }
        private void openListBox()
        {
            listbox_Patient.Items.Clear();
            list_id.Clear();
            list_name.Clear();
            var q2 = from p in db.PatientInfo
                     select p;
            foreach (var c in q2)
            {
                list_id.Add(c.fid);
                list_name.Add(c.fName);
                listbox_Patient.Items.Add(c.fid + " " + c.fName);
            }
            listbox_Patient.SelectedIndex = -1;
        }
        private void load_cmb(System.Windows.Forms.ComboBox cmb)
        {
            cmb.Items.Add("衛生習慣");
            cmb.Items.Add("居家清潔");
            cmb.Items.Add("飲食起居");
            cmb.Items.Add("認知能力");
            cmb.Items.Add("體能表現");
            cmb.Items.Add("人際互動");
            cmb.Items.Add("烹飪能力");
            cmb.Items.Add("休閒安排");
            cmb.Items.Add("財務管理");
            cmb.Items.Add("健康促進");
        }

        private void cmb_Question_SelectionChangeCommitted(object sender, EventArgs e)
        {
            list_cmb_select.Add(cmb_Question.SelectedItem.ToString());
            System.Windows.Forms.Label tye = new System.Windows.Forms.Label();
            tye.Text = cmb_Question.SelectedItem.ToString() + "";
            tye.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
            tye.BorderStyle = BorderStyle.FixedSingle;
            flp_Add(tye);

            load_setTxtAndLabel("現狀評估:");
            load_setTxtAndLabel("問題:");
            load_setTxtAndLabel("復健目標:");
            load_setTxtAndLabel("復健計畫:");

            for (int i = num - 4; i < num; i++)
            {
                flp_流動評估表.Controls.Add(labels[i]);
                flp_流動評估表.Controls.Add(txts[i]);
            }
        }

        private void load_setTxtAndLabel(string str)
        { 
            labels.Add(new System.Windows.Forms.Label());
            labels[num].Text = str;
            labels[num].Font = new Font("微軟正黑體", 12);

            txt = load_textbox();
            txt.Font = new Font("微軟正黑體", 11);
            txts.Add(txt);
            num++;
        }
        private void load_history(string str,string detail)
        {
            labels.Add(new System.Windows.Forms.Label());
            labels[num].Text = str;
            labels[num].Font = new Font("微軟正黑體", 12);

            txt = load_textbox();
            txt.Text = detail;
            txt.Font = new Font("微軟正黑體", 11);
            txts.Add(txt);
            num++;
        }
        private void flp_Add(Control control)
        {
            flp_流動評估表.Controls.Add(control);
            flp_流動評估表.SetFlowBreak(control, true);
        }

        private System.Windows.Forms.TextBox load_textbox()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            txt.Multiline = true;
            txt.Size = new System.Drawing.Size(flp_流動評估表.Width -100 , 100);

            return txt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int f功能評估ID=-1;
        List<int> list_date_history = new List<int>(); 
        private void listbox_Patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            position = listbox_Patient.SelectedIndex;
            if (position < 0) return;
            DialogResult d = MessageBox.Show("是否重新選擇目標住民?\n當前評估資料若尚未儲存將全部消失", "警告", MessageBoxButtons.YesNo);
            if (d == DialogResult.No) return;
            num = 0;
            dateTimePicker1.Enabled = true;
            txts.Clear();
            labels.Clear();
            flp_流動評估表.Controls.Clear();
            list_cmb_select.Clear();
            list_date_history.Clear();
            listbox_history.Items.Clear();
            f功能評估ID = -1;
            //選取居民後，重置所有資料
            label_Name.Text = list_name[listbox_Patient.SelectedIndex];
            txt_tall.Text = "";
            txt_weight.Text = "";

            var q = from c in db.功能評估.AsEnumerable()
                    where c.fid == list_id[position]
                    select c;
            foreach(var c in q.ToList())
            {
                list_date_history.Add(c.f功能評估ID);
                listbox_history.Items.Add(c.f日期);
            }          
        }

        private void listbox_history_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("是否開啟歷史表單?\n表單開啟時候，當前尚未處理的資料將全部消失", "表單即將重整", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;
            num = 0;
            dateTimePicker1.Enabled = false;
            f功能評估ID = list_date_history[listbox_history.SelectedIndex];
            var q = (from c in db.功能評估
                    where c.f功能評估ID == f功能評估ID
                    select c).First();
            var q2 = from c in db.功能評估個表
                     where c.f功能評估ID == f功能評估ID
                     select c;
            label_Name.Text = list_name[position].ToString();
            txt_tall.Text = q.f身高.ToString();
            txt_weight.Text = q.f體重.ToString();
            BMI_Count();
            flp_流動評估表.Controls.Clear();

            foreach(var c in q2.ToList())
            {
                System.Windows.Forms.Label tye = new System.Windows.Forms.Label();
                tye.Text = c.f評估項目;
                tye.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                tye.BorderStyle = BorderStyle.FixedSingle;
                flp_Add(tye);

                load_history("現狀評估",c.f現狀評估);
                load_history("問題",c.f問題);
                load_history("復健目標",c.f復健目標);
                load_history("復健計畫",c.f復健計畫);

                for (int i = num - 4; i < num; i++)
                {
                    flp_流動評估表.Controls.Add(labels[i]);
                    flp_流動評估表.Controls.Add(txts[i]);
                }
            }
        }
        private void frm_功能評估表_Load(object sender, EventArgs e)
        {
            openListBox();
        }

        private void txt_weight_TextChanged(object sender, EventArgs e)
        {
            decimal tall;
            decimal weight;
            if(!decimal.TryParse(txt_tall.Text,out tall))
            {
                MessageBox.Show("");
                return;
            }
            if (!decimal.TryParse(txt_weight.Text, out weight))
            {
                MessageBox.Show("");

                return;
            }
            tall /= 100;
            decimal bmi = weight / (tall * tall);
            bmi = decimal.Round(bmi, 2, MidpointRounding.AwayFromZero);
            label_BMI.Text = bmi.ToString();
            MessageBox.Show(bmi.ToString());
        }

        private void btn_bmi_Click(object sender, EventArgs e)
        {
            BMI_Count();
        }

        private void BMI_Count()
        {
            decimal tall;
            decimal weight;
            if (!decimal.TryParse(txt_tall.Text, out tall))
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            if (!decimal.TryParse(txt_weight.Text, out weight))
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            tall /= 100;
            decimal bmi = weight / (tall * tall);
            bmi = decimal.Round(bmi, 2, MidpointRounding.AwayFromZero);
            label_BMI.Text = bmi.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //先刪除全部舊有資料表後重新新增
            if (txt_tall.Text == "" || txt_weight.Text == "")
            {
                MessageBox.Show("請輸入身高體重");
                txt_tall.Focus();
                return;
            }
            //var q1 = (from c in db.功能評估.AsEnumerable()
            //         where c.f功能評估ID == f功能評估ID
            //         select c.f功能評估ID).First();
            //q.
            db.功能評估.Add(new 功能評估
            {
                fid = list_id[position],
                f日期 = dateTimePicker1.Value.ToShortDateString(),
                f身高 = decimal.Parse(txt_tall.Text),
                f體重 = decimal.Parse(txt_weight.Text)
            });
            db.SaveChanges();
            var q = (from c in db.功能評估.AsEnumerable()
                     where c.fid == list_id[position] && c.f日期 == dateTimePicker1.Value.ToShortDateString()
                     select c.f功能評估ID).First();
            int i = 0;
            int txt_now = 0;
            while (txts.Count != 0)
            {
                db.功能評估個表.Add(new 功能評估個表
                {
                    f功能評估ID = q,
                    f評估項目 = list_cmb_select[i],
                    f現狀評估 = txts[txt_now].Text,
                    f問題 = txts[txt_now + 1].Text,
                    f復健目標 = txts[txt_now + 2].Text,
                    f復健計畫 = txts[txt_now + 3].Text,
                });
                i++;
                txts.RemoveRange(0, 4);
            }
            db.SaveChanges();
            MessageBox.Show("修改成功");
        }
    }
}
