using DAO;

namespace BUS
{
    public class TaiXeBUS
    {
        public int DangNhap(string tendn, string matkhau)
        {
            TaiXeDAO dao = new TaiXeDAO();
            return dao.DangNhap(tendn, matkhau);
        }
    }
}
