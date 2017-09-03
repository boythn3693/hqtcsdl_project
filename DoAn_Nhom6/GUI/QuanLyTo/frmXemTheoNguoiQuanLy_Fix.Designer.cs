namespace GUI.QuanLyTo
{
    partial class frmXemTheoNguoiQuanLy_Fix
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
            this.button3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.dsTo = new System.Windows.Forms.DataGridView();
            this.MaToo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNguoiQuanLy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsTo)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Khắc phục lỗi (Unreadtable Read)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(48, 119);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(226, 23);
            this.btn1.TabIndex = 30;
            this.btn1.Text = "Xem theo người quản lý (Lỗi Unreadtable Read)";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
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
            this.dsTo.Location = new System.Drawing.Point(12, 158);
            this.dsTo.Name = "dsTo";
            this.dsTo.Size = new System.Drawing.Size(792, 202);
            this.dsTo.TabIndex = 32;
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
            this.label7.Location = new System.Drawing.Point(255, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 31);
            this.label7.TabIndex = 33;
            this.label7.Text = "Xem thông tin tổ ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Chọn người quản lý";
            // 
            // cbNguoiQuanLy
            // 
            this.cbNguoiQuanLy.FormattingEnabled = true;
            this.cbNguoiQuanLy.Location = new System.Drawing.Point(125, 83);
            this.cbNguoiQuanLy.Name = "cbNguoiQuanLy";
            this.cbNguoiQuanLy.Size = new System.Drawing.Size(361, 21);
            this.cbNguoiQuanLy.TabIndex = 34;
            // 
            // frmXemTheoNguoiQuanLy_Fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 372);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbNguoiQuanLy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dsTo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn1);
            this.Name = "frmXemTheoNguoiQuanLy_Fix";
            this.Text = "Xem thông tin tổ theo nhà quản lý";
            this.Load += new System.EventHandler(this.frmXemTheoNguoiQuanLy_Fix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView dsTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaToo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbNguoiQuanLy;
    }
}