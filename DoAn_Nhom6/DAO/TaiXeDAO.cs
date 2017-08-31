using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiXeDAO
    {
        public int DangNhap(string tendn, string matkhau)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_DANGNHAP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar);
            cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar);
            //gán giá trị cho tham số
            cmd.Parameters["@TENDANGNHAP"].Value = tendn;
            cmd.Parameters["@MATKHAU"].Value = matkhau;
            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
            return (int)System.Data.ParameterDirection.ReturnValue;
        }
    }
}
