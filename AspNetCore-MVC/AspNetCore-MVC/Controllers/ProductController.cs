using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Controllers
{
    // Rota adicionada diretamente nas Actions.Nesse exemplo é uma simulação de uma API.
    [Route("api/product")]
    public class ProductController : Controller
    {
        //validação de da rota. pode escolher o tipo, mnº máximo e minimo de caracteres, etc.
        [HttpGet("{id=int}")]

        public int Get(int id) {

            return id;
        }

    }
}

