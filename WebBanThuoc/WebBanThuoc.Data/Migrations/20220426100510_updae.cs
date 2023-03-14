using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanThuoc.Data.Migrations
{
    public partial class updae : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Thuoc_NhaCungCap_IdNhaCungCap",
                table: "Thuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Thuoc_phanLoaiThuocs_IdLoaiThuoc",
                table: "Thuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Thuoc_TaiKhoan_IdTaiKhoan",
                table: "Thuoc");

            migrationBuilder.AlterColumn<int>(
                name: "IdTaiKhoan",
                table: "Thuoc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdNhaCungCap",
                table: "Thuoc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdLoaiThuoc",
                table: "Thuoc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Thuoc_NhaCungCap_IdNhaCungCap",
                table: "Thuoc",
                column: "IdNhaCungCap",
                principalTable: "NhaCungCap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Thuoc_phanLoaiThuocs_IdLoaiThuoc",
                table: "Thuoc",
                column: "IdLoaiThuoc",
                principalTable: "phanLoaiThuocs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Thuoc_TaiKhoan_IdTaiKhoan",
                table: "Thuoc",
                column: "IdTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Thuoc_NhaCungCap_IdNhaCungCap",
                table: "Thuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Thuoc_phanLoaiThuocs_IdLoaiThuoc",
                table: "Thuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Thuoc_TaiKhoan_IdTaiKhoan",
                table: "Thuoc");

            migrationBuilder.AlterColumn<int>(
                name: "IdTaiKhoan",
                table: "Thuoc",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdNhaCungCap",
                table: "Thuoc",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdLoaiThuoc",
                table: "Thuoc",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Thuoc_NhaCungCap_IdNhaCungCap",
                table: "Thuoc",
                column: "IdNhaCungCap",
                principalTable: "NhaCungCap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Thuoc_phanLoaiThuocs_IdLoaiThuoc",
                table: "Thuoc",
                column: "IdLoaiThuoc",
                principalTable: "phanLoaiThuocs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Thuoc_TaiKhoan_IdTaiKhoan",
                table: "Thuoc",
                column: "IdTaiKhoan",
                principalTable: "TaiKhoan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
