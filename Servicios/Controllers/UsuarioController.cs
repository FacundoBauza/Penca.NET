using BusinessLogic.Interfaces;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IB_Usuario bl;
        public UsuarioController(IB_Usuario _bl)
        {
            bl = _bl;
        }

        //Login
        [HttpPost]
        bool Login(string user, string pass)
        {
            return true;
        }

        //Agregar
        [HttpPost]
        public ActionResult<Usuario> Post([FromBody] Usuario value)
        {
            return Ok(bl.agregar_Usuario(value));
        }

        //Actualizar    
        [HttpPut]
        public ActionResult<Usuario> Put(int id, [FromBody] Usuario value)
        {
            return Ok(bl.actualizar_Usuario(value));
        }

        //Listar
        [HttpGet]
        public List<Usuario> Get()
        {
            return bl.listar_Usuarios();
        }

        //Eliminar

        [HttpDelete("{id:int}")]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(bl.eliminar_Usuario(id));
        }
    }
}
