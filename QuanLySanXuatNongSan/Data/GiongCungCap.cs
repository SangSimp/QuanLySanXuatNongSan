using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class GiongCungCap
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string TenGiong { get; set; }

        [Required, StringLength(50)]
        public string LoaiNongSan { get; set; } 

        public int ThoiGianThuHoachDuKien { get; set; }
        [StringLength(20)]
        public string DonViTinh { get; set; }

        [StringLength(255)]
        public string DacTinh { get; set; } 

        [StringLength(255)]
        public string HinhAnh { get; set; } 
    }
}
