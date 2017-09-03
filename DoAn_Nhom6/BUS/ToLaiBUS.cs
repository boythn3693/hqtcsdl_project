using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class ToLaiBUS
    {
        public static DataTable DanhSachToLai()
        {
            return ToLaiDAO.DanhSachToLai();
        }
    }
}
