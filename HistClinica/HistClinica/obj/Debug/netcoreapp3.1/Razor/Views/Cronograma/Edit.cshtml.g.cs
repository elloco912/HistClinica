#pragma checksum "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d22cf4747fdd080012cef1421c3685981835bad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cronograma_Edit), @"mvc.1.0.view", @"/Views/Cronograma/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d22cf4747fdd080012cef1421c3685981835bad", @"/Views/Cronograma/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cronograma_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.D012_CRONOMEDICO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-dialog modal-lg"" role=""document"">
	<div class=""modal-content"">
		<div class=""modal-header"">
			<h5 class=""modal-title text-center"" id=""exampleModalLabel"">Actualizar cronograma</h5>
			<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
		</div>
");
#nullable restore
#line 10 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
         using (Html.BeginForm("Edit", "Cronograma"))
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"modal-body\">\r\n\t\t\t\t<div class=\"col-sm-12\">\r\n\t\t\t\t\t<div class=\"row pb-2\">\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 16 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
                       Write(Html.HiddenFor(m => m.idProgramMedica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Medico</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 23 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.idMedico, new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Especialidad</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 33 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
					<div class=""row pb-2"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Fecha Inicio</label>
								</div>
								<div class=""col-sm-8"">

									");
#nullable restore
#line 46 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
                               Write(Html.EditorFor(m => m.fechaIni, new { htmlAttributes = new { @class = "form-control", @type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Fecha Fin</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 57 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
                               Write(Html.EditorFor(m => m.fechaFin, new { htmlAttributes = new { @class = "form-control", @type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
					<div class=""row pb-2"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Hora Inicio</label>
								</div>
								<div class=""col-sm-8"">
									");
#nullable restore
#line 69 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.hrInicio, new SelectList(ViewBag.listahoras), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Hora Fin</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 79 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.hrFin, new SelectList(ViewBag.listahoras), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
					<div class=""row pb-2"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Estado</label>
								</div>
								<div class=""col-sm-8"">
									");
#nullable restore
#line 91 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.idEstado, new SelectList(ViewBag.lestado, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Consultorio</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 101 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.idConsultorio, new SelectList(ViewBag.listaconsultorio, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class=""modal-footer"">
					<button style=""width: 80px;"" type=""submit"" class=""btn btn-primary"">Guardar</button>
					<button style=""width: 80px;"" type=""submit"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
				</div>
			</div>
");
#nullable restore
#line 112 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Edit.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.D012_CRONOMEDICO> Html { get; private set; }
    }
}
#pragma warning restore 1591
