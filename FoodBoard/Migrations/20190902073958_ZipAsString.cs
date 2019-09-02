using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBoard.Migrations
{
    public partial class ZipAsString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZIPNumber",
                table: "AspNetUsers",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ZIPNumber",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldNullable: true);
        }
    }
}
