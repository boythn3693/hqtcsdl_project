using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
