#pragma checksum "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e5156c8e0d3b0cb9812cdbc0ecf8eb9f5e8c4f3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5156c8e0d3b0cb9812cdbc0ecf8eb9f5e8c4f3", @"/Views/Cronograma/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cronograma_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.CronoMedico>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
 using (Html.BeginForm("Create","Cronograma"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"row pb-2\">\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Medico</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
#line 12 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
               Write(Html.DropDownListFor(m => m.idMedico, new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Especialidad</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
#line 22 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
               Write(Html.DropDownListFor(m => m.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idEspecialidad", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Consultorio</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
#line 32 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
               Write(Html.DropDownListFor(m => m.idConsultorio, new SelectList(ViewBag.listaconsultorio, "idConsultorio", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row pb-2\">\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Fecha</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
#line 44 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
               Write(Html.TextBoxFor(m => m.fecProgramMedica, new { @class = "form-control", @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Hora Inicio</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
#line 54 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
               Write(Html.DropDownListFor(m => m.dsHrInicio, new SelectList(ViewBag.listahoras), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Hora Fin</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
#line 64 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
               Write(Html.DropDownListFor(m => m.dsHrFin, new SelectList(ViewBag.listahoras), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row pb-2\">\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Estado</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5156c8e0d3b0cb9812cdbc0ecf8eb9f5e8c4f38181", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5156c8e0d3b0cb9812cdbc0ecf8eb9f5e8c4f38453", async() => {
                    WriteLiteral("Activo");
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
                WriteLiteral("\r\n\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e5156c8e0d3b0cb9812cdbc0ecf8eb9f5e8c4f39688", async() => {
                    WriteLiteral("Inactivo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 76 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.dsEstado);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row pb-2 text-right\">\r\n\t\t<div class=\"col-sm-12\">\r\n\t\t\t<button class=\"btn btn-primary\">Guardar</button>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 93 "D:\HistClinica\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.CronoMedico> Html { get; private set; }
    }
}
#pragma warning restore 1591
