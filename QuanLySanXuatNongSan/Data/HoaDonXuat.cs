using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class HoaDonXuat
    {
        [Key]
        public int ID { get; set; }

        public int KhachHangID { get; set; }
        [ForeignKey("KhachHangID")]
        public KhachHang KhachHang { get; set; }

        public int NguoiLapID { get; set; } 
        [ForeignKey("NguoiLapID")]
        public NguoiDung NguoiLap { get; set; }

        public DateTime NgayLap { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        [StringLength(50)]
        public string HinhThucThanhToan { get; set; } 

        public ICollection<ChiTietHoaDonXuat> ChiTietHoaDonXuat { get; set; }
    }
}
