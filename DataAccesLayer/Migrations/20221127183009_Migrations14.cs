using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class Migrations14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios_Puntaje",
                table: "Usuarios_Puntaje");

            migrationBuilder.AddColumn<bool>(
                name: "esCompartida",
                table: "Usuarios_Puntaje",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios_Puntaje",
                table: "Usuarios_Puntaje",
                columns: new[] { "username", "id_Penca", "esCompartida" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios_Puntaje",
                table: "Usuarios_Puntaje");

            migrationBuilder.DropColumn(
                name: "esCompartida",
                table: "Usuarios_Puntaje");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios_Puntaje",
                table: "Usuarios_Puntaje",
                columns: new[] { "username", "id_Penca" });
        }
    }
}
