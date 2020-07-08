﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestorSistemasSite.Models;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnuncioController : ControllerBase
    {
        private ApplicationDbContext db;
        public static List<Anuncio> Anuncio = null;

        public AnuncioController(ApplicationDbContext contexto)
        {
            db = contexto;
        }


        [HttpGet]
        public IEnumerable<Anuncio> Get()
        {
            var model = db.Anuncio.Where(x=> x.Ativo).Tolist();
            return model;
        }
    }
}
