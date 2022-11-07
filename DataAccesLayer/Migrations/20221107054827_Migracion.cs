using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class Migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    usuarioCreadorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PencasEmpresariales", x => x.id);
                    table.ForeignKey(
                        name: "FK_PencasEmpresariales_AspNetUsers_usuarioCreadorId",
                        column: x => x.usuarioCreadorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PencasEmpresariales_Torneos_torneoid",
                        column: x => x.torneoid,
                        principalTable: "Torneos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pencaUsuarioCompartida",
                columns: table => new
                {
                    idUsuario = table.Column<string>(name: "id_Usuario", type: "nvarchar(450)", nullable: false),
                    idPenca = table.Column<int>(name: "id_Penca", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pencaUsuarioCompartida", x => new { x.idUsuario, x.idPenca });
                    table.ForeignKey(
                        name: "FK_pencaUsuarioCompartida_AspNetUsers_id_Usuario",
                        column: x => x.idUsuario,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pencaUsuarioCompartida_PencasCompartidas_id_Penca",
                        column: x => x.idPenca,
                        principalTable: "PencasCompartidas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Premios",
                columns: table => new
                {
                    idUsuario = table.Column<string>(name: "id_Usuario", type: "nvarchar(450)", nullable: false),
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
                        name: "FK_Premios_AspNetUsers_id_Usuario",
                        column: x => x.idUsuario,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Premios_PencasCompartidas_id_Penca",
                        column: x => x.idPenca,
                        principalTable: "PencasCompartidas",
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
                    idUsuario = table.Column<string>(name: "id_Usuario", type: "nvarchar(450)", nullable: false),
                    idPenca = table.Column<int>(name: "id_Penca", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pencaUsuarioEmpresarial", x => new { x.idUsuario, x.idPenca });
                    table.ForeignKey(
                        name: "FK_pencaUsuarioEmpresarial_AspNetUsers_id_Usuario",
                        column: x => x.idUsuario,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pencaUsuarioEmpresarial_PencasEmpresariales_id_Penca",
                        column: x => x.idPenca,
                        principalTable: "PencasEmpresariales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subscripciones",
                columns: table => new
                {
                    idUsuario = table.Column<string>(name: "id_Usuario", type: "nvarchar(450)", nullable: false),
                    idPenca = table.Column<int>(name: "id_Penca", type: "int", nullable: false),
                    nroTarCredito = table.Column<string>(name: "nroTar_Credito", type: "nvarchar(max)", nullable: false),
                    rut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscripciones", x => new { x.idUsuario, x.idPenca });
                    table.ForeignKey(
                        name: "FK_Subscripciones_AspNetUsers_id_Usuario",
                        column: x => x.idUsuario,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscripciones_PencasEmpresariales_id_Penca",
                        column: x => x.idPenca,
                        principalTable: "PencasEmpresariales",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_PencasEmpresariales_usuarioCreadorId",
                table: "PencasEmpresariales",
                column: "usuarioCreadorId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "PencasCompartidas");

            migrationBuilder.DropTable(
                name: "PencasEmpresariales");

            migrationBuilder.DropTable(
                name: "criterioPremios");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Torneos");
        }
    }
}
