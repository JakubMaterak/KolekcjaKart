using Microsoft.EntityFrameworkCore.Migrations;

namespace KolekcjaKart.Migrations
{
    public partial class AddStrength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CardType",
                table: "Cards",
                newName: "CardEffectType");

            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Power",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "CardEffectType",
                table: "Cards",
                newName: "CardType");
        }
    }
}
