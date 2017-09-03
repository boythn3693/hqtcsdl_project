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
            this.dsTo_1 = new System.Windows.Forms.DataGridView();
            this.MaTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.btnThemTo = new System.Windows.Forms.Button();
            this.btnSuaTo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTo = new System.Windows.Forms.TextBox();
            this.dateNgayNhanChuc = new System.Windows.Forms.DateTimePicker();
            this.cbNguoiQuanLy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTenToTruong = new System.Windows.Forms.ComboBox();
            this.txtMaTo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFormTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsTo_1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTo_1
            // 
            this.dsTo_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsTo_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTo_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTo,
            this.TenTo,
            this.ToTruong,
            this.NgayNhanChuc,
            this.QuanLy});
            this.dsTo_1.Location = new System.Drawing.Point(12, 204);
            this.dsTo_1.Name = "dsTo_1";
            this.dsTo_1.Size = new System.Drawing.Size(962, 219);
            this.dsTo_1.TabIndex = 0;
            this.dsTo_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTo_1_CellClick);
            // 
            // MaTo
            // 
            this.MaTo.DataPropertyName = "MaTo";
            this.MaTo.FillWeight = 48.8506F;
            this.MaTo.HeaderText = "Mã Tổ";
            this.MaTo.Name = "MaTo";
            // 
            // TenTo
            // 
            this.TenTo.DataPropertyName = "TenTo";
            this.TenTo.FillWeight = 126.9036F;
            this.TenTo.HeaderText = "Tên Tổ";
            this.TenTo.Name = "TenTo";
            // 
            // ToTruong
            // 
            this.ToTruong.DataPropertyName = "TenTaiXe";
            this.ToTruong.FillWeight = 108.0819F;
            this.ToTruong.HeaderText = "Tổ Trưởng";
            this.ToTruong.Name = "ToTruong";
            // 
            // NgayNhanChuc
            // 
            this.NgayNhanChuc.DataPropertyName = "NgayNhanChuc";
            this.NgayNhanChuc.FillWeight = 108.0819F;
            this.NgayNhanChuc.HeaderText = "Ngày nhận chức";
            this.NgayNhanChuc.Name = "NgayNhanChuc";
            // 
            // QuanLy
            // 
            this.QuanLy.DataPropertyName = "TenTaiXe1";
            this.QuanLy.FillWeight = 108.0819F;
            this.QuanLy.HeaderText = "Người quản lý";
            this.QuanLy.Name = "QuanLy";
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.Location = new System.Drawing.Point(12, 175);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(114, 23);
            this.btnXemDanhSach.TabIndex = 1;
            this.btnXemDanhSach.Text = "Làm mới danh sách";
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);
            // 
            // btnThemTo
            // 
            this.btnThemTo.Location = new System.Drawing.Point(273, 142);
            this.btnThemTo.Name = "btnThemTo";
            this.btnThemTo.Size = new System.Drawing.Size(122, 23);
            this.btnThemTo.TabIndex = 2;
            this.btnThemTo.Text = "Thêm tổ";
            this.btnThemTo.UseVisualStyleBackColor = true;
            this.btnThemTo.Click += new System.EventHandler(this.btnThemTo_Click);
            // 
            // btnSuaTo
            // 
            this.btnSuaTo.Location = new System.Drawing.Point(401, 142);
            this.btnSuaTo.Name = "btnSuaTo";
            this.btnSuaTo.Size = new System.Drawing.Size(122, 23);
            this.btnSuaTo.TabIndex = 3;
            this.btnSuaTo.Text = "Đổi tên tổ";
            this.btnSuaTo.UseVisualStyleBackColor = true;
            this.btnSuaTo.Click += new System.EventHandler(this.btnSuaTo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(529, 142);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Đổi người quản lý";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.txtTenTo.Location = new System.Drawing.Point(291, 62);
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
            this.label2.Location = new System.Drawing.Point(202, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên tổ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 107);
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
            // cbTenToTruong
            // 
            this.cbTenToTruong.FormattingEnabled = true;
            this.cbTenToTruong.Location = new System.Drawing.Point(291, 102);
            this.cbTenToTruong.Name = "cbTenToTruong";
            this.cbTenToTruong.Size = new System.Drawing.Size(191, 21);
            this.cbTenToTruong.TabIndex = 14;
            // 
            // txtMaTo
            // 
            this.txtMaTo.Enabled = false;
            this.txtMaTo.Location = new System.Drawing.Point(12, 86);
            this.txtMaTo.Name = "txtMaTo";
            this.txtMaTo.Size = new System.Drawing.Size(100, 20);
            this.txtMaTo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(44, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã Tổ";
            // 
            // btnFormTest
            // 
            this.btnFormTest.Location = new System.Drawing.Point(12, 456);
            this.btnFormTest.Name = "btnFormTest";
            this.btnFormTest.Size = new System.Drawing.Size(148, 23);
            this.btnFormTest.TabIndex = 22;
            this.btnFormTest.Text = "Xem thông tin theo tổ";
            this.btnFormTest.UseVisualStyleBackColor = true;
            this.btnFormTest.Click += new System.EventHandler(this.btnFormTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Xem danh sách tổ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cập nhật ngày nhận chức";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Xem danh sách tổ theo nhà quản lý";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // frmQuanLyTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 506);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFormTest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaTo);
            this.Controls.Add(this.cbTenToTruong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNguoiQuanLy);
            this.Controls.Add(this.dateNgayNhanChuc);
            this.Controls.Add(this.txtTenTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSuaTo);
            this.Controls.Add(this.btnThemTo);
            this.Controls.Add(this.btnXemDanhSach);
            this.Controls.Add(this.dsTo_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuanLyTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tổ";
            this.Load += new System.EventHandler(this.frmQuanLyTo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTo_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsTo_1;
        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.Button btnThemTo;
        private System.Windows.Forms.Button btnSuaTo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTo;
        private System.Windows.Forms.DateTimePicker dateNgayNhanChuc;
        private System.Windows.Forms.ComboBox cbNguoiQuanLy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTenToTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanChuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuanLy;
        private System.Windows.Forms.TextBox txtMaTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFormTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
    }
}