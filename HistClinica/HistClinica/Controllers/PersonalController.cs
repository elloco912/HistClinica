using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistClinica.Data;
using HistClinica.Models;
using Microsoft.AspNetCore.Mvc;

namespace HistClinica.Controllers
{
    public class PersonalController : Controller
    {
        private readonly ClinicaServiceContext _context;
        public PersonalController(ClinicaServiceContext contexto)
        {
            _context = contexto;
        }
        public IActionResult Index()
        {
            //combo especialidades
            return View();
        }

        public IActionResult Create()
        {
            //combo especialidades
            List<Especialidad> lespecialidads = new List<Especialidad>();
            lespecialidads = _context.Especialidad.ToList();
            ViewBag.listaespecialidades = lespecialidads;

            //combo tipo de empleado
            List<TipoEmpleado> tipoEmpleados = new List<TipoEmpleado>();
            tipoEmpleados = _context.TipoEmpleado.ToList();
            ViewBag.lsttipoempleado = tipoEmpleados;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medico medico)
        {
            return View();
        }
    }
}