﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar() {
            return View();
        }

        public IActionResult Pesquisar() {
            return View();
        }

        public IActionResult Resumo() {
            return View();
        }

        public IActionResult Tratamento() {
            return View();
        }
    }
}