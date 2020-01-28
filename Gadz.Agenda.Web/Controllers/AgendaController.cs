using Gadz.Agenda.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

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

        public IActionResult Pesquisar()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }

        public IActionResult Tratamento()
        {
            return View();
        }
    }
}