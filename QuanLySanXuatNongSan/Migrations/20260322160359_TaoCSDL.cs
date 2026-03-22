using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLySanXuatNongSan.Migrations
{
    /// <inheritdoc />
    public partial class TaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiongCungCap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGiong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LoaiNongSan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThoiGianThuHoachDuKien = table.Column<int>(type: "int", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DacTinh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiongCungCap", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoVaTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhuVucTrong",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhuVuc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DienTich = table.Column<double>(type: "float", nullable: false),
                    TinhTrangDat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LoaiDat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuVucTrong", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenDangNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonXuat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangID = table.Column<int>(type: "int", nullable: false),
                    NguoiLapID = table.Column<int>(type: "int", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HinhThucThanhToan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonXuat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDonXuat_KhachHang_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonXuat_NguoiDung_NguoiLapID",
                        column: x => x.NguoiLapID,
                        principalTable: "NguoiDung",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeHoachSanXuat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhuVucTrongID = table.Column<int>(type: "int", nullable: false),
                    GiongCungCapID = table.Column<int>(type: "int", nullable: false),
                    NguoiPhuTrachID = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayThuHoachDuKien = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SanLuongDuKien = table.Column<double>(type: "float", nullable: false),
                    ChiPhiDuKien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeHoachSanXuat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KeHoachSanXuat_GiongCungCap_GiongCungCapID",
                        column: x => x.GiongCungCapID,
                        principalTable: "GiongCungCap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeHoachSanXuat_KhuVucTrong_KhuVucTrongID",
                        column: x => x.KhuVucTrongID,
                        principalTable: "KhuVucTrong",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeHoachSanXuat_NguoiDung_NguoiPhuTrachID",
                        column: x => x.NguoiPhuTrachID,
                        principalTable: "NguoiDung",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VatTuNongNghiep",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenVatTu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LoaiVatTu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoLuongTon = table.Column<double>(type: "float", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    NhaCungCapID = table.Column<int>(type: "int", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HanSuDung = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTuNongNghiep", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VatTuNongNghiep_NhaCungCap_NhaCungCapID",
                        column: x => x.NhaCungCapID,
                        principalTable: "NhaCungCap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonXuat",
                columns: table => new
                {
                    HoaDonXuatID = table.Column<int>(type: "int", nullable: false),
                    GiongCungCapID = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    DonGiaBan = table.Column<int>(type: "int", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonXuat", x => new { x.HoaDonXuatID, x.GiongCungCapID });
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonXuat_GiongCungCap_GiongCungCapID",
                        column: x => x.GiongCungCapID,
                        principalTable: "GiongCungCap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonXuat_HoaDonXuat_HoaDonXuatID",
                        column: x => x.HoaDonXuatID,
                        principalTable: "HoaDonXuat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThuHoach",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeHoachSanXuatID = table.Column<int>(type: "int", nullable: false),
                    NgayThuHoach = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SanLuong = table.Column<double>(type: "float", nullable: false),
                    ChatLuong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TyLeHaoHut = table.Column<double>(type: "float", nullable: false),
                    HinhAnhThuHoach = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuHoach", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ThuHoach_KeHoachSanXuat_KeHoachSanXuatID",
                        column: x => x.KeHoachSanXuatID,
                        principalTable: "KeHoachSanXuat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhatKyChamSoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeHoachSanXuatID = table.Column<int>(type: "int", nullable: false),
                    NgayThucHien = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HanhDong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VatTuNongNghiepID = table.Column<int>(type: "int", nullable: true),
                    SoLuongVatTu = table.Column<double>(type: "float", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HinhAnhMinhHoa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ChiPhiPhatSinh = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhatKyChamSoc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhatKyChamSoc_KeHoachSanXuat_KeHoachSanXuatID",
                        column: x => x.KeHoachSanXuatID,
                        principalTable: "KeHoachSanXuat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhatKyChamSoc_VatTuNongNghiep_VatTuNongNghiepID",
                        column: x => x.VatTuNongNghiepID,
                        principalTable: "VatTuNongNghiep",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonXuat_GiongCungCapID",
                table: "ChiTietHoaDonXuat",
                column: "GiongCungCapID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonXuat_KhachHangID",
                table: "HoaDonXuat",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonXuat_NguoiLapID",
                table: "HoaDonXuat",
                column: "NguoiLapID");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachSanXuat_GiongCungCapID",
                table: "KeHoachSanXuat",
                column: "GiongCungCapID");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachSanXuat_KhuVucTrongID",
                table: "KeHoachSanXuat",
                column: "KhuVucTrongID");

            migrationBuilder.CreateIndex(
                name: "IX_KeHoachSanXuat_NguoiPhuTrachID",
                table: "KeHoachSanXuat",
                column: "NguoiPhuTrachID");

            migrationBuilder.CreateIndex(
                name: "IX_NhatKyChamSoc_KeHoachSanXuatID",
                table: "NhatKyChamSoc",
                column: "KeHoachSanXuatID");

            migrationBuilder.CreateIndex(
                name: "IX_NhatKyChamSoc_VatTuNongNghiepID",
                table: "NhatKyChamSoc",
                column: "VatTuNongNghiepID");

            migrationBuilder.CreateIndex(
                name: "IX_ThuHoach_KeHoachSanXuatID",
                table: "ThuHoach",
                column: "KeHoachSanXuatID");

            migrationBuilder.CreateIndex(
                name: "IX_VatTuNongNghiep_NhaCungCapID",
                table: "VatTuNongNghiep",
                column: "NhaCungCapID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDonXuat");

            migrationBuilder.DropTable(
                name: "NhatKyChamSoc");

            migrationBuilder.DropTable(
                name: "ThuHoach");

            migrationBuilder.DropTable(
                name: "HoaDonXuat");

            migrationBuilder.DropTable(
                name: "VatTuNongNghiep");

            migrationBuilder.DropTable(
                name: "KeHoachSanXuat");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "GiongCungCap");

            migrationBuilder.DropTable(
                name: "KhuVucTrong");

            migrationBuilder.DropTable(
                name: "NguoiDung");
        }
    }
}
