using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBoard.Migrations
{
    public partial class implementUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);
        }
    }
}
