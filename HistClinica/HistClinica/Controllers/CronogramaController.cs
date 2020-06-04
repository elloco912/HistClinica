using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HistClinica.Data;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HistClinica.Controllers
{
    public class CronogramaController : Controller
    {
        private readonly ClinicaServiceContext _context;
        private readonly ICronogramaRepository cronogramaRepository;

        public CronogramaController(ClinicaServiceContext clinicaService, ICronogramaRepository cronograma)
        {
            _context = clinicaService;
            cronogramaRepository = cronograma;
        }
        public async Task<IActionResult> Index()
        {
            //combo horas
            string[] horas = new string[] { "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "24:00" };

            //combo consultorios
            List<Consultorio> lconsultorio = new List<Consultorio>();
            lconsultorio = _context.Consultorio.ToList();
            ViewBag.listaconsultorio = lconsultorio;

            //combo especialidades
            List<Especialidad> lespecialidads = new List<Especialidad>();
            lespecialidads = _context.Especialidad.ToList();
            ViewBag.listaespecialidades = lespecialidads;

            //combo medicos
            List<Medico> medicos = new List<Medico>();
            medicos = _context.Medico.ToList();
            ViewBag.listamedicos = medicos;
            ViewBag.listahoras = horas;

            //listar
            List<CronoMedico> cronograma = new List<CronoMedico>();
            cronograma = await cronogramaRepository.GetAllCronogramas();


            return View(cronograma);
        }



        public async Task<IActionResult> Create(CronoMedico cronoMedico)
        {
            if (ModelState.IsValid)
            {
                await cronogramaRepository.InsertCronograma(cronoMedico);
                return RedirectToAction("Index");

            }
            return PartialView();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await cronogramaRepository.DeleteCronograma(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Editar(int id)
        {
            CronoMedico cronoMedico = await cronogramaRepository.GetByIdCrono(id);
            return PartialView("Edit", cronoMedico);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CronoMedico cronoMedico)
        {
            if (ModelState.IsValid)
            {
                await cronogramaRepository.UpdateCronograma(cronoMedico);
                return RedirectToAction("Index");
            }
            return PartialView();
        }
    }
}