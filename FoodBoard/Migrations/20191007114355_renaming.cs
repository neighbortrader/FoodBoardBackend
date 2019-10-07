using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBoard.Migrations
{
    public partial class renaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZIPNumber",
                table: "AspNetUsers",
                newName: "ZIPCode");

            migrationBuilder.RenameColumn(
                name: "AddressNumber",
                table: "AspNetUsers",
                newName: "StreetNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZIPCode",
                table: "AspNetUsers",
                newName: "ZIPNumber");

            migrationBuilder.RenameColumn(
                name: "StreetNumber",
                table: "AspNetUsers",
                newName: "AddressNumber");
        }
    }
}
