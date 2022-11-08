using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "criterioPremios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantGanadores = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_criterioPremios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Torneos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "porcentajePremios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    posicion = table.Column<int>(type: "int", nullable: false),
                    porcentaje = table.Column<int>(type: "int", nullable: false),
                    idCriterioPremio = table.Column<int>(name: "id_CriterioPremio", type: "int", nullable: false),
                    criterioid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_porcentajePremios", x => x.id);
                    table.ForeignKey(
                        name: "FK_porcentajePremios_criterioPremios_criterioid",
                        column: x => x.criterioid,
                        principalTable: "criterioPremios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    equipo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    equipo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    golesEquipo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    golesEquipo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resultado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idTorneo = table.Column<int>(name: "id_Torneo", type: "int", nullable: false),
                    torneoid = table.Column<int>(type: "int", nullable: false),
                    Torneosid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Eventos_Torneos_Torneosid",
                        column: x => x.Torneosid,
                        principalTable: "Torneos",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Eventos_Torneos_torneoid",
                        column: x => x.torneoid,
                        principalTable: "Torneos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PencasCompartidas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    criterioPremiosid = table.Column<int>(type: "int", nullable: false),
                    torneoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PencasCompartidas", x => x.id);
                    table.ForeignKey(
                        name: "FK_PencasCompartidas_Torneos_torneoid",
                        column: x => x.torneoid,
                        principalTable: "Torneos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PencasCompartidas_criterioPremios_criterioPremiosid",
                        column: x => x.criterioPremiosid,
                        principalTable: "criterioPremios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PencasEmpresariales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    torneoid = table.Column<int>(type: "int", nullable: false),
                    usuarioCreadorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PencasEmpresariales", x => x.id);
                    table.ForeignKey(
                        name: "FK_PencasEmpresariales_Torneos_torneoid",
                        column: x => x.torneoid,
                        principalTable: "Torneos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PencasEmpresariales_Usuarios_usuarioCreadorid",
                        column: x => x.usuarioCreadorid,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pencaUsuarioCompartida",
                columns: table => new
                {
                    idUsuario = table.Column<int>(name: "id_Usuario", type: "int", nullable: false),
                    idPenca = table.Column<int>(name: "id_Penca", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pencaUsuarioCompartida", x => new { x.idUsuario, x.idPenca });
                    table.ForeignKey(
                        name: "FK_pencaUsuarioCompartida_PencasCompartidas_id_Penca",
                        column: x => x.idPenca,
                        principalTable: "PencasCompartidas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pencaUsuarioCompartida_Usuarios_id_Usuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Premios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(name: "id_Usuario", type: "int", nullable: false),
                    idPenca = table.Column<int>(name: "id_Penca", type: "int", nullable: false),
                    valorPremio = table.Column<float>(type: "real", nullable: false),
                    pago = table.Column<bool>(type: "bit", nullable: false),
                    criterioPremiosid = table.Column<int>(type: "int", nullable: false),
                    idCriterioPremio = table.Column<int>(name: "id_CriterioPremio", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premios", x => new { x.idUsuario, x.idPenca });
                    table.ForeignKey(
                        name: "FK_Premios_PencasCompartidas_id_Penca",
                        column: x => x.idPenca,
                        principalTable: "PencasCompartidas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Premios_Usuarios_id_Usuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Premios_criterioPremios_criterioPremiosid",
                        column: x => x.criterioPremiosid,
                        principalTable: "criterioPremios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pencaUsuarioEmpresarial",
                columns: table => new
                {
                    idUsuario = table.Column<int>(name: "id_Usuario", type: "int", nullable: false),
                    idPenca = table.Column<int>(name: "id_Penca", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pencaUsuarioEmpresarial", x => new { x.idUsuario, x.idPenca });
                    table.ForeignKey(
                        name: "FK_pencaUsuarioEmpresarial_PencasEmpresariales_id_Penca",
                        column: x => x.idPenca,
                        principalTable: "PencasEmpresariales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pencaUsuarioEmpresarial_Usuarios_id_Usuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subscripciones",
                columns: table => new
                {
                    idUsuario = table.Column<int>(name: "id_Usuario", type: "int", nullable: false),
                    idPenca = table.Column<int>(name: "id_Penca", type: "int", nullable: false),
                    nroTarCredito = table.Column<string>(name: "nroTar_Credito", type: "nvarchar(max)", nullable: false),
                    rut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscripciones", x => new { x.idUsuario, x.idPenca });
                    table.ForeignKey(
                        name: "FK_Subscripciones_PencasEmpresariales_id_Penca",
                        column: x => x.idPenca,
                        principalTable: "PencasEmpresariales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subscripciones_Usuarios_id_Usuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_torneoid",
                table: "Eventos",
                column: "torneoid");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_Torneosid",
                table: "Eventos",
                column: "Torneosid");

            migrationBuilder.CreateIndex(
                name: "IX_PencasCompartidas_criterioPremiosid",
                table: "PencasCompartidas",
                column: "criterioPremiosid");

            migrationBuilder.CreateIndex(
                name: "IX_PencasCompartidas_torneoid",
                table: "PencasCompartidas",
                column: "torneoid");

            migrationBuilder.CreateIndex(
                name: "IX_PencasEmpresariales_torneoid",
                table: "PencasEmpresariales",
                column: "torneoid");

            migrationBuilder.CreateIndex(
                name: "IX_PencasEmpresariales_usuarioCreadorid",
                table: "PencasEmpresariales",
                column: "usuarioCreadorid");

            migrationBuilder.CreateIndex(
                name: "IX_pencaUsuarioCompartida_id_Penca",
                table: "pencaUsuarioCompartida",
                column: "id_Penca");

            migrationBuilder.CreateIndex(
                name: "IX_pencaUsuarioEmpresarial_id_Penca",
                table: "pencaUsuarioEmpresarial",
                column: "id_Penca");

            migrationBuilder.CreateIndex(
                name: "IX_porcentajePremios_criterioid",
                table: "porcentajePremios",
                column: "criterioid");

            migrationBuilder.CreateIndex(
                name: "IX_Premios_criterioPremiosid",
                table: "Premios",
                column: "criterioPremiosid");

            migrationBuilder.CreateIndex(
                name: "IX_Premios_id_Penca",
                table: "Premios",
                column: "id_Penca");

            migrationBuilder.CreateIndex(
                name: "IX_Subscripciones_id_Penca",
                table: "Subscripciones",
                column: "id_Penca");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "pencaUsuarioCompartida");

            migrationBuilder.DropTable(
                name: "pencaUsuarioEmpresarial");

            migrationBuilder.DropTable(
                name: "porcentajePremios");

            migrationBuilder.DropTable(
                name: "Premios");

            migrationBuilder.DropTable(
                name: "Subscripciones");

            migrationBuilder.DropTable(
                name: "PencasCompartidas");

            migrationBuilder.DropTable(
                name: "PencasEmpresariales");

            migrationBuilder.DropTable(
                name: "criterioPremios");

            migrationBuilder.DropTable(
                name: "Torneos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
