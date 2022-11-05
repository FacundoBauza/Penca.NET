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

        //Agregar
        [HttpPost]
        public ActionResult<Torneo> Post([FromBody] Torneo value)
        {
            return Ok(bl.agregar_Torneo(value));
        }

        //Actualizar    
        [HttpPut]
        public ActionResult<Torneo> Put(int id, [FromBody] Torneo value)
        {
            return Ok(bl.actualizar_Torneo(value));
        }

        //Listar
        [HttpGet]
        public List<Torneo> Get()
        {  
            return bl.listar_Torneos();
        }

        //Eliminar
        [HttpDelete("{id:int}")]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(bl.eliminar_Torneo(id));
        }
    };
    
}