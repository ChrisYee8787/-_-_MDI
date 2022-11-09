
using RehabilitationForm.CustomComponents;
using RehabilitationForm.utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;

namespace RehabilitationForm
{
    public partial class GroupActivityForm : Form
    {
        string staffName;
        bool comformNoPicIs = true;
        public int getUpdateSwitch = -1;
        public int getInsertSwith = -1;
        public string getLoginRankInGAF = "";
        List<string> picPath = new List<string>();
        public GroupActivityForm()
        {
            InitializeComponent();

        }

        private void GroupActivityForm_Load(object sender, EventArgs e)
        {

            ComboBox comBox = new ComboBox();
            comBox.Tag = 0; //當update時 tag要用1才不會一直亂生，但邊還是要tag =0才正常
            ThemeComboxGetcallSelf(comBox);
            new Utility().ReadOrModifyResxData("EventTypeCombox.resX", "", cbx_EventType, "體能", "烹飪", "護理衛教", "家事清潔", "財務管理", "休閒娛樂", "社區適應討論會", "住民自治會議");
            if (getInsertSwith > 0) { staffName = getStaffID(getInsertSwith); }

        }



        private void GroupActivityForm_Shown(object sender, EventArgs e)
        {
            new Utility().getResxLikeOptions("Options.resx");
            comboboxWheelOrNot();
            if (getUpdateSwitch > 0)
            {
                btn_GroupActivityUpdate.Visible = true;
                btn_GroupActivityADD.Visible = false;
                getGroupActivityMainResultForUpdate();
                getGroupActivityClassThemeForUpdate();
                getScheduleDetailsForUpdate();
                getGroupActivityPicAndFilesForUpdate();
                getPersonalPerformanceForUpdate();

            }
        }



        void ThemeComboxGetcallSelf(ComboBox xb)
        {
            xb.Font = new Font("微軟正黑體", 12);
            new Utility().ReadOrModifyResxData("ClassThemeListCombox.resx", "", xb, "衛生習慣", "居家清潔", "飲食起居", "認知能力", "體能表現", "人際互動", "烹飪能力", "休閒安排", "財務管理", "健康促進");
            xb.Width = 100;
            //xb.Tag = 0;
            //xb.Text = "課程主題";
          
                xb.SelectedIndex = xb.FindString(xb.Text);
            
            xb.SelectedIndexChanged += (_, __) =>
            {
                if (Convert.ToInt32(xb.Tag) == 0) ThemeComboxGetcallSelf(new ComboBox());   //第一次才給貼下一個
                xb.Tag = 1; //改了就不是第一次了
                lbx_calendarTheme.Items.Clear();    //為了先清舊的
                foreach (Control item in xb.Parent.Controls)
                {
                    lbx_calendarTheme.Items.Add(((ComboBox)item).Text); //月曆那邊也要貼一下
                }
                comboboxWheelOrNot();
                //if (xb.Parent.Controls.Count == 1) { xb.Tag = 0; }  //刪到剩1個時要可以重新加
            };


            flp_classTheme.Controls.Add(xb);

        }



        private void btn_ScheduleAdd_Click(object sender, EventArgs e)
        {
            ScheduleDetails sd = new ScheduleDetails();
            //ControlExtension.Draggable(sd,true);
            flp_ScheduleDetails.Controls.Add(sd);
        }

        private void btn_ScheduleRemove_Click(object sender, EventArgs e)
        {

            if (flp_ScheduleDetails.Controls.Count <= 0) return;
            flp_ScheduleDetails.Controls.RemoveAt(flp_ScheduleDetails.Controls.Count - 1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flp_ScheduleDetails.Controls.Count <= 0) return;
            foreach (ScheduleDetails item in flp_ScheduleDetails.Controls)
            {
                foreach (var itemInSD in item.Controls)
                {
                    if (itemInSD is DateTimePicker)
                    {
                        MessageBox.Show(((DateTimePicker)itemInSD).Name);
                    }
                }
            }

        }

