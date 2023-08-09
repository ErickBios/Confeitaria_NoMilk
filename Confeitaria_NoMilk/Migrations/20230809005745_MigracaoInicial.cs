using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Confeitaria_NoMilk.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIAS",
                columns: table => new
                {
                    CATEGORIAID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORIA_NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DESCRICAO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS", x => x.CATEGORIAID);
                });

            migrationBuilder.CreateTable(
                name: "LANCHES",
                columns: table => new
                {
                    LANCHEID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DESCRICAO_CURTA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DESCRICAO_DETALHADA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PRECO = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    IMAGEM_URL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IMAGEM_THUMBNAI_URL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IS_LANCHE_PREFERIDO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EM_ESTOQUE = table.Column<bool>(type: "bit", nullable: false),
                    CATEGORIAID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LANCHES", x => x.LANCHEID);
                    table.ForeignKey(
                        name: "FK_LANCHES_CATEGORIAS_CATEGORIAID",
                        column: x => x.CATEGORIAID,
                        principalTable: "CATEGORIAS",
                        principalColumn: "CATEGORIAID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LANCHES_CATEGORIAID",
                table: "LANCHES",
                column: "CATEGORIAID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LANCHES");

            migrationBuilder.DropTable(
                name: "CATEGORIAS");
        }
    }
}
