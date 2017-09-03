using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ToLaiDAO
    {
        public static DataTable DanhSachToLai()
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_SelectAllToLai", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }


    }
}
