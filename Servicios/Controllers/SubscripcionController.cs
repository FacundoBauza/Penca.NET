using BusinessLogic.Interfaces;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscripcionController : ControllerBase
    {

        private IB_Subscripcion bl;
        public SubscripcionController(IB_Subscripcion _bl)
        {
            bl = _bl;
        }

        //Agregar Suscripcion
        [HttpPost]
        public ActionResult<Subscripcion> Post([FromBody] Subscripcion value)
        {
            return Ok(bl.agregar_Subscripcion(value));
        }

        //Listar Subscripciones
        [HttpGet("{id_User:int}")]
        public List<Subscripcion> Get(int id_User)
        {
            return bl.listar_Subscripciones(id_User);
        }
    }
}
