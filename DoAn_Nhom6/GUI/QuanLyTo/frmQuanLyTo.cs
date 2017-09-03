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

namespace GUI.QuanLyTo
{
    public partial class frmQuanLyTo : Form
    {
        public frmQuanLyTo()
        {
            InitializeComponent();
            dateNgayNhanChuc.Value = DateTime.Now;

            LoadDanhSachToTruong();
        }
        public void LoadDanhSach_1()
        {
            DataTable table = new DataTable();
            table = ToLaiBUS.DanhSachToLai();

            dsTo_1.DataSource = table;
        }
        public void LoadDanhSach_2()
        {
            //DataTable table = new DataTable();
            //table = ToLaiBUS.DanhSachToLai();

            //dsTo_2.DataSource = table;
        }

        private void frmQuanLyTo_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadDanhSachToTruong()
        {
            DataTable dt = new DataTable();
            dt = TaiXeBUS.LoadDanhSachToTruong();
            cbTenToTruong.DataSource = dt;
            cbTenToTruong.DisplayMember = "TenTaiXe";
            cbTenToTruong.ValueMember = "MaTaiXe";

            cbNguoiQuanLy.DataSource = dt;
            cbNguoiQuanLy.DisplayMember = "TenTaiXe";
            cbNguoiQuanLy.ValueMember = "MaTaiXe";
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            LoadDanhSach_1();
        }

        public bool checkVailidate()
        {
            bool check = true;
            if (string.IsNullOrEmpty(txtTenTo.Text) || string.IsNullOrEmpty(Convert.ToString(dateNgayNhanChuc.Value)))
            {
                check = false;
            }

            return check;
        }

        private void btnThemTo_Click(object sender, EventArgs e)
        {
            bool check = checkVailidate();
            try
            {
                if(check)
                {
                    ToLaiDTO dto = new ToLaiDTO();
                    dto.Tento = txtTenTo.Text;
                    dto.Totruong = Convert.ToInt32(cbTenToTruong.SelectedValue);
                    dto.Ngaynhanchuc = Convert.ToDateTime(dateNgayNhanChuc.Value);
                    dto.Quanly = Convert.ToInt32(cbNguoiQuanLy.SelectedValue);

                    ToLaiBUS.ThemToLai(dto);
                    LoadDanhSach_1();
                } else
                {
                    MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaTo_Click(object sender, EventArgs e)
        {
            bool check = checkVailidate();
            try
            {
                if (check)
                {

                    ToLaiDTO dto = ToLaiBUS.TimKiemTheoTo(Convert.ToInt32(txtMaTo.Text));
                    dto.Tento = txtTenTo.Text;

                    ToLaiBUS.CapNhatTo(dto);
                    LoadDanhSach_1();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dsTo_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dsTo_1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int maTo = Convert.ToInt32(dsTo_1.Rows[e.RowIndex].Cells["MaTo"].Value);

                ToLaiDTO dto = ToLaiBUS.TimKiemTheoTo(maTo);
                txtMaTo.Text = Convert.ToString(dto.Mato);
                txtTenTo.Text = dto.Tento;
                dateNgayNhanChuc.Value = dto.Ngaynhanchuc;
                cbTenToTruong.SelectedValue = dto.Totruong;
                cbNguoiQuanLy.SelectedValue = dto.Quanly;
                
            }
        }

        private void btnFormTest_Click(object sender, EventArgs e)
        {
            frmQuanLyTo_Fix frm = new frmQuanLyTo_Fix();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmXemDanhSach_Fix frm = new frmXemDanhSach_Fix();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool check = checkVailidate();
            try
            {
                if (check)
                {

                    ToLaiDTO dto = ToLaiBUS.TimKiemTheoTo(Convert.ToInt32(txtMaTo.Text));
                    dto.Quanly = Convert.ToInt32(cbNguoiQuanLy.SelectedValue);

                    ToLaiBUS.CapNhatNguoiQuanLy(dto);
                    LoadDanhSach_1();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmXemTheoNguoiQuanLy_Fix frm = new frmXemTheoNguoiQuanLy_Fix();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = checkVailidate();
            try
            {
                if (check)
                {

                    ToLaiDTO dto = ToLaiBUS.TimKiemTheoTo(Convert.ToInt32(txtMaTo.Text));
                    dto.Ngaynhanchuc = Convert.ToDateTime(dateNgayNhanChuc.Value);

                    ToLaiBUS.CapNhatNgayNhanChuc_T2(dto);
                    LoadDanhSach_1();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
