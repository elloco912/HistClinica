using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HistClinica.Data;
using HistClinica.Models;
using System.IO;
using OfficeOpenXml;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace HistClinica.Controllers
{
    public class PacientesController : Controller
    {
        private readonly ClinicaServiceContext _context;

        public PacientesController(ClinicaServiceContext context)
        {
            _context = context;
        }

        public static List<Paciente> lista;

        //Metodo que nos descargue el archivo->Descargar


        public FileResult exportarExcel()
        {
            string[] cabeceras = { "idtpPaciente", "descripcion", "idAsegurado", "nrohc", "nomAcompana", "edadAcompana", "dniAcompana", "idgpoSangre", "idFactorrh", "idPersona", "idPacConvenio", "estado" };
            string[] nombrePropiedades = { "idtpPaciente", "descripcion", "idAsegurado", "nrohc", "nomAcompana", "edadAcompana", "dniAcompana", "idgpoSangre", "idFactorrh", "idPersona", "idPacConvenio", "estado" };
            byte[] buffer= exportarExcelDatos(cabeceras,nombrePropiedades,lista);
            return File(buffer, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }



        //creando nuestro metodo (que nos genera el array de bytes)->Genera
        public byte[] exportarExcelDatos<T>(string[] cabeceras,string[] nombrePropiedades, List<T> lista)
        {
            using (MemoryStream ms=new MemoryStream())
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage ep=new ExcelPackage()) 
                {
                    ep.Workbook.Worksheets.Add("hoja");

                    ExcelWorksheet ew = ep.Workbook.Worksheets[0];
                    for(int i=0;i < cabeceras.Length; i++)
                    {
                        ew.Cells[1, i + 1].Value = cabeceras[i];
                        ew.Column(i + 1).Width = 50;
                    }
                    int fila = 2;
                    int col = 1;

                    foreach(object item in lista)
                    {
                        col = 1;
                        foreach(string propiedad in nombrePropiedades)
                        {
                            ew.Cells[fila, col].Value =
                                item.GetType().GetProperty(propiedad).GetValue(item).ToString();
                            col++;
                        }
                        fila++;
                    }
                    ep.SaveAs(ms);
                    byte[] buffer = ms.ToArray();

                    return buffer;

                }
            }
        }



        public FileResult exportarPDF()
        {
            string[] cabeceras = { "idtpPaciente", "descripcion", "idAsegurado", "nrohc", "nomAcompana", "edadAcompana", "dniAcompana", "idgpoSangre", "idFactorrh", "idPersona", "idPacConvenio", "estado" };
            string[] nombrePropiedades = { "idtpPaciente", "descripcion", "idAsegurado", "nrohc", "nomAcompana", "edadAcompana", "dniAcompana", "idgpoSangre", "idFactorrh", "idPersona", "idPacConvenio", "estado" };
            byte[] buffer = exportarPDFDatos(cabeceras, nombrePropiedades, lista);
            return File(buffer, "application/pdf");
        }





        public byte[] exportarPDFDatos<T>(string[] cabeceras, string[] nombrePropiedades, List<T> lista)
        {
            using (MemoryStream ms =new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(ms);
                using(var pdfDoc= new PdfDocument(writer))
                {
                    Document doc = new Document(pdfDoc);
                    Paragraph c1 = new Paragraph("HOJA DE FILIACION");
                    c1.SetFontSize(20);
                    c1.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

                    doc.Add(c1);
                    //Creamos la tabla

                    Table table = new Table(nombrePropiedades.Length);
                    Cell celda;
                    for(int i = 0; i <nombrePropiedades.Length; i++)
                    {
                        celda = new Cell();
                        celda.Add(new Paragraph(nombrePropiedades[i]));
                        table.AddHeaderCell(celda);
                    }
                    foreach(object item in lista)
                    {
                        foreach(string propiedad in nombrePropiedades)
                        {
                            celda = new Cell();
                            celda.Add(new Paragraph(item.GetType().GetProperty(propiedad).GetValue(item).ToString()));
                            table.AddCell(celda);
                        }
                    }

                    doc.Add(table);
                    doc.Close();
                    writer.Close();
                }
                return ms.ToArray();
            }

        }

        // GET: Pacientes
        public async Task<IActionResult> Index()
        {

            lista = await _context.Paciente.ToListAsync();
            return View(await _context.Paciente.ToListAsync());
        }

        // GET: Pacientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Paciente
                .FirstOrDefaultAsync(m => m.idPaciente == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // GET: Pacientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idPaciente,idtpPaciente,descripcion,idAsegurado,nrohc,nomAcompana,edadAcompana,dniAcompana,idgpoSangre,idFactorrh,idPersona,idPacConvenio,estado")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paciente);
        }

        // GET: Pacientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Paciente.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idPaciente,idtpPaciente,descripcion,idAsegurado,nrohc,nomAcompana,edadAcompana,dniAcompana,idgpoSangre,idFactorrh,idPersona,idPacConvenio,estado")] Paciente paciente)
        {
            if (id != paciente.idPaciente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.idPaciente))
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

        // GET: Pacientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Paciente
                .FirstOrDefaultAsync(m => m.idPaciente == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paciente = await _context.Paciente.FindAsync(id);
            _context.Paciente.Remove(paciente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteExists(int id)
        {
            return _context.Paciente.Any(e => e.idPaciente == id);
        }
    }
}
