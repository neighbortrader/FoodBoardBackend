using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBoard.Migrations
{
    public partial class betterDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Fisch/Fleisch" },
                    { 3, "Obst/Gemüse" },
                    { 4, "Getreideprodukte" },
                    { 5, "Getränke" },
                    { 6, "Süßes/Nachtisch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
