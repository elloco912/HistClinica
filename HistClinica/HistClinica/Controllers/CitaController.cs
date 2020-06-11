using HistClinica.Data;
using HistClinica.DTO;
using HistClinica.Models;
using HistClinica.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace HistClinica.Controllers
{
    public class CitaController : Controller
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly ClinicaServiceContext _context;
        private readonly ICitaRepository _repository;
        private readonly IUtilRepository _utilrepository;

        public CitaController(ClinicaServiceContext clinicaService,ICitaRepository repository, IUtilRepository utilRepository, IPacienteRepository pacienterepository)
        {
            _repository = repository;
            _context = clinicaService;
            _utilrepository = utilRepository;
            _pacienteRepository = pacienterepository;
        }

        // GET: Cita
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetAllCitas());
        }

        // GET: Cita/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t068_CITA = await _repository.GetById(id);
            if (t068_CITA == null)
            {
                return NotFound();
            }

            return View(t068_CITA);
        }

        // GET: Cita/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cita/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CitaDTO Cita)
        {
            if (Cita != null)
            {
                await _repository.InsertCita(Cita);
                return RedirectToAction(nameof(Index));
            }
            return View(Cita);
        }

        // GET: Cita/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lespecialidads = new Object();
            lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;

            var lcronograma = await _utilrepository.GetCronograma();
            ViewBag.lcronograma = lcronograma;

            var lhoras = await _utilrepository.GetHoras();
            ViewBag.lhoras = lhoras;

            var lestado = await _utilrepository.getEstadoCita();
            ViewBag.lestado = lestado;

            var t068_CITA = await _repository.GetById(id);
            if (t068_CITA == null)
            {
                return NotFound();
            }
            return PartialView(t068_CITA);

        }

        // POST: Cita/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,int? CronoMedicoID)
        {
            if (id != 0)
            {
                try
                {
                    await _repository.ReprogramarCita(id, CronoMedicoID);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _repository.CitaExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index","Paciente");
            }
            return View();
        }

        // GET: Cita/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t068_CITA = await _repository.GetById(id);
            if (t068_CITA == null)
            {
                return NotFound();
            }

            return View(t068_CITA);
        }

        // POST: Cita/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.DeleteCita(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<JsonResult> GetMedicoByEsp(int id)
        {
            var medico = await _utilrepository.GetMedicoByEspecialidad(id);
            return Json(medico);
        }

        public async Task<JsonResult> GetCronogramaByMedico(int id)
        {
            var cronograma = await _utilrepository.GetCronogramaByMedico(id);
            return Json(cronograma);
        }

        public async Task<JsonResult> GetHorasByCronograma(int id)
        {
            var horas = await _utilrepository.GetHorasByCronograma(id);
            return Json(horas);
        }

        public async Task<IActionResult> Registro()
        {
            var lespecialidads = new Object();
            lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;

            var lcronograma = await _utilrepository.GetCronograma();
            ViewBag.lcronograma = lcronograma;

            var lhoras = await _utilrepository.GetHoras();
            ViewBag.lhoras = lhoras;
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> Registro(CitaDTO cita)
        {
            if (cita != null)
            {
                await _repository.InsertCita(cita);
                return RedirectToAction("Index","Paciente");
            }
            return View(cita);
        }

        public async Task<JsonResult> BuscarDni(int dni)
        {
            var personaDTO = await _pacienteRepository.GetByDni(dni);
            return Json(personaDTO);
        }


        public async Task<IActionResult> AnularCita(int id)
        {
            return View();
        }
        public async Task<IActionResult> AnularCita(int? id)
        {
            await _repository.AnularCita(id);
            return RedirectToAction("Index", "Paciente");
        }

    }
}
