using Gadz.Agenda.DomainModel;
using Gadz.Agenda.Web.Filters;
using Gadz.Agenda.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Gadz.Agenda.Web.Controllers
{
    public class AcessoController : Controller
    {
        private readonly IUsuarioServices _userServices;

        public AcessoController(IUsuarioServices userServices)
        {
            _userServices = userServices;
        }

        [Breadcrumb("Acesso")]
        public IActionResult Index()
        {
            return View();
        }

        [Title("Login")]
        public IActionResult Login()
        {
            var c = new Credencial();
            return View(c);
        }

        [HttpPost]
        public IActionResult Login(Credencial credencial)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AgendaContext())
                {
                    var usuario = db.Usuarios.FirstOrDefault(x => x.Login.Equals(credencial.Login));
                    if (usuario != null)
                    {
                        new DefaultHttpContext().Response.Cookies.Append("userId", usuario.Id.ToString(), new CookieOptions() { Expires = DateTimeOffset.Now.AddDays(1) });
                        return RedirectToAction("index", "home");
                    }
                    else
                        ModelState.AddModelError("", "User not found");
                }
            }

            return View(credencial);
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AlterarSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AlterarSenha(NovaSenhaModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = _userServices.BuscarUsuario(model.Login, model.Senha);

                if (usuario != null)
                {
                    usuario.AlterarSenha(model.Senha);
                    new DefaultHttpContext().Response.Cookies.Append("userId", usuario.Id.ToString(), new CookieOptions() { Expires = DateTimeOffset.Now.AddDays(1) });

                    _userServices.AtualizarUsuario(usuario);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "User not found");
                }
            }

            return View(model);
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }
    }
}