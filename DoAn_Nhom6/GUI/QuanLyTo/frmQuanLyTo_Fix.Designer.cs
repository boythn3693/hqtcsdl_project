namespace GUI.QuanLyTo
{
    partial class frmQuanLyTo_Fix
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
            this.dsTo_2 = new System.Windows.Forms.DataGridView();
            this.MaToo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.cbToLai = new System.Windows.Forms.ComboBox();
            this.btnXemDanhSach_2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateNgayNhanChuc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsTo_2)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTo_2
            // 
            this.dsTo_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsTo_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTo_2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaToo,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dsTo_2.Location = new System.Drawing.Point(12, 123);
            this.dsTo_2.Name = "dsTo_2";
            this.dsTo_2.Size = new System.Drawing.Size(792, 202);
            this.dsTo_2.TabIndex = 16;
            this.dsTo_2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTo_2_CellClick);
            // 
            // MaToo
            // 
            this.MaToo.DataPropertyName = "MaTo";
            this.MaToo.FillWeight = 42.92785F;
            this.MaToo.HeaderText = "Mã Tổ";
            this.MaToo.Name = "MaToo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenTo";
            this.dataGridViewTextBoxColumn1.FillWeight = 126.9036F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Tổ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenTaiXe";
            this.dataGridViewTextBoxColumn2.FillWeight = 110.0562F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tổ Trưởng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayNhanChuc";
            this.dataGridViewTextBoxColumn3.FillWeight = 110.0562F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày nhận chức";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenTaiXe1";
            this.dataGridViewTextBoxColumn4.FillWeight = 110.0562F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Người quản lý";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Chọn tổ";
            // 
            // cbToLai
            // 
            this.cbToLai.FormattingEnabled = true;
            this.cbToLai.Location = new System.Drawing.Point(89, 62);
            this.cbToLai.Name = "cbToLai";
            this.cbToLai.Size = new System.Drawing.Size(361, 21);
            this.cbToLai.TabIndex = 24;
            // 
            // btnXemDanhSach_2
            // 
            this.btnXemDanhSach_2.Location = new System.Drawing.Point(12, 94);
            this.btnXemDanhSach_2.Name = "btnXemDanhSach_2";
            this.btnXemDanhSach_2.Size = new System.Drawing.Size(226, 23);
            this.btnXemDanhSach_2.TabIndex = 23;
            this.btnXemDanhSach_2.Text = "Xem theo tổ (Lỗi Dirty Read)";
            this.btnXemDanhSach_2.UseVisualStyleBackColor = true;
            this.btnXemDanhSach_2.Click += new System.EventHandler(this.btnXemDanhSach_2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "Xem thông tin của tổ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Khắc phục lỗi (Dirty Read)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateNgayNhanChuc
            // 
            this.dateNgayNhanChuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayNhanChuc.Location = new System.Drawing.Point(604, 93);
            this.dateNgayNhanChuc.Name = "dateNgayNhanChuc";
            this.dateNgayNhanChuc.Size = new System.Drawing.Size(200, 20);
            this.dateNgayNhanChuc.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày nhận chức";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(553, 331);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(118, 23);
            this.btnCapnhat.TabIndex = 30;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cập nhật Fix lỗi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmQuanLyTo_Fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateNgayNhanChuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbToLai);
            this.Controls.Add(this.btnXemDanhSach_2);
            this.Controls.Add(this.dsTo_2);
            this.Name = "frmQuanLyTo_Fix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem thông tin tổ";
            this.Load += new System.EventHandler(this.frmQuanLyTo_Fix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTo_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsTo_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaToo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbToLai;
        private System.Windows.Forms.Button btnXemDanhSach_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateNgayNhanChuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button button2;
    }
}