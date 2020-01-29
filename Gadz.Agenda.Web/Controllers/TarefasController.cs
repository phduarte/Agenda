using Gadz.Agenda.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Controllers
{
    public class TarefasController : Controller
    {
        [Breadcrumb("Tarefas")]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("Cadastrar")]
        public IActionResult Cadastrar()
        {
            var model = new Gadz.Agenda.Web.Models.TarefaModel();
            return View(model);
        }

        [Breadcrumb("Resumo")]

        public IActionResult Resumo()
        {
            return View();
        }
    }
}