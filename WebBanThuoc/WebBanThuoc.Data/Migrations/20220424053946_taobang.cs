using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanThuoc.Data.Migrations
{
    public partial class taobang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "donHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongSoTien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "phanLoaiThuocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiThuoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phanLoaiThuocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<int>(type: "int", nullable: false),
                    PassworkHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PassworkSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "phieuNhaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdNhaCungCap = table.Column<int>(type: "int", nullable: false),
                    IdTaiKhoan = table.Column<int>(type: "int", nullable: false),
                    TongSoTien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phieuNhaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_phieuNhaps_NhaCungCap_IdNhaCungCap",
                        column: x => x.IdNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_phieuNhaps_TaiKhoan_IdTaiKhoan",
                        column: x => x.IdTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thuoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DVT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTien = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DaBan = table.Column<int>(type: "int", nullable: false),
                    IdLoaiThuoc = table.Column<int>(type: "int", nullable: false),
                    IdTaiKhoan = table.Column<int>(type: "int", nullable: false),
                    IdNhaCungCap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thuoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thuoc_NhaCungCap_IdNhaCungCap",
                        column: x => x.IdNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Thuoc_phanLoaiThuocs_IdLoaiThuoc",
                        column: x => x.IdLoaiThuoc,
                        principalTable: "phanLoaiThuocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Thuoc_TaiKhoan_IdTaiKhoan",
                        column: x => x.IdTaiKhoan,
                        principalTable: "TaiKhoan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chiTietDonHangs",
                columns: table => new
                {
                    IdDonHang = table.Column<int>(type: "int", nullable: false),
                    IdThuoc = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietDonHangs", x => new { x.IdDonHang, x.IdThuoc });
                    table.ForeignKey(
                        name: "FK_chiTietDonHangs_donHangs_IdDonHang",
                        column: x => x.IdDonHang,
                        principalTable: "donHangs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietDonHangs_Thuoc_IdThuoc",
                        column: x => x.IdThuoc,
                        principalTable: "Thuoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chiTietPhieuNhaps",
                columns: table => new
                {
                    IdThuoc = table.Column<int>(type: "int", nullable: false),
                    IdPhieuNhap = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietPhieuNhaps", x => new { x.IdPhieuNhap, x.IdThuoc });
                    table.ForeignKey(
                        name: "FK_chiTietPhieuNhaps_phieuNhaps_IdPhieuNhap",
                        column: x => x.IdPhieuNhap,
                        principalTable: "phieuNhaps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietPhieuNhaps_Thuoc_IdThuoc",
                        column: x => x.IdThuoc,
                        principalTable: "Thuoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chiTietDonHangs_IdThuoc",
                table: "chiTietDonHangs",
                column: "IdThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietPhieuNhaps_IdThuoc",
                table: "chiTietPhieuNhaps",
                column: "IdThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_phieuNhaps_IdNhaCungCap",
                table: "phieuNhaps",
                column: "IdNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_phieuNhaps_IdTaiKhoan",
                table: "phieuNhaps",
                column: "IdTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_Thuoc_IdLoaiThuoc",
                table: "Thuoc",
                column: "IdLoaiThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_Thuoc_IdNhaCungCap",
                table: "Thuoc",
                column: "IdNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_Thuoc_IdTaiKhoan",
                table: "Thuoc",
                column: "IdTaiKhoan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chiTietDonHangs");

            migrationBuilder.DropTable(
                name: "chiTietPhieuNhaps");

            migrationBuilder.DropTable(
                name: "donHangs");

            migrationBuilder.DropTable(
                name: "phieuNhaps");

            migrationBuilder.DropTable(
                name: "Thuoc");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "phanLoaiThuocs");

            migrationBuilder.DropTable(
                name: "TaiKhoan");
        }
    }
}
