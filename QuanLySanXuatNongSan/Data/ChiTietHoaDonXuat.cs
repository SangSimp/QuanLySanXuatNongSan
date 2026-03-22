using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class ChiTietHoaDonXuat
    {
        public int HoaDonXuatID { get; set; }
        [ForeignKey("HoaDonXuatID")]
        public HoaDonXuat HoaDonXuat { get; set; }

        public int GiongCungCapID { get; set; }
        [ForeignKey("GiongCungCapID")]
        public GiongCungCap GiongCungCap { get; set; }

        public double SoLuong { get; set; } 

        public int DonGiaBan { get; set; } 
        public double GiamGia { get; set; } 
    }
}
