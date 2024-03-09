using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaSimple.NETAPIproject.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "villaID",
                table: "villaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_villaNumbers_villaID",
                table: "villaNumbers",
                column: "villaID");

            migrationBuilder.AddForeignKey(
                name: "FK_villaNumbers_Villas_villaID",
                table: "villaNumbers",
                column: "villaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_villaNumbers_Villas_villaID",
                table: "villaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_villaNumbers_villaID",
                table: "villaNumbers");

            migrationBuilder.DropColumn(
                name: "villaID",
                table: "villaNumbers");
        }
    }
}
