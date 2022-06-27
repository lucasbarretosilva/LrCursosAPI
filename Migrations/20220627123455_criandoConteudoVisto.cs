using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LrCursosAPI.Migrations
{
    public partial class criandoConteudoVisto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConteudoVisto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutenticacaoId = table.Column<int>(type: "int", nullable: false),
                    ConteudoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConteudoVisto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConteudoVisto_Autenticacao_AutenticacaoId",
                        column: x => x.AutenticacaoId,
                        principalTable: "Autenticacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConteudoVisto_Conteudo_ConteudoId",
                        column: x => x.ConteudoId,
                        principalTable: "Conteudo",
                        principalColumn: "ConteudoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConteudoVisto_AutenticacaoId",
                table: "ConteudoVisto",
                column: "AutenticacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConteudoVisto_ConteudoId",
                table: "ConteudoVisto",
                column: "ConteudoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConteudoVisto");
        }
    }
}
