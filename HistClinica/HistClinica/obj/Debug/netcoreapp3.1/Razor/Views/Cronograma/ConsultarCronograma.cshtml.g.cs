#pragma checksum "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fe1e4e67abb1350ca282df095b60f843d5a9238"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cronograma_ConsultarCronograma), @"mvc.1.0.view", @"/Views/Cronograma/ConsultarCronograma.cshtml")]
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
#line 1 "D:\HistClinica\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HistClinica\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fe1e4e67abb1350ca282df095b60f843d5a9238", @"/Views/Cronograma/ConsultarCronograma.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cronograma_ConsultarCronograma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HistClinica.DTO.CronogramaDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""modal-dialog modal-lg"" role=""document"">
	<div class=""modal-content"">
		<div class=""modal-header"">
			<h2 class=""modal-title text-center"" id=""exampleModalLabel1"">Consultar cronograma</h2>
			<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
		</div>
		<div class=""container"">
			<div class=""col-sm-12 pt-3"">


");
#nullable restore
#line 16 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                 using (Html.BeginForm())
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"row pb-2\">\r\n\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Medico</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 26 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                               Write(Html.DropDownList("idmedico", new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 36 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
				<div class=""row pt-3"">
					<div class=""col-sm-12"">
						<table class=""table table-bordered table-hover text-center"" id=""cronogramagrid"">
							<thead>
								<tr>
									<th>Id</th>
									<th>Fecha</th>
									<th>Hora ini</th>
									<th>Hora fin</th>
									<th>Estado</th>
									<th>Acciones</th>
								</tr>
							</thead>
							<tbody>
");
#nullable restore
#line 52 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                 foreach (var item in Model)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 55 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.idProgramMedica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 56 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.fecProgramMedica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 57 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.hrInicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 58 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.hrFin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 59 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.desEstado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t<button type=\"submit\" class=\"edit btn btn-primary\" onclick=\"Cargarmodal();\"><i class=\"fas fa-edit\"></i></button>\r\n\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 64 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t</table>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HistClinica.DTO.CronogramaDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
