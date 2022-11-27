using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_ManejadorPenca
    {
        //Agregar
        bool set_PencaCompartida(PencaCompartidas pc, CriterioPremio cp);
        bool set_PencaEmpresarial(PencaEmpresariales pe);

        //Actualizar
        bool update_PencaCompartida(DTPencaCompartida pc);
        bool update_PencaEmpresarial(DTPencaEmpresarial pe);

        //Listar
        List<DTPencaCompartida> get_PencaCompartida();
        List<DTPencaEmpresarial> get_PencaEmpresarial();

        //Eliminar
        bool delete_PencaCompartida(int id_PencaC);
        bool delete_PencaEmpresarial(int id_PencaL);

        //Agregar Pronostico
        bool setPronostico(DTPronostico dp);

        //Agregar Usuario a Penca
        bool setUsuarioPenca(DTUsuarioPenca dp);
    }
}
