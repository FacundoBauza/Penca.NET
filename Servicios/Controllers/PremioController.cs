using BusinessLogic.Interfaces;
using Dominio.DT;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremioController : ControllerBase
    {
        private IB_Premio bl;
        public PremioController(IB_Premio _bl)
        {
            bl = _bl;
        }

        //Agregar
        [HttpPost("/api/agregarPremio")]
        public ActionResult<DTPremio> Post([FromBody] DTPremio value)
        {
            return Ok(bl.agregar_Premio(value));
        }

        //Listar
        [HttpGet("/api/listarPremios")]
        public List<DTPremio> Get()
        {
            return bl.listar_Premios();
        }

        //Cobrar Premio    
        [HttpPut("/api/pagarPremio/{username}/{id_Penca:int}")]
        public ActionResult<DTPremio> Put(string username, int id_Penca)
        {
            return Ok(bl.Pagar_Premio(username, id_Penca));
        }
    }
}
