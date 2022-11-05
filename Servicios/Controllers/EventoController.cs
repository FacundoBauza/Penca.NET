using BusinessLogic.Interfaces;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private IB_Evento bl;
        public EventoController(IB_Evento _bl)
        {
            bl = _bl;
        }

        //Agregar
        [HttpPost]
        public ActionResult<Evento> Post([FromBody] Evento value)
        {
            return Ok(bl.agregar_Evento(value));
        }

        //Actualizar    
        [HttpPut]
        public ActionResult<Evento> Put(int id, [FromBody] Evento value)
        {
            return Ok(bl.actualizar_Evento(value));
        }

        //Listar
        [HttpGet]
        public List<Evento> Get()
        {
            return bl.listar_Eventos();
        }

        //Eliminar
        [HttpDelete("{id:int}")]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(bl.eliminar_Evento(id));
        }
    }
}
