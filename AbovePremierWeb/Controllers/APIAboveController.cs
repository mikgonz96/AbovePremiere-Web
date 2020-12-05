using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AbovePremierWeb.Models;
using AbovePremierWeb.DAOs;

namespace AbovePremierWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIAboveController : ControllerBase
    {
        
        // GET: api/APIAbove/5
        [HttpGet("{mail}/{pass}")]
        public ActionResult Get(string mail, string pass)
        {
            var u = new Usuario(mail,pass);
            var conf = UsuarioDAO.getInstance().verificarUsuario(u);
            return Content(JsonConvert.SerializeObject(conf), "application/json");
        }
                
    }
}
