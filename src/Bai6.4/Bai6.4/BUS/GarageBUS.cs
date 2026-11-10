using System.Collections.Generic;
using System.Data;
using Bai6._4.DAL;
using Bai6._4.DTO;

namespace Bai6._4.BUS
{
    public class GarageBUS
    {
        private GarageDAL dal = new GarageDAL();

        public DataTable SearchXeByBienSo(string bienSo) => dal.SearchXeByBienSo(bienSo);
        public bool TiepNhanXeMoi(KhachHangDTO kh, XeDTO xe) => dal.TiepNhanXeMoi(kh, xe);
        public DataTable GetListPhuTung() => dal.GetListPhuTung();
        public bool UpdatePhuTung(PhuTungDTO pt) => dal.UpdatePhuTung(pt);
        public bool LapPhieuSuaChua(string bienSo, string noiDung, List<ChiTietSuaChuaDTO> listChiTiet, out string errorMessage)
        {
            return dal.LapPhieuSuaChuaTransaction(bienSo, noiDung, listChiTiet, out errorMessage);
        }
        public DataTable GetListPhieuSuaChua() => dal.GetListPhieuSuaChua();
        public bool ThanhToanPhieu(int maPhieu) => dal.ThanhToanPhieu(maPhieu);
    }
}