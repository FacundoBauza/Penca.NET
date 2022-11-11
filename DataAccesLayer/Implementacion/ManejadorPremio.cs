using DataAccesLayer.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementacion
{
    public class ManejadorPremio : I_ManejadorPremio
    {
        //Otorgar Premio => Etapa: Sin Empezar
        bool I_ManejadorPremio.set_Premio(Premio p)
        {
            throw new NotImplementedException();
        }

        //Listar Premios => Etapa: Sin Empezar
        List<Premio> I_ManejadorPremio.get_Premios(int id_Usuario)
        {
            throw new NotImplementedException();
        }

        //Cobrar Premio => Etapa: Sin Empezar
        bool I_ManejadorPremio.Cobrar_Premio(int id_usuario, int id_Penca)
        {
            throw new NotImplementedException();
        }
    }
}
