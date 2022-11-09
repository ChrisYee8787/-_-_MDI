using RehabilitationForm.utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RehabilitationForm
{
    public partial class PersonalPerformance : UserControl
    {
        public PersonalPerformance()
        {
            InitializeComponent();
            new Utility().ReadOrModifyResxData("comboxEmotions.resx", "", cbx_Emotions,"未參與", "高亢/興奮", "愉快/平穩", "淡漠/平板", "焦慮/緊張", "憤怒/煩躁");
            new Utility().ReadOrModifyResxData("comboxParticipatePersistence.resx", "", cbx_ParticipatePersistence, "未參與", "全程參與", "部分參與", "偶有參與", "幾乎不參與");
            new Utility().ReadOrModifyResxData("comboxCooperate.resx", "", cbx_Cooperate, "未參與", "主動配合", "被動配合", "偶有配合", "拒絕配合");
            new Utility().ReadOrModifyResxData("comboxHumanInteraction.resx", "", cbx_HumanInteraction, "未參與", "主動與人互動", "能與交談", "偶有簡單回應", "答非所問/無邏輯", "意念飛躍/話多");
            new Utility().ReadOrModifyResxData("comboxAttentionRes.resx", "", cbx_Attention, "未參與", "全程專心", "偶有分心", "專注度差", "渙散嗜睡", "症狀干擾");
            new Utility().ReadOrModifyResxData("comboxParticipatePerformance.resx", "", cbx_ParticipatePerformance, "未參與", "可獨自完成", "少量協助", "部分完成", "大量協助");

            loadResidentName();

            comboboxWheelSwith();
        }

        private void loadResidentName()
        {
            //string sql = "select fid,fName from PatientInfo ";
            //DataTable dt = new Utility().exeReader(sql, null);


            tbx_ppResidentName.Text = "";   


        }

        private void comboboxWheelSwith()
        {
            //MouseEventHandler meh = new MouseEventHandler((_, __) => { ((HandledMouseEventArgs)__).Handled = true; });
            if (classForStatic.comboboxWheel == "1")
            {
                foreach (Control item in Controls)
                {
                    if (item is ComboBox) { ((ComboBox)item).MouseWheel += classForStatic.meh; }
                }
            }
            else if (classForStatic.comboboxWheel == "0")
            {
                foreach (Control item in Controls)
                {
                    if (item is ComboBox) ((ComboBox)item).MouseWheel -= classForStatic.meh;
                }
            }
        }


        private void PeopleClose_Click(object sender, EventArgs e)
        {
            //Control parentControl = Parent;
            //Parent.Controls.Remove(this);
            //parentControl.Focus();
            this.Dispose();
        }

        private void btn_uc_personperformCopy_Click(object sender, EventArgs e)
        {
            PersonalPerformance ppCopy = new PersonalPerformance();

            ppCopy.cbx_Emotions.SelectedIndex = this.cbx_Emotions.SelectedIndex;
            ppCopy.cbx_ParticipatePersistence.SelectedIndex = this.cbx_ParticipatePersistence.SelectedIndex;
            ppCopy.cbx_Cooperate.SelectedIndex = this.cbx_Cooperate.SelectedIndex;
            ppCopy.cbx_HumanInteraction.SelectedIndex = this.cbx_HumanInteraction.SelectedIndex;
            ppCopy.cbx_Attention.SelectedIndex = this.cbx_Attention.SelectedIndex;
            ppCopy.cbx_ParticipatePerformance.SelectedIndex = this.cbx_ParticipatePerformance.SelectedIndex;
            //ppCopy.cbx_ppResidentName.SelectedIndex = this.cbx_ppResidentName.SelectedIndex;
            Parent.Controls.Add(ppCopy);
        }
    }
}
