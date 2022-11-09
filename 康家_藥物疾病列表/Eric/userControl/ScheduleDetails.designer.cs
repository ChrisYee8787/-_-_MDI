namespace RehabilitationForm.CustomComponents
{
    partial class ScheduleDetails
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_scheduleStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_scheduleEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_scheduleCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Depiction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtp_scheduleStart
            // 
            this.dtp_scheduleStart.CustomFormat = "HH:mm:ss";
            this.dtp_scheduleStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_scheduleStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_scheduleStart.Location = new System.Drawing.Point(18, 54);
            this.dtp_scheduleStart.Name = "dtp_scheduleStart";
            this.dtp_scheduleStart.ShowUpDown = true;
            this.dtp_scheduleStart.Size = new System.Drawing.Size(129, 29);
            this.dtp_scheduleStart.TabIndex = 0;
            this.dtp_scheduleStart.ValueChanged += new System.EventHandler(this.dtp_scheduleStart_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "起始時間";
            // 
            // dtp_scheduleEnd
            // 
            this.dtp_scheduleEnd.CustomFormat = "HH:mm:ss";
            this.dtp_scheduleEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_scheduleEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_scheduleEnd.Location = new System.Drawing.Point(161, 54);
            this.dtp_scheduleEnd.Name = "dtp_scheduleEnd";
            this.dtp_scheduleEnd.ShowUpDown = true;
            this.dtp_scheduleEnd.Size = new System.Drawing.Size(129, 29);
            this.dtp_scheduleEnd.TabIndex = 0;
            this.dtp_scheduleEnd.ValueChanged += new System.EventHandler(this.dtp_scheduleEnd_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(157, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "結束時間";
            // 
            // tbx_scheduleCost
            // 
            this.tbx_scheduleCost.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_scheduleCost.Location = new System.Drawing.Point(304, 54);
            this.tbx_scheduleCost.Name = "tbx_scheduleCost";
            this.tbx_scheduleCost.Size = new System.Drawing.Size(100, 29);
            this.tbx_scheduleCost.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(300, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "花費時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(414, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "大綱說明";
            // 
            // tbx_Depiction
            // 
            this.tbx_Depiction.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_Depiction.Location = new System.Drawing.Point(418, 54);
            this.tbx_Depiction.Name = "tbx_Depiction";
            this.tbx_Depiction.Size = new System.Drawing.Size(265, 29);
            this.tbx_Depiction.TabIndex = 4;
            // 
            // ScheduleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tbx_Depiction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_scheduleCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_scheduleEnd);
            this.Controls.Add(this.dtp_scheduleStart);
            this.Name = "ScheduleDetails";
            this.Size = new System.Drawing.Size(696, 96);
            this.Load += new System.EventHandler(this.ScheduleDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_scheduleStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_scheduleEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_scheduleCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Depiction;
    }
}
