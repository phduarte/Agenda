using Gadz.Agenda.Web.Filters;
using Gadz.Agenda.Domain;
using Gadz.Agenda.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Gadz.Agenda.Web.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AgendaDbContext _dbContext;

        public UsuariosController(AgendaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Breadcrumb("Usuários"), Title("Usuários")]
        public IActionResult Index()
        {
            var model = _dbContext.Usuarios;
            return View(model);
        }

        [Breadcrumb("Cadastrar"), Title("Cadastro de usuários")]
        public IActionResult Cadastrar(int id)
        {
            var model = _dbContext.Usuarios.Find(id);
            return View(model);
        }

        [Breadcrumb("Cadastrar"), Title("Cadastro de usuários")]
        [HttpPost]
        public IActionResult Cadastrar(Usuario model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Usuarios.Add(model);
                _dbContext.SaveChanges();

                return RedirectToAction("index");
            }

            return View(model);
        }

        [Breadcrumb("Cadastrar"), Title("Cadastro de usuários")]
        public IActionResult Editar(int id)
        {
            var model = _dbContext.Usuarios.Find(id);
            return View("Cadastrar", model);
        }

        [Breadcrumb("Cadastrar"), Title("Cadastro de usuários")]
        [HttpPost]
        public IActionResult Editar(Usuario model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Usuarios.Update(model);
                _dbContext.SaveChanges();

                return RedirectToAction("index");
            }

            return View("Cadastrar", model);
        }

        [HttpPost, Breadcrumb("Pesquisar")]
        public IActionResult Pesquisar(string criterio)
        {
            var model = _dbContext.Usuarios.Where(x => x.Nome.ToLower().Contains(criterio.ToLower()));

            return View("index", model);
        }
    }
}
