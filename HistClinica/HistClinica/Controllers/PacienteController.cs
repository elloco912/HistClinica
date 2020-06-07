using System;
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

        public PacienteController(IPersonaRepository personaRepository, IPacienteRepository pacienteRepository)
        {
            _personaRepository = personaRepository;
            _pacienteRepository = pacienteRepository;
        }

        //GET: Paciente
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
        public IActionResult Create()
        {
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
