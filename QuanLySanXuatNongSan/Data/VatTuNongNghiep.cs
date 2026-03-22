using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class VatTuNongNghiep
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string TenVatTu { get; set; }

        [StringLength(50)]
        public string LoaiVatTu { get; set; }

        public double SoLuongTon { get; set; } 

        public int DonGia { get; set; } 

        public int NhaCungCapID { get; set; }
        [ForeignKey("NhaCungCapID")]
        public NhaCungCap NhaCungCap { get; set; }
        [StringLength(20)]
        public string DonViTinh { get; set; }

        public DateTime? HanSuDung { get; set; } 

        [StringLength(255)]
        public string HinhAnh { get; set; } 
    }
}
