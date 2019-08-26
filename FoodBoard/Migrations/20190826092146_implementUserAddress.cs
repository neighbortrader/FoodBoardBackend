using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBoard.Migrations
{
    public partial class implementUserAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressNumber",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Users",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Users",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZIPNumber",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ZIPNumber",
                table: "Users");
        }
    }
}
