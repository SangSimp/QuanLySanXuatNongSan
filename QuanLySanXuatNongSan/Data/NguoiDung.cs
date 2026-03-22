using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class NguoiDung
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string HoTen { get; set; }

        [Required, StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required, StringLength(255)]
        public string MatKhau { get; set; } 

        [Required, StringLength(50)]
        public string VaiTro { get; set; }
        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; } 

        public bool TrangThai { get; set; } 
    }
}
