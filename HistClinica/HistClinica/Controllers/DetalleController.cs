using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
//using HistClinica.Clases;
using HistClinica.Models;
using HistClinica.Data;
=======
using HistClinica.Models;
using HistClinica.DTO;
using HistClinica.Data;
using HistClinica.Repositories.Interfaces;
>>>>>>> master

namespace HistClinica.Controllers
{
    public class DetalleController : Controller
    {
<<<<<<< HEAD
        public IActionResult Index(D00_TBDETALLE oDetalle)
        {
            List<D00_TBDETALLE> listaDetalle = new List<D00_TBDETALLE>();
            using (ClinicaServiceContext db = new ClinicaServiceContext())

            {
                if (oDetalle.coddetTab == null || oDetalle.coddetTab == "")
                {
                    listaDetalle = (from detalle in db.D00_TBDETALLE
                                    where detalle.idTab == 1
                                         select new D00_TBDETALLE
                                         {
                                             idDet = detalle.idDet,
                                             coddetTab = detalle.coddetTab,
                                             descripcion = detalle.descripcion,
                                         }).ToList();

                    ViewBag.nombreDetalle = "";
                }

                else

                {
                    listaDetalle = (from detalle in db.D00_TBDETALLE
                                    where detalle.idTab == 1
                                         && detalle.coddetTab.Contains(oDetalle.coddetTab)
                                         select new D00_TBDETALLE
                                         {
                                             idDet = detalle.idDet,
                                             coddetTab = detalle.coddetTab,
                                             descripcion = detalle.descripcion,
                                         }).ToList();
                    ViewBag.nombreEspecialidad = (oDetalle.coddetTab);
                }
            }
            return View(listaDetalle);
=======
        IDetalleRepository _detalleRepository;
        public DetalleController(IDetalleRepository detalleRepository)
        {
            _detalleRepository = detalleRepository;
        }
        public async Task<IActionResult> IndexAsync(DetalleDTO oDetalle)
        {
            //List<DetalleDTO> listaDetalle = new List<DetalleDTO>();
            //using (ClinicaServiceContext db = new ClinicaServiceContext())

            //{
            //    if (oDetalle.coddetTab == null || oDetalle.coddetTab == "")
            //    {
            //        listaDetalle = (from detalle in db.D00_TBDETALLE
            //                        where detalle.idTab == 1
            //                             select new DetalleDTO
            //                             {
            //                                 idDet = detalle.idDet,
            //                                 coddetTab = detalle.coddetTab,
            //                                 descripcion = detalle.descripcion,
            //                             }).ToList();

            //        ViewBag.nombreDetalle = "";
            //    }

            //    else

            //    {
            //        listaDetalle = (from detalle in db.D00_TBDETALLE
            //                        where detalle.idTab == 1
            //                             && detalle.coddetTab.Contains(oDetalle.coddetTab)
            //                             select new DetalleDTO
            //                             {
            //                                 idDet = detalle.idDet,
            //                                 coddetTab = detalle.coddetTab,
            //                                 descripcion = detalle.descripcion,
            //                             }).ToList();
            //        ViewBag.nombreEspecialidad = (oDetalle.coddetTab);
            //    }
            //}
            return View(await _detalleRepository.GetAllDetalles());
>>>>>>> master
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
<<<<<<< HEAD
        public IActionResult Agregar(D00_TBDETALLE oDetalle)
=======
        public async Task<IActionResult> AgregarAsync(DetalleDTO oDetalle)
>>>>>>> master
        {
            try
            {

<<<<<<< HEAD
                //Conexion a BD
                using (ClinicaServiceContext db = new ClinicaServiceContext())
                {

                    if (!ModelState.IsValid)
                    {
                        return View(oDetalle);
                    }
                    else
                    {

                        D00_TBDETALLE objeto = new D00_TBDETALLE();
                        objeto.coddetTab = oDetalle.coddetTab;
                        objeto.descripcion = oDetalle.descripcion;
                        objeto.idTab = 1;
                        db.D00_TBDETALLE.Add(objeto);
                        db.SaveChanges();
                    }

                }
=======
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
>>>>>>> master
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

<<<<<<< HEAD
            
                using (ClinicaServiceContext db = new ClinicaServiceContext())
                {
                D00_TBDETALLE oDetalle = db.D00_TBDETALLE.Where(p => p.idDet == idDet).First();
                    db.D00_TBDETALLE.Remove(oDetalle);
                    db.SaveChanges();
                    
=======
>>>>>>> master


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
<<<<<<< HEAD
        public IActionResult Editar(int idDet)
        {
            //todo esto lo deberia tener en el repositorio, aca solo llamar al metodo edit
            // no lo hice asi el agregar tmb esta asi y no hay 
            D00_TBDETALLE oDetalle = new D00_TBDETALLE();
            using (ClinicaServiceContext db = new ClinicaServiceContext())
            {
                oDetalle = (from detalle in db.D00_TBDETALLE
                            where detalle.idDet == idDet
                            select new D00_TBDETALLE
                            {
                                idDet = detalle.idDet,
                                coddetTab = detalle.coddetTab,
                                descripcion = detalle.descripcion
                            }).First();
            }
=======
        public async Task<IActionResult> EditarAsync(int idDet)
        {    
            //todo esto lo deberia tener en el repositorio, aca solo llamar al metodo edit
            // no lo hice asi el agregar tmb esta asi y no hay 
            DetalleDTO oDetalle = new DetalleDTO();
            //using (ClinicaServiceContext db = new ClinicaServiceContext())
            //{
            oDetalle = await _detalleRepository.GetById(idDet);
            //}
>>>>>>> master
            return View(oDetalle);
        }
    }
}



