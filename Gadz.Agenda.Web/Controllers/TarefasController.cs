using Gadz.Agenda.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Controllers
{
    public class TarefasController : Controller
    {
        [Breadcrumb("Tarefas")]
        [Title("Tarefas")]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("Cadastrar")]
        [Title("Cadastro de tarefas")]
        public IActionResult Cadastrar()
        {
            var model = new Gadz.Agenda.Web.Models.TarefaModel();
            return View(model);
        }

        [Breadcrumb("Resumo")]
        [Title("Tarefa")]
        public IActionResult Resumo()
        {
            return View();
        }
    }
}