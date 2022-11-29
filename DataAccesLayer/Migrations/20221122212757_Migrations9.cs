using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class Migrations9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pronostico",
                table: "Pronostico");

            migrationBuilder.AddColumn<bool>(
                name: "esCompartida",
                table: "Pronostico",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pronostico",
                table: "Pronostico",
                columns: new[] { "Username_Usuario", "id_Evento" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pronostico",
                table: "Pronostico");

            migrationBuilder.DropColumn(
                name: "esCompartida",
                table: "Pronostico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pronostico",
                table: "Pronostico",
                columns: new[] { "Username_Usuario", "id_Evento", "id_Penca" });
        }
    }
}
