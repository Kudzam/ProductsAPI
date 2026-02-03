using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductsAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductsModels",
                columns: new[] { "Id", "Contractor", "ProductLabel", "ProductType", "Quantity" },
                values: new object[,]
                {
                    { 1, "Outsource", "Levi", "Jeans", 90 },
                    { 2, "Outsource", "Next", "T-Shirt", 38 },
                    { 3, "InHouse", "RiverIsland", "Jacket", 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductsModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductsModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductsModels",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
