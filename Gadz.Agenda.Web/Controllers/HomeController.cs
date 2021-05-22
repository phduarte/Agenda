﻿using Gadz.Agenda.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Web.Controllers
{
    public class HomeController : Controller
    {
        [Breadcrumb("Bem vindo ao Agenda"), Title("Agenda")]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("Versões"), Title("Versões")]
        public IActionResult Versoes()
        {
            return View();
        }

        [Breadcrumb("Configurações"), Title("Admin")]
        public IActionResult Settings()
        {
            return View();
        }
    }
}