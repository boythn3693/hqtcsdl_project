using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();
            dt = QuanLyTaiKhoan.DanhSachTaiKhoan();
            dsTK.DataSource = dt;
        }

        private void dsTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dsTK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string tenTK = Convert.ToString(dsTK.Rows[e.RowIndex].Cells[0].Value);

                TaiXeDTO dto = QuanLyTaiKhoan.LayThongTinTheoTenTK(tenTK);

                txtTenTK.Text = dto.Tendangnhap;
                txtMatKhau.Text = dto.Matkhau;
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(txtTenTK.Text == ""){
                MessageBox.Show("Chưa chọn tài khoản");
                return;
            }
            try
            {
                TaiXeDTO dto = QuanLyTaiKhoan.LayThongTinTheoTenTK(txtTenTK.Text);
                dto.Matkhau = txtMatKhau.Text;

                QuanLyTaiKhoan.CapNhatTaiKhoan(txtTenTK.Text, txtMatKhau.Text);
                LoadData();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDoiMatKhau_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
