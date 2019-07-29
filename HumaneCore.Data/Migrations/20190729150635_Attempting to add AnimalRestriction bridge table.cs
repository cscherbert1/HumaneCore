using Microsoft.EntityFrameworkCore.Migrations;

namespace HumaneCore.Data.Migrations
{
    public partial class AttemptingtoaddAnimalRestrictionbridgetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AnimalRestriction",
                columns: table => new
                {
                    AnimalId = table.Column<long>(nullable: false),
                    RestrictionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalRestriction", x => new { x.AnimalId, x.RestrictionId });
                    table.ForeignKey(
                        name: "FK_AnimalRestriction_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalRestriction_Restrictions_RestrictionId",
                        column: x => x.RestrictionId,
                        principalTable: "Restrictions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalRestriction_RestrictionId",
                table: "AnimalRestriction",
                column: "RestrictionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalRestriction");

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
    }
}
