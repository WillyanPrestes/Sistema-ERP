using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Financeiro.Models.Migrations
{
    /// <inheritdoc />
    public partial class Cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbPessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(name: "_IdPessoa", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Telefone = table.Column<string>(name: "_Telefone", type: "longtext", nullable: true),
                    Celular = table.Column<string>(name: "_Celular", type: "longtext", nullable: true),
                    Logradouro = table.Column<string>(name: "_Logradouro", type: "longtext", nullable: true),
                    Bairro = table.Column<string>(name: "_Bairro", type: "longtext", nullable: true),
                    Cep = table.Column<string>(name: "_Cep", type: "longtext", nullable: true),
                    Numero = table.Column<string>(name: "_Numero", type: "longtext", nullable: true),
                    Email = table.Column<string>(name: "_Email", type: "longtext", nullable: true),
                    IdMunicipio = table.Column<int>(name: "_IdMunicipio", type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false),
                    Nome = table.Column<string>(name: "_Nome", type: "longtext", nullable: true),
                    Apelido = table.Column<string>(name: "_Apelido", type: "longtext", nullable: true),
                    CPF = table.Column<string>(name: "_CPF", type: "longtext", nullable: true),
                    RazaoSocial = table.Column<string>(name: "_RazaoSocial", type: "longtext", nullable: true),
                    NomeFantasia = table.Column<string>(name: "_NomeFantasia", type: "longtext", nullable: true),
                    CNPJ = table.Column<string>(name: "_CNPJ", type: "longtext", nullable: true),
                    IE = table.Column<string>(name: "_IE", type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbPessoa", x => x.IdPessoa);
                    table.ForeignKey(
                        name: "FK_dbPessoa_Municipio__IdMunicipio",
                        column: x => x.IdMunicipio,
                        principalTable: "Municipio",
                        principalColumn: "_IdMunicipio");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbCliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(name: "_IdCliente", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdPessoa = table.Column<int>(name: "_IdPessoa", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbCliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_dbCliente_dbPessoa__IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "dbPessoa",
                        principalColumn: "_IdPessoa");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_dbCliente__IdPessoa",
                table: "dbCliente",
                column: "_IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_dbPessoa__IdMunicipio",
                table: "dbPessoa",
                column: "_IdMunicipio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbCliente");

            migrationBuilder.DropTable(
                name: "dbPessoa");
        }
    }
}
