#pragma checksum "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5e3f06f9206869c94a97c493c83abe798e112ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Edit), @"mvc.1.0.view", @"/Views/Persona/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e3f06f9206869c94a97c493c83abe798e112ca", @"/Views/Persona/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.PersonaDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-dialog modal-lg"" role=""document"">
	<div class=""modal-content"">
		<button style=""text-align:right"" type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
		<div class=""container"">
			<div class=""col-sm-12 text-center"">
				<h4 class=""modal-title"" id=""myModalLabel"">Actualizar registro</h4>
			</div>
			<div class=""col-sm-12 pt-4"">
");
#nullable restore
#line 10 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                 using (Html.BeginForm("Edit", "Persona"))
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t\t\t<div class=\"box box-primary\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 15 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                           Write(Html.HiddenFor(m => m.idPersona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 16 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                           Write(Html.HiddenFor(m => m.personal.idMedico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 17 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                           Write(Html.HiddenFor(m => m.personal.idEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<div class=\"box-body\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>TIPO DE EMPLEADO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 23 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.DropDownListFor(m => m.personal.idTipoEmpleado, new SelectList(ViewBag.lsttipoempleado, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtNombres\">PRIMER NOMBRE</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 29 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.primerNombre, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtNombres\">SEGUNDO NOMBRE</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 35 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.segundoNombre, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtNroDocumento\">DOCUMENTO DE IDENTIDAD</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 41 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.numeroDocumento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtNroColegio\">N° DE COLEGIO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 47 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.numeroColegio, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtruc\">N° DE RUC</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 53 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.ruc, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtespecialidad\">ESPECIALIDAD</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 59 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.DropDownListFor(m => m.personal.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									</div>
								</div>
							</div>
						</div>
						<div class=""col-md-6"">
							<div class=""box box-primary"">
								<div class=""box-body"">
									<div class=""form-group"">
										<label for=""txtarea"">AREA</label>
									</div>
									<div class=""form-group"">
										");
#nullable restore
#line 71 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.area, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtApPaterno\">APELLIDO PATERNO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 77 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.apellidoPaterno, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtApPaterno\">APELLIDO MATERNO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 83 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.apellidoMaterno, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label id=\"txtfecingresopersonal\">FECHA INGRESO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 89 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.fechaIngreso, new { htmlAttributes = new { @class = "form-control", @type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtcargo\">CARGO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 95 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.cargo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtTelefono\">TELÉFONO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 101 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.telefono, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""row m-0 p-0 pb-2"">
						<div class=""col-sm-12 text-right"">
							<input type=""submit"" class=""btn btn-primary"" style=""width: 112px;font-size: 16px;"" value=""Guardar"">
						</div>
					</div>
");
#nullable restore
#line 112 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.DTO.PersonaDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
