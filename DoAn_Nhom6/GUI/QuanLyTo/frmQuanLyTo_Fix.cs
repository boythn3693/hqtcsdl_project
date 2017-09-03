using BUS;
using DTO;
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
    public partial class frmQuanLyTo_Fix : Form
    {
        public frmQuanLyTo_Fix()
        {
            InitializeComponent();
        }

        private void btnXemDanhSach_2_Click(object sender, EventArgs e)
        {
            int maTo = Convert.ToInt32(cbToLai.SelectedValue);
            dsTo_2.DataSource = ToLaiBUS.XemThongTinTheoTo_Fix(maTo);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int maTo = Convert.ToInt32(cbToLai.SelectedValue);
            dsTo_2.DataSource = ToLaiBUS.XemThongTinTheoTo(maTo);
        }

        private void frmQuanLyTo_Fix_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ToLaiBUS.DanhSachToLai();

            cbToLai.DataSource = dt;
            cbToLai.DisplayMember = "TenTo";
            cbToLai.ValueMember = "MaTo";
        }

        private void dsTo_2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dsTo_2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int maTo = Convert.ToInt32(dsTo_2.Rows[e.RowIndex].Cells[0].Value);

                ToLaiDTO dto = ToLaiBUS.TimKiemTheoTo(maTo);
                dateNgayNhanChuc.Value = dto.Ngaynhanchuc;
         
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maTo = Convert.ToInt32(cbToLai.SelectedValue);
                ToLaiDTO dto = ToLaiBUS.TimKiemTheoTo(Convert.ToInt32(maTo));
                dto.Ngaynhanchuc = Convert.ToDateTime(dateNgayNhanChuc.Value);

                ToLaiBUS.CapNhatNgayNhanChuc(dto);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int maTo = Convert.ToInt32(cbToLai.SelectedValue);
                ToLaiDTO dto = ToLaiBUS.TimKiemTheoTo(Convert.ToInt32(maTo));
                dto.Ngaynhanchuc = Convert.ToDateTime(dateNgayNhanChuc.Value);

                ToLaiBUS.CapNhatNgayNhanChuc_Fix(dto);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            int maTo = Convert.ToInt32(cbToLai.SelectedValue);
            dsTo_2.DataSource = ToLaiBUS.XemTheoTo(maTo);
        }

    }
}
