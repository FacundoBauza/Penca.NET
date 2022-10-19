using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Conexion : DbContext
    {
       
    public class Practico4Context : DbContext
    {
        public Practico4Context() { }
        public Practico4Context(DbContextOptions<Practico4Context> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-L7LID20\\SQLEXPRESS, 1433;Database = Practico3; User id = sa; Password = 1234; ");
            }
        }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Contactos> Contactos { get; set; }
    }

}

    }
}
