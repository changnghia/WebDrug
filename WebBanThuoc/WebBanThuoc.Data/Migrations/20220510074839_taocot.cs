using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanThuoc.Data.Migrations
{
    public partial class taocot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Trangthai",
                table: "DonHang",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trangthai",
                table: "DonHang");
        }
    }
}
