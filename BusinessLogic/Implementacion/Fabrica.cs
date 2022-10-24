using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Fabrica
    {
        private static Sistema instancia;
        public static ISistema getInstance()
        {
            if (instancia == null)
            {
                instancia = new Sistema();
            }
            return instancia;
        }
    }
}
