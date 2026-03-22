using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class NhatKyChamSoc
    {
        [Key]
        public int ID { get; set; }

        public int KeHoachSanXuatID { get; set; }
        [ForeignKey("KeHoachSanXuatID")]
        public KeHoachSanXuat KeHoachSanXuat { get; set; }

        public DateTime NgayThucHien { get; set; }

        [StringLength(100)]
        public string HanhDong { get; set; }

        public int? VatTuNongNghiepID { get; set; } 
        [ForeignKey("VatTuNongNghiepID")]
        public VatTuNongNghiep VatTuNongNghiep { get; set; }

        public double SoLuongVatTu { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }
        [StringLength(255)]
        public string HinhAnhMinhHoa { get; set; } 

        public double? ChiPhiPhatSinh { get; set; } 
    }
}
