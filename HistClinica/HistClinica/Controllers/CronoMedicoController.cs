using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HistClinica.Data;
using HistClinica.Models;
namespace HistClinica.Controllers
{
    //[Route("event") ]
    public class CronoMedicoController : Controller
    {
        private ClinicaServiceContext db;

        public CronoMedicoController(ClinicaServiceContext _db)
        {
            db = _db;
        }
        //[Route("")]
        //[Route("~/")]
        //[Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("findall")]

        public IActionResult GetEvents()
        {
            var events = db.D012_CRONOMEDICO.Select(e => new 
            {
                id = e.idProgramMedica,
                mes = e.mes,
                semana = e.semana,
                dia = e.dia,
                fecha = e.fecProgramMedica,
                idmedico = e.idMedico,
                idespecialidad = e.idEspecialidad,
                idconsultorio = e.idConsultorio,
                horhrInicio=e.hrInicio,
                hrFin=e.hrFin,
                estado = e.idEstado,

            }).ToList();

            return new JsonResult(events);
        }

        [HttpPost]
        public IActionResult SaveEvent(D012_CRONOMEDICO e)
        {
            var status = false;
            
                if (e.idProgramMedica > 0)
                {
                    //Update the event
                    var v = db.D012_CRONOMEDICO.Where(a => a.idProgramMedica == e.idProgramMedica).FirstOrDefault();
                    if (v != null)
                    {
                        v.mes = e.mes;
                        v.semana = e.semana;
                        v.dia = e.dia;
                        v.fecProgramMedica = e.fecProgramMedica;
                        v.idMedico = e.idMedico;
                        v.idEspecialidad = e.idEspecialidad;
                        v.idConsultorio = e.idConsultorio;
                        v.hrInicio = e.hrInicio;
                        v.hrFin = e.hrFin;
                        v.idEstado = e.idEstado;

                }
            }
                else
                {
                    db.D012_CRONOMEDICO.Add(e);
                }

                db.SaveChanges();
                status = true;

            return new JsonResult(status);
        }

        [HttpPost]
        public IActionResult DeleteEvent(int eventID)
        {
            var status = false;
            
                var v = db.D012_CRONOMEDICO.Where(a => a.idProgramMedica == eventID).FirstOrDefault();
                if (v != null)
                {
                    db.D012_CRONOMEDICO.Remove(v);
                    db.SaveChanges();
                    status = true;
                }
            
            return new JsonResult(status);
        }
    }
}