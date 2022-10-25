using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Implementacion;
using Dominio.Entidades;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TorneoController : ControllerBase
    {
        private IB_Torneo bl;
        public TorneoController(IB_Torneo _bl)
        {
            bl = _bl;
        }

        [HttpGet(Name = "GetTorneo")]
        public List<Torneo> Get()
        {
       
            return bl.getTorneos();
        
        }

    };
    
}