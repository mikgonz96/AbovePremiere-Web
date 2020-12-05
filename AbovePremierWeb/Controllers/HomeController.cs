using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AbovePremierWeb.Models;
using AbovePremierWeb.DAOs;

namespace AbovePremierWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var usuarioJson = HttpContext.Session.GetString("usuario");
            
            if (usuarioJson != null)
            {
                ViewBag.msg = "¡Bienvenido " + usuarioJson+"! ♥";
                return Redirect("Home/Download");
            }
            else
            {
                return View();
            }

        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoginAct(string mail, string pass)
        {
            Usuario usuario = new Usuario(mail, pass);
            var confirm2 = UsuarioDAO.getInstance().verificarUsuario(usuario);

            if (confirm2)
            {
                Usuario us = new Usuario(usuario.mail);
                HttpContext.Session.SetString("usuario", JsonConvert.SerializeObject(us));
                ViewBag.msg = "¡Bienvenido " + usuario.mail + "! ♥";
                return Redirect("Download");
            }
            else
            {
                ViewBag.msg = "Mail o Constraseña Incorrecta";
                return View("Login");
            }

            //return Redirect("Download");
        }

        public IActionResult Registro()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(string mail, string pass, string key)
        {
            Usuario usuario = new Usuario(mail, pass);
            var confirm = KeyDAO.getInstance().verificarKey(key);
            var confirm2 = UsuarioDAO.getInstance().verificarUsuario(usuario);

            if (confirm && !confirm2)
            {
                UsuarioDAO.getInstance().agregarUsuario(usuario);
                KeyDAO.getInstance().borrarKey(key);
                ViewBag.msg = "El usuario fue creado correctamente";
                return View("Registro");
            }
            else if(!confirm)
            {
                ViewBag.msg = "La key ingresada ya está en uso o es inexistente";
                return View("Registro");
            }
            else
            {
                ViewBag.msg = "El usuario ya existe";
                return View("Registro");
            }
            
        }

        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            return Redirect("Index");

        }

        public IActionResult Download()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
