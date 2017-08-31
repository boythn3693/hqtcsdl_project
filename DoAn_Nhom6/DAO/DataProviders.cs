using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProviders
    {
        public static SqlConnection ConnectionDB()
        {
            string ConnStr = ConfigurationManager.ConnectionStrings["project"].ConnectionString;
            SqlConnection cn = new SqlConnection(ConnStr);
            cn.Open();
            return cn;
        }
    }
}
