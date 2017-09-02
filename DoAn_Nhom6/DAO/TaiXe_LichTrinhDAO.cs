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
    public class TaiXe_LichTrinhDAO
    {
        public DataTable DanhSachTaiXe_LichTrinh()
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_DANHSACH_TAIXE_LICHTRINH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }

        public List<TaiXe_LichTrinhDTO> TimKiem(int mataixe, string tentaixe, string tenlichtrinh, DateTime ngayphancong)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_TIMKIEM_TAIXE_LICHTRINH", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MATAIXE", SqlDbType.Int);
            cmd.Parameters.Add("@TENTAIXE", SqlDbType.NVarChar);
            cmd.Parameters.Add("@TENLICHTRINH", SqlDbType.NVarChar);
            cmd.Parameters.Add("@NGAYPHANCONG", SqlDbType.DateTime);
            //gán giá trị cho tham số
            cmd.Parameters["@MATAIXE"].Value = mataixe;
            cmd.Parameters["@TENTAIXE"].Value = tentaixe;
            cmd.Parameters["@TENLICHTRINH"].Value = tenlichtrinh;
            cmd.Parameters["@NGAYPHANCONG"].Value = ngayphancong;
            //Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();
            List<TaiXe_LichTrinhDTO> list = new List<TaiXe_LichTrinhDTO>();
            while (reader.Read())
            {
                TaiXe_LichTrinhDTO dto = new TaiXe_LichTrinhDTO();

                

                list.Add(dto);
            }
            //Đóng kết nối
            cn.Close();
            return list;
        }
    }
}
