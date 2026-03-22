using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class KeHoachSanXuat
    {
        [Key]
        public int ID { get; set; }

        public int KhuVucTrongID { get; set; }
        [ForeignKey("KhuVucTrongID")]
        public KhuVucTrong KhuVucTrong { get; set; }

        public int GiongCungCapID { get; set; }
        [ForeignKey("GiongCungCapID")]
        public GiongCungCap GiongCungCap { get; set; }

        public int NguoiPhuTrachID { get; set; } 
        [ForeignKey("NguoiPhuTrachID")]
        public NguoiDung NguoiPhuTrach { get; set; }

        public DateTime NgayBatDau { get; set; }
        public DateTime NgayThuHoachDuKien { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }
        public double SanLuongDuKien { get; set; } 

        public double ChiPhiDuKien { get; set; } 
    }
}
