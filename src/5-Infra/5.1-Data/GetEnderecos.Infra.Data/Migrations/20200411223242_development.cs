using Microsoft.EntityFrameworkCore.Migrations;

namespace GetEnderecos.Infra.Data.Migrations
{
    public partial class development : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "enderecos",
                schema: "public",
                columns: table => new
                {
                    cep = table.Column<string>(type: "varchar(8)", nullable: false),
                    logradouro = table.Column<string>(type: "varchar(250)", nullable: false),
                    complemento = table.Column<string>(type: "varchar(150)", nullable: false),
                    bairro = table.Column<string>(type: "varchar(100)", nullable: false),
                    municipio = table.Column<string>(type: "varchar(100)", nullable: false),
                    ibge_municipio = table.Column<string>(type: "varchar(10)", nullable: false),
                    uf = table.Column<string>(type: "varchar(2)", nullable: false),
                    ibge_uf = table.Column<string>(type: "varchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecos", x => x.cep);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enderecos",
                schema: "public");
        }
    }
}
