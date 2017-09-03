using DAO;
using System.Data;

namespace BUS
{
    public class TaiXeBUS
    {
        public int DangNhap(string tendn, string matkhau)
        {
            TaiXeDAO dao = new TaiXeDAO();
            return dao.DangNhap(tendn, matkhau);
        }
        public static DataTable LoadDanhSachToTruong()
        {
            return TaiXeDAO.DanhSachTaiXe();
        }

        public static DataTable LoadDanhSachQL()
        {
            return TaiXeDAO.DanhSachQuanLy();
        }
    }
}
