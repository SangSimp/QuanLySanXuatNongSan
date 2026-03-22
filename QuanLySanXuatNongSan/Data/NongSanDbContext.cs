using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanXuatNongSan.Data
{
    public class NongSanDbContext : DbContext
    {
        // 1. Hệ thống & Danh mục cơ bản
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<KhuVucTrong> KhuVucTrong { get; set; }
        public DbSet<GiongCungCap> GiongCungCap { get; set; }

        // 2. Danh mục mở rộng
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<VatTuNongNghiep> VatTuNongNghiep { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }

        // 3. Nghiệp vụ Sản Xuất
        public DbSet<KeHoachSanXuat> KeHoachSanXuat { get; set; }
        public DbSet<NhatKyChamSoc> NhatKyChamSoc { get; set; }
        public DbSet<ThuHoach> ThuHoach { get; set; }

        // 4. Nghiệp vụ Thương mại (Bán hàng)
        public DbSet<HoaDonXuat> HoaDonXuat { get; set; }
        public DbSet<ChiTietHoaDonXuat> ChiTietHoaDonXuat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Nhớ đổi tên Server nếu cần
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=QuanLySanXuatNongSan; Integrated Security=True; MultipleActiveResultSets=True; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình Khóa chính kép cho bảng ChiTietHoaDonXuat (Giống y hệt bài HoaDon_ChiTiet trong sách)
            modelBuilder.Entity<ChiTietHoaDonXuat>()
                .HasKey(c => new { c.HoaDonXuatID, c.GiongCungCapID });
        }
    }
}
