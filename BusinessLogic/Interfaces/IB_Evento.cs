﻿using Dominio.DT;
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
        bool agregar_Evento(DTEvento e);

        //Actualizar
        bool actualizar_Evento(Evento e);

        //Listar
        List<DTEvento> listar_Eventos();

        //Eliminar
        bool eliminar_Evento(int id_Evento);
    }
}
