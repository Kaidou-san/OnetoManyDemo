using Microsoft.EntityFrameworkCore.Migrations;

namespace OtoMDemo.Migrations
{
    public partial class ThirdMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShipId",
                table: "Pets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_ShipId",
                table: "Pets",
                column: "ShipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Ships_ShipId",
                table: "Pets",
                column: "ShipId",
                principalTable: "Ships",
                principalColumn: "ShipId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Ships_ShipId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_ShipId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "ShipId",
                table: "Pets");
        }
    }
}
