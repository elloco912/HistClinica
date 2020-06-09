﻿using HistClinica.Data;
using HistClinica.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HistClinica.Controllers
{
    public class LoginController : Controller
    {
        private readonly ClinicaServiceContext _context;

        public LoginController(ClinicaServiceContext contexto)
        {
            _context = contexto;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(D001_USUARIO usu)
        {
            var user = _context.D001_USUARIO.Where(u => u.loginUser.Equals(usu.loginUser) && u.claveUser.Equals(usu.claveUser)).FirstOrDefault();
            if (user != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}