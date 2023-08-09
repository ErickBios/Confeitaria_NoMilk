using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Confeitaria_NoMilk.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("INSERT INTO CATEGORIAS(CATEGORIA_NOME, DESCRICAO) " +
				"VALUES('Normal','Lanche feito com ingredientes normais')");

			migrationBuilder.Sql("INSERT INTO CATEGORIAS(CATEGORIA_NOME, DESCRICAO) " +
				"VALUES('Natural','Lanche feito com ingredientes integrais e naturais')");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("DELETE FROM CATEGORIAS");
		}
    }
}