        private void btn_picAPic_Click(object sender, EventArgs e)  //點圖加進flowlayoutpanel
        {
            if (flp_picAPic.Controls.Count >= 4)
            {
                btn_picAPic.Text = "最多4張";
                return;
            }
            else
            {
                btn_picAPic.Text = "選擇圖片";
            }
            //bool firstResXisNull = false;
            OpenFileDialog GetPhoto = new OpenFileDialog();
            GetPhoto.Filter = "images | *.jpg|images | *.png|Bitmap Image|*.bmp|Gif Image|*.gif|all file|*.*";
            if (GetPhoto.ShowDialog() == DialogResult.OK)
            {
                string fileName = GetPhoto.FileName.Split('\\')[GetPhoto.FileName.Split('\\').Length - 1];
                picPath.Add(GetPhoto.FileName); //為了要記"長path"
                try
                {

                    if (GetPhoto.FileName.EndsWith(".jpg") || GetPhoto.FileName.EndsWith(".png") || GetPhoto.FileName.EndsWith(".bmp") || GetPhoto.FileName.EndsWith(".gif"))
                    {
                        Image oImage = Image.FromFile(GetPhoto.FileName);

                        if (File.Exists(Application.StartupPath + @"\LocalResX.resx"))
                        {
                            //==================
                            new Utility().resXModify("LocalResX.resx", fileName, oImage, false, "", false);

                        }
                        else
                        {
                            ResXResourceWriter resourceWriter = new ResXResourceWriter("LocalResX.resx");

                            resourceWriter.AddResource(fileName, oImage);

                            resourceWriter.Close();
                        }

                    }
                    else { throw new ArgumentException(); }

                }
                catch (FileNotFoundException caught)
                {

                    MessageBox.Show("Source: " + caught.Source + " Message: " + caught.Message);
                    return;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message + "\r\n請選擇圖檔");
                    return;
                }
                finally
                {
                    imageReload();
                }


            }


        }

        private void imageReload()  //先load看看有沒圖，沒有就try掉 return
        {
            flp_picAPic.Controls.Clear();
            //.Controls.Clear();
            ResXResourceReader resReader = null;
            try

            {

                //Create a new ResXResource reader and set the resx path to resxPathName

                resReader = new ResXResourceReader("LocalResX.resx");

                //Enumerate the elements within the resx file and dispaly them

                foreach (DictionaryEntry d in resReader)

                {

                    PictureBox pbFormLoading = new PictureBox();
                    pbFormLoading.Image = (Image)d.Value;




                    makeflpWithPicAndWord(pbFormLoading, d.Key.ToString());


                }

                //Close the resxReader

                resReader.Close();

                //MessageBox.Show("Done");

            }

            //If the resx file represents some incoherences
            catch (FileNotFoundException fnfeEx)
            {
                //MessageBox.Show("暫無內容，請加入圖片");
                return;
            }
            catch (ArgumentException caught)

            {

                MessageBox.Show("Source: " + caught.Source + "Message: " + caught.Message);
                return;
            }
            finally
            {

                resReader.Close();
            }




        }

        private void makeflpWithPicAndWord(PictureBox picboxReal, string path)  //選圖之後要塞圖進flowlaypanel
        {

            picboxReal.SizeMode = PictureBoxSizeMode.Zoom;
            picboxReal.Size = new Size(190, 190);


            picboxReal.Click += (_, __) => picWhenClick(_, __, path);

            System.Windows.Forms.GroupBox gbForNameAndPicture = new System.Windows.Forms.GroupBox();
            gbForNameAndPicture.Size = new Size(picboxReal.Size.Width, picboxReal.Size.Height + 20);
            gbForNameAndPicture.Margin = new Padding(7, 7, 7, 7);
            gbForNameAndPicture.Controls.Add(picboxReal);



            System.Windows.Forms.Label wordInGroup = new System.Windows.Forms.Label();
            string lblTooLoneSol = path.Split('\\')[path.Split('\\').Length - 1];   //我一直以為是傳長PATH進來，結果只是短PATH而已
            wordInGroup.Text = lblTooLoneSol.Length > 12 ? lblTooLoneSol.Substring(0, 11) + "..." : lblTooLoneSol;
            wordInGroup.Location = new Point(0, picboxReal.Size.Height);
            gbForNameAndPicture.Controls.Add(wordInGroup);

            Button picDelButton = new Button();
            picDelButton.Size = new Size(50, 20);
            picDelButton.Text = "刪除";
            picDelButton.Location = new Point(picboxReal.Size.Width - picDelButton.Size.Width, picboxReal.Size.Height);
            picDelButton.Click += (_, __) =>
            {
                gbForNameAndPicture.Dispose();
                new Utility().resXModify("LocalResX.resx", lblTooLoneSol, null, true, "", false);
                picPath.Remove(picPath.Where(n => n.Split('\\')[n.Split('\\').Length - 1].ToString() == path).FirstOrDefault());
            };
            gbForNameAndPicture.Controls.Add(picDelButton);

            flp_picAPic.Controls.Add(gbForNameAndPicture);

            //flp_forPictureBox.Controls.Add(imageFormCustomer);
            //flp_forPictureBox.FlowDirection = FlowDirection.TopDown;
            //flp_forPictureBox.Controls.Add(wordInGroup);
        }
        private void picWhenClick(object sender, EventArgs e, string path)  //點圖放大
        {
            Form aPicShow = new Form();
            aPicShow.Size = new Size(500, 500);
            aPicShow.Text = path.Split('\\')[path.Split('\\').Length - 1];


            PictureBox pbTemp = new PictureBox();
            pbTemp.Size = new Size(aPicShow.Width, aPicShow.Height);
            pbTemp.SizeMode = PictureBoxSizeMode.Zoom;
            pbTemp.Image = ((PictureBox)sender).Image;


            aPicShow.SizeChanged += (_, __) => pbTemp.Size = new Size(aPicShow.Width, aPicShow.Height);
            //(sender2, e2) => aPicShowSizeChange(sender2, e2, pbTemp);

            aPicShow.Controls.Add(pbTemp);
            aPicShow.Show();
        }

