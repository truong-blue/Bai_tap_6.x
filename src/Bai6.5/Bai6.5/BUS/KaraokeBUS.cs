using System.Data;
using Bai6._5.DAL;

namespace Bai6._5.BUS
{
    public class KaraokeBUS
    {
        private KaraokeDAL dal = new KaraokeDAL();

        public DataTable GetListPhongHat() => dal.GetListPhongHat();
        public DataTable GetListDichVu() => dal.GetListDichVu();
        public bool MoPhongHat(int maPhong) => dal.MoPhongHat(maPhong);
        public DataTable GetHoaDonHienTaiByMaPhong(int maPhong) => dal.GetHoaDonHienTaiByMaPhong(maPhong);
        public DataTable GetChiTietDichVuByMaHD(int maHD) => dal.GetChiTietDichVuByMaHD(maHD);
        public bool ThemDichVuVaoHoaDon(int maHD, int maDV, int soLuong, decimal donGia)
        {
            return dal.ThemDichVuVaoHoaDon(maHD, maDV, soLuong, donGia);
        }
        public bool ThanhToanHoaDon(int maHD, int maPhong, out decimal tongTienPhong, out decimal tongTienDV, out string errorMessage)
        {
            return dal.ThanhToanHoaDonTransaction(maHD, maPhong, out tongTienPhong, out tongTienDV, out errorMessage);
        }
    }
}