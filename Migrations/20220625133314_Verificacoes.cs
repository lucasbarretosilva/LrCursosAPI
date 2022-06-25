using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LrCursosAPI.Migrations
{
    public partial class Verificacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Visto",
                table: "Curso",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visto",
                table: "Conteudo",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Visto",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Visto",
                table: "Conteudo");
        }
    }
}