        private void GroupActivityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (ResXResourceWriter writer = new ResXResourceWriter("LocalResX.resx"))    //圖的資源檔就可空白了，不然舊圖就會留著
            {
                writer.Close(); //只是會怕多寫一條
            }
        }

        private void picAFile_Click(object sender, EventArgs e)
        {
            if (lbx_picAFile.Items.Count > 0) { MessageBox.Show("已有檔案"); return; }

            OpenFileDialog GetPhoto = new OpenFileDialog();
            GetPhoto.Filter = "all file|*.*";
            if (GetPhoto.ShowDialog() == DialogResult.OK)
            {
                //lbx_picAFile.Items.Add(GetPhoto.FileName.Split('\\')[GetPhoto.FileName.Split('\\').Length - 1]);
                lbx_picAFile.Items.Add(GetPhoto.FileName);

            }
        }


        private void ResidentADD_Click(object sender, EventArgs e)
        {
            //List<ParamatsWithValueClass> lsp = new List<ParamatsWithValueClass>();
            //lsp.Add(new ParamatsWithValueClass { key="C",value= "衛生習慣" });
            //new Utility().exeReader(@"select * from 功能評估 where  @C  = 'true'", lsp);
            flp_PersonalPerformance.Controls.Add(new PersonalPerformance());
        }


        private void AllCompleteThenAdd_Click(object sender, EventArgs e)
        {
            string STRcbx_EventType = "";
            string STRdtp_classDate = "";
            string STRdtp_classTimeStart = "";
            string STRdtp_classTimeEnd = "";
            string STRtbx_groupName = "";
            string STRtbx_className = "";
            string STRflp_classTheme = "";
            string STRtbx_Goal = "";
            string STRtbx_Location = "";
            int STRtbx_PeopleCount = 0;
            string STRtbx_Leader = "";
            string STRtbx_Recorder = "";
            string STRtbx_Process = "";
            string STRtbx_Achievement = "";
            string STRtbx_FillFormStaff = "";
            string STRdtp_FillFormDate = "";
            if (flp_picAPic.Controls.Count == 0)
            {

                DialogResult Result = MessageBox.Show("並未傳圖，請問確認是否是之後再補圖？", "警告", MessageBoxButtons.OKCancel);

                if (Result == DialogResult.OK)
                {
                    comformNoPicIs = false; //確認之後才補圖時，就下面在跑機能組方法時false掉不跑
                }
                else if (Result == DialogResult.Cancel)
                {
                    MessageBox.Show("請加入圖片");
                    return;
                }

            }
            foreach (PersonalPerformance item in flp_PersonalPerformance.Controls)
            {
                if (item.Controls[23].Text == "") { MessageBox.Show("有住民名稱未填入"); return; }
                foreach (Control itemInPP in item.Controls)
                {
                    if (itemInPP is ComboBox)
                    {
                        if (((ComboBox)itemInPP).Text == "")
                        {
                            MessageBox.Show("有住民並未填入表現");
                            return;
                        }
                    }
                }
            }

            if (flp_PersonalPerformance.Controls.Count == 0) { MessageBox.Show("請加入住民"); return; }

            if (flp_ScheduleDetails.Controls.Count == 0) { MessageBox.Show("請加入行程"); return; }
            if (flp_classTheme.Controls[0].Text == "") { MessageBox.Show("請加入課程主題"); return; }
            List<string> listStringForCheckValue = new List<string>();

            STRcbx_EventType = cbx_EventType.Text;
            STRdtp_classDate = dtp_classDate.Text;
            STRdtp_classTimeStart = dtp_classTimeStart.Text;
            STRdtp_classTimeEnd = dtp_classTimeEnd.Text;
            STRtbx_groupName = tbx_groupName.Text;
            STRtbx_className = tbx_className.Text;
            foreach (Control item in flp_classTheme.Controls)
            {
                STRflp_classTheme += ((ComboBox)item).Text + " , ";
            }
            STRtbx_Goal = tbx_Goal.Text;
            STRtbx_Location = tbx_Location.Text;
            STRtbx_Leader = tbx_Leader.Text;
            STRtbx_Recorder = tbx_Recorder.Text;
            STRtbx_Process = tbx_Process.Text;
            STRtbx_Achievement = tbx_Achievement.Text;
            STRtbx_FillFormStaff = tbx_FillFormStaff.Text;
            STRdtp_FillFormDate = dtp_FillFormDate.Text;

            listStringForCheckValue.Add(STRcbx_EventType);
            listStringForCheckValue.Add(STRdtp_classDate);
            listStringForCheckValue.Add(STRdtp_classTimeStart);
            listStringForCheckValue.Add(STRdtp_classTimeEnd);
            listStringForCheckValue.Add(STRtbx_groupName);
            listStringForCheckValue.Add(STRtbx_className);
            listStringForCheckValue.Add(STRflp_classTheme);
            listStringForCheckValue.Add(STRtbx_Goal);
            listStringForCheckValue.Add(STRtbx_Location);       //少了的人數項目在下面try可以做檢查就不加了。
            listStringForCheckValue.Add(STRtbx_Leader);
            listStringForCheckValue.Add(STRtbx_Recorder);
            listStringForCheckValue.Add(STRtbx_Process);
            listStringForCheckValue.Add(STRtbx_Achievement);
            listStringForCheckValue.Add(STRtbx_FillFormStaff);
            listStringForCheckValue.Add(STRdtp_FillFormDate);


            try
            {
                STRtbx_PeopleCount = Convert.ToInt32(tbx_PeopleCount.Text);

                foreach (string item in listStringForCheckValue)
                {
                    if (item == "") { throw new FormatException(); } //因為不打字空字串去sql也會存空字串，不算null，所以會存下去，但設定是不能空白所以要檢查。
                }

            }
            catch (FormatException fe) { MessageBox.Show("有字串未正確輸入 數字 或 空白"); return; }
            catch (Exception ex)
            {
                MessageBox.Show($"發生 {ex.Message} 錯誤，請連絡管理員");
                return;
            }

            string sql = "INSERT INTO [dbo].[tGroupActivity](" +
                //"[fID]," +
                "[fEventType]," +
                "[fDate]," +
                "[fStartTime]," +
                "[fEndTime]," +
                "[fGroupName]," +
                "[fClassName]," +
                "[fGoal]," +
                "[fLocation]," +
                "[fPeopleCount]," +
                "[fLeader]," +
                "[fRecorder]," +
                "[fProcess]," +
                "[fAchievement]," +
                "[fFillFormStaff]," +
                "[fFillFormDate]" +
                ")VALUES(" +
                   //"@K_fID," +
                   "@K_fEventType," +
                      "@K_fDate," +
                         "@K_fStartTime," +
                            "@K_fEndTime," +
                               "@K_fGroupName," +
                                  "@K_fClassName," +
                                     "@K_fGoal," +
                                        "@K_fLocation," +
                                           "@K_fPeopleCount," +
                                              "@K_fLeader," +
                                                 "@K_fRecorder," +
                                                    "@K_fProcess," +
                                                       "@K_fAchievement," +
                                                          "@K_fFillFormStaff," +
                                                             "@K_fFillFormDate" +

                ");" +
                "SELECT SCOPE_IDENTITY(); ";

            List<ParamatsWithValueClass> paramatsWithValueClasses = new List<ParamatsWithValueClass>();
            //int IDscalar =Convert.ToInt32( new Utility().exeScalar(" select fGroupActivityID from tGroupActivity ", null));
            //paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key= "K_fID", value= (++IDscalar).ToString() });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fEventType", value = STRcbx_EventType });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fDate", value = STRdtp_classDate });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fStartTime", value = STRdtp_classTimeStart });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fEndTime", value = STRdtp_classTimeEnd });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fGroupName", value = STRtbx_groupName });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fClassName", value = STRtbx_className });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fGoal", value = STRtbx_Goal });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fLocation", value = STRtbx_Location });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fPeopleCount", value = STRtbx_PeopleCount.ToString() });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fLeader", value = STRtbx_Leader });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fRecorder", value = STRtbx_Recorder });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fProcess", value = STRtbx_Process });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fAchievement", value = STRtbx_Achievement });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fFillFormStaff", value = STRtbx_FillFormStaff });
            paramatsWithValueClasses.Add(new ParamatsWithValueClass() { key = "K_fFillFormDate", value = STRdtp_FillFormDate });


            string howsSuccess = new Utility().exeScalar(sql, paramatsWithValueClasses);    //新增活動資料庫一筆

            GroupActivityClassThemeADD(howsSuccess);    //課程主題關聯資料表新增
            ScheduleDetailsADD(howsSuccess);    //大綱排程關聯資料表新增
            PersonalPerformanceADD(howsSuccess);    //住民表現

            if (comformNoPicIs) { GroupActivityPicAndFilesADD(howsSuccess); }   //存圖與存檔的關聯資料表新增 //雖然沒圖但有答應事後再補 就會false掉不進去

            if (howsSuccess == "") { MessageBox.Show("資料新增失敗"); } else { MessageBox.Show($"1筆資料  {howsSuccess}  新增成功"); }

        }

        private void clanderCombox_selectIndexChang(object sender, EventArgs e)
        {
            if (cbx_clanderCombox.SelectedIndex == 0)       //選整天時少掉的控制項
            {
                dtp_calendarStartTime.Visible = false;
                dtp_calendarEndTime.Visible = false;
                dtp_calendarEndDay.Visible = false;
                lbl_calendarEnd.Visible = false;
            }
            else
            {
                dtp_calendarStartTime.Visible = true;
                dtp_calendarEndTime.Visible = true;
                dtp_calendarEndDay.Visible = true;
                lbl_calendarEnd.Visible = true;
            }
        }



        private void cbx_EventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_calendarEventType.Text = cbx_EventType.Text.Trim();
        }

        private void btn_demo_Click(object sender, EventArgs e)
        {
            cbx_EventType.SelectedIndex = 0;
            tbx_groupName.Text = "團體名稱";
            tbx_className.Text = "課程名稱";
            tbx_Goal.Text = "團體目的";
            tbx_Location.Text = "團體地點";
            tbx_PeopleCount.Text = "5";
            tbx_Leader.Text = staffName;
            tbx_Recorder.Text = staffName;
            tbx_Process.Text = "過程摘要";
            tbx_Achievement.Text = "成果簡述";
            tbx_FillFormStaff.Text = staffName;

        }

        private void btn_classThemeDelete_Click(object sender, EventArgs e)
        {
            if (flp_classTheme.Controls.Count <= 1) { return; }
            flp_classTheme.Controls[flp_classTheme.Controls.Count - 2].Tag = 0;
            flp_classTheme.Controls.RemoveAt(flp_classTheme.Controls.Count - 1);
            lbx_calendarTheme.Items.Clear();    //為了先清舊的
            foreach (Control item in flp_classTheme.Controls)
            {
                lbx_calendarTheme.Items.Add(((ComboBox)item).Text); //月曆那邊也要貼一下
            }
        }


        private void btn_option_Click(object sender, EventArgs e)
        {
            Option opn = new Option();
            opn.ShowDialog();
            if (opn.DialogResult == DialogResult.OK)
            {
                comboboxWheelOrNot();
                new Utility().ReadOrModifyResxData("Options.resx", "comboboxWheel", null, classForStatic.comboboxWheel);
            }
            else if (opn.DialogResult == DialogResult.Cancel)
            {
                //new Utility().resXModify("Options.resx", "comboboxWheel", null, false, Option.comboboxWheel);
            }
        }

        public void comboboxWheelOrNot()
        {

            if (classForStatic.comboboxWheel == "1")
            {
                foreach (var item in this.Controls)
                {
                    if (item is ComboBox) { ((ComboBox)item).MouseWheel += classForStatic.meh; }
                }
                foreach (var item in flp_classTheme.Controls)
                {
                    if (item is ComboBox) { ((ComboBox)item).MouseWheel += classForStatic.meh; }
                }
                foreach (PersonalPerformance item in flp_PersonalPerformance.Controls)
                {
                    foreach (Control itemInPP in item.Controls)
                    {
                        if (itemInPP is ComboBox) { ((ComboBox)itemInPP).MouseWheel += classForStatic.meh; }
                    }
                }
            }
            else if (classForStatic.comboboxWheel == "0")
            {
                foreach (var item in this.Controls)
                {
                    if (item is ComboBox) { ((ComboBox)item).MouseWheel -= classForStatic.meh; }
                }
                foreach (var item in flp_classTheme.Controls)
                {
                    if (item is ComboBox) { ((ComboBox)item).MouseWheel -= classForStatic.meh; }
                }
                foreach (PersonalPerformance item in flp_PersonalPerformance.Controls)
                {
                    foreach (Control itemInPP in item.Controls)
                    {
                        if (itemInPP is ComboBox) { ((ComboBox)itemInPP).MouseWheel -= classForStatic.meh; }
                    }
                }
            }
        }

        private void btn_GroupActivityDelete_Click(object sender, EventArgs e)
        {

        }


        //=================================================vvvADD   //主項目ADD完後加
        private void GroupActivityClassThemeADD(string id)
        {

            string sql = "INSERT INTO [dbo].[tGroupActivityClassTheme](" +

                "[fGroupActivityID]," +
                "[fClassTheme]) " +
                "VALUES(" +
                "@K_id," +
                "@K_ClassTheme" +
                ")";
            List<ParamatsWithValueClass> withValueList = new List<ParamatsWithValueClass>();

            foreach (Control item in flp_classTheme.Controls)
            {
                if (item is ComboBox && item.Text != "")
                {
                    withValueList.Add(new ParamatsWithValueClass { key = "K_id", value = id });
                    withValueList.Add(new ParamatsWithValueClass { key = "K_ClassTheme", value = (((ComboBox)item).SelectedIndex + 1).ToString() });  //要改成index制
                    new Utility().exeNonQuery(sql, withValueList);
                }
                withValueList = new List<ParamatsWithValueClass>();
            }
        }

        private void ScheduleDetailsADD(string id)
        {
            int count = 0;
            string sql = "INSERT INTO [dbo].[tScheduleDetails](" +
                "[fGroupActivityID]  ," +
                "[fStartTime] ," +
                "[fEndTime] ," +
                "[fDepiction]" +
                ") VALUES (" +
               "@K_id," +
                 "@K_StartTime," +
                   "@K_EndTime," +
                     "@K_Depiction" +
                ")";
            List<ParamatsWithValueClass> withValueList = new List<ParamatsWithValueClass>();
            foreach (ScheduleDetails item in flp_ScheduleDetails.Controls)
            {

                foreach (Control itemINflowlaypanel in item.Controls)
                {
                    if (itemINflowlaypanel.Name == "dtp_scheduleEnd") { withValueList.Add(new ParamatsWithValueClass { key = "K_EndTime", value = ((DateTimePicker)itemINflowlaypanel).Text }); }
                    if (itemINflowlaypanel.Name == "dtp_scheduleStart") { withValueList.Add(new ParamatsWithValueClass { key = "K_StartTime", value = ((DateTimePicker)itemINflowlaypanel).Text }); }
                    if (itemINflowlaypanel.Name == "tbx_Depiction") { withValueList.Add(new ParamatsWithValueClass { key = "K_Depiction", value = " 行程 " + (++count) + " : " + ((TextBox)itemINflowlaypanel).Text }); }
                }
                withValueList.Add(new ParamatsWithValueClass { key = "K_id", value = id });
                new Utility().exeNonQuery(sql, withValueList);
                withValueList = new List<ParamatsWithValueClass>();
            }
        }

        private void PersonalPerformanceADD(string id)
        {
            string sql = "INSERT INTO [dbo].[tPersonalPerformance](" +

                "[fGroupActivityID] ," +
                "[fResidentID] ," +
                "[fEmotions] ," +
                "[fParticipatePersistence] ," +
                "[fCooperate]  ," +
                "[fHumanInteraction]  ," +
                "[fAttention] ," +
                "[fParticipatePerformance]  ," +
                "[fDepiction]" +
                ") VALUES (" +
                 "@K_id," +
                 "@K_ResidentID," +
                 "@K_Emotions," +
                 "@K_ParticipatePersistence," +
                 "@K_Cooperate," +
                 "@K_HumanInteraction," +
                 "@K_Attention," +
                 "@K_ParticipatePerformance," +
                 "@K_Depiction" +
                ")";
            List<ParamatsWithValueClass> withValueList = new List<ParamatsWithValueClass>();
            foreach (PersonalPerformance item in flp_PersonalPerformance.Controls)
            {

                foreach (Control itemINflowlaypanel in item.Controls)
                {
                    if (itemINflowlaypanel.Name == "lbl_ResidentID") { withValueList.Add(new ParamatsWithValueClass { key = "K_ResidentID", value = itemINflowlaypanel.Text }); }
                    if (itemINflowlaypanel.Name == "cbx_Emotions") { withValueList.Add(new ParamatsWithValueClass { key = "K_Emotions", value = ((ComboBox)itemINflowlaypanel).Text }); }
                    if (itemINflowlaypanel.Name == "cbx_ParticipatePersistence") { withValueList.Add(new ParamatsWithValueClass { key = "K_ParticipatePersistence", value = ((ComboBox)itemINflowlaypanel).Text }); }
                    if (itemINflowlaypanel.Name == "cbx_Cooperate") { withValueList.Add(new ParamatsWithValueClass { key = "K_Cooperate", value = ((ComboBox)itemINflowlaypanel).Text }); }
                    if (itemINflowlaypanel.Name == "cbx_HumanInteraction") { withValueList.Add(new ParamatsWithValueClass { key = "K_HumanInteraction", value = ((ComboBox)itemINflowlaypanel).Text }); }
                    if (itemINflowlaypanel.Name == "cbx_Attention") { withValueList.Add(new ParamatsWithValueClass { key = "K_Attention", value = ((ComboBox)itemINflowlaypanel).Text }); }
                    if (itemINflowlaypanel.Name == "cbx_ParticipatePerformance") { withValueList.Add(new ParamatsWithValueClass { key = "K_ParticipatePerformance", value = ((ComboBox)itemINflowlaypanel).Text }); }
                    if (itemINflowlaypanel.Name == "tbx_ppRemark") { withValueList.Add(new ParamatsWithValueClass { key = "K_Depiction", value = ((TextBox)itemINflowlaypanel).Text }); }
                }
                withValueList.Add(new ParamatsWithValueClass { key = "K_id", value = id });
                new Utility().exeNonQuery(sql, withValueList);
                withValueList = new List<ParamatsWithValueClass>();
            }
        }

        private void GroupActivityPicAndFilesADD(string id)
        {
            string sql = "INSERT INTO [dbo].[tGroupActivityPicAndFiles](" +

                "[fGroupActivityID]  ," +
                "[fPicture1Path] ," +
                "[fPicture2Path] ," +
                "[fPicture3Path] ," +
                "[fPicture4Path] ," +
                "[fFile1Path]" +
                ") VALUES (" +
                 "@K_id," +
                      "@K_Picture1Path," +
                           "@K_Picture2Path," +
                                "@K_Picture3Path," +
                                     "@K_Picture4Path," +
                                          "@K_File1Path" +
                ")";

            List<ParamatsWithValueClass> withValueList = new List<ParamatsWithValueClass>();

            for (int i = 0; i < 4; i++)
            {
                int count = i;

                withValueList.Add(new ParamatsWithValueClass
                {
                    key = $"K_Picture{++count}Path",
                    value = i < picPath.Count ? picPath[i] : ""
                });

            }

            withValueList.Add(new ParamatsWithValueClass { key = "K_File1Path", value = lbx_picAFile.Items.Count != 0 ? lbx_picAFile.Items[0].ToString() : "" });

            withValueList.Add(new ParamatsWithValueClass { key = "K_id", value = id });
            new Utility().exeNonQuery(sql, withValueList);
            withValueList = new List<ParamatsWithValueClass>();


        }
        //================================================^^^ADD
        private void btn_lbx_picAFileClear_Click(object sender, EventArgs e)
        {
            lbx_picAFile.Items.Clear(); //沒有進資料流只有清字所以"暫時沒有問題"
        }

        //=====================================================vvvvUpdate
        private void btn_GroupActivityUpdate_Click(object sender, EventArgs e)
        {
            if (getUpdateSwitch < 0) return;

        }

        void getGroupActivityMainResultForUpdate()
        {
            List<ParamatsWithValueClass> listParamat = new List<ParamatsWithValueClass>();
            listParamat.Add(new ParamatsWithValueClass { key = "K_id", value = getUpdateSwitch.ToString() });
            DataTable dt = new Utility().exeReader(@"select * from tGroupActivity where fGroupActivityID = @K_id", listParamat);

            cbx_EventType.Text = dt.Rows[0]["fEventType"].ToString();
            dtp_classDate.Text = dt.Rows[0]["fDate"].ToString();
            dtp_classTimeStart.Text = dt.Rows[0]["fStartTime"].ToString();
            dtp_classTimeEnd.Text = dt.Rows[0]["fEndTime"].ToString();
            tbx_groupName.Text = dt.Rows[0]["fGroupName"].ToString();
            tbx_className.Text = dt.Rows[0]["fClassName"].ToString();
            //flp_classTheme    //要去連別的這邊沒有
            tbx_Goal.Text = dt.Rows[0]["fGoal"].ToString();
            tbx_Location.Text = dt.Rows[0]["fLocation"].ToString();
            tbx_PeopleCount.Text = dt.Rows[0]["fPeopleCount"].ToString();
            tbx_Leader.Text = dt.Rows[0]["fLeader"].ToString();
            tbx_Recorder.Text = dt.Rows[0]["fRecorder"].ToString();
            tbx_Process.Text = dt.Rows[0]["fProcess"].ToString();
            tbx_Achievement.Text = dt.Rows[0]["fAchievement"].ToString();
            tbx_FillFormStaff.Text = dt.Rows[0]["fFillFormStaff"].ToString();
            dtp_FillFormDate.Text = dt.Rows[0]["fFillFormDate"].ToString();

        }
        void getGroupActivityClassThemeForUpdate()
        {
            List<ParamatsWithValueClass> listParamat = new List<ParamatsWithValueClass>();
            listParamat.Add(new ParamatsWithValueClass { key = "K_id", value = getUpdateSwitch.ToString() });
            DataTable dt = new Utility().exeReader(@"select TypeNames.TypeName from tGroupActivity " +
                                                                                        "join tGroupActivityClassTheme on tGroupActivity.fGroupActivityID = tGroupActivityClassTheme.fGroupActivityID " +
                                                                                        "join TypeNames on tGroupActivityClassTheme.fClassTheme = TypeNames.TypeNameId " +
                                                                                        "where tGroupActivity.fGroupActivityID = @K_id",
                                                                                        listParamat);
            int count = 0;
            flp_classTheme.Controls.Clear();
            foreach (DataRow item in dt.Rows)
            {
                ComboBox cbo = new ComboBox();
                cbo.Text = item[0].ToString();
                if (count == dt.Rows.Count - 1) { cbo.Tag = 0; } else { cbo.Tag = 1; }//假設他是最一個要打開設TAG0
                ThemeComboxGetcallSelf(cbo);
                count++;
            }
            comboboxWheelOrNot();
        }

        void getScheduleDetailsForUpdate()
        {
            List<ParamatsWithValueClass> listParamat = new List<ParamatsWithValueClass>();
            listParamat.Add(new ParamatsWithValueClass { key = "K_id", value = getUpdateSwitch.ToString() });
            DataTable dt = new Utility().exeReader(@"select fStartTime,fEndTime,fDepiction " +
                                                                                        "from tScheduleDetails " +
                                                                                        "where tScheduleDetails.fGroupActivityID =  @K_id",
                                                                                        listParamat);
            foreach (DataRow item in dt.Rows)
            {
                ScheduleDetails sd = new ScheduleDetails();
                foreach (Control itemInSchedule in sd.Controls)
                {
                    if (itemInSchedule.Name == "dtp_scheduleStart") { ((DateTimePicker)itemInSchedule).Value = Convert.ToDateTime(item["fStartTime"]); }
                    if (itemInSchedule.Name == "dtp_scheduleEnd") { ((DateTimePicker)itemInSchedule).Value = Convert.ToDateTime(item["fEndTime"]); }
                    if (itemInSchedule.Name == "tbx_Depiction") { itemInSchedule.Text = item["fDepiction"].ToString(); }
                }
                flp_ScheduleDetails.Controls.Add(sd);
            }

        }

        void getGroupActivityPicAndFilesForUpdate()
        {

            List<ParamatsWithValueClass> listParamat = new List<ParamatsWithValueClass>();
            listParamat.Add(new ParamatsWithValueClass { key = "K_id", value = getUpdateSwitch.ToString() });
            DataTable dt = new Utility().exeReader(@"select fPicture1Path,fPicture2Path,fPicture3Path,fPicture4Path,fFile1Path " +
                                                                                        " from tGroupActivityPicAndFiles " +
                                                                                        " where tGroupActivityPicAndFiles.fGroupActivityID = @K_id",
                                                                                        listParamat);
            for (int i = 1; i <= 4; i++)
            {

                string longPath = dt.Rows[0][$"fPicture{i}Path"].ToString();
                if (longPath != "")
                {
                    Image oImage = Image.FromFile(longPath);
                    string shortPath = longPath.Split('\\')[longPath.Split('\\').Count() - 1];
                    new Utility().resXModify("LocalResX.resx", shortPath, oImage, false, "", false);
                }

            }
            imageReload();

            lbx_picAFile.Items.Add(dt.Rows[0]["fFile1Path"]);



        }

        void getPersonalPerformanceForUpdate()
        {
            List<ParamatsWithValueClass> listParamat = new List<ParamatsWithValueClass>();
            listParamat.Add(new ParamatsWithValueClass { key = "K_id", value = getUpdateSwitch.ToString() });
            DataTable dt = new Utility().exeReader(@" select fResidentID,fEmotions,fParticipatePersistence,fCooperate,fHumanInteraction,fAttention,fParticipatePerformance,fDepiction "+
                                                                                        " from tPersonalPerformance where fGroupActivityID =  @K_id",
                                                                                        listParamat);
            foreach (DataRow item in dt.Rows)
            {
                PersonalPerformance pp = new PersonalPerformance();
                foreach (Control itemPersonalPerformance in pp.Controls)
                {
                    if (itemPersonalPerformance.Name == "cbx_ppResidentName") { ((ComboBox)itemPersonalPerformance).SelectedIndex = Convert.ToInt32( item["fResidentID"])-1; }
                    if (itemPersonalPerformance.Name == "cbx_Emotions") { itemPersonalPerformance.Text = item["fEmotions"].ToString(); }
                    if (itemPersonalPerformance.Name == "cbx_ParticipatePersistence") { itemPersonalPerformance.Text = item["fParticipatePersistence"].ToString(); }
                    if (itemPersonalPerformance.Name == "cbx_Cooperate") { itemPersonalPerformance.Text = item["fCooperate"].ToString(); }
                    if (itemPersonalPerformance.Name == "cbx_HumanInteraction") { itemPersonalPerformance.Text = item["fHumanInteraction"].ToString(); }
                    if (itemPersonalPerformance.Name == "cbx_Attention") { itemPersonalPerformance.Text = item["fAttention"].ToString(); }
                    if (itemPersonalPerformance.Name == "cbx_ParticipatePerformance") { itemPersonalPerformance.Text = item["fParticipatePerformance"].ToString(); }
                    if (itemPersonalPerformance.Name == "tbx_ppRemark") { itemPersonalPerformance.Text = item["fDepiction"].ToString(); }
                }
                flp_PersonalPerformance.Controls.Add(pp);
            }
        }

        //=====================================================^^^Update
    }
}
