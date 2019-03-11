using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore_MVC.Models;
using AspNetCore_MVC.Repository;
using AspNetCore_MVC.Interfaces;

namespace AspNetCore_MVC.Controllers
{
    public class HomeController : Controller
    {
        private IPeopleRepository _peopleRepository;
        public HomeController(IPeopleRepository repository)
        {
            // Método antigo sem injeção de dependencia - Foi passado como parametro a interface 
            //_peopleRepository =  new PeopleRepository ("slqserver://178.333");

            _peopleRepository = repository;
        }

        public IActionResult Index()
        {
            ViewData["Name"] = _peopleRepository.GetNameById(2);

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
