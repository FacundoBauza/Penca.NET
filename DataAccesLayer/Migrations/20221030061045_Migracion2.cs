using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class Migracion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Torneos_torneoId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_PencasCompartidas_Torneos_torneoId",
                table: "PencasCompartidas");

            migrationBuilder.DropForeignKey(
                name: "FK_PencasEmpresariales_Torneos_torneoId",
                table: "PencasEmpresariales");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Torneos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "torneoId",
                table: "PencasEmpresariales",
                newName: "torneoid");

            migrationBuilder.RenameIndex(
                name: "IX_PencasEmpresariales_torneoId",
                table: "PencasEmpresariales",
                newName: "IX_PencasEmpresariales_torneoid");

            migrationBuilder.RenameColumn(
                name: "torneoId",
                table: "PencasCompartidas",
                newName: "torneoid");

            migrationBuilder.RenameIndex(
                name: "IX_PencasCompartidas_torneoId",
                table: "PencasCompartidas",
                newName: "IX_PencasCompartidas_torneoid");

            migrationBuilder.RenameColumn(
                name: "torneoId",
                table: "Eventos",
                newName: "torneoid");

            migrationBuilder.RenameIndex(
                name: "IX_Eventos_torneoId",
                table: "Eventos",
                newName: "IX_Eventos_torneoid");

            migrationBuilder.AddColumn<int>(
                name: "Torneosid",
                table: "Eventos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_Torneosid",
                table: "Eventos",
                column: "Torneosid");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Torneos_Torneosid",
                table: "Eventos",
                column: "Torneosid",
                principalTable: "Torneos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Torneos_torneoid",
                table: "Eventos",
                column: "torneoid",
                principalTable: "Torneos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PencasCompartidas_Torneos_torneoid",
                table: "PencasCompartidas",
                column: "torneoid",
                principalTable: "Torneos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PencasEmpresariales_Torneos_torneoid",
                table: "PencasEmpresariales",
                column: "torneoid",
                principalTable: "Torneos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Torneos_Torneosid",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Torneos_torneoid",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_PencasCompartidas_Torneos_torneoid",
                table: "PencasCompartidas");

            migrationBuilder.DropForeignKey(
                name: "FK_PencasEmpresariales_Torneos_torneoid",
                table: "PencasEmpresariales");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_Torneosid",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Torneosid",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Torneos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "torneoid",
                table: "PencasEmpresariales",
                newName: "torneoId");

            migrationBuilder.RenameIndex(
                name: "IX_PencasEmpresariales_torneoid",
                table: "PencasEmpresariales",
                newName: "IX_PencasEmpresariales_torneoId");

            migrationBuilder.RenameColumn(
                name: "torneoid",
                table: "PencasCompartidas",
                newName: "torneoId");

            migrationBuilder.RenameIndex(
                name: "IX_PencasCompartidas_torneoid",
                table: "PencasCompartidas",
                newName: "IX_PencasCompartidas_torneoId");

            migrationBuilder.RenameColumn(
                name: "torneoid",
                table: "Eventos",
                newName: "torneoId");

            migrationBuilder.RenameIndex(
                name: "IX_Eventos_torneoid",
                table: "Eventos",
                newName: "IX_Eventos_torneoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Torneos_torneoId",
                table: "Eventos",
                column: "torneoId",
                principalTable: "Torneos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PencasCompartidas_Torneos_torneoId",
                table: "PencasCompartidas",
                column: "torneoId",
                principalTable: "Torneos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PencasEmpresariales_Torneos_torneoId",
                table: "PencasEmpresariales",
                column: "torneoId",
                principalTable: "Torneos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
