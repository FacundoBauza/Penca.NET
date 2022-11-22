﻿// <auto-generated />
using System;
using DataAccesLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(SolutionContext))]
    partial class SolutionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccesLayer.Models.CriterioPremios", b =>
                {
                    b.Property<int>("id_CriterioPremio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_CriterioPremio"));

                    b.Property<int>("cantGanadores")
                        .HasColumnType("int");

                    b.HasKey("id_CriterioPremio");

                    b.ToTable("CriterioPremio");
                });

            modelBuilder.Entity("DataAccesLayer.Models.Eventos", b =>
                {
                    b.Property<int>("id_Evento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_Evento"));

                    b.Property<string>("equipo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("equipo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("golesEquipo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("golesEquipo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_Torneo")
                        .HasColumnType("int");

                    b.Property<string>("resultado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Evento");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("DataAccesLayer.Models.PencaCompartidas", b =>
                {
                    b.Property<int>("id_PencaCompartida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_PencaCompartida"));

                    b.Property<int>("id_CriterioPremio")
                        .HasColumnType("int");

                    b.Property<int>("id_Torneo")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_PencaCompartida");

                    b.ToTable("PencaCompartida");
                });

            modelBuilder.Entity("DataAccesLayer.Models.PencaEmpresariales", b =>
                {
                    b.Property<int>("id_PencaEmpresarial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_PencaEmpresarial"));

                    b.Property<string>("Username_UsuarioCreador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_Torneo")
                        .HasColumnType("int");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_PencaEmpresarial");

                    b.ToTable("PencaEmpresarial");
                });

            modelBuilder.Entity("DataAccesLayer.Models.PencaUsuario_Compartidas", b =>
                {
                    b.Property<string>("Username_Usuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("id_PencaCompartida")
                        .HasColumnType("int");

                    b.HasKey("Username_Usuario", "id_PencaCompartida");

                    b.ToTable("PencaCompartida_Users");
                });

            modelBuilder.Entity("DataAccesLayer.Models.PencaUsuario_Empresariales", b =>
                {
                    b.Property<string>("Username_Usuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("id_PencaEmpresarial")
                        .HasColumnType("int");

                    b.HasKey("Username_Usuario", "id_PencaEmpresarial");

                    b.ToTable("PencaEmpresarial_Users");
                });

            modelBuilder.Entity("DataAccesLayer.Models.PorcentajesPremios", b =>
                {
                    b.Property<int>("id_Porcentaje")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_Porcentaje"));

                    b.Property<int>("id_CriterioPremio")
                        .HasColumnType("int");

                    b.Property<int>("porcentaje")
                        .HasColumnType("int");

                    b.Property<int>("posicion")
                        .HasColumnType("int");

                    b.HasKey("id_Porcentaje");

                    b.ToTable("PorcentajePremio");
                });

            modelBuilder.Entity("DataAccesLayer.Models.Premios", b =>
                {
                    b.Property<string>("Username_Usuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("id_PencaCompartida")
                        .HasColumnType("int");

                    b.Property<bool>("pago")
                        .HasColumnType("bit");

                    b.Property<float>("valorPremio")
                        .HasColumnType("real");

                    b.HasKey("Username_Usuario", "id_PencaCompartida");

                    b.ToTable("Premios");
                });

            modelBuilder.Entity("DataAccesLayer.Models.Pronostico", b =>
                {
                    b.Property<string>("Username_Usuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("id_Evento")
                        .HasColumnType("int");

                    b.Property<bool>("esCompartida")
                        .HasColumnType("bit");

                    b.Property<int>("golesEquipo1")
                        .HasColumnType("int");

                    b.Property<int>("golesEquipo2")
                        .HasColumnType("int");

                    b.Property<int>("id_Penca")
                        .HasColumnType("int");

                    b.HasKey("Username_Usuario", "id_Evento");

                    b.ToTable("Pronostico");
                });

            modelBuilder.Entity("DataAccesLayer.Models.Subscripciones", b =>
                {
                    b.Property<string>("Username_Usuario")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("id_PencaEmpresarial")
                        .HasColumnType("int");

                    b.Property<string>("nroTar_Credito")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username_Usuario", "id_PencaEmpresarial");

                    b.ToTable("Subscripcion");
                });

            modelBuilder.Entity("DataAccesLayer.Models.Torneos", b =>
                {
                    b.Property<int>("id_Torneo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_Torneo"));

                    b.Property<DateTime>("fechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Torneo");

                    b.ToTable("Torneo");
                });

            modelBuilder.Entity("DataAccesLayer.Models.Users", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DataAccesLayer.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DataAccesLayer.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccesLayer.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DataAccesLayer.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
