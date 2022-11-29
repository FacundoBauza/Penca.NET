using BusinessLogic.Interfaces;
using Dominio.DT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasosUsoController : ControllerBase
    {
        private IB_CasosUso fu;
        public CasosUsoController(IB_CasosUso _fu)
        {
            fu = _fu;
        }

        //Listar Eventos/Torneo
        [HttpGet("/api/listarEventosTorneo")]
        public List<DTEvento> listarEventosTorneo(int id)
        {
            return fu.obtenerEventos_Torneo(id);
        }


        //Listar Pronosticos/Usuario
        [HttpGet("/api/listarPronosticosUsuario")]
        public List<DTPronostico> listarPronosticosUsuario(string username, int id_Penca)
        {
            return fu.obtenerPronosticos_Usuario(username, id_Penca);
        }

        //Actualizar Puntajes
        [HttpGet("/api/actualizarPuntajes")]
        public void actualizarPuntajes(int id_Penca, bool esCompartida)
        {
            fu.actualizarPuntajes(id_Penca, esCompartida);
        }

        //Listar Pronosticos/Usuario
        [HttpGet("/api/listarPuntajeUsuarioPenca")]
        public List<DTPuntosUsuarioFront> listarPuntajeUsuarioPenca(int id_Penca, bool esCompartida)
        {
            return fu.obtenerPuntaje_UsuarioPenca(id_Penca, esCompartida);
        }

        //Listar Usuario Penca
        [HttpGet("/api/listarUsuarioPenca")]
        public List<DTUsuario> listarUsuarioPenca(int id_Penca, bool esCompartida)
        {
            return fu.listarUsuariosPenca(id_Penca, esCompartida);
        }
    }
}
