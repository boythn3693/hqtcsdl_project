using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ToLaiDAO
    {
        //Loi dirty read
        public static DataTable XemThongTinTheoTo(int maTo)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_XEMTHONGTIN_TO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            //gán giá trị cho tham số
            cmd.Parameters["@MaTo"].Value = maTo;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;       
        }

        //Khac phuc loi dirty read
        public static DataTable XemThongTinTheoTo_Fix(int maTo)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_FIX_XEMTHONGTIN_TO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            //gán giá trị cho tham số
            cmd.Parameters["@MaTo"].Value = maTo;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }

        //Dirty read
        public static void CapNhatTo(ToLaiDTO t)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_CAPNHAT_TO", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            cmd.Parameters.Add("@TenTo", SqlDbType.NVarChar);
          
            //gán giá trị cho tham số
            cmd.Parameters["@MaTo"].Value = t.Mato;
            cmd.Parameters["@TenTo"].Value = t.Tento;
          
            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }



        //Bong ma
        public static void ThemToLai(ToLaiDTO dto)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_THEM_TO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenTo", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ToTruong", SqlDbType.Int);
            cmd.Parameters.Add("@NgayNhanChuc", SqlDbType.DateTime);
            cmd.Parameters.Add("@QuanLy", SqlDbType.Int);
            
            //cmd.Parameters.Add("@MaTaiXe", SqlDbType.Int).Direction = ParameterDirection.Output;

            //gán giá trị cho tham số
            cmd.Parameters["@TenTo"].Value = dto.Tento;
            cmd.Parameters["@ToTruong"].Value = dto.Totruong;
            cmd.Parameters["@NgayNhanChuc"].Value = dto.Ngaynhanchuc;
            cmd.Parameters["@QuanLy"].Value = dto.Quanly;
            
            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }

        //loi bong ma
        public static DataTable DanhSachTo_BongMa()
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_XemDanhSachTo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }

        //khac phuc loi bong ma
        public static DataTable DanhSachTo_BongMa_Fix()
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_Fix_XemDanhSachTo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }



        //Unreadtable Read
        public static DataTable XemTheoTo_UnReadtableRead(int maQuanLy)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_XemThongTinTheoTo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNguoiQuanLy", SqlDbType.Int);
            //gán giá trị cho tham số
            cmd.Parameters["@MaNguoiQuanLy"].Value = maQuanLy;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;   
        }
        //Unreadtable Read fix
        public static DataTable XemTheoTo_UnReadtableRead_Fix(int maQuanLy)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_Fix_XemThongTinTheoTo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNguoiQuanLy", SqlDbType.Int);
            //gán giá trị cho tham số
            cmd.Parameters["@MaNguoiQuanLy"].Value = maQuanLy;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt; 
        }
        ////Unreadtable Read
        public static void CapNhatNguoiQuanLy(ToLaiDTO t)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_DOINGUOIQUANLY", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            cmd.Parameters.Add("@QuanLy", SqlDbType.Int);

            //gán giá trị cho tham số
            cmd.Parameters["@MaTo"].Value = t.Mato;
            cmd.Parameters["@QuanLy"].Value = t.Quanly;

            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }


        //Lost update
        public static void CapNhatNgayNhanChuc(ToLaiDTO t)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_CAPNHATTHONGTIN_TO", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            cmd.Parameters.Add("@NgayNhanChuc", SqlDbType.DateTime);

            //gán giá trị cho tham số
            cmd.Parameters["@MaTo"].Value = t.Mato;
            cmd.Parameters["@NgayNhanChuc"].Value = t.Quanly;

            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }
        public static void CapNhatNgayNhanChuc_T2(ToLaiDTO t)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_CAPNHATTHONGTIN_TO_T2", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            cmd.Parameters.Add("@NgayNhanChuc", SqlDbType.DateTime);

            //gán giá trị cho tham số
            cmd.Parameters["@MaTo"].Value = t.Mato;
            cmd.Parameters["@NgayNhanChuc"].Value = t.Quanly;

            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }
        public static void CapNhatNgayNhanChuc_Fix(ToLaiDTO t)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_FIX_CAPNHATTHONGTIN_TO", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            cmd.Parameters.Add("@NgayNhanChuc", SqlDbType.DateTime);

            //gán giá trị cho tham số
            cmd.Parameters["@MaTo"].Value = t.Mato;
            cmd.Parameters["@NgayNhanChuc"].Value = t.Quanly;

            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }


        //Khong co Waitfor delay
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
        public static DataTable XemTheoTo(int maTo)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_Timkiem_MaTo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            //gán giá trị cho tham số
            cmd.Parameters["@MaTo"].Value = maTo;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }
        public static ToLaiDTO TimKiemTheoTo(int maTo)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_SelectToLai_MaTo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            //gán giá trị cho tham số
            cmd.Parameters["@MaTo"].Value = maTo;

            //Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();
            ToLaiDTO dto = new ToLaiDTO();
            while (reader.Read())
            {
                dto.Mato = reader.GetInt32(0);
                dto.Tento = reader.GetString(1);
                dto.Totruong = reader.GetInt32(2);
                dto.Ngaynhanchuc = reader.GetDateTime(3);
                dto.Quanly = reader.GetInt32(4);
            }
            //Đóng kết nối
            cn.Close();
            return dto;
        }

    }
}
