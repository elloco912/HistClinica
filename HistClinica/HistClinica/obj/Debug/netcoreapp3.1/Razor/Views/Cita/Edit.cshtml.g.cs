#pragma checksum "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "053c0d3c676129c064050a1fd92f9b4c594efe52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cita_Edit), @"mvc.1.0.view", @"/Views/Cita/Edit.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"053c0d3c676129c064050a1fd92f9b4c594efe52", @"/Views/Cita/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cita_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.CitaDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("desfecha"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deshora"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control pr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("nombrepaciente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""modal-dialog"" role=""document"">
	<div class=""modal-content"" style=""width: 1200px;position: relative;right: 302px;"">
		<div class=""container"">
			<div class=""col-sm-12 pb-2 pt-3 pb-2"">
				<h4>Reprogramacion de cita ambulatoria</h4>
			</div>
");
#nullable restore
#line 8 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
             using (Html.BeginForm(FormMethod.Post, new { @id = "frmeditcita" }))
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-sm-12\">\r\n\t\t\t\t\t<div class=\"row pb-3\">\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Id Cita</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 20 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.HiddenFor(m => m.idCita));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 21 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.EditorFor(m => m.idCita, new { htmlAttributes = new { @class = "form-control", @disabled = "true" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
						<div class=""col-sm-6"">
						</div>
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
#line 35 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), "Seleccione", new
									{
										@class = "form-control",
								   data_cascade_combo = "#medico",
								   data_cascade_combo_source = Url.Action("GetMedicoByEsp", "Cita"),
								   data_cascade_combo_param_name = "id"
							   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Medico</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 51 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.idmedico, new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccione", new
									{
										@class = "form-control",
										@id = "medico",
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
#line 70 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.idProgramMedica, new SelectList(ViewBag.lcronograma, "idprogramMed", "fecprogram"), "Seleccione", new
							   {
								   @class = "form-control",
								   data_cascade_combofec = "#horaate",
								   data_cascade_combo_sourcefec = Url.Action("GetHorasByCronograma", "Cita"),
								   data_cascade_combo_param_namefec = "id",
								   @id = "fecate"
							   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 78 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.ValidationMessageFor(model => model.idProgramMedica, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "053c0d3c676129c064050a1fd92f9b4c594efe5210796", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 80 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.fecha);

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
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Hora</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 89 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.DropDownList("horaate", new SelectList(ViewBag.lhoras, "id", "hora"), "Seleccione", new { @class = "form-control", @id = "horaate" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "053c0d3c676129c064050a1fd92f9b4c594efe5213275", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 91 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.hora);

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
            WriteLiteral(@"
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
									");
#nullable restore
#line 103 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.EditorFor(m => m.dniPaciente, new { htmlAttributes = new { @class = "form-control", @disabled = "true" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 104 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.HiddenFor(m => m.dniPaciente));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Paciente</label>
								</div>
								<div class=""col-sm-8"">
									<input type=""hidden"" class=""form-control pr-2"" id=""idpaciente"">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "053c0d3c676129c064050a1fd92f9b4c594efe5216323", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 115 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.nombrePaciente);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
					<div class=""row pb-3 pt-3"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Servicios</label>
								</div>
								<div class=""col-sm-8 form-inline"">
									");
#nullable restore
#line 127 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.DropDownListFor(m => m.idServicioCli, new SelectList(ViewBag.servicios, "idtab", "descripcion"), "Seleccione", new { @class = "form-control", @disabled="true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
						<div class=""col-sm-6"">

						</div>
					</div>
					<div class=""row pt-3"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Motivo</label>
								</div>
								<div class=""col-sm-8 form-inline"">
									");
#nullable restore
#line 142 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
                               Write(Html.TextAreaFor(m => m.motivoreprogramacion, new { @class = "form-control", @style = "width:365px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
						<div class=""col-sm-6"">

						</div>
					</div>
					<div class=""row pt-3 pb-2"">
						<div class=""col-sm-12 text-right"">
							<button class=""btn btn-primary"">Registrar</button>
						</div>
					</div>
				</div>
");
#nullable restore
#line 156 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Cita\Edit.cshtml"
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
