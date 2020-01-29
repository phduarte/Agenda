using Gadz.Agenda.Web.Filters;
using Gadz.Agenda.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Controllers
{
    public class AgendaController : Controller
    {
        [Breadcrumb("Agenda")]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("Cadastrar")]

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(AgendamentoModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("index");
            }

            return View(model);
        }

        [Breadcrumb("Resumo")]
        public IActionResult Resumo()
        {
            return View();
        }

        [Breadcrumb("Tratamento")]
        public IActionResult Tratamento()
        {
            return View();
        }
    }
}