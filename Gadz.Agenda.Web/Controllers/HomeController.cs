using Gadz.Agenda.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Web.Controllers
{
    public class HomeController : Controller
    {
        [Breadcrumb("Bem vindo ao Agenda")]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("Versões")]
        public IActionResult Versoes()
        {
            return View();
        }
    }
}