#pragma checksum "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17244574a2f677e941f1584c574e168bf2d5ca3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cita_Registro), @"mvc.1.0.view", @"/Views/Cita/Registro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17244574a2f677e941f1584c574e168bf2d5ca3e", @"/Views/Cita/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cita_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.CitaDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control pr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("idpaciente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-dialog\" role=\"document\">\r\n\t<div class=\"modal-content\" style=\"width: 1200px;position: relative;right: 302px;\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"col-sm-12 pb-2 pt-3\">\r\n\t\t\t\t<h4>Programacion de cita ambulatoria</h4>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml"
             using (Html.BeginForm())
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-sm-12\">\r\n\t\t\t\t\t<div class=\"row pb-3\">\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"form-check form-check-inline\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 14 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml"
                           Write(Html.RadioButtonFor(m => m.tipo, "Consulta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-check form-check-inline\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 17 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml"
                           Write(Html.RadioButtonFor(m => m.tipo, "Procedimiento"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
						<div class=""col-sm-6""></div>
					</div>
					<div class=""row pb-3"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Especialidad</label>
								</div>
								<div class=""col-sm-8"">
									");
#nullable restore
#line 29 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml"
                               Write(Html.DropDownList("especialidad", new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), "Seleccione", new { @class = "form-control",
								   data_cascade_combo = "#medico",
								   data_cascade_combo_source = Url.Action("GetMedicoByEsp", "Cita"),
								   data_cascade_combo_param_name = "id"
							   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Medico</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 43 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml"
                               Write(Html.DropDownList("medico", new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccione", new { @class = "form-control",
								   data_cascade_combo_medico = "#fecate",
								   data_cascade_combo_source_medico = Url.Action("GetCronogramaByMedico", "Cita"),
								   data_cascade_combo_param_name_medico = "id"
							   }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
					<div class=""row pb"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Fecha Atencion</label>
								</div>
								<div class=""col-sm-8"">
									");
#nullable restore
#line 59 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml"
                               Write(Html.DropDownListFor(m => m.idProgramMedica, new SelectList(ViewBag.lcronograma, "idprogramMed", "fecprogram"), "Seleccione", new
									{
										@class = "form-control",
								   data_cascade_combofec = "#hora",
								   data_cascade_combo_sourcefec = Url.Action("GetHorasByCronograma", "Cita"),
								   data_cascade_combo_param_namefec = "id"
							   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Hora</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 75 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml"
                               Write(Html.DropDownList("hora", new SelectList(ViewBag.lhoras, "id", "hora"), "Seleccione", new { @class = "form-control", @id="hora"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
						<div class=""col-sm-4""></div>
					</div>
					<div class=""row pb-3 pt-3"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Dni</label>
								</div>
								<div class=""col-sm-8 form-inline"">
									<input type=""text"" class=""form-control pr-2"" id=""dni"">
									<a onclick=""BuscarPaciente();"" class=""btn btn-primary""><i style=""color:white;"" class=""fas fa-search""></i></a>
								</div>
							</div>
						</div>
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Paciente</label>
								</div>
								<div class=""col-sm-8"">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "17244574a2f677e941f1584c574e168bf2d5ca3e9616", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 99 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.idPaciente);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control pr-2\" id=\"nombrepaciente\"");
            BeginWriteAttribute("name", " name=\"", 3710, "\"", 3717, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"row pt-3 pb-2\">\r\n\t\t\t\t\t\t<div class=\"col-sm-12 text-right\">\r\n\t\t\t\t\t\t\t<button class=\"btn btn-primary\">Registrar</button>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 111 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cita\Registro.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.DTO.CitaDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591