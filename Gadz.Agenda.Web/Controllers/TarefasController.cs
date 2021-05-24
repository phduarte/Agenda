using Gadz.Agenda.Data;
using Gadz.Agenda.Domain;
using Gadz.Agenda.Web.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Gadz.Agenda.Controllers
{
    public class TarefasController : Controller
    {
        readonly AgendaDbContext _dbContext;

        public TarefasController(AgendaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Breadcrumb("Tarefas")]
        [Title("Tarefas")]
        public IActionResult Index()
        {
            var model = _dbContext.Tarefas;
            ViewBag.Responsaveis = new List<SelectListItem>
            {
                new SelectListItem("Paulo Duarte", "1"),
            };

            return View(model);
        }

        [Breadcrumb("Cadastrar")]
        [Title("Cadastro de tarefas")]
        public IActionResult Cadastrar(int id)
        {
            var model = _dbContext.Tarefas.Find(id);

            ViewBag.Categorias = _dbContext.Categorias.Select(c => new SelectListItem(c.Nome, c.Id.ToString())).ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Cadastrar(Tarefa model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Tarefas.Add(model);
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Categorias = _dbContext.Categorias.Select(c => new SelectListItem(c.Nome, c.Id.ToString())).ToList();

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