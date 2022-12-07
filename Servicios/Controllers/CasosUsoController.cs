using BusinessLogic.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasosUsoController : ControllerBase
    {
        private IB_CasosUso fu;
        private readonly UserManager<Users> _userManager;
        public CasosUsoController(IB_CasosUso _fu, UserManager<Users> userManager)
        {
            fu = _fu;
            _userManager = userManager;
        }

        //Listar Eventos/Torneo
        [HttpGet("/api/listarEventosTorneo")]
        public List<DTEvento> listarEventosTorneo(int id)
        {
            return fu.obtenerEventos_Torneo(id);
        }


        //Listar Pronosticos/Usuario
        [HttpGet("/api/listarPronosticosUsuario")]
        public List<DTPronostico> listarPronosticosUsuario(string username, int id_Penca, bool esCompartida)
        {
            return fu.obtenerPronosticos_Usuario(username, id_Penca, esCompartida);
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

        //Listar Usuarios
        [HttpGet("/api/listarUsuarios")]
        public List<DTUsuario> listarUsuario()
        {
            return fu.listarUsuarios();
        }

        //Listar SubscripcionesUsuario
        [HttpGet("/api/listarSubscripcionesUsuario")]
        public List<DTSubscripcion> listarSubscripcionesUsuario(string username)
        {
            return fu.listarSubscripcionesUsuario(username);
        }

        //Actualizar Pass
        [HttpGet("/api/actualizarUsuario")]
        public async void actualizarUsuario(string username, string pass)
        {
            Users u = new Users();
            var result = await _userManager.AddPasswordAsync(u, "sdg");
 
        }
    }
}
