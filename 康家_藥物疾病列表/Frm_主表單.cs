using RehabilitationForm.GroupActivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace 康家_藥物疾病列表
{
    public partial class Frm_主表單 : Form
    {

        public int getLoginID = 1;
        public string getLoginName = "測試者";
        public string getLoginRank = "職員";

        public Frm_主表單()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.IsMdiContainer = true;

        }
        public void openFrm(Form ff)
        {
            ff.MdiParent = this;
            ff.Show();
            ff.WindowState = FormWindowState.Maximized;
        }
        public void openFrm_noMax(Form ff)
        {
            ff.MdiParent = this;
            ff.Show();
            ff.WindowState = FormWindowState.Normal;

        }
        private void KillAllChildren()
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }
        private void btn_疾病表單(object sender, EventArgs e)
        {
            KillAllChildren();
            frm_康家居民疾病資料 f = new frm_康家居民疾病資料();
            openFrm(f);
        }

        private void btn_藥物表單(object sender, EventArgs e)
        {
            KillAllChildren();
            frm_康家居民用藥資訊_新 f = new frm_康家居民用藥資訊_新();
            openFrm(f);
        }

        private void btn_close(object sender, EventArgs e)
        {
            Close();
        }
        private void 垂直式排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }
        private void 水平式排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void 階梯式排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }
        private void 關閉全部視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillAllChildren();
        }

        private void Frm_主表單_KeyPress(object sender, KeyPressEventArgs e)
        {
            //switch (e.KeyChar.ToString().ToUpper())
            //{
            //    case "F":
            //        檔案FToolStripMenuItem.PerformClick();

            //        break;
            //}
            //MessageBox.Show(e.KeyChar.ToString());

        }

        private void Frm_主表單_KeyDown(object sender, KeyEventArgs e)
        {
            //F E V W O



        }

        private void 開啟病人表單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillAllChildren();
            frm_康家居民疾病資料 f = new frm_康家居民疾病資料();
            openFrm(f);
        }

        private void 開啟藥物表單(object sender, EventArgs e)
        {
            KillAllChildren();
            frm_康家居民用藥資訊_新 f = new frm_康家居民用藥資訊_新();
            openFrm(f);
        }

        private void 功能評估(object sender, EventArgs e)
        {
            KillAllChildren();
            frm_功能評估表 f = new frm_功能評估表();
            openFrm(f);
        }

        private void btn_住民資料(object sender, EventArgs e)
        {
            KillAllChildren();
            frm_住民資料表 f = new frm_住民資料表();
            openFrm(f);
        }

        private void btn_會談表單(object sender, EventArgs e)
        {
            KillAllChildren();
            frm_Consult f = new frm_Consult();
            openFrm(f);
        }

        private void groupActivityMDI_Click(object sender, EventArgs e)
        {
            KillAllChildren();
            openFrm(new GroupActivityMenu());
        }

        private void btn_藥物表單2(object sender, EventArgs e)
        {
            KillAllChildren();
            openFrm(new frm_康家居民用藥資訊_新());
        }

        private void 檔案FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_緊急聯絡人(object sender, EventArgs e)
        {
            KillAllChildren();
            openFrm(new EmergyCaller());
        }
    }
}
