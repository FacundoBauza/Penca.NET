using BusinessLogic.Interfaces;
using DataAccesLayer.Interfaces;
using Dominio.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementacion
{
    public class B_CasosUso: IB_CasosUso
    {
        private I_CasosUso _dal;
        private I_Casteos _cas;
        private I_Functions _fu;
        public B_CasosUso(I_CasosUso dal, I_Casteos cas, I_Functions fu)
        {
            _dal = dal;
            _cas = cas;
            _fu = fu;
        }

        List<DTEvento> IB_CasosUso.obtenerEventosTorneo(int id)
        {
            return _dal.getEventosTorneo(id);
        }


        List<int> IB_CasosUso.obtenerPorcentajesPremio(int id)
        {
            return _fu.obtenerPorcentajesPremio(id);
        }

        List<DTPencaCompartida> IB_CasosUso.obtenerPencaCompartida_Usuario(string username)
        {
            return _fu.obtenerPencaCompartida_Usuario(username);
        }

        List<DTPencaEmpresarial> IB_CasosUso.obtenerPencaEmpresarial_Usuario(string username)
        {
            return _fu.obtenerPencaEmpresarial_Usuario(username);
        }

        List<DTEvento> IB_CasosUso.obtenerEventos_Torneo(int id_Torneo)
        {
            return _dal.getEventosTorneo(id_Torneo);
        }

        DTTorneo IB_CasosUso.obtenerTorneo_Penca(int id_Penca)
        {
            return _fu.obtenerTorneo_Penca(id_Penca);
        }

        List<DTSubscripcion> IB_CasosUso.obtenerSubscripciones_Usuario(string username)
        {
            return _fu.obtenerSubscripciones_Usuario(username);
        }

        List<DTUsuario> IB_CasosUso.obtenerUsuarios_PencaCompartida(int id_Penca)
        {
            return _fu.obtenerUsuarios_PencaCompartida(id_Penca);
        }

        List<DTUsuario> IB_CasosUso.obtenerUsuarios_PencaEmpresarial(int id_Penca)
        {
            return _fu.obtenerUsuarios_PencaEmpresarial(id_Penca);
        }

        DTPencaEmpresarial IB_CasosUso.obtenerInfo_PencaEmpresarial(int id_Penca)
        {
            return _fu.obtenerInfo_PencaEmpresarial(id_Penca);
        }

        DTPencaCompartida IB_CasosUso.obtenerInfo_PencaCompartida(int id_Penca)
        {
            return _fu.obtenerInfo_PencaCompartida(id_Penca);
        }
    }
}
