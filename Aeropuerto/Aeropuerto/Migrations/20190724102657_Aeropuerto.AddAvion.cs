using Microsoft.EntityFrameworkCore.Migrations;

namespace Aeropuerto.Migrations
{
    public partial class AeropuertoAddAvion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CuidaoAviones",
                table: "CuidaoAviones");

            migrationBuilder.RenameTable(
                name: "CuidaoAviones",
                newName: "Aviones");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aviones",
                table: "Aviones",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Aviones",
                table: "Aviones");

            migrationBuilder.RenameTable(
                name: "Aviones",
                newName: "CuidaoAviones");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CuidaoAviones",
                table: "CuidaoAviones",
                column: "ID");
        }
    }
}
