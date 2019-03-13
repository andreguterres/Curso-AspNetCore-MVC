﻿using Microsoft.AspNetCore.Mvc;
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
        #region//validação de da rota. pode escolher o tipo, nº máximo e minimo de caracteres, etc.

        //[HttpGet("{id=int}")]

        //public int Get(int id) {

        //    return id;
        #endregion

        #region// Imprimi na tela a patch "api/product".
        //public string Get()
        //{

        //    // Imprimi na tela a patch "api/product".
        //    return HttpContext.Request.Path;

        //}
        #endregion

        #region// Parametro enviado por Query String
        //public string Get()
        //{

        //    // Parametro enviado por Query String
        //    // Exemplo de Url com a String Digitada
        //    //https://localhost:5001/api/product?param= Olá Mundo !
        //    return HttpContext.Request.Query["param"];

        //}
        #endregion


        #region//Pode retornar uma página, um arquivo df, imagem, etc..
        //public string Get()
        public IActionResult Get()
        {
            //Pode customizar o tipo de retorno.
            HttpContext.Response.StatusCode = 404;

            //Retorna texto 
            HttpContext.Response.Headers.Add("ResponseHeader", "Ola Mundo !");

            //return "ok";

            //Retorna Imagem
            return File("images/NewTux.svg", "image/svg+xml");

        }
        #endregion
    }
}

