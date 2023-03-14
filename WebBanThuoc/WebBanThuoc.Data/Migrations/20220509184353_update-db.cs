using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanThuoc.Data.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chiTietDonHangs_donHangs_IdDonHang",
                table: "chiTietDonHangs");

            migrationBuilder.DropForeignKey(
                name: "FK_chiTietDonHangs_Thuoc_IdThuoc",
                table: "chiTietDonHangs");

            migrationBuilder.DropTable(
                name: "chiTietPhieuNhaps");

            migrationBuilder.DropTable(
                name: "phieuNhaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_donHangs",
                table: "donHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chiTietDonHangs",
                table: "chiTietDonHangs");

            migrationBuilder.RenameTable(
                name: "donHangs",
                newName: "DonHang");

            migrationBuilder.RenameTable(
                name: "chiTietDonHangs",
                newName: "ChiTietDonHang");

            migrationBuilder.RenameIndex(
                name: "IX_chiTietDonHangs_IdThuoc",
                table: "ChiTietDonHang",
                newName: "IX_ChiTietDonHang_IdThuoc");

            migrationBuilder.AddColumn<int>(
                name: "IdTaiKhoan",
                table: "DonHang",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonHang",
                table: "DonHang",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietDonHang",
                table: "ChiTietDonHang",
                columns: new[] { "IdDonHang", "IdThuoc" });

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_IdTaiKhoan",
                table: "DonHang",
                column: "IdTaiKhoan");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDonHang_DonHang_IdDonHang",
                table: "ChiTietDonHang",
                column: "IdDonHang",
                principalTable: "DonHang",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDonHang_Thuoc_IdThuoc",
                table: "ChiTietDonHang",
                column: "IdThuoc",
                principalTable: "Thuoc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonHang_TaiKhoan_IdTaiKhoan",
                table: "DonHang",
                column: "IdTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDonHang_DonHang_IdDonHang",
                table: "ChiTietDonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDonHang_Thuoc_IdThuoc",
                table: "ChiTietDonHang");

            migrationBuilder.DropForeignKey(
                name: "FK_DonHang_TaiKhoan_IdTaiKhoan",
                table: "DonHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonHang",
                table: "DonHang");

            migrationBuilder.DropIndex(
                name: "IX_DonHang_IdTaiKhoan",
                table: "DonHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietDonHang",
                table: "ChiTietDonHang");

            migrationBuilder.DropColumn(
                name: "IdTaiKhoan",
                table: "DonHang");

            migrationBuilder.RenameTable(
                name: "DonHang",
                newName: "donHangs");

            migrationBuilder.RenameTable(
                name: "ChiTietDonHang",
                newName: "chiTietDonHangs");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDonHang_IdThuoc",
                table: "chiTietDonHangs",
                newName: "IX_chiTietDonHangs_IdThuoc");

            migrationBuilder.AddPrimaryKey(
                name: "PK_donHangs",
                table: "donHangs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chiTietDonHangs",
                table: "chiTietDonHangs",
                columns: new[] { "IdDonHang", "IdThuoc" });

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
                name: "chiTietPhieuNhaps",
                columns: table => new
                {
                    IdPhieuNhap = table.Column<int>(type: "int", nullable: false),
                    IdThuoc = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietDonHangs_donHangs_IdDonHang",
                table: "chiTietDonHangs",
                column: "IdDonHang",
                principalTable: "donHangs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_chiTietDonHangs_Thuoc_IdThuoc",
                table: "chiTietDonHangs",
                column: "IdThuoc",
                principalTable: "Thuoc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
