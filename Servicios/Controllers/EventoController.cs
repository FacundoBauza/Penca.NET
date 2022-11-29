using BusinessLogic.Interfaces;
using Dominio.DT;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

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
        [HttpPost("/api/agregarEvento")]
        public ActionResult<DTEvento> Post([FromBody] DTEvento value)
        {
            MensajesEnum x = bl.agregar_Evento(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Actualizar    
        [HttpPut("/api/actualizarEvento")]
        public ActionResult<Evento> Put([FromBody] DTEvento value)
        {
            MensajesEnum x = bl.actualizar_Evento(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Listar
        [HttpGet("/api/listarEventos")]
        public List<DTEvento> Get()
        {
            return bl.listar_Eventos();
        }

        //Eliminar
        [HttpDelete("/api/agregarEvento/{id:int}")]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(bl.eliminar_Evento(id));
        }
    }
}
