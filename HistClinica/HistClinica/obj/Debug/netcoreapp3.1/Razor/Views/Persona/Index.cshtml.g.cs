#pragma checksum "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "333de67b0114ef9fcb5047d65fdf4683b6afbe85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Index), @"mvc.1.0.view", @"/Views/Persona/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333de67b0114ef9fcb5047d65fdf4683b6afbe85", @"/Views/Persona/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HistClinica.DTO.PersonaDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Persona", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 152px;font-size: 16px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "masculino", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "femenino", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Registro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loginForm2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
	<div class=""col-sm-12"">
		<div class=""row"">
			<div class=""col-sm-12 text-center"">
				<div class=""card card-primary"">
					<div class=""card-header"">
						<h2>Gestion de personal</h2>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-sm-12"" style=""padding-top:50px;"">
		<div class=""row"">
			<div class=""col-sm-12"">
				<div class=""row"">
					<div class=""col-sm-12"">
						<label>
							Nombre:
						</label>
					</div>
					<div class=""col-sm-12 form-inline"">
						<input onkeydown=""buscar(event)"" type=""text"" id=""txtnom"" name=""name""");
            BeginWriteAttribute("value", " value=\"", 697, "\"", 705, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" style=""width:200px;"" />
						<button type=""submit"" onclick=""getByNombre();"" class=""btn btn-primary""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-sm-12"" style=""padding-top: 30px;"">
		<div class=""row"">
			<div class=""col-sm-6"">
			</div>
			<div class=""col-sm-6 text-right"" style=""padding-bottom: 10px"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe859275", async() => {
                WriteLiteral("Agregar Personal");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
	<div class=""col-sm-12"">
		<div class=""box-body table-responsive"">
			<table class=""table table-striped table-hover text-center"">
				<thead>
					<tr>
						<th>Código</th>
						<th>Nombres</th>
						<th>Apellido</th>
						<th>Fecha Ingreso</th>
						<th>Teléfono</th>
						<th>Cargo</th>
						<th>Acciones</th>
					</tr>
				</thead>
				<tbody>
");
#nullable restore
#line 61 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                     foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 64 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                       Write(item.idPersona);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 65 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                       Write(item.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 66 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                       Write(item.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 67 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                       Write(item.fechaIngreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 68 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                       Write(item.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 69 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                       Write(item.cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t<a type=\"submit\" class=\"edit btn btn-primary\" ><i class=\"fas fa-edit\"></i></a>\r\n\t\t\t\t\t\t\t<a type=\"submit\" class=\"btn btn-danger\"><i class=\"fas fa-minus\"></i></a>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 75 "C:\Users\User\Desktop\proy_v2\HistClinica\HistClinica\HistClinica\Views\Persona\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				</tbody>
			</table>
		</div>
	</div>
</div>

<div class=""modal fade"" id=""modalestado"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
	<div class=""modal-dialog"" role=""document"">
		<div class=""modal-content"">
			<button style=""text-align:right;"" type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
			<div class=""modal-body"">
				<div class=""col-sm-12 text-center"" style=""padding-bottom: 10px;"">
					<h2 id=""exampleModalLabel"">Aviso!</h2>
				</div>
				<div class=""col-sm-12 text-center"" style=""padding-top: 10px; padding-bottom:10px;"">
					<h4>¿Desea cambiar el estado del personal?</h4>
				</div>
			</div>
			<div class=""modal-footer"">
				<button style=""width: 80px;"" type=""button"" id=""btnaceptar"" class=""btn btn-primary"">Si</button>
				<button style=""width: 80px;"" type=""button"" data-dismiss=""modal"" class=""btn btn-primary"">No</button>
			</div>
		</div>
	</div>
</div>

");
            WriteLiteral(@"

<div class=""modal fade"" id=""modalasignar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
	<div class=""modal-dialog"" role=""document"">
		<div class=""modal-content"" style=""width: 1200px;position: relative;right: 302px;"">
			<div class=""container"">
				<div class=""col-sm-12"">
					<div class=""row"">
						<div class=""col-sm-12"">
							<h2 style=""text-align: left"">Asignar Usuario</h2>
						</div>
					</div>
				</div>

			</div>


			<div class=""container"">
				<div class=""col-sm-12"">
					<div class=""row"">
						<div class=""col-md-6"">
							<div class=""box box-primary"">
								<div class=""box-body"">
									<div class=""form-group"">
										<label>CODIGO</label>
									</div>
									<div class=""form-group"">
										<input id=""txtCodigo""");
            BeginWriteAttribute("Text", " Text=\"", 3932, "\"", 3939, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" size=\"60\" maxlength=\"60\">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>TIPO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<input id=\"txtTipo\"");
            BeginWriteAttribute("Text", " Text=\"", 4153, "\"", 4160, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" size=\"60\" maxlength=\"60\">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>ID</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<input id=\"txtId\"");
            BeginWriteAttribute("Text", " Text=\"", 4370, "\"", 4377, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" size=\"60\" maxlength=\"60\">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>CLAVE </label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<input ID=\"txtClave\"");
            BeginWriteAttribute("Text", " Text=\"", 4594, "\"", 4601, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" size=""60"" maxlength=""60"">
									</div>
								</div>
							</div>
						</div>
						<div class=""col-md-6"">
							<div class=""box box-primary"">
								<div class=""box-body"">
									<div class=""form-group"">
										<label>ESTADO</label>
									</div>
									<div class=""form-group"">
										<select ID=""ddlEstado"" class=""form-control"" style=""width: 520px"">
											");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8517465", async() => {
                WriteLiteral("Activo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8518647", async() => {
                WriteLiteral("Inactivo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</select>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>MODULO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<select ID=\"ddlModulo\" class=\"form-control\" style=\"width: 520px\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8520156", async() => {
                WriteLiteral("Programacion de Citas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8521353", async() => {
                WriteLiteral("Inactivo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</select>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>PERMISOS</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<select ID=\"ddlPermisos\" class=\"form-control\" style=\"width: 520px\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8522870", async() => {
                WriteLiteral("Programacion de Citas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8524067", async() => {
                WriteLiteral("Reportes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8525251", async() => {
                WriteLiteral("Gestion de Personal");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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

								</div>
								<div align=""center"" style=""padding-bottom: 20px;"">
									<table>
										<tr>
											<td>
												<button type=""button"" class=""btn btn-primary"" Width=""400px"">Agregar</button>
											</td>
											<td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
											<td>
												<button type=""button"" class=""btn btn-danger"" Width=""400px"">Desagregar</button>
											</td>
										</tr>
									</table>
								</div>
							</div>
						</div>
					</div>
				</div>

				<div align=""right"" style=""padding-bottom: 20px;"">
					<table>
						<tr>
							<td>
								<button type=""button"" class=""btn btn-primary"" style=""width: 112px;font-size: 16px;"">Guardar </button>
							</td>
							<td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
							<td>&nbsp;&nbsp;&nbsp;&nbsp;</td>

							<td>
								<button type=""button"" class=""btn btn-dark"" style=""width: 112px;font-size: 16px;"">Salir</button>
							</td>
						</tr>
					</table>
	");
            WriteLiteral(@"			</div>

			</div>

		</div>
	</div>
</div>
<div class=""modal fade"" id=""modaleditar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
	<div class=""modal-dialog"" role=""document"">
		<div class=""modal-content"" style=""width: 1200px;position: relative;right: 302px;"">
			<button style=""text-align:right"" type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
			<div class=""container"">
				<div class=""col-sm-12 text-center"">
					<h4 class=""modal-title"" id=""myModalLabel"">Actualizar registro</h4>
				</div>
				<div class=""col-sm-12 pt-4"">
					");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8528182", async() => {
                WriteLiteral(@"
						<div class=""row"">
							<div class=""col-md-6"">
								<div class=""box box-primary"">
									<div class=""box-body"">
										<div class=""form-group"">
											<label>TIPO DE EMPLEADO</label>
										</div>
										<div class=""form-group"">
											<select class=""form-control"">
												");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8528770", async() => {
                    WriteLiteral("Médico");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "333de67b0114ef9fcb5047d65fdf4683b6afbe8530105", async() => {
                    WriteLiteral("Admicionista");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</select>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label>ID EMPLEADO</label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<input id=\"txtid\" name=\"txtid\"");
                BeginWriteAttribute("Text", " Text=\"", 8314, "\"", 8321, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" size=\"60\" maxlength=\"60\" readonly>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label for=\"txtNombres\">NOMBRES</label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<input id=\"txtNombres\"");
                BeginWriteAttribute("Text", " Text=\"", 8573, "\"", 8580, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""nombres"" class=""form-control"" size=""60"" maxlength=""60"" required>
										</div>
										<div class=""form-group"">
											<label>DOCUMENTO DE IDENTIDAD</label>
										</div>
										<div class=""form-group"">
											<input id=""txtNroDocumento"" onkeydown=""ValidarSoloNumero(event)"" name=""nroDni""");
                BeginWriteAttribute("Text", " Text=\"", 8901, "\"", 8908, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" size=""60"" maxlength=""8"" required>
										</div>
										<div class=""form-group"">
											<label>N° DE COLEGIO</label>
										</div>
										<div class=""form-group"">
											<input id=""txtNroColegio"" onkeydown=""ValidarSoloNumero(event)""");
                BeginWriteAttribute("Text", " Text=\"", 9188, "\"", 9195, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""nroColegio"" class=""form-control"" size=""60"" maxlength=""60"" required>
										</div>
										<div class=""form-group"">
											<label>ESPECIALIDAD</label>
										</div>
										<div class=""form-group"">
											<input id=""txtespecialidad"" name=""especialidad"" class=""form-control"" size=""60"" maxlength=""60"" required>
										</div>
									</div>
								</div>
							</div>
							<div class=""col-md-6"">
								<div class=""box box-primary"">
									<div class=""box-body"">
										<div class=""form-group"">
											<label>AREA</label>
										</div>
										<div class=""form-group"">
											<input type=""text"" id=""txtarea"" name=""area""");
                BeginWriteAttribute("value", " value=\"", 9881, "\"", 9889, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" required />
										</div>
										<div class=""form-group"">
											<label>CARGO</label>
										</div>
										<div class=""form-group"">
											<input id=""txtcargo"" name=""cargo"" class=""form-control"" size=""60"" maxlength=""60"" required>
										</div>
										<div class=""form-group"">
											<label>APELLIDOS</label>
										</div>
										<div class=""form-group"">
											<input id=""txtApPaterno"" name=""apellidos""");
                BeginWriteAttribute("Text", " Text=\"", 10365, "\"", 10372, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" size=""60"" maxlength=""60"" required>
										</div>
										<div class=""form-group"">
											<label>FECHA INGRESO</label>
										</div>
										<div class=""form-group"">
											<input id=""fchIngreso"" name=""fecingreso""");
                BeginWriteAttribute("value", " value=\"", 10631, "\"", 10639, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" required />\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label>TELÉFONO</label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<input id=\"txtTelefono\" onkeydown=\"ValidarSoloNumero(event)\"");
                BeginWriteAttribute("Text", " Text=\"", 10890, "\"", 10897, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""telefono"" class=""form-control"" size=""60"" maxlength=""60"" required>
										</div>
										<div class=""form-group"">
											<label>N° DE RUC</label>
										</div>
										<div class=""form-group"">
											<input id=""txtruc"" onkeydown=""ValidarSoloNumero(event)"" name=""nroRuc"" class=""form-control"" size=""60"" maxlength=""60"" required>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class=""row m-0 p-0 pt-4 pb-3"">
							<div class=""col-sm-12 text-right"">
								<button id=""btnguardar"" type=""submit"" onclick=""Update();"" class=""btn btn-primary"" style=""width: 112px;font-size: 16px;"">Guardar</button>
							</div>
						</div>
					");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HistClinica.DTO.PersonaDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
