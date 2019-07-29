using Microsoft.EntityFrameworkCore.Migrations;

namespace HumaneCore.Data.Migrations
{
    public partial class ChangedSpeciestoallowforcollectionofbreeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Restrictions_RestrictionId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_RestrictionId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "RestrictionId",
                table: "Animals");

            migrationBuilder.AddColumn<long>(
                name: "AnimalId",
                table: "Restrictions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restrictions_AnimalId",
                table: "Restrictions",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restrictions_Animals_AnimalId",
                table: "Restrictions",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restrictions_Animals_AnimalId",
                table: "Restrictions");

            migrationBuilder.DropIndex(
                name: "IX_Restrictions_AnimalId",
                table: "Restrictions");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Restrictions");

            migrationBuilder.AddColumn<int>(
                name: "RestrictionId",
                table: "Animals",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_RestrictionId",
                table: "Animals",
                column: "RestrictionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Restrictions_RestrictionId",
                table: "Animals",
                column: "RestrictionId",
                principalTable: "Restrictions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
