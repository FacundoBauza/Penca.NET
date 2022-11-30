using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_Premio
    {
        //Otorgar Premio
        bool agregar_Premio(DTPremio p);

        //Listar Premios
        List<DTPremio> listar_Premios();

        //Cobrar Premio
        bool Pagar_Premio(string username, int id_Penca);
    }
}
