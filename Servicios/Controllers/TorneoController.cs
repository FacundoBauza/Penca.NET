using Microsoft.AspNetCore.Mvc;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TorneoController : ControllerBase
    {
       
    };
    /*
        private readonly ILogger<TorneoController> _logger;

        public TorneoController(ILogger<TorneoController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "GetTorneo")]
        public IEnumerable<Torneo> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Torneo
            {
                
            })
            .ToArray();
        }*/
    
}