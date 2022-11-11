using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Implementacion;
using Dominio.Entidades;
using Dominio.DT;

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
        [HttpPost("/api/agregarTorneo")]
        public ActionResult<Torneo> Post([FromBody] DTTorneo value)
        {
            return Ok(bl.agregar_Torneo(value));
        }

        //Actualizar    
        [HttpPut("/api/actualizarTorneo")]
        public ActionResult<Torneo> Put(int id, [FromBody] Torneo value)
        {
            return Ok(bl.actualizar_Torneo(value));
        }

        //Listar
        [HttpGet("/api/listarTorneos")]
        public List<Torneo> Get()
        {  
            return bl.listar_Torneos();
        }

        //Eliminar
        [HttpDelete("/api/eliminarTorneo/{id:int}")]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(bl.eliminar_Torneo(id));
        }
    };
    
}