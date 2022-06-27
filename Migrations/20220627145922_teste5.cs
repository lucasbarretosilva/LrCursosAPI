using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LrCursosAPI.Migrations
{
    public partial class teste5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConteudoVisto_Curso_CursoId",
                table: "ConteudoVisto");

            migrationBuilder.DropIndex(
                name: "IX_ConteudoVisto_CursoId",
                table: "ConteudoVisto");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "ConteudoVisto");

            migrationBuilder.CreateIndex(
                name: "IX_ConteudoVisto_ConteudoId",
                table: "ConteudoVisto",
                column: "ConteudoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConteudoVisto_Conteudo_ConteudoId",
                table: "ConteudoVisto",
                column: "ConteudoId",
                principalTable: "Conteudo",
                principalColumn: "ConteudoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConteudoVisto_Conteudo_ConteudoId",
                table: "ConteudoVisto");

            migrationBuilder.DropIndex(
                name: "IX_ConteudoVisto_ConteudoId",
                table: "ConteudoVisto");

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "ConteudoVisto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConteudoVisto_CursoId",
                table: "ConteudoVisto",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConteudoVisto_Curso_CursoId",
                table: "ConteudoVisto",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "CursoId");
        }
    }
}
