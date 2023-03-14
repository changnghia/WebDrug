using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanThuoc.Data.Migrations
{
    public partial class capnhapusd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "TaiKhoan",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "TaiKhoan");
        }
    }
}
