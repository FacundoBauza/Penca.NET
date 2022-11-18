using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class Migrations1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pronostico",
                columns: table => new
                {
                    UsernameUsuario = table.Column<string>(name: "Username_Usuario", type: "nvarchar(450)", nullable: false),
                    idEvento = table.Column<int>(name: "id_Evento", type: "int", nullable: false),
                    golesEquipo1 = table.Column<int>(type: "int", nullable: false),
                    golesEquipo2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pronostico", x => new { x.UsernameUsuario, x.idEvento });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pronostico");
        }
    }
}
