using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Library.Filters;
using Site01.Models;

namespace Site01.Controllesrs
{
    [Login]
    public class PalavraController : Controller
    {
        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;
        }
        //listar todas as palvras do banco de dados
        public IActionResult Index()
        {
            var palavras = _db.Palavras.ToList();
            return View(palavras);
        }

        //Crud - cadastrar, consultar, Atuaçozar e Excluir. Create, Retriever, Update, Delete, CRUD.
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Palavra());
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm]Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        //
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Palavra palavra = _db.Palavras.Find(Id);

            return View("Cadastrar", palavra);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Palavra palavra)
        {
            if (ModelState.IsValid)
            {               
                _db.Palavras.Update(palavra);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("cadastrar", palavra);
        }

        //Palavra/Excluir/39
        //{Controller}/{action}/{Id?}
        public IActionResult Excluir(int Id)
        {

            //TODo -excluir registro no banco
            _db.Palavras.Remove(_db.Palavras.Find(Id));
            _db.SaveChanges();


            return RedirectToAction("index");
        }

    }
}