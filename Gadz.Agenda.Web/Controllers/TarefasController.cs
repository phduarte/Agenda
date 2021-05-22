using Gadz.Agenda.Web.Data;
using Gadz.Agenda.Web.Domain;
using Gadz.Agenda.Web.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

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
            //var model = new Gadz.Agenda.Web.Models.TarefaModel();
            var model = _dbContext.Tarefas.Find(id);

            ViewBag.Grupos = new List<SelectListItem>
            {
                new SelectListItem("Trabalho", "1"),
                new SelectListItem("Hobby", "2"),
                new SelectListItem("Casa", "3"),
                new SelectListItem("Viagem", "4"),
                new SelectListItem("Saúde", "5"),
            };

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

            ViewBag.Grupos = new List<SelectListItem>
            {
                new SelectListItem("Trabalho", "1"),
                new SelectListItem("Hobby", "2"),
                new SelectListItem("Casa", "3"),
                new SelectListItem("Viagem", "4"),
                new SelectListItem("Saúde", "5"),
            };

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