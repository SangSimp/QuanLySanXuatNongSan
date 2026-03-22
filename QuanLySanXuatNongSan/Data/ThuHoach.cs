using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class ThuHoach
    {
        [Key]
        public int ID { get; set; }

        public int KeHoachSanXuatID { get; set; }
        [ForeignKey("KeHoachSanXuatID")]
        public KeHoachSanXuat KeHoachSanXuat { get; set; }

        public DateTime NgayThuHoach { get; set; }

        public double SanLuong { get; set; } 

        [StringLength(50)]
        public string ChatLuong { get; set; } 
        public double TyLeHaoHut { get; set; } 

        [StringLength(255)]
        public string HinhAnhThuHoach { get; set; }
    }
}
