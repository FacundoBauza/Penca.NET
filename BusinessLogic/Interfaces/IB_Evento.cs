using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_Evento
    {
        //Agregar
        MensajesEnum agregar_Evento(DTEvento e);

        //Actualizar
        MensajesEnum actualizar_Evento(DTEvento e);

        //Listar
        List<DTEvento> listar_Eventos();

        //Eliminar
        bool eliminar_Evento(int id_Evento);
    }
}
