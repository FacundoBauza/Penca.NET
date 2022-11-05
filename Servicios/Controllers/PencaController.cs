using BusinessLogic.Interfaces;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PencaController : ControllerBase
    {
        private IB_Penca bl;
        public PencaController(IB_Penca _bl)
        {
            bl = _bl;
        }

        //Agregar Penca Compartida
        [HttpPost]
        public ActionResult<PencaCompartida> Post([FromBody] PencaCompartida value)
        {
            return Ok(bl.actualizar_PencaCompartida(value));
        }

        //Agregar Penca Empresarial
        [HttpPost]
        public ActionResult<PencaEmpresarial> Post([FromBody] PencaEmpresarial value)
        {
            return Ok(bl.agregar_PencaEmpresarial(value));

        }

        //Actualizar Penca Compartida    
        [HttpPut]
        public ActionResult<PencaCompartida> Put_Compartida(int id, [FromBody] PencaCompartida value)
        {
            return Ok(bl.actualizar_PencaCompartida(value));
        }

        //Actualizar Penca Empresarial
        [HttpPut]
        public ActionResult<PencaEmpresarial> Put_Empresarial(int id, [FromBody] PencaEmpresarial value)
        {
            return Ok(bl.actualizar_PencaEmpresarial(value));
        }

        //Listar Penca Compartida
        [HttpGet]
        public List<PencaCompartida> Get_Compartida()
        {
            return bl.listar_PencaCompartida();
        }

        //Listar Penca Empresarial
        [HttpGet]
        public List<PencaEmpresarial> Get_Empresarial()
        {
            return bl.listar_PencaEmpresarial();
        }

        //Eliminar Penca Compartida
        [HttpDelete("{id:int}")]
        public ActionResult<bool> Delete_Compartida(int id_PencaC)
        {
            return Ok(bl.eliminar_PencaCompartida(id_PencaC));
        }

        //Eliminar Penca Empresarial
        [HttpDelete("{id:int}")]
        public ActionResult<bool> DeleteE_Empresarial(int id_PencaE)
        {
            return Ok(bl.eliminar_PencaEmpresarial(id_PencaE));
        }
    };
}
