using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBite.Migrations
{
    public partial class ProductAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Image", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "~/images/0fb3c319-ab08-4c09-a568-8aa089d9df89.jpeg", "Ribs & Wings + Chips", 70m },
                    { 2, "~/images/43d5ecaa-7b70-44e0-9b0d-f1639b7d4aa9.jpeg", "Steak & Wors + Chips", 70m },
                    { 3, "~/images/images.jpeg", "Chicken Dust + Chips Mild or Spicy", 100m },
                    { 4, "~/images/54f194c0-1766-47a2-9d03-8b5682564918.jpeg", "Green Salad", 70m },
                    { 5, "~/images/downlod.jpeg", "Fish + Chips Mild or Spicy", 100m },
                    { 6, "~/images/images (1).jpeg", "Chichen Dust, Small Pops & Fish Cakes + Chips Mild or Spicy", 120m },
                    { 7, "~/images/929c81e9-e8ac-4e93-bfa4-7839ab9fc2c0.jpeg", "Green Salad, Fish  + Chips", 100m },
                    { 8, "~/images/download (2).jpeg", "Family Mixed Meat platter", 370m },
                    { 9, "~/images/images (5).jpeg", "Family Meaty platter", 450m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);
        }
    }
}
