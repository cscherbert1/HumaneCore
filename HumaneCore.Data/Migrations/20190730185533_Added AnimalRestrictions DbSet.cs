using Microsoft.EntityFrameworkCore.Migrations;

namespace HumaneCore.Data.Migrations
{
    public partial class AddedAnimalRestrictionsDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalRestriction_Animals_AnimalId",
                table: "AnimalRestriction");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalRestriction_Restrictions_RestrictionId",
                table: "AnimalRestriction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalRestriction",
                table: "AnimalRestriction");

            migrationBuilder.RenameTable(
                name: "AnimalRestriction",
                newName: "AnimalRestrictions");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalRestriction_RestrictionId",
                table: "AnimalRestrictions",
                newName: "IX_AnimalRestrictions_RestrictionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalRestrictions",
                table: "AnimalRestrictions",
                columns: new[] { "AnimalId", "RestrictionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalRestrictions_Animals_AnimalId",
                table: "AnimalRestrictions",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalRestrictions_Restrictions_RestrictionId",
                table: "AnimalRestrictions",
                column: "RestrictionId",
                principalTable: "Restrictions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalRestrictions_Animals_AnimalId",
                table: "AnimalRestrictions");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimalRestrictions_Restrictions_RestrictionId",
                table: "AnimalRestrictions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalRestrictions",
                table: "AnimalRestrictions");

            migrationBuilder.RenameTable(
                name: "AnimalRestrictions",
                newName: "AnimalRestriction");

            migrationBuilder.RenameIndex(
                name: "IX_AnimalRestrictions_RestrictionId",
                table: "AnimalRestriction",
                newName: "IX_AnimalRestriction_RestrictionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalRestriction",
                table: "AnimalRestriction",
                columns: new[] { "AnimalId", "RestrictionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalRestriction_Animals_AnimalId",
                table: "AnimalRestriction",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalRestriction_Restrictions_RestrictionId",
                table: "AnimalRestriction",
                column: "RestrictionId",
                principalTable: "Restrictions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
