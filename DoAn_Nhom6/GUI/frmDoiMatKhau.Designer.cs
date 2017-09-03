namespace GUI
{
    partial class frmDoiMatKhau
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
            this.dsTK = new System.Windows.Forms.DataGridView();
            this.MaTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTK
            // 
            this.dsTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTo,
            this.TenTo});
            this.dsTK.Location = new System.Drawing.Point(12, 145);
            this.dsTK.Name = "dsTK";
            this.dsTK.Size = new System.Drawing.Size(577, 191);
            this.dsTK.TabIndex = 1;
            this.dsTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTK_CellClick);
            // 
            // MaTo
            // 
            this.MaTo.DataPropertyName = "TenDangNhap";
            this.MaTo.FillWeight = 48.8506F;
            this.MaTo.HeaderText = "Tên đăng nhập";
            this.MaTo.Name = "MaTo";
            // 
            // TenTo
            // 
            this.TenTo.DataPropertyName = "MatKhau";
            this.TenTo.FillWeight = 126.9036F;
            this.TenTo.HeaderText = "Mật khẩu";
            this.TenTo.Name = "TenTo";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên tài khoản";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Enabled = false;
            this.txtTenTK.Location = new System.Drawing.Point(110, 57);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(191, 20);
            this.txtTenTK.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(110, 83);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(191, 20);
            this.txtMatKhau.TabIndex = 13;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(110, 116);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(135, 23);
            this.btnDoiMatKhau.TabIndex = 16;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 348);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dsTK);
            this.Name = "frmDoiMatKhau";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTo;
    }
}