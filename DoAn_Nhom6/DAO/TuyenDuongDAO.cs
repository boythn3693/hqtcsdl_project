using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TuyenDuongDAO
    {
        public void ThemTuyenDuong(TuyenDuongDTO dto)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_ThemTuyenDuong", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTuyenDuong", SqlDbType.VarChar).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@TenTuyenDuong", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ChieuDai", SqlDbType.Int);
            
            //gán giá trị cho tham số
            cmd.Parameters["@MaTuyenDuong"].Value = dto.Matuyenduong;
            cmd.Parameters["@TenTuyenDuong"].Value = dto.Tentuyenduong;
            cmd.Parameters["@ChieuDai"].Value = dto.Chieudai;
            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //lấy mã sp đc phát sinh sau khi thêm, gán lại vào dto
            dto.Matuyenduong = cmd.Parameters["@MaTuyenDuong"].Value.ToString();
            //Đóng kết nối
            cn.Close();
        }

        public void SuaTuyenDuong(TuyenDuongDTO dto)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_SuaTuyenDuong", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTuyenDuong", SqlDbType.VarChar);
            cmd.Parameters.Add("@TenTuyenDuong", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ChieuDai", SqlDbType.Int);
            //gán giá trị cho tham số
            cmd.Parameters["@MaTuyenDuong"].Value = dto.Matuyenduong;
            cmd.Parameters["@TenTuyenDuong"].Value = dto.Tentuyenduong;
            cmd.Parameters["@ChieuDai"].Value = dto.Chieudai;
            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }

        public void XoaTuyenDuong(string matuyenduong)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_XoaTuyenDuong", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTuyenDuong", SqlDbType.VarChar);
            //gán giá trị cho tham số
            cmd.Parameters["@MaTuyenDuong"].Value = matuyenduong;
            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }
    }
}
