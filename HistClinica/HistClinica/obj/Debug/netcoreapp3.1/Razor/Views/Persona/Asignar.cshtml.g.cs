#pragma checksum "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Persona\Asignar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f29635162cba57553c1d108233139caf107012cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Asignar), @"mvc.1.0.view", @"/Views/Persona/Asignar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29635162cba57553c1d108233139caf107012cb", @"/Views/Persona/Asignar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Asignar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.PersonaDTO>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-dialog modal-lg"" role=""document"">
	<div class=""modal-content"">
		<div class=""modal-header"">
			<h2 class=""modal-title text-center"" id=""exampleModalLabel1"">Asignar Usuario</h2>
			<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
		</div>
");
#nullable restore
#line 10 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Persona\Asignar.cshtml"
         using (Html.BeginForm())
		{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""container"">
				<div class=""col-sm-12"">
					<div class=""row"">
						<div class=""col-md-6"">
							<div class=""box box-primary"">
								<div class=""box-body"">
									<div class=""form-group"">
										<label>CODIGO</label>
									</div>
									<div class=""form-group"">
										");
#nullable restore
#line 22 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Persona\Asignar.cshtml"
                                   Write(Html.EditorFor(m => m.personal.idEmpleado, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>TIPO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 28 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Persona\Asignar.cshtml"
                                   Write(Html.DropDownListFor(m => m.personal.idTipoEmpleado, new SelectList(ViewBag.lsttipoempleado, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>AFILIA EN CAJA</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<select class=\"form-control\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f29635162cba57553c1d108233139caf107012cb5428", async() => {
                WriteLiteral("Si");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f29635162cba57553c1d108233139caf107012cb6404", async() => {
                WriteLiteral("No");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</select>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>CLAVE </label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 43 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Persona\Asignar.cshtml"
                                   Write(Html.PasswordFor(m => m.asignacion.claveUser, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									</div>
									<div class=""form-group"">
										<!--	<button class=""btn btn-primary"">Asignar modulo</button>-->
									</div>

								</div>
							</div>
						</div>
						<div class=""col-md-6"">
							<div class=""box box-primary"">
								<div class=""box-body"">
									<div class=""form-group"">
										<label>NOMBRE USUARIO</label>
									</div>
									<div class=""form-group"">
										");
#nullable restore
#line 59 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Persona\Asignar.cshtml"
                                   Write(Html.EditorFor(m => m.nombres, new { htmlAttributes = new { @class = "form-control", @disabled = "true" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>NUMERO DE DOCUMENTO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 65 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Persona\Asignar.cshtml"
                                   Write(Html.EditorFor(m => m.numeroDocumento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>CAJA </label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 71 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Persona\Asignar.cshtml"
                                   Write(Html.DropDownListFor(m => m.asignacion.idCaja, new SelectList(ViewBag.lscaja, "idCaja", "nroCaja"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>

				<div align=""right"" style=""padding-bottom: 20px;"">
					<table>
						<tr>
							<td>
								<button type=""submit"" class=""btn btn-primary"" style=""width: 112px;font-size: 16px;"">Guardar </button>
							</td>
							<td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
							<td>&nbsp;&nbsp;&nbsp;&nbsp;</td>

							<td>
								<button type=""button"" class=""btn btn-dark"" style=""width: 112px;font-size: 16px;"" data-dismiss=""modal"">Salir</button>
							</td>
						</tr>
					</table>
				</div>

			</div>
");
#nullable restore
#line 96 "C:\Users\User\OneDrive\Desktop\his-net core\HistClinica\HistClinica\HistClinica\Views\Persona\Asignar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.DTO.PersonaDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
