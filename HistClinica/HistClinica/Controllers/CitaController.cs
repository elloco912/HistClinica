using HistClinica.Data;
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
        private readonly ClinicaServiceContext _context;
        private readonly ICitaRepository _repository;
        private readonly IUtilRepository _utilrepository;

        public CitaController(ClinicaServiceContext clinicaService,ICitaRepository repository, IUtilRepository utilRepository)
        {
            _repository = repository;
            _context = clinicaService;
            _utilrepository = utilRepository;
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
        public async Task<IActionResult> Create([Bind("idCita,codCita,nroCita,descripcion,fechaCita,ultCie10,servicio,tpAtencion,nroHC,idEstadoCita,idEstaGralPac,estadoReprogram,ejecutado,prioridad,precio,descuento,coa,igv,idPaciente,idEmpleado,idConsultorio,idProgramMedica,idTpAtencion,idEstAtencion")] T068_CITA t068_CITA)
        {
            if (ModelState.IsValid)
            {
                await _repository.InsertCita(t068_CITA);
                return RedirectToAction(nameof(Index));
            }
            return View(t068_CITA);
        }

        // GET: Cita/Edit/5
        public async Task<IActionResult> Edit(int? id)
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

        // POST: Cita/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCita,codCita,nroCita,descripcion,fechaCita,ultCie10,servicio,tpAtencion,nroHC,idEstadoCita,idEstaGralPac,estadoReprogram,ejecutado,prioridad,precio,descuento,coa,igv,idPaciente,idEmpleado,idConsultorio,idProgramMedica,idTpAtencion,idEstAtencion")] T068_CITA t068_CITA)
        {
            if (id != t068_CITA.idCita)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.UpdateCita(t068_CITA);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _repository.CitaExists(t068_CITA.idCita))
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
            return View(t068_CITA);
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

        public async Task<IActionResult> Registro()
        {
            var lespecialidads = new Object();
            lespecialidads = await _utilrepository.GetTipo("Especialidad");
            ViewBag.listaespecialidades = lespecialidads;

            var medico = await _utilrepository.GetMedicos();
            ViewBag.listamedicos = medico;
            return PartialView();
        }
    }
}
