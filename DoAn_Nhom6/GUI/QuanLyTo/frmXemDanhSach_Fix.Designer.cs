namespace GUI.QuanLyTo
{
    partial class frmXemDanhSach_Fix
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
            this.dsTo = new System.Windows.Forms.DataGridView();
            this.MaToo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXemDanhSach = new System.Windows.Forms.Button();
            this.btnXemDanhSach_KhacPhuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsTo)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTo
            // 
            this.dsTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaToo,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dsTo.Location = new System.Drawing.Point(12, 109);
            this.dsTo.Name = "dsTo";
            this.dsTo.Size = new System.Drawing.Size(792, 202);
            this.dsTo.TabIndex = 17;
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
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Xem danh sách tổ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXemDanhSach
            // 
            this.btnXemDanhSach.CausesValidation = false;
            this.btnXemDanhSach.Location = new System.Drawing.Point(12, 71);
            this.btnXemDanhSach.Name = "btnXemDanhSach";
            this.btnXemDanhSach.Size = new System.Drawing.Size(226, 23);
            this.btnXemDanhSach.TabIndex = 28;
            this.btnXemDanhSach.Text = "Xem danh sách (Lỗi bóng ma)";
            this.btnXemDanhSach.UseVisualStyleBackColor = true;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_2_Click);
            // 
            // btnXemDanhSach_KhacPhuc
            // 
            this.btnXemDanhSach_KhacPhuc.CausesValidation = false;
            this.btnXemDanhSach_KhacPhuc.Location = new System.Drawing.Point(255, 71);
            this.btnXemDanhSach_KhacPhuc.Name = "btnXemDanhSach_KhacPhuc";
            this.btnXemDanhSach_KhacPhuc.Size = new System.Drawing.Size(226, 23);
            this.btnXemDanhSach_KhacPhuc.TabIndex = 29;
            this.btnXemDanhSach_KhacPhuc.Text = "Xem danh sách (Khắc phục Lỗi bóng ma)";
            this.btnXemDanhSach_KhacPhuc.UseVisualStyleBackColor = true;
            this.btnXemDanhSach_KhacPhuc.Click += new System.EventHandler(this.btnXemDanhSach_KhacPhuc_Click);
            // 
            // frmXemDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(815, 319);
            this.Controls.Add(this.btnXemDanhSach_KhacPhuc);
            this.Controls.Add(this.btnXemDanhSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dsTo);
            this.Name = "frmXemDanhSach";
            this.Text = "Xem danh sách";
            ((System.ComponentModel.ISupportInitialize)(this.dsTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaToo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.Button btnXemDanhSach_KhacPhuc;
    }
}