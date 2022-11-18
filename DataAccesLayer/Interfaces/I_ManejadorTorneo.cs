using DataAccesLayer.Implementacion;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_ManejadorTorneo
    {
        //Agregar
        bool add_Torneo(Torneo t);

        //Actualizar
        bool update_Torneo(Torneo t);

        //Listar
        List<DTTorneo> get_Torneos();

        //Eliminar
        bool delete_Torneo(int id_Torneo);
    }
}
