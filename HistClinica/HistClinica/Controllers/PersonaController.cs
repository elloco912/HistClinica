using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ClinicaServiceContext _context;
        private readonly IPersonaRepository _personaRepository;
        private readonly IUtilRepository _utilrepository;

        public PersonaController(IPersonaRepository personaRepository,ClinicaServiceContext contexto,IUtilRepository utilRepository)
        {
            _context = contexto;
            _personaRepository = personaRepository;
            _utilrepository = utilRepository;
        }

        // GET: Persona
        public async Task<IActionResult> Index()
        {
            return View(await _personaRepository.GetAllPersonal());
        }

        // GET: Persona/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _personaRepository.GetById(id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Persona/Create
        public async Task<IActionResult> Create()
        {
            var lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            //combo tipo de empleado
            var tipoEmpleados = await _utilrepository.GetTipo("Tipo Empleado");
            ViewBag.lsttipoempleado = tipoEmpleados;
            return View();
        }

        // POST: Persona/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonaDTO personaDTO)
        {
            if (personaDTO != null)
            {
                await _personaRepository.InsertPersona(personaDTO);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Create");
        }


        // POST: Persona/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        public async Task<IActionResult> Editar(int idpersona)
        {
            var lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            //combo tipo de empleado
            var tipoEmpleados = await _utilrepository.GetTipo("Tipo Empleado");
            ViewBag.lsttipoempleado = tipoEmpleados;

            PersonaDTO persona = await _personaRepository.GetById(idpersona);
            return PartialView("Edit", persona);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PersonaDTO personaDTO)
        {
            if (personaDTO != null)
            {
                try
                {
                    await _personaRepository.UpdatePersona(personaDTO);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await _personaRepository.PersonaExists(personaDTO.idPersona))
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
            return View(personaDTO);
        }

        // GET: Persona/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _personaRepository.GetById(id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Persona/Delete/5
        //  [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _personaRepository.GetById(id);
            await _personaRepository.DeletePersona(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
