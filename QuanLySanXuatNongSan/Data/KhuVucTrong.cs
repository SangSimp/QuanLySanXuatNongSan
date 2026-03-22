using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class KhuVucTrong
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string TenKhuVuc { get; set; }

        public double DienTich { get; set; } 

        [StringLength(255)]
        public string TinhTrangDat { get; set; }
        [StringLength(255)]
        public string ViTri { get; set; } 

        [StringLength(50)]
        public string LoaiDat { get; set; } 

        [StringLength(50)]
        public string TrangThai { get; set; } 
    }
}
