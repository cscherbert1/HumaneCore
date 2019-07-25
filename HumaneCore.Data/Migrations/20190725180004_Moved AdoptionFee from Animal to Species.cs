using Microsoft.EntityFrameworkCore.Migrations;

namespace HumaneCore.Data.Migrations
{
    public partial class MovedAdoptionFeefromAnimaltoSpecies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdoptionFee",
                table: "Animals");

            migrationBuilder.AddColumn<double>(
                name: "AdoptionFee",
                table: "Species",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdoptionFee",
                table: "Species");

            migrationBuilder.AddColumn<double>(
                name: "AdoptionFee",
                table: "Animals",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
