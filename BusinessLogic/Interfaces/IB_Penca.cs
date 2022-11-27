using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_Penca
    {
        //Agregar
        MensajesEnum agregar_PencaCompartida(DTPencaCompartida2 pc);
        MensajesEnum agregar_PencaEmpresarial(DTPencaEmpresarial pe);

        //Actualizar
        MensajesEnum actualizar_PencaCompartida(DTPencaCompartida pc);
        MensajesEnum actualizar_PencaEmpresarial(DTPencaEmpresarial pe);

        //Listar
        List<DTPencaCompartida> listar_PencaCompartida();
        List<DTPencaEmpresarial> listar_PencaEmpresarial();

        //Eliminar
        bool eliminar_PencaCompartida(int id_PencaC);
        bool eliminar_PencaEmpresarial(int id_PencaE);

        //Agregar Pronostico
        MensajesEnum agregar_Pronostico(DTPronostico dp);
        MensajesEnum agregar_usuarioPenca(DTUsuarioPenca dp);

    }
}
