﻿using BusinessLogic.Interfaces;
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
        [HttpPost("/api/agregarEvento")]
        public ActionResult<DTEvento> Post([FromBody] DTEvento value)
        {
            return Ok(bl.agregar_Evento(value));
        }

        //Actualizar    
        [HttpPut("/api/actualizarEvento")]
        public ActionResult<Evento> Put(int id, [FromBody] Evento value)
        {
            return Ok(bl.actualizar_Evento(value));
        }

        //Listar
        [HttpGet("/api/listarEventos")]
        public List<Evento> Get()
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
