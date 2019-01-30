using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site01.Library.Mail;
using Site01.Models;

namespace Site01.Controllesrs
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Contato = new Contato();
            return View();
        }

        public IActionResult ReceberContato([FromForm]Contato contato)
        {
            if (ModelState.IsValid)
            {
                //entra
                //string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                //return new ContentResult() { Content = conteudo };

                ViewBag.Contato = new Contato();
                EnviarEmail.EnviarMensagemContato(contato);
                ViewBag.Mensagem = "Mensagem Enviada com sucesso!";
                return View("Index");
            }
            else
            {
                //Não passou
                ViewBag.Contato = contato;
                return View("Index");
            }
            
        }


        //obter dados manualmente

        //public IActionResult ReceberContato() {

        //    //dados enviados por post usa-se Request.Form
        //    //dados enviados por querystring usa-se Reques.QueryString
        //    Contato contato = new Contato();

        //    contato.Nome = Request.Form["nome"];
        //    contato.Email = Request.Form["email"];
        //    contato.Assunto = Request.Form["assunto"];
        //    contato.Mensagem = Request.Form["mensagem"];

        //    string conteudo = string.Format( "Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

        //    return new ContentResult() { Content = conteudo};

        //}
    }
}