using DataAccesLayer.Models;
using Dominio.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_CasosUso
    {
        List<DTEvento> getEventosTorneo(int id);
        List<DTPronostico> getPronosticos_Usuario(string username, int id_Penca, bool esCompartida);
        List<DTPuntosUsuarioFront> getPuntaje_UsuarioPenca(int id_Penca, bool esCompartida);
        void updatePuntaje_UsuarioPenca(int id_Penca, bool esCompartida);
        List<DTUsuario> getUsuariosPenca(int id_Penca, bool esCompartida);
        List<DTUsuario> getUsuarios();
        List<DTSubscripcion> getSubscripcionesUsuario(string username);
        bool updateUsuario(string username, string pass);
        Users getUsuario(string username);
    }
}
