using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public int _matk;
        public string _taikhoan="", _hoten="";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string __taikhoan = txtTaiKhoan.Text;
            string __matkhau = txtMatKhau.Text;

            if (__taikhoan.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo");
                txtTaiKhoan.Focus();
            }
            else if (__matkhau.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu", "Thông báo");
                txtMatKhau.Focus();
            }
            else
            {
                try
                {
                    TaiXeBUS bus = new TaiXeBUS();
                    int login = bus.DangNhap(__taikhoan, __matkhau);

                    if (login > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            _taikhoan = __taikhoan;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
