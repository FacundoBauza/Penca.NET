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
            bool x = bl.agregar_Torneo(new Torneo(0, "Copa de Campeones", new DateTime(), new DateTime(), null));
            return bl.listar_Torneos();
        }

    };
    
}