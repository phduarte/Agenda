using Gadz.Staff.Access;
using Gadz.Staff.Agenda.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Gadz.Staff.Agenda.Web.Controllers {
    public class AcessoController : Controller {


        AccessServices accessServices = new AccessServices();

        public IActionResult Index() {
            return View();
        }

        public IActionResult Login() {

            var cookie = new DefaultHttpContext().Request.Cookies["userId"];

            var c = new Usuario();
            return View(c);
        }

        [HttpPost]
        public IActionResult Login(Credencial credencial) {

            var usuario = accessServices.BuscarUsuario(credencial.Login, credencial.Senha);

            if (usuario != null) {

                new DefaultHttpContext().Response.Cookies.Append("userId", usuario.Id.ToString(), new CookieOptions() { Expires = DateTimeOffset.Now.AddDays(1) });

                return RedirectToAction("Index", "Home");
            }

            return View(credencial);
        }

        public IActionResult Logout() {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AlterarSenha() {
            return View();
        }

        public IActionResult RecuperarSenha() {
            return View();
        }
    }
}