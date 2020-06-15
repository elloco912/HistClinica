using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HistClinica.Clases;
using HistClinica.Models;
namespace HistClinica.Controllers
{
    public class DetalleController : Controller
    {
        public IActionResult Index(Detalle oDetalle)
        {
            List<Detalle> listaDetalle = new List<Detalle>();
            using (ClinicaContext db = new ClinicaContext())

            {
                if (oDetalle.coddetTab == null || oDetalle.coddetTab == "")
                {
                    listaDetalle = (from detalle in db.D00Tbdetalle
                                    where detalle.IdTab == 1
                                         select new Detalle
                                         {
                                             idDet = detalle.IdDet,
                                             coddetTab = detalle.CoddetTab,
                                             descripcion = detalle.Descripcion,
                                         }).ToList();

                    ViewBag.nombreDetalle = "";
                }

                else

                {
                    listaDetalle = (from detalle in db.D00Tbdetalle
                                    where detalle.IdTab == 1
                                         && detalle.CoddetTab.Contains(oDetalle.coddetTab)
                                         select new Detalle
                                         {
                                             idDet = detalle.IdDet,
                                             coddetTab = detalle.CoddetTab,
                                             descripcion = detalle.Descripcion,
                                         }).ToList();
                    ViewBag.nombreEspecialidad = (oDetalle.coddetTab);
                }
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
        public IActionResult Agregar(Detalle oDetalle)
        {
            try
            {

                //Conexion a BD
                using (ClinicaContext db = new ClinicaContext())
                {

                    if (!ModelState.IsValid)
                    {
                        return View(oDetalle);
                    }
                    else
                    {

                        D00Tbdetalle objeto = new D00Tbdetalle();
                        objeto.CoddetTab = oDetalle.coddetTab;
                        objeto.Descripcion = oDetalle.descripcion;
                        objeto.IdTab = 1;
                        db.D00Tbdetalle.Add(objeto);
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex)
            {
                return View(oDetalle);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Eliminar(int idDet)
        {
            

            
                using (ClinicaContext db = new ClinicaContext())
                {
                    D00Tbdetalle oDetalle = db.D00Tbdetalle.Where(p => p.IdDet == idDet).First();
                    db.D00Tbdetalle.Remove(oDetalle);
                    db.SaveChanges();
                    



                }
                return RedirectToAction("Index");


           
        }


        //[HttpPost] Ya esta . Saludos
        public IActionResult Editar(int idDet)
        {    
            //todo esto lo deberia tener en el repositorio, aca solo llamar al metodo edit
            // no lo hice asi el agregar tmb esta asi y no hay 
            Detalle oDetalle = new Detalle();
            using (ClinicaContext db = new ClinicaContext())
            {
                oDetalle = (from detalle in db.D00Tbdetalle
                            where detalle.IdDet == idDet
                            select new Detalle
                            {
                                idDet = detalle.IdDet,
                                coddetTab = detalle.CoddetTab,
                                descripcion = detalle.Descripcion
                            }).First();
            }
            return View(oDetalle);
        }

       
        
    }
}



