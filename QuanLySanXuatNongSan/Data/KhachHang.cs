using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class KhachHang
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string HoVaTen { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }
    }
}
