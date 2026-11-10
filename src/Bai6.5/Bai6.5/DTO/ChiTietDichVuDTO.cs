using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6._5.DTO
{
    public class ChiTietDichVuDTO
    {
        public int MaHD { get; set; }
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }
}