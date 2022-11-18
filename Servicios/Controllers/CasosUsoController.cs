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
        public List<DTEvento> Get(int id)
        {
            return fu.obtenerEventos_Torneo(id);
        }
    }
}
