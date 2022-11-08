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

       
    };
}
