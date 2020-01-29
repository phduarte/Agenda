using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Web.Controllers
{
    public class UsuariosController : Controller
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
        public IActionResult Pesquisar(string criterio)
        {
            return View();
        }
    }
}
