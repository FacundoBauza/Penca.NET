using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class SolutionContext: DbContext
    {
        Conexion x = new Conexion();
        public SolutionContext() { }
        public SolutionContext(DbContextOptions<SolutionContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-O6DTQ45\\ROOT;Initial Catalog=PencaNet;Encrypt=False;User ID=sa;Password=1234");
            }
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PencaCompartida> PencasCompartidas { get; set; }
        public DbSet<PencaEmpresarial> PencasEmpresariales { get; set; }
        public DbSet<Torneo> Torneos { get; set; }
        public DbSet<Subscripcion> Subscripciones { get; set; }
        public DbSet<Premio> Premios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<CriterioPremios> criterioPremios { get; set; }
        public DbSet<PorcentajesPremio> porcentajePremios { get; set; }
        public DbSet<PencaUsuario_Compartida> pencaUsuarioCompartida { get; set; }
        public DbSet<PencaUsuario_Empresarial> pencaUsuarioEmpresarial { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Torneo>()
                .HasMany(c => c.pencasEmpresariales)
                .WithOne(p => p.torneo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Torneo>()
                .HasMany(c => c.pencasCompartidas)
                .WithOne(p => p.torneo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Subscripcion>()
                .HasKey(su => new { su.id_Usuario, su.id_Penca });
            modelBuilder.Entity<Subscripcion>()
                .HasOne(su => su.usuario)
                .WithMany(su => su.Subscripciones)
                .HasForeignKey(su => su.id_Usuario);
            modelBuilder.Entity<Subscripcion>()
                .HasOne(su => su.pencaEmpresarial)
                .WithMany(su => su.Subscripciones)
                .HasForeignKey(su => su.id_Penca)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Premio>()
               .HasKey(p => new { p.id_Usuario, p.id_Penca });
            modelBuilder.Entity<Premio>()
                .HasOne(p => p.usuario)
                .WithMany(p => p.Premios)
                .HasForeignKey(p => p.id_Usuario)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Premio>()
                .HasOne(p => p.pencaCompartida)
                .WithMany(p => p.Premios)
                .HasForeignKey(p => p.id_Penca)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PencaUsuario_Compartida>()
              .HasKey(p => new { p.id_Usuario, p.id_Penca });
            modelBuilder.Entity<PencaUsuario_Compartida>()
                .HasOne(p => p.usuario)
                .WithMany(p => p.pencaUsuarioCompartida)
                .HasForeignKey(p => p.id_Usuario)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PencaUsuario_Compartida>()
                .HasOne(p => p.pencaCompartida)
                .WithMany(p => p.pencaUsuarioCompartida)
                .HasForeignKey(p => p.id_Penca)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PencaUsuario_Empresarial>()
              .HasKey(p => new { p.id_Usuario, p.id_Penca });
            modelBuilder.Entity<PencaUsuario_Empresarial>()
                .HasOne(p => p.usuario)
                .WithMany(p => p.pencaUsuarioEmpresarial)
                .HasForeignKey(p => p.id_Usuario)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PencaUsuario_Empresarial>()
                .HasOne(p => p.pencaEmpresarial)
                .WithMany(p => p.pencaUsuarioEmpresarial)
                .HasForeignKey(p => p.id_Penca)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PorcentajesPremio>()
                .HasOne(p => p.criterio)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Evento>()
                .HasOne(e => e.torneo)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Premio>()
                .HasOne(p => p.criterioPremios)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
