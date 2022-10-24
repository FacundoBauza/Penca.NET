using DataAccesLayer.Implementacion;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio.Entidades
{
    public class Sistema: ISistema
    {
        public ManejadorUsuario manejadorU { get; set; }
        public ManejadorPenca manejadorP { get; set; }
        public Sistema(){ }
    }
}
