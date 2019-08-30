using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto1.Migrations
{
    public partial class commit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RGs",
                columns: table => new
                {
                    RgId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RgNome = table.Column<string>(nullable: true),
                    RgNomeMae = table.Column<string>(nullable: true),
                    RgNomePai = table.Column<string>(nullable: true),
                    RgNaturalidade = table.Column<string>(nullable: true),
                    RgDataDeNascimento = table.Column<string>(nullable: true),
                    RgNumber = table.Column<string>(nullable: true),
                    RgCpf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGs", x => x.RgId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RGs");
        }
    }
}
