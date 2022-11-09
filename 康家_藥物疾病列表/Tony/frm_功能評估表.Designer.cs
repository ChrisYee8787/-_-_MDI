namespace 康家_藥物疾病列表
{
    partial class frm_功能評估表
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_Question = new System.Windows.Forms.ComboBox();
            this.btn_storage = new System.Windows.Forms.Button();
            this.flp_流動評估表 = new System.Windows.Forms.FlowLayoutPanel();
            this.listbox_Patient = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tall = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_BMI = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_bmi = new System.Windows.Forms.Button();
            this.listbox_history = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Question
            // 
            this.cmb_Question.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_Question.FormattingEnabled = true;
            this.cmb_Question.ItemHeight = 23;
            this.cmb_Question.Location = new System.Drawing.Point(802, 73);
            this.cmb_Question.Name = "cmb_Question";
            this.cmb_Question.Size = new System.Drawing.Size(187, 31);
            this.cmb_Question.TabIndex = 0;
            this.cmb_Question.SelectionChangeCommitted += new System.EventHandler(this.cmb_Question_SelectionChangeCommitted);
            // 
            // btn_storage
            // 
            this.btn_storage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_storage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_storage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_storage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_storage.Location = new System.Drawing.Point(1105, 63);
            this.btn_storage.Name = "btn_storage";
            this.btn_storage.Size = new System.Drawing.Size(114, 55);
            this.btn_storage.TabIndex = 6;
            this.btn_storage.Text = "新增資料";
            this.btn_storage.UseVisualStyleBackColor = false;
            this.btn_storage.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // flp_流動評估表
            // 
            this.flp_流動評估表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_流動評估表.AutoScroll = true;
            this.flp_流動評估表.Location = new System.Drawing.Point(257, 128);
            this.flp_流動評估表.Name = "flp_流動評估表";
            this.flp_流動評估表.Size = new System.Drawing.Size(1170, 526);
            this.flp_流動評估表.TabIndex = 7;
            // 
            // listbox_Patient
            // 
            this.listbox_Patient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox_Patient.FormattingEnabled = true;
            this.listbox_Patient.ItemHeight = 25;
            this.listbox_Patient.Location = new System.Drawing.Point(0, 55);
            this.listbox_Patient.Name = "listbox_Patient";
            this.listbox_Patient.Size = new System.Drawing.Size(251, 379);
            this.listbox_Patient.TabIndex = 9;
            this.listbox_Patient.SelectedIndexChanged += new System.EventHandler(this.listbox_Patient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "住民清單";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(257, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "當前評估居民:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Name.Location = new System.Drawing.Point(435, 23);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(36, 29);
            this.label_Name.TabIndex = 12;
            this.label_Name.Text = "無";
            this.label_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(659, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "評估項目:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(659, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "身高(公分):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(937, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "體重:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(257, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "評估日期";
            // 
            // txt_tall
            // 
            this.txt_tall.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_tall.Location = new System.Drawing.Point(810, 21);
            this.txt_tall.Multiline = true;
            this.txt_tall.Name = "txt_tall";
            this.txt_tall.Size = new System.Drawing.Size(109, 33);
            this.txt_tall.TabIndex = 18;
            // 
            // txt_weight
            // 
            this.txt_weight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_weight.Location = new System.Drawing.Point(1024, 21);
            this.txt_weight.Multiline = true;
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(109, 33);
            this.txt_weight.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(1139, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "BMI:";
            // 
            // label_BMI
            // 
            this.label_BMI.AutoSize = true;
            this.label_BMI.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_BMI.Location = new System.Drawing.Point(1211, 21);
            this.label_BMI.Name = "label_BMI";
            this.label_BMI.Size = new System.Drawing.Size(27, 29);
            this.label_BMI.TabIndex = 21;
            this.label_BMI.Text = "0";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.Control;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_update.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_update.Location = new System.Drawing.Point(1225, 63);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(156, 55);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "修改歷史資料";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(1387, 63);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 55);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "刪除";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_bmi
            // 
            this.btn_bmi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_bmi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_bmi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_bmi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_bmi.Location = new System.Drawing.Point(1024, 63);
            this.btn_bmi.Name = "btn_bmi";
            this.btn_bmi.Size = new System.Drawing.Size(75, 55);
            this.btn_bmi.TabIndex = 24;
            this.btn_bmi.Text = "BMI";
            this.btn_bmi.UseVisualStyleBackColor = false;
            this.btn_bmi.Click += new System.EventHandler(this.btn_bmi_Click);
            // 
            // listbox_history
            // 
            this.listbox_history.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbox_history.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox_history.FormattingEnabled = true;
            this.listbox_history.ItemHeight = 25;
            this.listbox_history.Location = new System.Drawing.Point(0, 500);
            this.listbox_history.Name = "listbox_history";
            this.listbox_history.Size = new System.Drawing.Size(251, 154);
            this.listbox_history.TabIndex = 25;
            this.listbox_history.SelectedIndexChanged += new System.EventHandler(this.listbox_history_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(12, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 31);
            this.label8.TabIndex = 26;
            this.label8.Text = "評估歷史紀錄";
            // 
            // frm_功能評估表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1476, 658);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listbox_history);
            this.Controls.Add(this.btn_bmi);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label_BMI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_tall);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listbox_Patient);
            this.Controls.Add(this.flp_流動評估表);
            this.Controls.Add(this.btn_storage);
            this.Controls.Add(this.cmb_Question);
            this.Name = "frm_功能評估表";
            this.Text = "frm_住民功能評估和復建計畫";
            this.Load += new System.EventHandler(this.frm_功能評估表_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_storage;
        private System.Windows.Forms.FlowLayoutPanel flp_流動評估表;
        private System.Windows.Forms.ListBox listbox_Patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Question;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tall;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_BMI;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_bmi;
        private System.Windows.Forms.ListBox listbox_history;
        private System.Windows.Forms.Label label8;
    }
}