using BusinessLogic.Implementacion;
using Dominio.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_CasosUso
    {
        List<int> obtenerPorcentajesPremio(int id);


        List<DTPencaCompartida> obtenerPencaCompartida_Usuario(string username);
        List<DTPencaEmpresarial> obtenerPencaEmpresarial_Usuario(string username);
        DTTorneo obtenerTorneo_Penca(int id_Penca);
        List<DTSubscripcion> obtenerSubscripciones_Usuario(string username);
        List<string> obtenerUsuarios_PencaCompartida(int id_Penca);
        List<string> obtenerUsuarios_PencaEmpresarial(int id_Penca);
        DTPencaEmpresarial obtenerInfo_PencaEmpresarial(int id_Penca);
        DTPencaCompartida obtenerInfo_PencaCompartida(int id_Penca);
        void actualizarPuntajes(int id_Penca, bool esCompartida);
        List<DTUsuario> listarUsuariosPenca(int id_Penca, bool esCompartida);
        List<DTUsuario> listarUsuarios();
        List<DTSubscripcion> listarSubscripcionesUsuario(string username);
        bool actualizarUsuario(string username, string pass);


        List<DTEvento> obtenerEventos_Torneo(int id_Torneo);
        List<DTEvento> obtenerEventosTorneo(int id);
        List<DTPronostico> obtenerPronosticos_Usuario(string username, int id_Penca);
        List<DTPuntosUsuarioFront> obtenerPuntaje_UsuarioPenca(int id_Penca, bool esCompartida);
    }
}
