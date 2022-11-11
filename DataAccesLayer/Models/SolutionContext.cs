using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccesLayer.Models
{
    public class SolutionContext: IdentityDbContext<Users>
    {
        Conexion x = new Conexion();
        public SolutionContext() { }
        public SolutionContext(DbContextOptions<SolutionContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=ADESKTOP-L7LID20\\SQLEXPRESS;Initial Catalog=PencaNet;Encrypt=False;User ID=sa;Password=1234");
            }
        }

        public DbSet<Users> Usuarios { get; set; }
        public DbSet<PencaCompartidas> PencasCompartidas { get; set; }
        public DbSet<PencaEmpresariales> PencasEmpresariales { get; set; }
        public DbSet<Torneos> Torneos { get; set; }
        public DbSet<Subscripciones> Subscripciones { get; set; }
        public DbSet<Premios> Premios { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<CriterioPremios> criterioPremios { get; set; }
        public DbSet<PorcentajesPremios> porcentajePremios { get; set; }
        public DbSet<PencaUsuario_Compartidas> pencaUsuarioCompartida { get; set; }
        public DbSet<PencaUsuario_Empresariales> pencaUsuarioEmpresarial { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Torneos>()
                .HasMany(c => c.pencasEmpresariales)
                .WithOne(p => p.torneo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Torneos>()
                .HasMany(c => c.pencasCompartidas)
                .WithOne(p => p.torneo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Subscripciones>()
                .HasKey(su => new { su.id_Usuario, su.id_Penca });
            modelBuilder.Entity<Subscripciones>()
                .HasOne(su => su.usuario)
                .WithMany(su => su.Subscripciones)
                .HasForeignKey(su => su.id_Usuario);
            modelBuilder.Entity<Subscripciones>()
                .HasOne(su => su.pencaEmpresarial)
                .WithMany(su => su.Subscripciones)
                .HasForeignKey(su => su.id_Penca)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Premios>()
               .HasKey(p => new { p.id_Usuario, p.id_Penca });
            modelBuilder.Entity<Premios>()
                .HasOne(p => p.usuario)
                .WithMany(p => p.Premios)
                .HasForeignKey(p => p.id_Usuario)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Premios>()
                .HasOne(p => p.pencaCompartida)
                .WithMany(p => p.premios)
                .HasForeignKey(p => p.id_Penca)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PencaUsuario_Compartidas>()
              .HasKey(p => new { p.id_Usuario, p.id_Penca });
            modelBuilder.Entity<PencaUsuario_Compartidas>()
                .HasOne(p => p.usuario)
                .WithMany(p => p.pencaUsuarioCompartida)
                .HasForeignKey(p => p.id_Usuario)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PencaUsuario_Compartidas>()
                .HasOne(p => p.pencaCompartida)
                .WithMany(p => p.pencaUsuarioCompartida)
                .HasForeignKey(p => p.id_Penca)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PencaUsuario_Empresariales>()
              .HasKey(p => new { p.id_Usuario, p.id_Penca });
            modelBuilder.Entity<PencaUsuario_Empresariales>()
                .HasOne(p => p.usuario)
                .WithMany(p => p.pencaUsuarioEmpresarial)
                .HasForeignKey(p => p.id_Usuario)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PencaUsuario_Empresariales>()
                .HasOne(p => p.pencaEmpresarial)
                .WithMany(p => p.pencaUsuarioEmpresarial)
                .HasForeignKey(p => p.id_Penca)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PorcentajesPremios>()
                .HasOne(p => p.criterio)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Eventos>()
                .HasOne(e => e.torneo)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Premios>()
                .HasOne(p => p.criterioPremios)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
