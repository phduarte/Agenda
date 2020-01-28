using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Controllers
{
    public class TarefasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            var model = new Gadz.Agenda.Web.Models.TarefaModel();
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
    }
}