using DAO;
using DTO;

namespace BUS
{
    public class TuyenDuongBUS
    {
        public void ThemTuyenDuong(TuyenDuongDTO dto)
        {
            TuyenDuongDAO dao = new TuyenDuongDAO();
            dao.ThemTuyenDuong(dto);
        }

        public void SuaTuyenDuong(TuyenDuongDTO dto)
        {
            TuyenDuongDAO dao = new TuyenDuongDAO();
            dao.SuaTuyenDuong(dto);
        }

        public void XoaTuyenDuong(string matuyenduong)
        {
            TuyenDuongDAO dao = new TuyenDuongDAO();
            dao.XoaTuyenDuong(matuyenduong);
        }
    }
}
