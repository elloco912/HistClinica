﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HistClinica.Data;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using HistClinica.DTO;

namespace HistClinica.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IUtilRepository _utilrepository;

        public PacienteController(IPersonaRepository personaRepository, IPacienteRepository pacienteRepository,IUtilRepository utilrepository)
        {
            _personaRepository = personaRepository;
            _pacienteRepository = pacienteRepository;
            _utilrepository = utilrepository;
        }

       // GET: Paciente
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _pacienteRepository.GetAllPacientes());
        //}

        public IActionResult Index()
        {
            return View();
        }

        // GET: Paciente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _pacienteRepository.GetByDni(id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // GET: Paciente/Create
        public async Task<IActionResult> Create()
        {
            var lsttipsexo = new Object();
            lsttipsexo = await _utilrepository.GetTipo("sexo");
            ViewBag.lssexo = lsttipsexo;

            var lsgrdinstruccion = new Object();
            lsgrdinstruccion = await _utilrepository.GetTipo("grado instruccion");
            ViewBag.lgrdinst = lsgrdinstruccion;

            var ocupacion = new Object();
            ocupacion = await _utilrepository.GetTipo("Ocupacion");
            ViewBag.locupacion = ocupacion;

            var gruposangre = new Object();
            gruposangre = await _utilrepository.GetTipo("Grupo Sangre");
            ViewBag.lgpsangre = gruposangre;

            var factrh = new Object();
            factrh = await _utilrepository.GetTipo("Factor RH");
            ViewBag.lfh = factrh;

            var parentesco = new Object();
            parentesco = await _utilrepository.GetTipo("Parentesco");
            ViewBag.lparentesco = parentesco;

            var tipovia = new Object();
            tipovia = await _utilrepository.GetTipo("Tipo Via");
            ViewBag.ltipovia = tipovia;

            var tippac = new Object();
            tippac = await _utilrepository.GetTipo("Tipo Paciente");
            ViewBag.ltippac = tippac;

            var estadocivil = new Object();
            estadocivil = await _utilrepository.GetTipo("Estado Civil");
            ViewBag.lestcivil = estadocivil;

            var tipdoc = new Object();
            tipdoc = await _utilrepository.GetTipo("Tipo Documento");
            ViewBag.ltipdoc = tipdoc;

            return View();
        }

        // POST: Paciente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonaDTO persona)
        {
            if (ModelState.IsValid)
            {
                await _personaRepository.InsertPersona(persona);
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Paciente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _pacienteRepository.GetByDni(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        // POST: Paciente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PersonaDTO paciente)
        {
            if (id != paciente.idPaciente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _personaRepository.UpdatePersona(paciente);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!(await _pacienteRepository.PacienteExists(paciente.idPaciente)))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }

        // GET: Paciente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _pacienteRepository.GetByDni(id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: Paciente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paciente = await _pacienteRepository.GetByDni(id);
            await _pacienteRepository.DeletePaciente(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
