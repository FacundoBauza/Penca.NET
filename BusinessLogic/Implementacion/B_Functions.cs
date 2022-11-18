using BusinessLogic.Interfaces;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementacion
{
    public class B_Functions: IB_Functions
    {
        private I_Functions _fu;
        private I_Casteos _cas;
        public B_Functions(I_Functions fu, I_Casteos cas)
        {
            _fu = fu;
            _cas = cas;
        }

        List<int> IB_Functions.obtenerPorcentajesPremio(int id)
        {
            return _fu.obtenerPorcentajesPremio(id);    
        }

        List<int> IB_Functions.obtenerEventosTorneo(int id)
        {
            return _fu.obtenerEventosTorneo(id);
        }

        List<DTPencaCompartida> IB_Functions.obtenerPencaCompartida_Usuario(string username)
        {
            return _fu.obtenerPencaCompartida_Usuario(username);
        }

        List<DTPencaEmpresarial> IB_Functions.obtenerPencaEmpresarial_Usuario(string username)
        {
            return _fu.obtenerPencaEmpresarial_Usuario(username);
        }

        List<DTEvento> IB_Functions.obtenerEventos_Torneo(int id_Torneo)
        {
            return _fu.obtenerEventos_Torneo(id_Torneo);
        }

        DTTorneo IB_Functions.obtenerTorneo_Penca(int id_Penca)
        {
            return _fu.obtenerTorneo_Penca(id_Penca);
        }

        List<DTSubscripcion> IB_Functions.obtenerSubscripciones_Usuario(string username)
        {
            return _fu.obtenerSubscripciones_Usuario(username);
        }

        List<DTUsuario> IB_Functions.obtenerUsuarios_PencaCompartida(int id_Penca)
        {
            return _fu.obtenerUsuarios_PencaCompartida(id_Penca);
        }

        List<DTUsuario> IB_Functions.obtenerUsuarios_PencaEmpresarial(int id_Penca)
        {
            return _fu.obtenerUsuarios_PencaEmpresarial(id_Penca);
        }

        DTPencaEmpresarial IB_Functions.obtenerInfo_PencaEmpresarial(int id_Penca)
        {
            return _fu.obtenerInfo_PencaEmpresarial(id_Penca);
        }

        DTPencaCompartida IB_Functions.obtenerInfo_PencaCompartida(int id_Penca)
        {
            return _fu.obtenerInfo_PencaCompartida(id_Penca);
        }
    }
}
