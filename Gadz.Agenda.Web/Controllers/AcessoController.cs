﻿using Gadz.Agenda.Access;
using Gadz.Agenda.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Gadz.Agenda.Web.Controllers
{
    public class AcessoController : Controller
    {
        private readonly IAccessServices _accessServices;

        public AcessoController(IAccessServices accessServices)
        {
            _accessServices = accessServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            var c = new Credencial();
            return View(c);
        }

        [HttpPost]
        public IActionResult Login(Credencial credencial)
        {
            var usuario = _accessServices.BuscarUsuario(credencial.Login, credencial.Senha);

            if (usuario != null)
            {
                new DefaultHttpContext().Response.Cookies.Append("userId", usuario.Id.ToString(), new CookieOptions() { Expires = DateTimeOffset.Now.AddDays(1) });

                return RedirectToAction("Index", "Home");
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
                var usuario = _accessServices.BuscarUsuario(model.Login, model.Senha);

                if (usuario != null)
                {
                    usuario.ResetPassword(model.Senha);
                    new DefaultHttpContext().Response.Cookies.Append("userId", usuario.Id.ToString(), new CookieOptions() { Expires = DateTimeOffset.Now.AddDays(1) });

                    _accessServices.AtualizarUsuario(usuario);

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