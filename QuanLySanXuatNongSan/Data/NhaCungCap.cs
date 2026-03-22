using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class NhaCungCap
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(150)]
        public string TenNhaCungCap { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        [StringLength(255)]
        public string DiaChi { get; set; }
    }
}
