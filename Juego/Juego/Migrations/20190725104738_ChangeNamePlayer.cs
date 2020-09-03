using Microsoft.EntityFrameworkCore.Migrations;

namespace Juego.Migrations
{
    public partial class ChangeNamePlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pilotos",
                table: "Pilotos");

            migrationBuilder.RenameTable(
                name: "Pilotos",
                newName: "Jugadores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores");

            migrationBuilder.RenameTable(
                name: "Jugadores",
                newName: "Pilotos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pilotos",
                table: "Pilotos",
                column: "ID");
        }
    }
}
