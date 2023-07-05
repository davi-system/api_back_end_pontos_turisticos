using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_pontos_turisticos.Migrations
{
    /// <inheritdoc />
    public partial class PontosTuristicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PontoTuristico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(60)", nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: true),
                    Endereco = table.Column<string>(type: "varchar(100)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontoTuristico", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PontoTuristico");
        }
    }
}
