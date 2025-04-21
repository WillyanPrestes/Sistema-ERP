using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Financeiro.Models.Migrations
{
    /// <inheritdoc />
    public partial class produto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbCategoriaProduto",
                columns: table => new
                {
                    IdCategoriaProduto = table.Column<int>(name: "_IdCategoriaProduto", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(name: "_Descricao", type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbCategoriaProduto", x => x.IdCategoriaProduto);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbProduto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(name: "_IdProduto", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(name: "_Descricao", type: "longtext", nullable: false),
                    oCusto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MargemLucro = table.Column<decimal>(name: "_MargemLucro", type: "decimal(18,2)", nullable: false),
                    PrecoVenda = table.Column<decimal>(name: "_PrecoVenda", type: "decimal(18,2)", nullable: false),
                    EstoqueAtual = table.Column<decimal>(name: "_EstoqueAtual", type: "decimal(18,2)", nullable: false),
                    EstoqueMinimo = table.Column<decimal>(name: "_EstoqueMinimo", type: "decimal(18,2)", nullable: false),
                    UnidadeMedia = table.Column<string>(name: "_UnidadeMedia", type: "longtext", nullable: false),
                    Ativo = table.Column<bool>(name: "_Ativo", type: "tinyint(1)", nullable: false),
                    IdCategoriaProduto = table.Column<int>(name: "_IdCategoriaProduto", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbProduto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_dbProduto_dbCategoriaProduto__IdCategoriaProduto",
                        column: x => x.IdCategoriaProduto,
                        principalTable: "dbCategoriaProduto",
                        principalColumn: "_IdCategoriaProduto",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_dbProduto__IdCategoriaProduto",
                table: "dbProduto",
                column: "_IdCategoriaProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbProduto");

            migrationBuilder.DropTable(
                name: "dbCategoriaProduto");
        }
    }
}
