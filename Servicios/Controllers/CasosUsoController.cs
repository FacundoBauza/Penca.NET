using BusinessLogic.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using sib_api_v3_sdk.Model;
using sib_api_v3_sdk.Api;

public class test
{
    public List<String> emails { get; set; }
    public String link { get; set; }
}

namespace Servicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasosUsoController : ControllerBase
    {
        private IB_CasosUso fu;
        private readonly UserManager<Users> _userManager;
        public CasosUsoController(IB_CasosUso _fu, UserManager<Users> userManager)
        {
            fu = _fu;
            _userManager = userManager;
        }

        //Listar Eventos/Torneo
        [HttpGet("/api/listarEventosTorneo")]
        public List<DTEvento> listarEventosTorneo(int id)
        {
            return fu.obtenerEventos_Torneo(id);
        }


        //Listar Pronosticos/Usuario
        [HttpGet("/api/listarPronosticosUsuario")]
        public List<DTPronostico> listarPronosticosUsuario(string username, int id_Penca, bool esCompartida)
        {
            return fu.obtenerPronosticos_Usuario(username, id_Penca, esCompartida);
        }

        //Actualizar Puntajes
        [HttpGet("/api/actualizarPuntajes")]
        public void actualizarPuntajes(int id_Penca, bool esCompartida)
        {
            fu.actualizarPuntajes(id_Penca, esCompartida);
        }

        //Listar Pronosticos/Usuario
        [HttpGet("/api/listarPuntajeUsuarioPenca")]
        public List<DTPuntosUsuarioFront> listarPuntajeUsuarioPenca(int id_Penca, bool esCompartida)
        {
            return fu.obtenerPuntaje_UsuarioPenca(id_Penca, esCompartida);
        }

        //Listar Usuario Penca
        [HttpGet("/api/listarUsuarioPenca")]
        public List<DTUsuario> listarUsuarioPenca(int id_Penca, bool esCompartida)
        {
            return fu.listarUsuariosPenca(id_Penca, esCompartida);
        }

        //Listar Usuarios
        [HttpGet("/api/listarUsuarios")]
        public List<DTUsuario> listarUsuario()
        {
            return fu.listarUsuarios();
        }

        //Listar SubscripcionesUsuario
        [HttpGet("/api/listarSubscripcionesUsuario")]
        public List<DTSubscripcion> listarSubscripcionesUsuario(string username)
        {
            return fu.listarSubscripcionesUsuario(username);
        }

        [HttpPost("/api/enviarInvitaciones")]
        public ActionResult<PencaEmpresarial> Post([FromBody] test body)
        {
            var apiInstance = new TransactionalEmailsApi();
            //De donde lo envio
            string SenderName = "Leandro Marrero";
            string SenderEmail = "leandro.marrero03@gmail.com";
            SendSmtpEmailSender Email = new SendSmtpEmailSender(SenderName, SenderEmail);
            //A quien lo envio
            List<SendSmtpEmailTo> To = new List<SendSmtpEmailTo>();
            foreach (var i in body.emails)
            {
                string ToEmail = i;
                string ToName = "John Doe";
                SendSmtpEmailTo smtpEmailTo = new SendSmtpEmailTo(ToEmail, ToName);
                To.Add(smtpEmailTo);
            }
            Debug.WriteLine(To);
            //Cuerpo del email
            string HtmlContent = "<html><body><h1>This is my first transactional email " + body.link + "</h1></body></html>";
            string TextContent = null;
            string Subject = "Invitacion a Penca";
            string ReplyToName = "John Doe";
            string ReplyToEmail = "replyto@domain.com";
            SendSmtpEmailReplyTo ReplyTo = new SendSmtpEmailReplyTo(ReplyToEmail, ReplyToName);

            //Agregar cabeceras
            JObject Headers = new JObject();
            Headers.Add("Some-Custom-Name", "unique-id-1234");
            long? TemplateId = null;
            JObject Params = new JObject();
            Params.Add("parameter", "My param value");
            Params.Add("subject", "New Subject");

            Dictionary<string, object> _parmas = new Dictionary<string, object>();
            _parmas.Add("params", Params);
            try
            {
                var sendSmtpEmail = new SendSmtpEmail(Email, To, null, null, HtmlContent, TextContent, Subject, ReplyTo, null, Headers, TemplateId, _parmas, null, null);
                CreateSmtpEmail result = apiInstance.SendTransacEmail(sendSmtpEmail);
                Debug.WriteLine(result.ToJson());

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Console.WriteLine(e.Message);
            }
            return null;
            //return fu.listarUsuariosPenca(id_Penca, esCompartida);
        }

        //Nueva Pass
        [HttpGet("/api/pedidoNuevaPass")]
        public async void pedidoNuevaPass(string username)
        {
            /*int longitud = 7;
            Guid miGuid = Guid.NewGuid();
            string String = Convert.ToBase64String(miGuid.ToByteArray());
            String = String.Replace("=", "").Replace("+", "");
            string nuevaPass = String.Substring(0, longitud);

            //Users u = fu.obtenerUsuario(username);
            Users u = _userManager.FindByNameAsync(username).Result;
            List<string> emails = new List<string>
            {
                username
            };
            test t = new test()
            {
                emails = emails,
                link = nuevaPass
            };
         
            Post(t);
            var result = _userManager.RemovePasswordAsync(u);
            var result1 = _userManager.AddPasswordAsync(u, nuevaPass);*/
        }
    }
}
