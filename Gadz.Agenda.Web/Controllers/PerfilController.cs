using Gadz.Agenda.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Web.Controllers
{
    public class PerfilController : Controller
    {
        [Title("Perfil")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
