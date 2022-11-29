using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class Migrations171 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pronostico",
                table: "Pronostico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pronostico",
                table: "Pronostico",
                columns: new[] { "Username_Usuario", "id_Evento", "id_Penca" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pronostico",
                table: "Pronostico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pronostico",
                table: "Pronostico",
                columns: new[] { "Username_Usuario", "id_Evento" });
        }
    }
}
