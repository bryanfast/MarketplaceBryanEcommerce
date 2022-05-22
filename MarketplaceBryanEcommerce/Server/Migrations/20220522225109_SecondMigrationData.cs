using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketplaceBryanEcommerce.Server.Migrations
{
    public partial class SecondMigrationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://pics.filmaffinity.com/Ready_Player_One-508487059-large.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg");
        }
    }
}
