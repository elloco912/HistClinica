<<<<<<< HEAD
#pragma checksum "C:\Users\MARCO\Desktop\version3\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d60c5fe3291e688d7cce8f8f72404a8e8707ea1d"
=======
#pragma checksum "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d60c5fe3291e688d7cce8f8f72404a8e8707ea1d"
>>>>>>> master
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cronograma_Create), @"mvc.1.0.view", @"/Views/Cronograma/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d60c5fe3291e688d7cce8f8f72404a8e8707ea1d", @"/Views/Cronograma/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cronograma_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.D012_CRONOMEDICO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/comboaninado.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
 using (Html.BeginForm("Create","Cronograma"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"row pb-2\">\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Medico</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
<<<<<<< HEAD
#line 12 "C:\Users\MARCO\Desktop\version3\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
=======
#line 12 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
>>>>>>> master
               Write(Html.DropDownListFor(m => m.idMedico, new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccione", new { @class = "form-control" ,
				   data_cascade_combo = "#stypes",
				   data_cascade_combo_source = Url.Action("GetEspecialidad", "Cronograma"),
				   data_cascade_combo_param_name = "id"
			   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Especialidad</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
<<<<<<< HEAD
#line 26 "C:\Users\MARCO\Desktop\version3\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
=======
#line 26 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
>>>>>>> master
               Write(Html.DropDownListFor(m => m.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), new { @class = "form-control", id = "stypes" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Consultorio</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
<<<<<<< HEAD
#line 36 "C:\Users\MARCO\Desktop\version3\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
=======
#line 36 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
>>>>>>> master
               Write(Html.DropDownListFor(m => m.idConsultorio, new SelectList(ViewBag.listaconsultorio, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row pb-2\">\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Fecha</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
<<<<<<< HEAD
#line 48 "C:\Users\MARCO\Desktop\version3\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
=======
#line 48 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
>>>>>>> master
               Write(Html.TextBoxFor(m => m.fecProgramMedica, new { @class = "form-control", @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Hora Inicio</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
<<<<<<< HEAD
#line 58 "C:\Users\MARCO\Desktop\version3\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
=======
#line 58 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
>>>>>>> master
               Write(Html.DropDownListFor(m => m.hrInicio, new SelectList(ViewBag.listahoras), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Hora Fin</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
<<<<<<< HEAD
#line 68 "C:\Users\MARCO\Desktop\version3\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
=======
#line 68 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
>>>>>>> master
               Write(Html.DropDownListFor(m => m.hrFin, new SelectList(ViewBag.listahoras), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row pb-2\">\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Estado</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
<<<<<<< HEAD
#line 80 "C:\Users\MARCO\Desktop\version3\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
=======
#line 80 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
>>>>>>> master
               Write(Html.DropDownListFor(m => m.idEstado, new SelectList(ViewBag.lestado, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row pb-2 text-right\">\r\n\t\t<div class=\"col-sm-12\">\r\n\t\t\t<button class=\"btn btn-primary\">Guardar</button>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 94 "C:\Users\MARCO\Desktop\version3\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
=======
#line 94 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
>>>>>>> master
}

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d60c5fe3291e688d7cce8f8f72404a8e8707ea1d8825", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d60c5fe3291e688d7cce8f8f72404a8e8707ea1d8705", async() => {
>>>>>>> master
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.D012_CRONOMEDICO> Html { get; private set; }
    }
}
#pragma warning restore 1591
