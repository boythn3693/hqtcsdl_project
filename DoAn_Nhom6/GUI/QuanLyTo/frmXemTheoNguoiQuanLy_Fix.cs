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

namespace GUI.QuanLyTo
{
    public partial class frmXemTheoNguoiQuanLy_Fix : Form
    {
        public frmXemTheoNguoiQuanLy_Fix()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int maQL = Convert.ToInt32(cbNguoiQuanLy.SelectedValue);
            dsTo.DataSource = ToLaiBUS.XemTheoTo_UnReadtableRead(maQL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int maQL = Convert.ToInt32(cbNguoiQuanLy.SelectedValue);
            dsTo.DataSource = ToLaiBUS.XemTheoTo_UnReadtableRead_Fix(maQL);
        }

        private void frmXemTheoNguoiQuanLy_Fix_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = TaiXeBUS.LoadDanhSachToTruong();
            cbNguoiQuanLy.DataSource = dt;
            cbNguoiQuanLy.DisplayMember = "TenTaiXe";
            cbNguoiQuanLy.ValueMember = "MaTaiXe";
        }
    }
}
