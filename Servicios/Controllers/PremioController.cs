using BusinessLogic.Interfaces;
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
        [HttpPost]
        public ActionResult<Torneo> Post([FromBody] Premio value)
        {
            return Ok(bl.agregar_Premio(value));
        }

        //Listar
        [HttpGet("{id_User:int}")]
        public List<Premio> Get(int id_User)
        {
            return bl.listar_Premios(id_User);
        }

        //Cobrar Premio    
        [HttpPut("{id_User:int}/{id_Penca:int}")]
        public ActionResult<Premio> Put(int id_User, int id_Penca)
        {
            return Ok(bl.Cobrar_Premio(id_User, id_Penca));
        }
    }
}
