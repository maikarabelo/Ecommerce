using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBite.Migrations
{
    public partial class ProductsAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Image",
                value: "~/images/download.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Image",
                value: "~/images/downlod.jpeg");
        }
    }
}
