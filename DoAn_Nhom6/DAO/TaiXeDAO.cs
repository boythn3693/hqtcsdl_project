using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TaiXeDAO
    {
        public void XoaTaiXe(string mataixe)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_XOA_TAIXE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTaiXe", SqlDbType.Int);
            //gán giá trị cho tham số
            cmd.Parameters["@MaTaiXe"].Value = mataixe;
            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }

        public void SuaTaiXe(TaiXeDTO dto)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_CAPNHAT_TAIXE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaTaiXe", SqlDbType.Int);
            cmd.Parameters.Add("@TenTaiXe", SqlDbType.NVarChar);
            cmd.Parameters.Add("@KhaNangLai", SqlDbType.BigInt);
            cmd.Parameters.Add("@QuangDuong", SqlDbType.BigInt);
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar);
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar);
            cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit);
            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            //gán giá trị cho tham số
            cmd.Parameters["@MaTaiXe"].Value = dto.Mataixe;
            cmd.Parameters["@TenTaiXe"].Value = dto.Tentaixe;
            cmd.Parameters["@KhaNangLai"].Value = dto.Khanang;
            cmd.Parameters["@QuangDuong"].Value = dto.Quangduong;
            cmd.Parameters["@TenDangNhap"].Value = dto.Tendangnhap;
            cmd.Parameters["@MatKhau"].Value = dto.Matkhau;
            cmd.Parameters["@TinhTrang"].Value = dto.Tinhtrang;
            cmd.Parameters["@MaTo"].Value = dto.Mato;
            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }

        public void ThemTaiXe(TaiXeDTO dto)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_THEM_TAIXE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenTaiXe", SqlDbType.NVarChar);
            cmd.Parameters.Add("@KhaNangLai", SqlDbType.BigInt);
            cmd.Parameters.Add("@QuangDuong", SqlDbType.BigInt);
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar);
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar);
            cmd.Parameters.Add("@TinhTrang", SqlDbType.Bit);
            cmd.Parameters.Add("@MaTo", SqlDbType.Int);
            cmd.Parameters.Add("@MaTaiXe", SqlDbType.Int).Direction = ParameterDirection.Output;

            //gán giá trị cho tham số
            cmd.Parameters["@TenTaiXe"].Value = dto.Tentaixe;
            cmd.Parameters["@KhaNangLai"].Value = dto.Khanang;
            cmd.Parameters["@QuangDuong"].Value = dto.Quangduong;
            cmd.Parameters["@TenDangNhap"].Value = dto.Tendangnhap;
            cmd.Parameters["@MatKhau"].Value = dto.Matkhau;
            cmd.Parameters["@TinhTrang"].Value = dto.Tinhtrang;
            cmd.Parameters["@MaTo"].Value = dto.Mato;
            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //lấy mã sp đc phát sinh sau khi thêm, gán lại vào dto
            dto.Mataixe = Convert.ToInt32(cmd.Parameters["@MaTaiXe"].Value);
            //Đóng kết nối
            cn.Close();
        }

        public List<TaiXeDTO> TimKiemTaiXe( string tentaixe )
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_TIMKIEM_TAIXE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TENTAIXE", SqlDbType.NVarChar);
            //gán giá trị cho tham số
            cmd.Parameters["@Keys"].Value = tentaixe;
            //Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();
            List<TaiXeDTO> list = new List<TaiXeDTO>();
            while (reader.Read())
            {
                TaiXeDTO dto = new TaiXeDTO();

                dto.Mataixe = reader.GetInt32(0);
                dto.Tentaixe = reader.GetString(1);
                dto.Khanang = reader.GetInt64(2);
                dto.Quangduong = reader.GetInt64(3);
                dto.Tendangnhap = reader.GetString(4);
                dto.Tinhtrang = reader.GetBoolean(6);
                dto.Mato = reader.GetInt32(7);

                list.Add(dto);
            }
            //Đóng kết nối
            cn.Close();
            return list;
        }

        public static DataTable DanhSachTaiXe()
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_DANHSACH_TAIXE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }

        public static DataTable DanhSachQuanLy()
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_DANHSACH_QUANLY", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }

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

        public static DataTable DanhSachTaiKhoan()
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_DSTaiKhoan", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }
        public static DataTable KiemTraTaiKhoann(string tentk, string mk)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_DANGNHAP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar);
            cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar);
            //gán giá trị cho tham số
            cmd.Parameters["@TENDANGNHAP"].Value = tentk;
            cmd.Parameters["@MATKHAU"].Value = mk;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;   
        }
        public static DataTable KiemTraTaiKhoan_Fix(string tentk, string mk)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_FIX_DANGNHAP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar);
            cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar);
            //gán giá trị cho tham số
            cmd.Parameters["@TENDANGNHAP"].Value = tentk;
            cmd.Parameters["@MATKHAU"].Value = mk;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            da.Dispose();
            dt.Dispose();
            return dt;
        }

        public static void CapNhatTaiKhoan(string tentk, string mk)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("GT_DOIMATKHAU", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar);
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar);

            //gán giá trị cho tham số
            cmd.Parameters["@TenDangNhap"].Value = tentk;
            cmd.Parameters["@MatKhau"].Value = mk;

            //Thực thi câu truy vấn
            cmd.ExecuteNonQuery();
            //Đóng kết nối
            cn.Close();
        }

        public static TaiXeDTO LayThongTinTheoTenTK(string ten)
        {
            SqlConnection cn;
            cn = DataProviders.ConnectionDB();
            SqlCommand cmd = new SqlCommand("sp_LayThongTinTheoTen", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar);
            //gán giá trị cho tham số
            cmd.Parameters["@TENDANGNHAP"].Value = ten;

            //Thực thi câu truy vấn
            SqlDataReader reader = cmd.ExecuteReader();
            TaiXeDTO dto = new TaiXeDTO();
            while (reader.Read())
            {
                dto.Tendangnhap = reader.GetString(0);
                dto.Matkhau = reader.GetString(1);
            }
            //Đóng kết nối
            cn.Close();
            return dto;
        }
    }
}
