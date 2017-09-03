using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.QuanLyTo;
namespace GUI
{
    public partial class frmMain : Form
    {
        private static string taikhoan;
        private static int phanquyen;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();

            taikhoan = frm._taikhoan;

            if ( taikhoan.Length == 0 )
            {
                this.Close();
            }
            else
            {
                
            }
        }

        private void btnQuanLyTo_Click(object sender, EventArgs e)
        {
            frmQuanLyTo ql = new frmQuanLyTo();
            ql.ShowDialog();
        }

        private void quanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }
    }
}
