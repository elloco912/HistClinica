#pragma checksum "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a593fa8f7248cd2044a96eca6a824b846cb59682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Create), @"mvc.1.0.view", @"/Views/Persona/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a593fa8f7248cd2044a96eca6a824b846cb59682", @"/Views/Persona/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.PersonaDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
  
	ViewBag.Title = "Registro";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	<div class=""container"">
		<div class=""col-sm-12"">
			<div class=""row"">
				<div class=""col-sm-12 pb-2"">
					<div class=""card card-primary"">
						<div class=""card-header"">
							<h2>Registro de personal</h2>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div class=""col-sm-12"">
");
#nullable restore
#line 21 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
             using (Html.BeginForm())
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t\t<div class=\"box box-primary\">\r\n\t\t\t\t\t\t\t<div class=\"box-body\">\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label>TIPO DE EMPLEADO</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 31 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.DropDownListFor(m => m.idTipoEmpleado, new SelectList(ViewBag.lsttipoempleado, "idTipoEmpleado", "Descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"txtNombres\">NOMBRES</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 37 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.nombres, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"txtNroDocumento\">DOCUMENTO DE IDENTIDAD</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 43 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.dni, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"txtNroColegio\">N° DE COLEGIO</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 49 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.numeroColegio, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"txtruc\">N° DE RUC</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 55 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.ruc, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"txtespecialidad\">ESPECIALIDAD</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 61 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.DropDownListFor(m => m.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idEspecialidad", "descripcion"), new { @class = "form-control" }));

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
#line 73 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.area, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"txtApPaterno\">APELLIDOS</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 79 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.apellidos, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label id=\"txtfecingresopersonal\">FECHA INGRESO</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 85 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.fechaIngreso, new { @class = "form-control", @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"txtcargo\">CARGO</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 91 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.cargo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t<label for=\"txtTelefono\">TELÉFONO</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 97 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                               Write(Html.TextBoxFor(m => m.telefono, new { @class = "form-control" }));

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
#line 108 "D:\HistClinica\HistClinica\HistClinica\Views\Persona\Create.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n");
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
