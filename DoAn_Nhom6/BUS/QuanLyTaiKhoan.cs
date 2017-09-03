using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class QuanLyTaiKhoan
    {
        public static DataTable DanhSachTaiKhoan()
        {
            return TaiXeDAO.DanhSachTaiKhoan();
        }
        public static DataTable KiemTraTaiKhoann(string tentk, string mk)
        {
            return TaiXeDAO.KiemTraTaiKhoann(tentk, mk);
        }
        public static DataTable KiemTraTaiKhoan_Fix(string tentk, string mk)
        {
            return TaiXeDAO.KiemTraTaiKhoan_Fix(tentk, mk);
        }
       
        public static void CapNhatTaiKhoan(string tentk, string mk)
        {
            TaiXeDAO.CapNhatTaiKhoan(tentk,mk);
        }
        public static TaiXeDTO LayThongTinTheoTenTK(string tentk)
        {
            return TaiXeDAO.LayThongTinTheoTenTK(tentk);
        }

    }
}
