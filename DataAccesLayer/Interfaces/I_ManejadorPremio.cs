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
        bool set_Premio(Premio p);

        //Listar Premios
        List<Premio> get_Premios(int id_Usuario);

        //Cobrar Premio
        bool Cobrar_Premio(int id_usuario, int id_Penca);
    }
}
