#pragma checksum "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Filtro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a00337fee7a23fb1517bd7706dc6f31867155716"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cronograma_Filtro), @"mvc.1.0.view", @"/Views/Cronograma/Filtro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00337fee7a23fb1517bd7706dc6f31867155716", @"/Views/Cronograma/Filtro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cronograma_Filtro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.D012_CRONOMEDICO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Filtro.cshtml"
 using (Html.BeginForm("Filtro", "Cronograma"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"row pb-2\">\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t<label>Medico</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t");
#nullable restore
#line 13 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Filtro.cshtml"
               Write(Html.DropDownListFor(m => m.idMedico, new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 23 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Cronograma\Filtro.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.D012_CRONOMEDICO> Html { get; private set; }
    }
}
#pragma warning restore 1591
