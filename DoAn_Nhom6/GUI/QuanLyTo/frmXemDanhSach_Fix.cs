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
    public partial class frmXemDanhSach_Fix : Form
    {
        public frmXemDanhSach_Fix()
        {
            InitializeComponent();
        }

        //Loi bong ma
        private void btnXemDanhSach_2_Click(object sender, EventArgs e)
        {
            dsTo.DataSource = ToLaiBUS.DanhSachTo_BongMa();
        }

        //khac phuc
        private void btnXemDanhSach_KhacPhuc_Click(object sender, EventArgs e)
        {
            dsTo.DataSource = ToLaiBUS.DanhSachTo_BongMa_Fix();
        }
    }
}
