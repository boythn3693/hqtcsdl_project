using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichTrinhDAO
    {
        public DataTable DanhSachLichTrinh()
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_LICHTRINH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }

        public List<LichTrinhDTO> DanhSachLichTrinh(string tenlichtrinh, string tentuyenduong)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_TIMKIEM_LICHTRINH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TENLICHTRINH", SqlDbType.NVarChar);
            cmd.Parameters.Add("@TENTUYENDUONG", SqlDbType.NVarChar);
            //gán giá trị cho tham số
            cmd.Parameters["@TENLICHTRINH"].Value = tenlichtrinh;
            cmd.Parameters["@TENTUYENDUONG"].Value = tentuyenduong;
            //Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();
            List<LichTrinhDTO> list = new List<LichTrinhDTO>();
            while (reader.Read())
            {
                LichTrinhDTO dto = new LichTrinhDTO();



                list.Add(dto);
            }
            //Đóng kết nối
            cn.Close();
            return list;
        }
    }
}
