
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 康家_藥物疾病列表;

namespace RehabilitationForm.GroupActivity
{
    public partial class GroupActivityMenu : Form
    {

        Form MDImain = Application.OpenForms["Frm_主表單"];
        Frm_主表單 getMDI;

        public GroupActivityMenu()
        {
            InitializeComponent();
        }

        private void GroupActivityMenu_Load(object sender, EventArgs e)
        {
            getMDI = (Frm_主表單)MDImain;
            if (getMDI.getLoginID > 0)
            {
                lbl_loginER.Text = getMDI.getLoginName  + "   " + getMDI.getLoginRank;

            }
            string sql = "select fgroupactivityid as '記錄編號ID', fEventType as '團體計畫',fDate as '日期',fStartTime as '開始時間',fEndTime as '結束時間',fClassName as '課程名稱',fLocation as '地點',fPeopleCount as '人數',fFillFormStaff as '填表人',fFillFormDate as '填表日期' from [dbo].[tGroupActivity]";
            DataTable dt = new Utility().exeReader(sql, null);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Columns[i].Width = 130;
            }
        }

        private void GroupActivityMenu_ResizeEnd(object sender, EventArgs e)
        {

        }

            int getMenuGroupActivitySelectID;
        private void dgv_GroupActivityList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show($"{dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue}");
            //dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString()
            if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(), out getMenuGroupActivitySelectID)){
                MessageBox.Show("並未正確選擇ROW取得groupActivityID");
                return;
            }

            DialogResult Result = MessageBox.Show("要修改嗎", "提示", MessageBoxButtons.OKCancel);

            if (Result == DialogResult.OK)
            {
                getMDI = (Frm_主表單)MDImain;
                GroupActivityForm gaf = new GroupActivityForm();
                gaf.getUpdateSwitch = getMenuGroupActivitySelectID;
                gaf.getLoginRankInGAF = getMDI.getLoginRank;
                getMDI.openFrm(gaf);

            }
            else if (Result == DialogResult.Cancel)
            {
                return;
            }
        }
        
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
          
            getMDI = (Frm_主表單)MDImain;
           GroupActivityForm gaf = new GroupActivityForm();
            gaf.getInsertSwith = getMDI.getLoginID; //因為不能讓別的模式也讓他跑這條所以要鎖在INSERT模式這邊
            gaf.getLoginRankInGAF = getMDI.getLoginRank;
            getMDI.openFrm(gaf);
            
        }
    }
}
