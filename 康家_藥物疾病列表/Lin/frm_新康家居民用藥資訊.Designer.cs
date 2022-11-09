namespace 康家_藥物疾病列表
{
    partial class frm_康家居民用藥資訊_新
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.DGV_Detail = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete用藥紀錄 = new System.Windows.Forms.Button();
            this.btn_update用藥紀錄 = new System.Windows.Forms.Button();
            this.btn_Insert用藥紀錄 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(92, 38);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 57);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "刪除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(167, 38);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(69, 57);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(17, 38);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(69, 57);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "新增";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // DGV_Detail
            // 
            this.DGV_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Detail.Location = new System.Drawing.Point(278, 136);
            this.DGV_Detail.Name = "DGV_Detail";
            this.DGV_Detail.RowHeadersWidth = 51;
            this.DGV_Detail.RowTemplate.Height = 27;
            this.DGV_Detail.Size = new System.Drawing.Size(825, 515);
            this.DGV_Detail.TabIndex = 24;
            this.DGV_Detail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Detail_CellClick);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(14, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 529);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 118);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制欄:日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(313, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "輸入欲查詢之住民ID或名稱";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_search.Location = new System.Drawing.Point(317, 56);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(129, 36);
            this.txt_search.TabIndex = 29;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Location = new System.Drawing.Point(242, 38);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(69, 57);
            this.btn_search.TabIndex = 28;
            this.btn_search.Text = "查詢";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete用藥紀錄);
            this.groupBox2.Controls.Add(this.btn_update用藥紀錄);
            this.groupBox2.Controls.Add(this.btn_Insert用藥紀錄);
            this.groupBox2.Location = new System.Drawing.Point(539, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 118);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制欄:藥物詳細資訊";
            // 
            // btn_delete用藥紀錄
            // 
            this.btn_delete用藥紀錄.Enabled = false;
            this.btn_delete用藥紀錄.Location = new System.Drawing.Point(181, 43);
            this.btn_delete用藥紀錄.Name = "btn_delete用藥紀錄";
            this.btn_delete用藥紀錄.Size = new System.Drawing.Size(69, 57);
            this.btn_delete用藥紀錄.TabIndex = 17;
            this.btn_delete用藥紀錄.Text = "刪除";
            this.btn_delete用藥紀錄.UseVisualStyleBackColor = true;
            this.btn_delete用藥紀錄.Click += new System.EventHandler(this.btn_delete_detail);
            // 
            // btn_update用藥紀錄
            // 
            this.btn_update用藥紀錄.Enabled = false;
            this.btn_update用藥紀錄.Location = new System.Drawing.Point(106, 43);
            this.btn_update用藥紀錄.Name = "btn_update用藥紀錄";
            this.btn_update用藥紀錄.Size = new System.Drawing.Size(69, 57);
            this.btn_update用藥紀錄.TabIndex = 16;
            this.btn_update用藥紀錄.Text = "修改";
            this.btn_update用藥紀錄.UseVisualStyleBackColor = true;
            this.btn_update用藥紀錄.Click += new System.EventHandler(this.btn_update_用藥紀錄);
            // 
            // btn_Insert用藥紀錄
            // 
            this.btn_Insert用藥紀錄.Enabled = false;
            this.btn_Insert用藥紀錄.Location = new System.Drawing.Point(31, 43);
            this.btn_Insert用藥紀錄.Name = "btn_Insert用藥紀錄";
            this.btn_Insert用藥紀錄.Size = new System.Drawing.Size(69, 57);
            this.btn_Insert用藥紀錄.TabIndex = 15;
            this.btn_Insert用藥紀錄.Text = "新增";
            this.btn_Insert用藥紀錄.UseVisualStyleBackColor = true;
            this.btn_Insert用藥紀錄.Click += new System.EventHandler(this.btn_insert_用藥紀錄);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(965, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 57);
            this.button1.TabIndex = 18;
            this.button1.Text = "重置視窗";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_reset);
            // 
            // frm_康家居民用藥資訊_新
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DGV_Detail);
            this.Name = "frm_康家居民用藥資訊_新";
            this.Text = "用藥紀錄表單_日期";
            this.Load += new System.EventHandler(this.frm_用藥紀錄表單_日期_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView DGV_Detail;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delete用藥紀錄;
        private System.Windows.Forms.Button btn_update用藥紀錄;
        private System.Windows.Forms.Button btn_Insert用藥紀錄;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}