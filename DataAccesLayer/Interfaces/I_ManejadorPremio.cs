using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_ManejadorPremio
    {
        //Otorgar Premio
        bool set_Premio(DTPremio p);

        //Listar Premios
        List<DTPremio> get_Premios();

        //Cobrar Premio
        bool Pagar_Premio(string username, int id_Penca);
    }
}
