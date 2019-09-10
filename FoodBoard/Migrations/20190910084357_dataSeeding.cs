using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBoard.Migrations
{
    public partial class dataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Milchprodukt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groceries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
