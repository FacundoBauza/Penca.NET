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
        private IB_Functions fu;
        public CasosUsoController(IB_Functions _fu)
        {
            fu = _fu;
        }

        //Listar
        /*[HttpGet("/api/listarEventos")]
        public List<DTEvento> Get()
        {
            return
        }*/
    }
}
