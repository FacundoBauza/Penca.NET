using BusinessLogic.Implementacion;
using BusinessLogic.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PencaController : ControllerBase
    {
        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        private IB_Penca bl;
        public PencaController(IB_Penca _bl, UserManager<Users> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            bl = _bl;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        //Agregar Penca Compartida
        [HttpPost("/api/agregarCompartida")]
        public ActionResult<PencaCompartida> Post([FromBody] DTPencaCompartida2 value)
        {
            return Ok(new StatusResponse {StatusMessage = bl.agregar_PencaCompartida(value).ToString()});
        }

        //Agregar Penca Empresarial
        [HttpPost("/api/agregarEmpresarial")]
        public ActionResult<PencaEmpresarial> Post([FromBody] DTPencaEmpresarial value)
        {
            return Ok(new StatusResponse { StatusMessage = bl.agregar_PencaEmpresarial(value).ToString() });
        }

        //Actualizar Penca Compartida    
        [HttpPut("/api/actualizarCompartida")]
        public ActionResult<PencaCompartida> Put_Compartida([FromBody] DTPencaCompartida value)
        {
            return Ok(bl.actualizar_PencaCompartida(value));
        }

        //Actualizar Penca Empresarial
        [HttpPut("/api/actualizarEmpresarial")]
        public ActionResult<PencaEmpresarial> Put_Empresarial([FromBody] DTPencaEmpresarial value)
        {
            return Ok(bl.actualizar_PencaEmpresarial(value));
        }

        //Listar Penca Compartida
        [HttpGet("/api/listarCompartida")]
        public List<DTPencaCompartida> Get_Compartida()
        {
            return bl.listar_PencaCompartida();
        }

        //Listar Penca Empresarial
        [HttpGet("/api/listarEmpresarial")]
        public List<DTPencaEmpresarial> Get_Empresarial()
        {
            return bl.listar_PencaEmpresarial();
        }

        //Eliminar Penca Compartida
        [HttpDelete("/api/eliminarCompartida/{id:int}")]
        public ActionResult<bool> Delete_Compartida(int id_PencaC)
        {
            return Ok(bl.eliminar_PencaCompartida(id_PencaC));
        }

        //Eliminar Penca Empresarial
        [HttpDelete("/api/eliminarEmpresarial/{id:int}")]
        public ActionResult<bool> DeleteE_Empresarial(int id_PencaE)
        {
            return Ok(bl.eliminar_PencaEmpresarial(id_PencaE));
        }
    };
}
