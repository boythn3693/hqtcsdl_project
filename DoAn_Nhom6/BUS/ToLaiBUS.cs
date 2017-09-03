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
    public class ToLaiBUS
    {
        public static DataTable DanhSachToLai()
        {
            return ToLaiDAO.DanhSachToLai();
        }
        public static DataTable XemTheoTo(int maTo)
        {
            return ToLaiDAO.XemTheoTo(maTo);
        }

        public static ToLaiDTO TimKiemTheoTo(int maTo)
        {
            return ToLaiDAO.TimKiemTheoTo(maTo);
        }

        ///////////////////////////////////////////
        //Dirty Read
        public static void CapNhatTo(ToLaiDTO dto)
        {
            ToLaiDAO.CapNhatTo(dto);
        }

        //Loi dirty read
        public static DataTable XemThongTinTheoTo(int maTo)
        {
            return ToLaiDAO.XemThongTinTheoTo(maTo);
        }
        //Khac phuc Loi dirty read
        public static DataTable XemThongTinTheoTo_Fix(int maTo)
        {
            return ToLaiDAO.XemThongTinTheoTo_Fix(maTo);
        }

        ///////////////////////////////////////////
        //Bong ma
        public static void ThemToLai(ToLaiDTO dto)
        {
            ToLaiDAO.ThemToLai(dto);
        }
        public static DataTable DanhSachTo_BongMa()
        {
            return ToLaiDAO.DanhSachTo_BongMa();
        }
        public static DataTable DanhSachTo_BongMa_Fix()
        {
            return ToLaiDAO.DanhSachTo_BongMa_Fix();
        }

        ////////////////////////////////////////////
        //Unreadtable Read
        public static DataTable XemTheoTo_UnReadtableRead(int maTo)
        {
            return ToLaiDAO.XemTheoTo_UnReadtableRead(maTo);
        }
        public static DataTable XemTheoTo_UnReadtableRead_Fix(int maTo)
        {
            return ToLaiDAO.XemTheoTo_UnReadtableRead_Fix(maTo);
        }
        public static void CapNhatNguoiQuanLy(ToLaiDTO dto)
        {
            ToLaiDAO.CapNhatNguoiQuanLy(dto);
        }

        public static void CapNhatNgayNhanChuc(ToLaiDTO dto)
        {
            ToLaiDAO.CapNhatNgayNhanChuc(dto);
        }
        public static void CapNhatNgayNhanChuc_T2(ToLaiDTO dto)
        {
            ToLaiDAO.CapNhatNgayNhanChuc_T2(dto);
        }
        public static void CapNhatNgayNhanChuc_Fix(ToLaiDTO dto)
        {
            ToLaiDAO.CapNhatNgayNhanChuc_Fix(dto);
        }
    }
}
