using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
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
                    nombre = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "CriterioPremio",
                columns: table => new
                {
                    idCriterioPremio = table.Column<int>(name: "id_CriterioPremio", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantGanadores = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterioPremio", x => x.idCriterioPremio);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    idEvento = table.Column<int>(name: "id_Evento", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    equipo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    golesEquipo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    golesEquipo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resultado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTorneo = table.Column<int>(name: "id_Torneo", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.idEvento);
                });

            migrationBuilder.CreateTable(
                name: "PencaCompartida",
                columns: table => new
                {
                    idPencaCompartida = table.Column<int>(name: "id_PencaCompartida", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTorneo = table.Column<int>(name: "id_Torneo", type: "int", nullable: false),
                    idCriterioPremio = table.Column<int>(name: "id_CriterioPremio", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PencaCompartida", x => x.idPencaCompartida);
                });

            migrationBuilder.CreateTable(
                name: "PencaCompartida_Users",
                columns: table => new
                {
                    UsernameUsuario = table.Column<string>(name: "Username_Usuario", type: "nvarchar(450)", nullable: false),
                    idPencaCompartida = table.Column<int>(name: "id_PencaCompartida", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PencaCompartida_Users", x => new { x.UsernameUsuario, x.idPencaCompartida });
                });

            migrationBuilder.CreateTable(
                name: "PencaEmpresarial",
                columns: table => new
                {
                    idPencaEmpresarial = table.Column<int>(name: "id_PencaEmpresarial", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idTorneo = table.Column<int>(name: "id_Torneo", type: "int", nullable: false),
                    UsernameUsuarioCreador = table.Column<string>(name: "Username_UsuarioCreador", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PencaEmpresarial", x => x.idPencaEmpresarial);
                });

            migrationBuilder.CreateTable(
                name: "PencaEmpresarial_Users",
                columns: table => new
                {
                    UsernameUsuario = table.Column<string>(name: "Username_Usuario", type: "nvarchar(450)", nullable: false),
                    idPencaEmpresarial = table.Column<int>(name: "id_PencaEmpresarial", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PencaEmpresarial_Users", x => new { x.UsernameUsuario, x.idPencaEmpresarial });
                });

            migrationBuilder.CreateTable(
                name: "PorcentajePremio",
                columns: table => new
                {
                    idPorcentaje = table.Column<int>(name: "id_Porcentaje", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    posicion = table.Column<int>(type: "int", nullable: false),
                    porcentaje = table.Column<int>(type: "int", nullable: false),
                    idCriterioPremio = table.Column<int>(name: "id_CriterioPremio", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PorcentajePremio", x => x.idPorcentaje);
                });

            migrationBuilder.CreateTable(
                name: "Premios",
                columns: table => new
                {
                    UsernameUsuario = table.Column<string>(name: "Username_Usuario", type: "nvarchar(450)", nullable: false),
                    idPencaCompartida = table.Column<int>(name: "id_PencaCompartida", type: "int", nullable: false),
                    valorPremio = table.Column<float>(type: "real", nullable: false),
                    pago = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premios", x => new { x.UsernameUsuario, x.idPencaCompartida });
                });

            migrationBuilder.CreateTable(
                name: "Subscripcion",
                columns: table => new
                {
                    UsernameUsuario = table.Column<string>(name: "Username_Usuario", type: "nvarchar(450)", nullable: false),
                    idPencaEmpresarial = table.Column<int>(name: "id_PencaEmpresarial", type: "int", nullable: false),
                    nroTarCredito = table.Column<string>(name: "nroTar_Credito", type: "nvarchar(max)", nullable: true),
                    rut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscripcion", x => new { x.UsernameUsuario, x.idPencaEmpresarial });
                });

            migrationBuilder.CreateTable(
                name: "Torneo",
                columns: table => new
                {
                    idTorneo = table.Column<int>(name: "id_Torneo", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneo", x => x.idTorneo);
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
                name: "CriterioPremio");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "PencaCompartida");

            migrationBuilder.DropTable(
                name: "PencaCompartida_Users");

            migrationBuilder.DropTable(
                name: "PencaEmpresarial");

            migrationBuilder.DropTable(
                name: "PencaEmpresarial_Users");

            migrationBuilder.DropTable(
                name: "PorcentajePremio");

            migrationBuilder.DropTable(
                name: "Premios");

            migrationBuilder.DropTable(
                name: "Subscripcion");

            migrationBuilder.DropTable(
                name: "Torneo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
