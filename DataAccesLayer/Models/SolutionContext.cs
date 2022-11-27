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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;

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
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-O6DTQ45\\ROOT;Initial Catalog=PencaNet;Encrypt=False;User ID=sa;Password=1234");
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
        public DbSet<Pronostico> Pronosticos { get; set; }
        public DbSet<PorcentajesPremios> porcentajePremios { get; set; }
        public DbSet<PencaUsuario_Compartidas> pencaUsuarioCompartida { get; set; }
        public DbSet<PencaUsuario_Empresariales> pencaUsuarioEmpresarial { get; set; }
        public DbSet<UsuarioPuntajes> usuarioPuntajes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
