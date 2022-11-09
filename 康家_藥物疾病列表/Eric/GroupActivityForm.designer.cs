namespace RehabilitationForm
{
    partial class GroupActivityForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_clanderCombox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_calendarStartDay = new System.Windows.Forms.DateTimePicker();
            this.dtp_calendarStartTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_calendarStart = new System.Windows.Forms.Label();
            this.lbl_calendarEnd = new System.Windows.Forms.Label();
            this.dtp_calendarEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtp_calendarEndTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_EventType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_classDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_classTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtp_classTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_groupName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_className = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbx_Goal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbx_Location = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbx_PeopleCount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbx_Leader = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbx_Recorder = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbx_Process = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.opf_choseFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_picAPic = new System.Windows.Forms.Button();
            this.flp_picAPic = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_lbx_picAFileAdd = new System.Windows.Forms.Button();
            this.lbx_picAFile = new System.Windows.Forms.ListBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbx_Achievement = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.flp_PersonalPerformance = new System.Windows.Forms.FlowLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dtp_FillFormDate = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_GroupActivityADD = new System.Windows.Forms.Button();
            this.btn_ScheduleAdd = new System.Windows.Forms.Button();
            this.btn_ScheduleRemove = new System.Windows.Forms.Button();
            this.flp_ScheduleDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.label32 = new System.Windows.Forms.Label();
            this.tbx_FillFormStaff = new System.Windows.Forms.TextBox();
            this.lbx_PersonalPerformance = new System.Windows.Forms.ListBox();
            this.flp_classTheme = new System.Windows.Forms.FlowLayoutPanel();
            this.tbx_calendarEventType = new System.Windows.Forms.TextBox();
            this.lbx_calendarTheme = new System.Windows.Forms.ListBox();
            this.btn_demo = new System.Windows.Forms.Button();
            this.btn_classThemeDelete = new System.Windows.Forms.Button();
            this.btn_GroupActivityUpdate = new System.Windows.Forms.Button();
            this.btn_GroupActivityDelete = new System.Windows.Forms.Button();
            this.btn_option = new System.Windows.Forms.Button();
            this.btn_lbx_picAFileClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_clanderCombox
            // 
            this.cbx_clanderCombox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_clanderCombox.FormattingEnabled = true;
            this.cbx_clanderCombox.Items.AddRange(new object[] {
            "整天",
            "時間區段"});
            this.cbx_clanderCombox.Location = new System.Drawing.Point(28, 98);
            this.cbx_clanderCombox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_clanderCombox.Name = "cbx_clanderCombox";
            this.cbx_clanderCombox.Size = new System.Drawing.Size(172, 33);
            this.cbx_clanderCombox.TabIndex = 0;
            this.cbx_clanderCombox.SelectedIndexChanged += new System.EventHandler(this.clanderCombox_selectIndexChang);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "團體課程記錄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "行事曆類型";
            // 
            // dtp_calendarStartDay
            // 
            this.dtp_calendarStartDay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_calendarStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_calendarStartDay.Location = new System.Drawing.Point(28, 172);
            this.dtp_calendarStartDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_calendarStartDay.Name = "dtp_calendarStartDay";
            this.dtp_calendarStartDay.Size = new System.Drawing.Size(172, 34);
            this.dtp_calendarStartDay.TabIndex = 3;
            // 
            // dtp_calendarStartTime
            // 
            this.dtp_calendarStartTime.CustomFormat = "HH:mm:ss";
            this.dtp_calendarStartTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_calendarStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_calendarStartTime.Location = new System.Drawing.Point(221, 172);
            this.dtp_calendarStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_calendarStartTime.Name = "dtp_calendarStartTime";
            this.dtp_calendarStartTime.ShowUpDown = true;
            this.dtp_calendarStartTime.Size = new System.Drawing.Size(163, 34);
            this.dtp_calendarStartTime.TabIndex = 3;
            // 
            // lbl_calendarStart
            // 
            this.lbl_calendarStart.AutoSize = true;
            this.lbl_calendarStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_calendarStart.Location = new System.Drawing.Point(24, 145);
            this.lbl_calendarStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_calendarStart.Name = "lbl_calendarStart";
            this.lbl_calendarStart.Size = new System.Drawing.Size(112, 25);
            this.lbl_calendarStart.TabIndex = 2;
            this.lbl_calendarStart.Text = "行事曆時間";
            // 
            // lbl_calendarEnd
            // 
            this.lbl_calendarEnd.AutoSize = true;
            this.lbl_calendarEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_calendarEnd.Location = new System.Drawing.Point(24, 222);
            this.lbl_calendarEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_calendarEnd.Name = "lbl_calendarEnd";
            this.lbl_calendarEnd.Size = new System.Drawing.Size(152, 25);
            this.lbl_calendarEnd.TabIndex = 2;
            this.lbl_calendarEnd.Text = "行事曆結束時間";
            // 
            // dtp_calendarEndDay
            // 
            this.dtp_calendarEndDay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_calendarEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_calendarEndDay.Location = new System.Drawing.Point(29, 251);
            this.dtp_calendarEndDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_calendarEndDay.Name = "dtp_calendarEndDay";
            this.dtp_calendarEndDay.Size = new System.Drawing.Size(171, 34);
            this.dtp_calendarEndDay.TabIndex = 3;
            // 
            // dtp_calendarEndTime
            // 
            this.dtp_calendarEndTime.CustomFormat = "HH:mm:ss";
            this.dtp_calendarEndTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_calendarEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_calendarEndTime.Location = new System.Drawing.Point(223, 251);
            this.dtp_calendarEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_calendarEndTime.Name = "dtp_calendarEndTime";
            this.dtp_calendarEndTime.ShowUpDown = true;
            this.dtp_calendarEndTime.Size = new System.Drawing.Size(163, 34);
            this.dtp_calendarEndTime.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(412, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "行事曆內容";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(16, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(932, 2);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(24, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "團體計畫選單";
            // 
            // cbx_EventType
            // 
            this.cbx_EventType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_EventType.FormattingEnabled = true;
            this.cbx_EventType.Location = new System.Drawing.Point(28, 382);
            this.cbx_EventType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_EventType.Name = "cbx_EventType";
            this.cbx_EventType.Size = new System.Drawing.Size(172, 33);
            this.cbx_EventType.TabIndex = 0;
            this.cbx_EventType.SelectedIndexChanged += new System.EventHandler(this.cbx_EventType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(24, 428);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "課程日期";
            // 
            // dtp_classDate
            // 
            this.dtp_classDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_classDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_classDate.Location = new System.Drawing.Point(29, 456);
            this.dtp_classDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_classDate.Name = "dtp_classDate";
            this.dtp_classDate.Size = new System.Drawing.Size(171, 34);
            this.dtp_classDate.TabIndex = 3;
            // 
            // dtp_classTimeStart
            // 
            this.dtp_classTimeStart.CustomFormat = "HH:mm:ss";
            this.dtp_classTimeStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_classTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_classTimeStart.Location = new System.Drawing.Point(223, 456);
            this.dtp_classTimeStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_classTimeStart.Name = "dtp_classTimeStart";
            this.dtp_classTimeStart.ShowUpDown = true;
            this.dtp_classTimeStart.Size = new System.Drawing.Size(163, 34);
            this.dtp_classTimeStart.TabIndex = 3;
            // 
            // dtp_classTimeEnd
            // 
            this.dtp_classTimeEnd.CustomFormat = "HH:m:ss";
            this.dtp_classTimeEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_classTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_classTimeEnd.Location = new System.Drawing.Point(399, 456);
            this.dtp_classTimeEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_classTimeEnd.Name = "dtp_classTimeEnd";
            this.dtp_classTimeEnd.ShowUpDown = true;
            this.dtp_classTimeEnd.Size = new System.Drawing.Size(163, 34);
            this.dtp_classTimeEnd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(216, 428);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "課程開始時間";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(393, 428);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "課程結束時間";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(24, 500);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "團體名稱";
            // 
            // tbx_groupName
            // 
            this.tbx_groupName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_groupName.Location = new System.Drawing.Point(29, 530);
            this.tbx_groupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_groupName.Name = "tbx_groupName";
            this.tbx_groupName.Size = new System.Drawing.Size(171, 34);
            this.tbx_groupName.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(217, 500);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "課程主題";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(25, 575);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "課程名稱";
            // 
            // tbx_className
            // 
            this.tbx_className.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_className.Location = new System.Drawing.Point(31, 605);
            this.tbx_className.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_className.Name = "tbx_className";
            this.tbx_className.Size = new System.Drawing.Size(169, 34);
            this.tbx_className.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(25, 652);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "團體目的";
            // 
            // tbx_Goal
            // 
            this.tbx_Goal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Goal.Location = new System.Drawing.Point(31, 682);
            this.tbx_Goal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_Goal.Multiline = true;
            this.tbx_Goal.Name = "tbx_Goal";
            this.tbx_Goal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Goal.Size = new System.Drawing.Size(532, 155);
            this.tbx_Goal.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(25, 859);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "團體地點";
            // 
            // tbx_Location
            // 
            this.tbx_Location.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Location.Location = new System.Drawing.Point(31, 889);
            this.tbx_Location.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_Location.Multiline = true;
            this.tbx_Location.Name = "tbx_Location";
            this.tbx_Location.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Location.Size = new System.Drawing.Size(532, 98);
            this.tbx_Location.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(25, 1005);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "團體人數";
            // 
            // tbx_PeopleCount
            // 
            this.tbx_PeopleCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_PeopleCount.Location = new System.Drawing.Point(28, 1039);
            this.tbx_PeopleCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_PeopleCount.Name = "tbx_PeopleCount";
            this.tbx_PeopleCount.Size = new System.Drawing.Size(188, 34);
            this.tbx_PeopleCount.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(229, 1005);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "團體領導";
            // 
            // tbx_Leader
            // 
            this.tbx_Leader.Enabled = false;
            this.tbx_Leader.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Leader.Location = new System.Drawing.Point(232, 1039);
            this.tbx_Leader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_Leader.Name = "tbx_Leader";
            this.tbx_Leader.Size = new System.Drawing.Size(188, 34);
            this.tbx_Leader.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(427, 1005);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 25);
            this.label18.TabIndex = 2;
            this.label18.Text = "記錄人員";
            // 
            // tbx_Recorder
            // 
            this.tbx_Recorder.Enabled = false;
            this.tbx_Recorder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Recorder.Location = new System.Drawing.Point(429, 1039);
            this.tbx_Recorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_Recorder.Name = "tbx_Recorder";
            this.tbx_Recorder.Size = new System.Drawing.Size(188, 34);
            this.tbx_Recorder.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(16, 1101);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(932, 2);
            this.label19.TabIndex = 5;
            this.label19.Text = "label6";
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(16, 1648);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(932, 2);
            this.label20.TabIndex = 8;
            this.label20.Text = "label6";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(25, 1669);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 25);
            this.label21.TabIndex = 2;
            this.label21.Text = "過程摘要";
            // 
            // tbx_Process
            // 
            this.tbx_Process.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Process.Location = new System.Drawing.Point(31, 1699);
            this.tbx_Process.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_Process.Multiline = true;
            this.tbx_Process.Name = "tbx_Process";
            this.tbx_Process.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Process.Size = new System.Drawing.Size(532, 209);
            this.tbx_Process.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(16, 1949);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(932, 2);
            this.label22.TabIndex = 8;
            this.label22.Text = "label6";
            // 
            // opf_choseFile
            // 
            this.opf_choseFile.FileName = "opf_choseFile";
            // 
            // btn_picAPic
            // 
            this.btn_picAPic.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_picAPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_picAPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_picAPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_picAPic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_picAPic.Location = new System.Drawing.Point(31, 1981);
            this.btn_picAPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_picAPic.Name = "btn_picAPic";
            this.btn_picAPic.Size = new System.Drawing.Size(121, 52);
            this.btn_picAPic.TabIndex = 9;
            this.btn_picAPic.Text = "選擇圖片";
            this.btn_picAPic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_picAPic.UseVisualStyleBackColor = true;
            this.btn_picAPic.Click += new System.EventHandler(this.btn_picAPic_Click);
            // 
            // flp_picAPic
            // 
            this.flp_picAPic.AutoScroll = true;
            this.flp_picAPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_picAPic.Location = new System.Drawing.Point(31, 2065);
            this.flp_picAPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flp_picAPic.Name = "flp_picAPic";
            this.flp_picAPic.Size = new System.Drawing.Size(1101, 428);
            this.flp_picAPic.TabIndex = 10;
            // 
            // btn_lbx_picAFileAdd
            // 
            this.btn_lbx_picAFileAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_lbx_picAFileAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_lbx_picAFileAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_lbx_picAFileAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lbx_picAFileAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_lbx_picAFileAdd.Location = new System.Drawing.Point(31, 2526);
            this.btn_lbx_picAFileAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_lbx_picAFileAdd.Name = "btn_lbx_picAFileAdd";
            this.btn_lbx_picAFileAdd.Size = new System.Drawing.Size(121, 52);
            this.btn_lbx_picAFileAdd.TabIndex = 9;
            this.btn_lbx_picAFileAdd.Text = "上傳檔案";
            this.btn_lbx_picAFileAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_lbx_picAFileAdd.UseVisualStyleBackColor = true;
            this.btn_lbx_picAFileAdd.Click += new System.EventHandler(this.picAFile_Click);
            // 
            // lbx_picAFile
            // 
            this.lbx_picAFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbx_picAFile.FormattingEnabled = true;
            this.lbx_picAFile.ItemHeight = 25;
            this.lbx_picAFile.Location = new System.Drawing.Point(31, 2602);
            this.lbx_picAFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbx_picAFile.Name = "lbx_picAFile";
            this.lbx_picAFile.Size = new System.Drawing.Size(532, 204);
            this.lbx_picAFile.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(16, 2838);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(932, 2);
            this.label23.TabIndex = 12;
            this.label23.Text = "label23";
            // 
            // tbx_Achievement
            // 
            this.tbx_Achievement.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Achievement.Location = new System.Drawing.Point(31, 2891);
            this.tbx_Achievement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_Achievement.Multiline = true;
            this.tbx_Achievement.Name = "tbx_Achievement";
            this.tbx_Achievement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Achievement.Size = new System.Drawing.Size(532, 209);
            this.tbx_Achievement.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.Location = new System.Drawing.Point(25, 2862);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 25);
            this.label24.TabIndex = 13;
            this.label24.Text = "成果簡述";
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(16, 3128);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(932, 2);
            this.label25.TabIndex = 15;
            this.label25.Text = "label25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label26.Location = new System.Drawing.Point(25, 1131);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 25);
            this.label26.TabIndex = 2;
            this.label26.Text = "大綱排程";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(1163, 3158);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "帶入住民清單";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ResidentADD_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label27.Location = new System.Drawing.Point(25, 3234);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 25);
            this.label27.TabIndex = 13;
            this.label27.Text = "個案個別表現";
            // 
            // flp_PersonalPerformance
            // 
            this.flp_PersonalPerformance.AutoScroll = true;
            this.flp_PersonalPerformance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_PersonalPerformance.Location = new System.Drawing.Point(31, 3278);
            this.flp_PersonalPerformance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flp_PersonalPerformance.Name = "flp_PersonalPerformance";
            this.flp_PersonalPerformance.Size = new System.Drawing.Size(1101, 973);
            this.flp_PersonalPerformance.TabIndex = 16;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.Location = new System.Drawing.Point(16, 32767);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(212, 2);
            this.label28.TabIndex = 17;
            this.label28.Text = "label28";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label29.Location = new System.Drawing.Point(25, 4284);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 25);
            this.label29.TabIndex = 18;
            this.label29.Text = "填表人";
            // 
            // dtp_FillFormDate
            // 
            this.dtp_FillFormDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_FillFormDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FillFormDate.Location = new System.Drawing.Point(427, 4329);
            this.dtp_FillFormDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_FillFormDate.Name = "dtp_FillFormDate";
            this.dtp_FillFormDate.Size = new System.Drawing.Size(172, 34);
            this.dtp_FillFormDate.TabIndex = 20;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label30.Location = new System.Drawing.Point(421, 4284);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 25);
            this.label30.TabIndex = 18;
            this.label30.Text = "填表日期";
            // 
            // btn_GroupActivityADD
            // 
            this.btn_GroupActivityADD.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GroupActivityADD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_GroupActivityADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btn_GroupActivityADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GroupActivityADD.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GroupActivityADD.Location = new System.Drawing.Point(768, 4322);
            this.btn_GroupActivityADD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GroupActivityADD.Name = "btn_GroupActivityADD";
            this.btn_GroupActivityADD.Size = new System.Drawing.Size(253, 52);
            this.btn_GroupActivityADD.TabIndex = 22;
            this.btn_GroupActivityADD.Text = "團體課程記錄新增";
            this.btn_GroupActivityADD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_GroupActivityADD.UseVisualStyleBackColor = true;
            this.btn_GroupActivityADD.Click += new System.EventHandler(this.AllCompleteThenAdd_Click);
            // 
            // btn_ScheduleAdd
            // 
            this.btn_ScheduleAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ScheduleAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ScheduleAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ScheduleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ScheduleAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ScheduleAdd.Location = new System.Drawing.Point(751, 1118);
            this.btn_ScheduleAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ScheduleAdd.Name = "btn_ScheduleAdd";
            this.btn_ScheduleAdd.Size = new System.Drawing.Size(121, 52);
            this.btn_ScheduleAdd.TabIndex = 9;
            this.btn_ScheduleAdd.Text = "新增";
            this.btn_ScheduleAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ScheduleAdd.UseVisualStyleBackColor = true;
            this.btn_ScheduleAdd.Click += new System.EventHandler(this.btn_ScheduleAdd_Click);
            // 
            // btn_ScheduleRemove
            // 
            this.btn_ScheduleRemove.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ScheduleRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ScheduleRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ScheduleRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ScheduleRemove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ScheduleRemove.Location = new System.Drawing.Point(880, 1116);
            this.btn_ScheduleRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ScheduleRemove.Name = "btn_ScheduleRemove";
            this.btn_ScheduleRemove.Size = new System.Drawing.Size(121, 52);
            this.btn_ScheduleRemove.TabIndex = 9;
            this.btn_ScheduleRemove.Text = "復原";
            this.btn_ScheduleRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ScheduleRemove.UseVisualStyleBackColor = true;
            this.btn_ScheduleRemove.Click += new System.EventHandler(this.btn_ScheduleRemove_Click);
            // 
            // flp_ScheduleDetails
            // 
            this.flp_ScheduleDetails.AutoScroll = true;
            this.flp_ScheduleDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_ScheduleDetails.Location = new System.Drawing.Point(31, 1180);
            this.flp_ScheduleDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flp_ScheduleDetails.Name = "flp_ScheduleDetails";
            this.flp_ScheduleDetails.Size = new System.Drawing.Size(1101, 446);
            this.flp_ScheduleDetails.TabIndex = 25;
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Location = new System.Drawing.Point(16, 4392);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(932, 2);
            this.label32.TabIndex = 27;
            this.label32.Text = "label32";
            // 
            // tbx_FillFormStaff
            // 
            this.tbx_FillFormStaff.Enabled = false;
            this.tbx_FillFormStaff.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_FillFormStaff.Location = new System.Drawing.Point(31, 4329);
            this.tbx_FillFormStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_FillFormStaff.Name = "tbx_FillFormStaff";
            this.tbx_FillFormStaff.Size = new System.Drawing.Size(209, 34);
            this.tbx_FillFormStaff.TabIndex = 28;
            // 
            // lbx_PersonalPerformance
            // 
            this.lbx_PersonalPerformance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbx_PersonalPerformance.FormattingEnabled = true;
            this.lbx_PersonalPerformance.ItemHeight = 25;
            this.lbx_PersonalPerformance.Location = new System.Drawing.Point(1167, 3278);
            this.lbx_PersonalPerformance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbx_PersonalPerformance.Name = "lbx_PersonalPerformance";
            this.lbx_PersonalPerformance.Size = new System.Drawing.Size(164, 979);
            this.lbx_PersonalPerformance.TabIndex = 29;
            // 
            // flp_classTheme
            // 
            this.flp_classTheme.AutoScroll = true;
            this.flp_classTheme.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.flp_classTheme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_classTheme.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.flp_classTheme.Location = new System.Drawing.Point(223, 530);
            this.flp_classTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flp_classTheme.Name = "flp_classTheme";
            this.flp_classTheme.Size = new System.Drawing.Size(340, 110);
            this.flp_classTheme.TabIndex = 30;
            // 
            // tbx_calendarEventType
            // 
            this.tbx_calendarEventType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_calendarEventType.Location = new System.Drawing.Point(417, 98);
            this.tbx_calendarEventType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_calendarEventType.Name = "tbx_calendarEventType";
            this.tbx_calendarEventType.Size = new System.Drawing.Size(145, 34);
            this.tbx_calendarEventType.TabIndex = 31;
            // 
            // lbx_calendarTheme
            // 
            this.lbx_calendarTheme.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbx_calendarTheme.FormattingEnabled = true;
            this.lbx_calendarTheme.ItemHeight = 25;
            this.lbx_calendarTheme.Location = new System.Drawing.Point(417, 158);
            this.lbx_calendarTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbx_calendarTheme.Name = "lbx_calendarTheme";
            this.lbx_calendarTheme.Size = new System.Drawing.Size(144, 129);
            this.lbx_calendarTheme.TabIndex = 32;
            // 
            // btn_demo
            // 
            this.btn_demo.Location = new System.Drawing.Point(460, 371);
            this.btn_demo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_demo.Name = "btn_demo";
            this.btn_demo.Size = new System.Drawing.Size(100, 29);
            this.btn_demo.TabIndex = 33;
            this.btn_demo.Text = "demo";
            this.btn_demo.UseVisualStyleBackColor = true;
            this.btn_demo.Click += new System.EventHandler(this.btn_demo_Click);
            // 
            // btn_classThemeDelete
            // 
            this.btn_classThemeDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_classThemeDelete.Location = new System.Drawing.Point(572, 605);
            this.btn_classThemeDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_classThemeDelete.Name = "btn_classThemeDelete";
            this.btn_classThemeDelete.Size = new System.Drawing.Size(77, 36);
            this.btn_classThemeDelete.TabIndex = 34;
            this.btn_classThemeDelete.Text = "刪除";
            this.btn_classThemeDelete.UseVisualStyleBackColor = true;
            this.btn_classThemeDelete.Click += new System.EventHandler(this.btn_classThemeDelete_Click);
            // 
            // btn_GroupActivityUpdate
            // 
            this.btn_GroupActivityUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GroupActivityUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_GroupActivityUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btn_GroupActivityUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GroupActivityUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GroupActivityUpdate.Location = new System.Drawing.Point(1029, 4322);
            this.btn_GroupActivityUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GroupActivityUpdate.Name = "btn_GroupActivityUpdate";
            this.btn_GroupActivityUpdate.Size = new System.Drawing.Size(113, 52);
            this.btn_GroupActivityUpdate.TabIndex = 22;
            this.btn_GroupActivityUpdate.Text = "更新";
            this.btn_GroupActivityUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_GroupActivityUpdate.UseVisualStyleBackColor = true;
            this.btn_GroupActivityUpdate.Visible = false;
            this.btn_GroupActivityUpdate.Click += new System.EventHandler(this.btn_GroupActivityUpdate_Click);
            // 
            // btn_GroupActivityDelete
            // 
            this.btn_GroupActivityDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GroupActivityDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_GroupActivityDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btn_GroupActivityDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GroupActivityDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GroupActivityDelete.Location = new System.Drawing.Point(1151, 4322);
            this.btn_GroupActivityDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GroupActivityDelete.Name = "btn_GroupActivityDelete";
            this.btn_GroupActivityDelete.Size = new System.Drawing.Size(113, 52);
            this.btn_GroupActivityDelete.TabIndex = 22;
            this.btn_GroupActivityDelete.Text = "刪除";
            this.btn_GroupActivityDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_GroupActivityDelete.UseVisualStyleBackColor = true;
            this.btn_GroupActivityDelete.Visible = false;
            this.btn_GroupActivityDelete.Click += new System.EventHandler(this.btn_GroupActivityDelete_Click);
            // 
            // btn_option
            // 
            this.btn_option.Location = new System.Drawing.Point(352, 371);
            this.btn_option.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(100, 29);
            this.btn_option.TabIndex = 35;
            this.btn_option.Text = "Option";
            this.btn_option.UseVisualStyleBackColor = true;
            this.btn_option.Click += new System.EventHandler(this.btn_option_Click);
            // 
            // btn_lbx_picAFileClear
            // 
            this.btn_lbx_picAFileClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_lbx_picAFileClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_lbx_picAFileClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_lbx_picAFileClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lbx_picAFileClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_lbx_picAFileClear.Location = new System.Drawing.Point(160, 2526);
            this.btn_lbx_picAFileClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_lbx_picAFileClear.Name = "btn_lbx_picAFileClear";
            this.btn_lbx_picAFileClear.Size = new System.Drawing.Size(121, 52);
            this.btn_lbx_picAFileClear.TabIndex = 9;
            this.btn_lbx_picAFileClear.Text = "清除";
            this.btn_lbx_picAFileClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_lbx_picAFileClear.UseVisualStyleBackColor = true;
            this.btn_lbx_picAFileClear.Click += new System.EventHandler(this.btn_lbx_picAFileClear_Click);
            // 
            // GroupActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.ClientSize = new System.Drawing.Size(1551, 1055);
            this.Controls.Add(this.btn_option);
            this.Controls.Add(this.btn_classThemeDelete);
            this.Controls.Add(this.btn_demo);
            this.Controls.Add(this.lbx_calendarTheme);
            this.Controls.Add(this.tbx_calendarEventType);
            this.Controls.Add(this.flp_classTheme);
            this.Controls.Add(this.lbx_PersonalPerformance);
            this.Controls.Add(this.tbx_FillFormStaff);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.flp_ScheduleDetails);
            this.Controls.Add(this.btn_GroupActivityDelete);
            this.Controls.Add(this.btn_GroupActivityUpdate);
            this.Controls.Add(this.btn_GroupActivityADD);
            this.Controls.Add(this.dtp_FillFormDate);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tbx_Achievement);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lbx_picAFile);
            this.Controls.Add(this.flp_picAPic);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_lbx_picAFileClear);
            this.Controls.Add(this.btn_lbx_picAFileAdd);
            this.Controls.Add(this.btn_ScheduleRemove);
            this.Controls.Add(this.btn_ScheduleAdd);
            this.Controls.Add(this.btn_picAPic);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbx_Goal);
            this.Controls.Add(this.tbx_Process);
            this.Controls.Add(this.tbx_Location);
            this.Controls.Add(this.tbx_Recorder);
            this.Controls.Add(this.tbx_Leader);
            this.Controls.Add(this.tbx_PeopleCount);
            this.Controls.Add(this.tbx_className);
            this.Controls.Add(this.tbx_groupName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_calendarEndTime);
            this.Controls.Add(this.dtp_classTimeEnd);
            this.Controls.Add(this.dtp_classTimeStart);
            this.Controls.Add(this.dtp_calendarStartTime);
            this.Controls.Add(this.dtp_calendarEndDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_calendarEnd);
            this.Controls.Add(this.dtp_classDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_calendarStartDay);
            this.Controls.Add(this.lbl_calendarStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_EventType);
            this.Controls.Add(this.cbx_clanderCombox);
            this.Controls.Add(this.flp_PersonalPerformance);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(794, 47);
            this.Name = "GroupActivityForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.Text = "新增團體課程記錄頁";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupActivityForm_FormClosing);
            this.Load += new System.EventHandler(this.GroupActivityForm_Load);
            this.Shown += new System.EventHandler(this.GroupActivityForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_clanderCombox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_calendarStartDay;
        private System.Windows.Forms.DateTimePicker dtp_calendarStartTime;
        private System.Windows.Forms.Label lbl_calendarStart;
        private System.Windows.Forms.Label lbl_calendarEnd;
        private System.Windows.Forms.DateTimePicker dtp_calendarEndDay;
        private System.Windows.Forms.DateTimePicker dtp_calendarEndTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_EventType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_classDate;
        private System.Windows.Forms.DateTimePicker dtp_classTimeStart;
        private System.Windows.Forms.DateTimePicker dtp_classTimeEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_groupName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbx_className;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbx_Goal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbx_Location;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbx_PeopleCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbx_Leader;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbx_Recorder;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbx_Process;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.OpenFileDialog opf_choseFile;
        private System.Windows.Forms.Button btn_picAPic;
        private System.Windows.Forms.FlowLayoutPanel flp_picAPic;
        private System.Windows.Forms.Button btn_lbx_picAFileAdd;
        private System.Windows.Forms.ListBox lbx_picAFile;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbx_Achievement;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.FlowLayoutPanel flp_PersonalPerformance;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dtp_FillFormDate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btn_GroupActivityADD;
        private System.Windows.Forms.Button btn_ScheduleAdd;
        private System.Windows.Forms.Button btn_ScheduleRemove;
        private System.Windows.Forms.FlowLayoutPanel flp_ScheduleDetails;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbx_FillFormStaff;
        private System.Windows.Forms.ListBox lbx_PersonalPerformance;
        private System.Windows.Forms.FlowLayoutPanel flp_classTheme;
        private System.Windows.Forms.TextBox tbx_calendarEventType;
        private System.Windows.Forms.ListBox lbx_calendarTheme;
        private System.Windows.Forms.Button btn_demo;
        private System.Windows.Forms.Button btn_classThemeDelete;
        private System.Windows.Forms.Button btn_GroupActivityUpdate;
        private System.Windows.Forms.Button btn_GroupActivityDelete;
        private System.Windows.Forms.Button btn_option;
        private System.Windows.Forms.Button btn_lbx_picAFileClear;
    }
}

