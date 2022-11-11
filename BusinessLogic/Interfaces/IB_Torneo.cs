using System;
using Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_Torneo
    {
        //Agregar
        bool agregar_Torneo(Torneo t);

        //Actualizar
        bool actualizar_Torneo(Torneo t);

        //Listar
        List<Torneo> listar_Torneos();

        //Eliminar
        bool eliminar_Torneo(int id_Torneo);
        
    }
}
