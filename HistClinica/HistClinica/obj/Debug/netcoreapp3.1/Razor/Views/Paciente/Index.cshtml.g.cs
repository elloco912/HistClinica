#pragma checksum "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27f46c9e7830a26d975ebe5d30207725dbb07cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paciente_Index), @"mvc.1.0.view", @"/Views/Paciente/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f46c9e7830a26d975ebe5d30207725dbb07cdd", @"/Views/Paciente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Paciente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.PersonaDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "value", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Paciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cargavistaparcial.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/combosaninadoscitas.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
  
	ViewBag.Title = "ProgramarCitaAdmision";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	<div class=""container"">
		<div class=""row"">
			<div class=""col-sm-12 text-center"">
				<div class=""card card-primary"">
					<div class=""card-header"">
						<h1>Admision</h1>
					</div>
				</div>

			</div>
		</div>
		<div class=""row"" style=""padding-top:30px;"">
			<div class=""col-sm-4"">
");
#nullable restore
#line 21 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                 using (Html.BeginForm())
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-sm-3\">\r\n\t\t\t\t\t\t\t<select class=\"form-control\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27f46c9e7830a26d975ebe5d30207725dbb07cdd6731", async() => {
                WriteLiteral("DNI");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
							</select>
						</div>
						<div class=""col-sm-4"">
							<input type=""text"" id=""dni"" name=""dni"" class=""form-control"" />
						</div>
						<div class=""col-sm-5"">
							<button class=""btn btn-info"" type=""submit"" id=""btnBuscar""><i class=""fas fa-search""></i></button>
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27f46c9e7830a26d975ebe5d30207725dbb07cdd8195", async() => {
                WriteLiteral("<i class=\"fas fa-user-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t<button class=\"btn btn-secondary\" type=\"submit\" onclick=\"return getbyID();\"><i class=\"fas fa-edit\"></i></button>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				<!--	<div class=""row"" style=""padding-top: 10px;"">
				<div class=""col-sm-4"">
					<label>Atencion</label>
				</div>
				<div class=""col-sm-8"">
					<select class=""form-control"">
						<option value=""value"">Call center</option>
					</select>
				</div>
			</div>
			<div class=""row"" style=""padding-top: 10px;"">
				<div class=""col-sm-4"">
					<label>Admision</label>
				</div>
				<div class=""col-sm-8"">
					<select class=""form-control"">
						<option value=""value"">Seguro convenio</option>
					</select>
				</div>
			</div>
			<div class=""row"" style=""padding-top: 10px;"">
				<div class=""col-sm-4"">
					<label>Seguro</label>
				</div>
				<div class=""col-sm-8"">
					<select class=""form-control"">
						<option value=""value"">Rimac</option>
					</select>
				</div>
			</div>
			<div class=""row"" style=""padding-top: 10px;"">
				<div class=""col-sm-4"">
					<label>Tarifario</label>
				</div>
				<div class=""col-sm-8"">
					<select class=""form-control"">
						<option value=""v");
            WriteLiteral(@"alue"">Rimac</option>
					</select>
				</div>
			</div>-->
			</div>

			<div class=""col-sm-4"">
				<div class=""card card-light"">
					<div class=""card-header"">
						<div class=""row"">
							<div class=""col-sm-4"">
								<label>Paciente</label>
							</div>
							<div class=""col-sm-8"">
								<label>");
#nullable restore
#line 89 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                  Write(Html.DisplayFor(m => m.apellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 89 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                                                           Write(Html.DisplayFor(m => m.apellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 89 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                                                                                                    Write(Html.DisplayFor(m => m.primerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"row\" style=\"padding-top: 10px;\">\r\n\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t<label>DNI</label>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 99 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.numeroDocumento, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"row\" style=\"padding-top: 10px;\">\r\n\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t<label>Correo</label>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 107 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.correo, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"row\" style=\"padding-top: 10px;\">\r\n\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t<label>Edad</label>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 115 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.edad, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"row\" style=\"padding-top: 10px;\">\r\n\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t<label>Ocupación</label>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 123 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.descripcionOcupacion, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					</div>
				</div>
			</div>
			<div class=""col-sm-4"">

			</div>
		</div>
		<div class=""row"" style=""padding-top: 10px;"">
			<div class=""col-sm-12"">
				<button style=""width: 112px; font-size: 15px;"" class=""btn btn-primary"" onclick=""CargaModalCitas();"">Citas</button>
				<button style=""width: 135px; font-size: 15px;"" class=""btn btn-primary"">Orden</button>
				<button onclick=""CargaConsultaCronograma();"" style=""width: 135px; font-size: 15px;"" class=""btn btn-primary"">Cronograma</button>
			</div>
		</div>
");
#nullable restore
#line 138 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
         if (ViewBag.mensaje != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""col-sm-12 alert alert-info alert-dismissible text-center"" role=""alert"" style=""margin-top: 15px;"">
				<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
				");
#nullable restore
#line 144 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
           Write(ViewBag.mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 146 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<div class=""row"" style=""padding-top: 80px;"">
			<div class=""col-sm-12"">
				<table class=""table table-bordered table-responsive table-hover"" id=""citagrid"">
					<thead>
						<tr>
							<th>#</th>
							<th>N°</th>
							<th>Tipo</th>
							<th>Fecha</th>
							<th>Hora</th>
							<th>Producto</th>
							<th>Descripción</th>
							<th>Medico</th>
							<th>Especialidad</th>
							<th>Precio</th>
							<th>IGV</th>
							<th>Estado</th>
							<th>Est.Pago</th>
							<th>Total</th>
							<th>Acciones</th>
						</tr>
					</thead>
					<tbody>
");
#nullable restore
#line 170 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                          
							if (Model != null)
							{
								foreach (var item in Model.paciente.cita)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 176 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.idCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 177 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.nroCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 178 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.TipoCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 179 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 180 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.hora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 181 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.consultorio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 182 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 183 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.medico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 184 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 185 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 186 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.igv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 187 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 188 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.estadoPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 189 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                       Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
										<td>
											<button title=""Reprogramar"" class=""edit btn btn-primary""><i class=""fas fa-address-book""></i></button>
											<button title=""Consultar"" class=""btn btn-primary"">
												<i class=""fa fa-search"" aria-hidden=""true""></i>
											</button>
											<button title=""Anular"" class=""anular btn btn-danger"">
												<i class=""fa fa-minus"" aria-hidden=""true""></i>
											</button>
										</td>
									</tr>
");
#nullable restore
#line 200 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
								}
							}
						

#line default
#line hidden
#nullable disable
            WriteLiteral(@"					</tbody>
				</table>
			</div>
			<div class=""col-sm-12 text-right"">
				<span style=""margin-right:10px;"">TOTAL DE VALOR VENTA - OPERACION GRAVADA</span><span>300</span><br />
				<span style=""margin-right:10px;"">IGV(18%)</span><span>54</span><br />
				<span style=""margin-right:10px;"">IMPORTE TOTAL</span><span>354</span>
			</div>
			<div class=""col-sm-12"" style=""padding-top: 10px;"">
				<div class=""row"">
					<div class=""col-sm-6"">

					</div>
					<div class=""col-sm-6 text-right"">
						<button class=""btn btn-primary"" style=""width: 112px;font-size: 16px;"">Pagar</button>
					</div>
				</div>

			</div>
		</div>
	</div>

<div class=""modal fade"" id=""modalcitas"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">

</div>
<div class=""modal fade"" id=""modalreprogramar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">

</div>

<div id=""modalcronograma"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1"" aria-hidden=""true"">
</");
            WriteLiteral("div>\r\n<div id=\"modalanular\" class=\"modal fade\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel1\" aria-hidden=\"true\">\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27f46c9e7830a26d975ebe5d30207725dbb07cdd23408", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27f46c9e7830a26d975ebe5d30207725dbb07cdd24448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
