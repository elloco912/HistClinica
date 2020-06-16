using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HistClinica.Models;
using HistClinica.DTO;
using HistClinica.Data;
using HistClinica.Repositories.Interfaces;

namespace HistClinica.Controllers
{
    public class DetalleController : Controller
    {
        IDetalleRepository _detalleRepository;
        public DetalleController(IDetalleRepository detalleRepository)
        {
            _detalleRepository = detalleRepository;
        }
        public async Task<IActionResult> IndexAsync(DetalleDTO oDetalle)
        {
            List<DetalleDTO> listaDetalle = new List<DetalleDTO>();
            if (oDetalle.coddetTab == null || oDetalle.coddetTab == "")
            {
                listaDetalle = await _detalleRepository.GetAllDetalles("");

                ViewBag.nombreDetalle = "";
            }

            else

            {
                ViewBag.nombreEspecialidad = (oDetalle.coddetTab);

                listaDetalle = await _detalleRepository.GetAllDetalles(oDetalle.coddetTab);
            }
            return View(listaDetalle);
        }


        public IActionResult Agregar()
        {

            return View();
        }

        //public IActionResult Editar(int? id)
        //{ //aca te falta
        //    return View();
        //}

        [HttpPost]
        public async Task<IActionResult> AgregarAsync(DetalleDTO oDetalle)
        {
            try
            {

                ////Conexion a BD
                //using (ClinicaServiceContext db = new ClinicaServiceContext())
                //{

                //    if (!ModelState.IsValid)
                //    {
                //        return View(oDetalle);
                //    }
                //    else
                //    {

                //        D00_TBDETALLE objeto = new D00_TBDETALLE();
                //        objeto.coddetTab = oDetalle.coddetTab;
                //        objeto.descripcion = oDetalle.descripcion;
                //        objeto.idTab = 1;
                //        db.D00_TBDETALLE.Add(objeto);
                //        db.SaveChanges();
                //    }

                //}
                await _detalleRepository.InsertDetalle(oDetalle);
            }
            catch (Exception ex)
            {
                return View(oDetalle);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> EliminarAsync(int idDet)
        {



            //using (ClinicaServiceContext db = new ClinicaServiceContext())
            //{
            //    D00_TBDETALLE oDetalle = db.D00_TBDETALLE.Where(p => p.idDet == idDet).First();
            //    db.D00_TBDETALLE.Remove(oDetalle);
            //    db.SaveChanges();




            //}
            await _detalleRepository.DeleteDetalle(idDet);
            return RedirectToAction("Index");



        }


        //[HttpPost] Ya esta . Saludos
        public async Task<IActionResult> EditarAsync(int idDet)
        {
            //todo esto lo deberia tener en el repositorio, aca solo llamar al metodo edit
            // no lo hice asi el agregar tmb esta asi y no hay 
            DetalleDTO oDetalle = new DetalleDTO();
            //using (ClinicaServiceContext db = new ClinicaServiceContext())
            //{
            oDetalle = await _detalleRepository.GetById(idDet);
            //}
            return View(oDetalle);
        }
    }
}



