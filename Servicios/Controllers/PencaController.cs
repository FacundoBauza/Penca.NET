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
            MensajesEnum x = bl.agregar_PencaCompartida(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje});
        }

        //Agregar Penca Empresarial
        [HttpPost("/api/agregarEmpresarial")]
        public ActionResult<PencaEmpresarial> Post([FromBody] DTPencaEmpresarial value)
        {
            MensajesEnum x = bl.agregar_PencaEmpresarial(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Actualizar Penca Compartida    
        [HttpPut("/api/actualizarCompartida")]
        public ActionResult<PencaCompartida> Put_Compartida([FromBody] DTPencaCompartida value)
        {
            MensajesEnum x = bl.actualizar_PencaCompartida(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Actualizar Penca Empresarial
        [HttpPut("/api/actualizarEmpresarial")]
        public ActionResult<PencaEmpresarial> Put_Empresarial([FromBody] DTPencaEmpresarial value)
        {
            MensajesEnum x = bl.actualizar_PencaEmpresarial(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
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

        //Agregar Usuario a Penca
        [HttpPost("/api/agregarUsuario")]
        public ActionResult<PencaCompartida> agregarusuario([FromBody] DTUsuarioPenca value)
        {
            MensajesEnum x = bl.agregar_usuarioPenca(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Agregar Pronostico
        [HttpPost("/api/agregarPronostico")]
        public ActionResult<PencaCompartida> Post([FromBody] DTPronostico value)
        {
            MensajesEnum x = bl.agregar_Pronostico(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Listar Porcentajes
        [HttpPost("/api/listarPorcentajes")]
        public ActionResult<List<int>> listarPorcentajes(int id_Criterio)
        {
            return Ok(bl.listarPorcentajes(id_Criterio));
        }
    };
}
