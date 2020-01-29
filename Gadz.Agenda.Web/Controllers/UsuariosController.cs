using Gadz.Agenda.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Web.Controllers
{
    public class UsuariosController : Controller
    {
        [Breadcrumb("Usuários")]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("Cadastrar")]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost, Breadcrumb("Pesquisar")]
        public IActionResult Pesquisar(string criterio)
        {
            return View();
        }
    }
}
