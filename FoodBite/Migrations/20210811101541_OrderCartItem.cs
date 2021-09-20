using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBite.Migrations
{
    public partial class OrderCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "OrderNumber",
                table: "Orders",
                newName: "OrderCartId");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderCartId",
                table: "Orders",
                newName: "OrderNumber");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }
    }
}
