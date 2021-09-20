using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBite.Migrations
{
    public partial class ShoppingCartAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderCartId",
                table: "Orders",
                newName: "ShoppingCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "Orders",
                newName: "OrderCartId");
        }
    }
}
