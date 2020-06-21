using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HistClinica.Models;
using HistClinica.DTO;
using HistClinica.Data;
using HistClinica.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HistClinica.Controllers
{
    public class DetalleController : Controller
    {
        IDetalleRepository _detalleRepository;
        public DetalleController(IDetalleRepository detalleRepository)
        {
            _detalleRepository = detalleRepository;
        }
        // GET: Detalle
        public async Task<IActionResult> Index(D00_TBDETALLE oDetalle)
        {
            List<D00_TBDETALLE> listaDetalle = new List<D00_TBDETALLE>();
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

        // GET: Detalle/Detalles/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d00_TBDETALLE = await _detalleRepository.GetById(id);
            if (d00_TBDETALLE == null)
            {
                return NotFound();
            }

            return View(d00_TBDETALLE);
        }

        // GET: Detalle/Agregar
        public IActionResult Agregar()
        {

            return View();
        }

        // POST: Detalle/Agregar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar(D00_TBDETALLE oDetalle)
        {
            try
            {
                await _detalleRepository.InsertDetalle(oDetalle);
            }
            catch (Exception ex)
            {
                return View(oDetalle);
            }

            return RedirectToAction("Index");
        }

        // GET: Detalle/Editar/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d00_TBDETALLE = await _detalleRepository.GetById(id);
            if (d00_TBDETALLE == null)
            {
                return NotFound();
            }
            return View(d00_TBDETALLE);
        }

        // POST: Detalle/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(D00_TBDETALLE d00_TBDETALLE)
        {
            if (d00_TBDETALLE.idDet != 0)
            {
                try
                {
                    await _detalleRepository.UpdateDetalle(d00_TBDETALLE);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _detalleRepository.DetalleExists(d00_TBDETALLE.idDet))
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
            return View(d00_TBDETALLE);
        }

        // GET: Detalle/Eliminar/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d00_TBDETALLE = await _detalleRepository.GetById(id);
            if (d00_TBDETALLE == null)
            {
                return NotFound();
            }

            return View(d00_TBDETALLE);
        }

        // POST: Detalle/Eliminar/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Eliminar(D00_TBDETALLE d00_TBDETALLE)
        {
            await _detalleRepository.DeleteDetalle(d00_TBDETALLE.idDet);
            return RedirectToAction(nameof(Index));
        }
    }
}



