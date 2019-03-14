using AspNetCore_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Controllers
{
    public class PessoaController: Controller
    {
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Save (PessoaModel pessoa)
        {
            // Condicional usada quando não utiliza notation na model
            //if (pessoa.Id == 0 || string.IsNullOrEmpty(pessoa.Nome) || string.IsNullOrEmpty(pessoa.Sobrenome) || pessoa.Idade == 0 )
            if (!ModelState.IsValid)    
            
                ViewBag.Validacao = "Preencha o formulário corretamente";

                  

            return View();
        }
    }
}
