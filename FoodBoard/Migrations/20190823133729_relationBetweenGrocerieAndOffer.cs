using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodBoard.Migrations
{
    public partial class relationBetweenGrocerieAndOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GrocerieId",
                table: "Offers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_GrocerieId",
                table: "Offers",
                column: "GrocerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Groceries_GrocerieId",
                table: "Offers",
                column: "GrocerieId",
                principalTable: "Groceries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Groceries_GrocerieId",
                table: "Offers");

            migrationBuilder.DropIndex(
                name: "IX_Offers_GrocerieId",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "GrocerieId",
                table: "Offers");
        }
    }
}
