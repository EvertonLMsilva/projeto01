using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllesrs
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm]Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email == "everton.l.m.silva@gmail.com" && usuario.Senha == "1234567")
                {
                    /*Add Session
                     HttpContext.Session.SetString("Login", "true");
                     HttpContext.Session.SetInt32("Login", serializar Objeto > String);
                     Serializar Objeto

                     Ler session
                     string login = HttpContext.Session.GetString("Login");
                     */
                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são inválidos";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


    }
}
