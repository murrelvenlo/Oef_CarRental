using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental_App.Migrations
{
    public partial class AfbeeldingAuto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Afbeelding",
                table: "Automodel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Afbeelding",
                table: "Automodel");
        }
    }
}
