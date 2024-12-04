using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafeteria.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderDateToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdProduct",
                table: "OrderItem",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "IdOrder",
                table: "OrderItem",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "TimeStamp",
                table: "Order",
                newName: "OrderDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderItem",
                newName: "IdProduct");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItem",
                newName: "IdOrder");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Order",
                newName: "TimeStamp");
        }
    }
}
