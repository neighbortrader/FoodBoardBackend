using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBoard.Migrations
{
    public partial class streetAsString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AddressNumber",
                table: "AspNetUsers",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AddressNumber",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
