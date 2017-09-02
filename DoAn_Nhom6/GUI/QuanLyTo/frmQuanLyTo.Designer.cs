namespace GUI.QuanLyTo
{
    partial class frmQuanLyTo
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
            this.dsLoi = new System.Windows.Forms.DataGridView();
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.btnThemTo = new System.Windows.Forms.Button();
            this.btnSuaTo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTo = new System.Windows.Forms.TextBox();
            this.dateNgayNhanChuc = new System.Windows.Forms.DateTimePicker();
            this.cbNguoiQuanLy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenToTruong = new System.Windows.Forms.ComboBox();
            this.dsSuaLoi = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TenTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSuaLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dsLoi
            // 
            this.dsLoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsLoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsLoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTo,
            this.ToTruong,
            this.NgayNhanChuc,
            this.QuanLy});
            this.dsLoi.Location = new System.Drawing.Point(12, 204);
            this.dsLoi.Name = "dsLoi";
            this.dsLoi.Size = new System.Drawing.Size(470, 219);
            this.dsLoi.TabIndex = 0;
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.Location = new System.Drawing.Point(190, 154);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(122, 23);
            this.btnXemDanhSach.TabIndex = 1;
            this.btnXemDanhSach.Text = "Xem danh sách tổ";
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnThemTo
            // 
            this.btnThemTo.Location = new System.Drawing.Point(351, 154);
            this.btnThemTo.Name = "btnThemTo";
            this.btnThemTo.Size = new System.Drawing.Size(122, 23);
            this.btnThemTo.TabIndex = 2;
            this.btnThemTo.Text = "Thêm tổ";
            this.btnThemTo.UseVisualStyleBackColor = true;
            // 
            // btnSuaTo
            // 
            this.btnSuaTo.Location = new System.Drawing.Point(515, 154);
            this.btnSuaTo.Name = "btnSuaTo";
            this.btnSuaTo.Size = new System.Drawing.Size(122, 23);
            this.btnSuaTo.TabIndex = 3;
            this.btnSuaTo.Text = "Cập nhật";
            this.btnSuaTo.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(680, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ TỔ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenTo
            // 
            this.txtTenTo.Location = new System.Drawing.Point(243, 66);
            this.txtTenTo.Name = "txtTenTo";
            this.txtTenTo.Size = new System.Drawing.Size(191, 20);
            this.txtTenTo.TabIndex = 7;
            // 
            // dateNgayNhanChuc
            // 
            this.dateNgayNhanChuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayNhanChuc.Location = new System.Drawing.Point(657, 63);
            this.dateNgayNhanChuc.Name = "dateNgayNhanChuc";
            this.dateNgayNhanChuc.Size = new System.Drawing.Size(200, 20);
            this.dateNgayNhanChuc.TabIndex = 8;
            // 
            // cbNguoiQuanLy
            // 
            this.cbNguoiQuanLy.FormattingEnabled = true;
            this.cbNguoiQuanLy.Location = new System.Drawing.Point(657, 102);
            this.cbNguoiQuanLy.Name = "cbNguoiQuanLy";
            this.cbNguoiQuanLy.Size = new System.Drawing.Size(200, 21);
            this.cbNguoiQuanLy.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên tổ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên tổ trường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Người quản lý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày nhận chức";
            // 
            // cbTenToTruong
            // 
            this.cbTenToTruong.FormattingEnabled = true;
            this.cbTenToTruong.Location = new System.Drawing.Point(243, 106);
            this.cbTenToTruong.Name = "cbTenToTruong";
            this.cbTenToTruong.Size = new System.Drawing.Size(191, 21);
            this.cbTenToTruong.TabIndex = 14;
            // 
            // dsSuaLoi
            // 
            this.dsSuaLoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsSuaLoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSuaLoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dsSuaLoi.Location = new System.Drawing.Point(512, 204);
            this.dsSuaLoi.Name = "dsSuaLoi";
            this.dsSuaLoi.Size = new System.Drawing.Size(462, 219);
            this.dsSuaLoi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bảng tranh chấp lỗi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(677, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Bảng sửa lỗi tranh chấp";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TenTo
            // 
            this.TenTo.DataPropertyName = "TenTo";
            this.TenTo.HeaderText = "Tên Tổ";
            this.TenTo.Name = "TenTo";
            // 
            // ToTruong
            // 
            this.ToTruong.DataPropertyName = "ToTruong";
            this.ToTruong.HeaderText = "Tổ Trưởng";
            this.ToTruong.Name = "ToTruong";
            // 
            // NgayNhanChuc
            // 
            this.NgayNhanChuc.DataPropertyName = "NgayNhanChuc";
            this.NgayNhanChuc.HeaderText = "Ngày nhận chức";
            this.NgayNhanChuc.Name = "NgayNhanChuc";
            // 
            // QuanLy
            // 
            this.QuanLy.DataPropertyName = "QuanLy";
            this.QuanLy.HeaderText = "Người quản lý";
            this.QuanLy.Name = "QuanLy";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenTo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Tổ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ToTruong";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tổ Trưởng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayNhanChuc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày nhận chức";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuanLy";
            this.dataGridViewTextBoxColumn4.HeaderText = "Người quản lý";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmQuanLyTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 506);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dsSuaLoi);
            this.Controls.Add(this.cbTenToTruong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNguoiQuanLy);
            this.Controls.Add(this.dateNgayNhanChuc);
            this.Controls.Add(this.txtTenTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSuaTo);
            this.Controls.Add(this.btnThemTo);
            this.Controls.Add(this.btnXemDanhSach);
            this.Controls.Add(this.dsLoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuanLyTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tên tổ trưởng";
            this.Load += new System.EventHandler(this.frmQuanLyTo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSuaLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsLoi;
        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.Button btnThemTo;
        private System.Windows.Forms.Button btnSuaTo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTo;
        private System.Windows.Forms.DateTimePicker dateNgayNhanChuc;
        private System.Windows.Forms.ComboBox cbNguoiQuanLy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTenToTruong;
        private System.Windows.Forms.DataGridView dsSuaLoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanChuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}