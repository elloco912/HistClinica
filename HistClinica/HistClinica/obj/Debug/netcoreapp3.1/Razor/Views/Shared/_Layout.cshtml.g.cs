#pragma checksum "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40316e75d503a7d45b757e62ea8f3acc72856ad4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40316e75d503a7d45b757e62ea8f3acc72856ad4", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Panel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Persona", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cronograma", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Paciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40316e75d503a7d45b757e62ea8f3acc72856ad46856", async() => {
                WriteLiteral(@"
	<meta charset=""utf-8"">
	<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">


	<title>Sistema Web | His</title>

	<!-- Tell the browser to be responsive to screen width -->
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	<!-- Font Awesome -->
	<link rel=""stylesheet""");
                BeginWriteAttribute("href", " href=\"", 342, "\"", 415, 1);
#nullable restore
#line 17 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 349, Url.Content("~/Content/plugins/fontawesome-free/css/all.min.css"), 349, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t<!-- Ionicons -->\r\n\t<link rel=\"stylesheet\" href=\"https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css\">\r\n\t<!-- Tempusdominus Bbootstrap 4 -->\r\n\t<link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 601, "\"", 705, 1);
#nullable restore
#line 21 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 608, Url.Content("~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css"), 608, 97, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t<!-- iCheck -->\r\n\t<link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 750, "\"", 832, 1);
#nullable restore
#line 23 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 757, Url.Content("~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css"), 757, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t<!-- JQVMap -->\r\n\t<link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 877, "\"", 939, 1);
#nullable restore
#line 25 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 884, Url.Content("~/Content/plugins/jqvmap/jqvmap.min.css"), 884, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t<!-- Theme style -->\r\n\t<link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 989, "\"", 1047, 1);
#nullable restore
#line 27 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 996, Url.Content("~/Content/dist/css/adminlte.min.css"), 996, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t<!-- overlayScrollbars -->\r\n\t<link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1103, "\"", 1191, 1);
#nullable restore
#line 29 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1110, Url.Content("~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"), 1110, 81, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t<!-- Daterange picker -->\r\n\t<link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1246, "\"", 1322, 1);
#nullable restore
#line 31 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1253, Url.Content("~/Content/plugins/daterangepicker/daterangepicker.css"), 1253, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t<!-- summernote -->\r\n\t<link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1371, "\"", 1441, 1);
#nullable restore
#line 33 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1378, Url.Content("~/Content/plugins/summernote/summernote-bs4.css"), 1378, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\t<!-- buscar -->\r\n\t<link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1488, "\"", 1573, 1);
#nullable restore
#line 36 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1495, Url.Content("~/Content/plugins/datatables-bs4/css/dataTables.bootstrap4.css"), 1495, 78, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\t<!-- Google Font: Source Sans Pro -->\r\n\t<link href=\"https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700\" rel=\"stylesheet\">\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40316e75d503a7d45b757e62ea8f3acc72856ad412131", async() => {
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
                WriteLiteral(@"
	<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>

	<style type=""text/css"">
		.user-panel img {
			height: auto;
			width: 3.1rem;
		}
	</style>

	<style type=""text/css"">
		.user-panel .info {
			display: inline-block;
			padding: 20px 5px 5px 10px;
		}
	</style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40316e75d503a7d45b757e62ea8f3acc72856ad414243", async() => {
                WriteLiteral(@"
	<div class=""wrapper"">

		<!-- Navbar -->

		<nav class=""main-header navbar navbar-expand navbar-light"" style=""background-color: #2F73D7;"">
			<!-- Left navbar links -->
			<ul class=""navbar-nav"">
				<li class=""nav-item"">
					<a class=""nav-link"" data-widget=""pushmenu"" href=""#""><i class=""fas fa-bars"" style=""color:white""></i></a>
				</li>

			</ul>

			<!-- SEARCH FORM -->
			<!-- Right navbar links -->
			<ul class=""navbar-nav ml-auto"">

				<!-- Messages Dropdown Menu -->
				<!-- Notifications Dropdown Menu -->
				<li class=""nav-item dropdown"">
					<a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
						<i href=""#"" class=""nav-icon fas fa-sign-out-alt"" style=""color:white"">  Cerrar Sesion </i>
					</a>
				</li>

				<li class=""nav-item"">
					<a class=""nav-link"">
						<i");
                BeginWriteAttribute("class", " class=\"", 2967, "\"", 2975, 0);
                EndWriteAttribute();
                WriteLiteral(@"></i>
					</a>
				</li>
			</ul>
		</nav>

		<!-- /.navbar -->
		<!-- Main Sidebar Container -->
		<aside class=""main-sidebar sidebar-dark-primary elevation-4"">
			<!-- Brand Logo -->
			<div style=""background-color: #2C5BA0;"">
				<a href=""index3.html"" class=""brand-link"">
					<img");
                BeginWriteAttribute("src", " src=\"", 3273, "\"", 3322, 1);
#nullable restore
#line 98 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3279, Url.Content("~/Content/dist/img/cem2.jpg"), 3279, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" alt=""AdminLTE Logo"" class=""brand-image img-circle elevation-3""
						 style=""opacity: .8"">
					<span class=""brand-text font-weight-light""><font face=""Kaushan Script, coursive  "">HIS</font></span>

				</a>
			</div>
			<!-- Sidebar -->
			<div class=""sidebar"">
				<!-- Sidebar user panel (optional) -->
				<div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
					<div class=""image"">
						<img");
                BeginWriteAttribute("src", " src=\"", 3726, "\"", 3778, 1);
#nullable restore
#line 109 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3732, Url.Content("~/Content/dist/img/avatar5.png"), 3732, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-circle elevation-2"" alt=""User Image"">
					</div>
					<div class=""info"">
						<a href=""#"" class=""d-block"">Rafael Sanchez</a>
					</div>
				</div>

				<!-- Sidebar Menu -->
				<nav class=""mt-2"">
					<ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
						<!-- Add icons to the links using the .nav-icon class
						with font-awesome or any other icon font library -->
						<li class=""nav-item "">
							");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40316e75d503a7d45b757e62ea8f3acc72856ad417580", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t<i class=\"nav-icon fas fa-clinic-medical\"></i>\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\tPanel de Administracion\r\n\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40316e75d503a7d45b757e62ea8f3acc72856ad419355", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t<i class=\"nav-icon fas fa-user-injured\"></i>\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\tGestionar Personal\r\n\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40316e75d503a7d45b757e62ea8f3acc72856ad421119", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t<i class=\"nav-icon fas fa-user-injured\"></i>\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\tCronograma de medicos\r\n\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40316e75d503a7d45b757e62ea8f3acc72856ad422890", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t<i class=\"nav-icon fas fa-notes-medical\"></i>\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\tReserva de Citas\r\n\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
						</li>

						<li class=""nav-item"">
							<a href=""#"" class=""nav-link "">
								<i class=""nav-icon far fa-business-time""></i>
								<p>
									Atencion Citas

								</p>
							</a>
						</li>

						<li class=""nav-item"">
							");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40316e75d503a7d45b757e62ea8f3acc72856ad424844", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t<i class=\"nav-icon far fa-calendar-alt\"></i>\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\tGestion de tablas\r\n\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
						</li>

						<li class=""nav-item"">
							<a href=""#"" class=""nav-link "">
								<i class=""nav-icon far fa-chart-bar"">&nbsp;</i>
								<p>
									Reportes

								</p>
							</a>
						</li>



					</ul>
				</nav>
				<!-- /.sidebar-menu -->
			</div>
			<!-- /.sidebar -->
		</aside>

		<!-- Content Wrapper. Contains page content -->
		<div class=""content-wrapper"">
			<!-- Content Header (Page header) -->
			<div class=""content-header"">
				<div class=""container-fluid"">
					<div class=""row mb-2"">
						<div class=""col-sm-6"">
							<h1 class=""m-0 text-dark""></h1>
						</div><!-- /.col -->
						<div class=""col-sm-12"">
							<div class=""layout-content"">
								<div class=""layout-content-body"">
									");
#nullable restore
#line 211 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
                               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t\t\t<input type=\"hidden\" id=\"hdnBaseUrl\"");
                BeginWriteAttribute("value", " value=\"", 6481, "\"", 6506, 1);
#nullable restore
#line 213 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6489, Url.Content("~"), 6489, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
								</div>
							</div>

						</div><!-- /.col -->
					</div><!-- /.row -->
				</div><!-- /.container-fluid -->
			</div>


			<!-- Main content -->
			<!-- /.Left col -->
			<!-- right col (We are only adding the ID to make the widgets sortable)-->
			<!-- right col -->
		</div>
		<!-- /.row (main row) -->
		<!-- /.content -->
		<!-- /.content-wrapper -->
		<footer class=""main-footer"">
			<strong>Copyright &copy; 2014-2020 <a href=""#"">GYE MEDICAL</a></strong>
			All rights reserved.
			<div class=""float-right d-none d-sm-inline-block"">
				<b>Version</b> 5.0.1
			</div>
		</footer>

		<!-- Control Sidebar -->
		<aside class=""control-sidebar control-sidebar-dark"">
			<!-- Control sidebar content goes here -->
		</aside>
		<!-- /.control-sidebar -->
	</div>


	<!-- ./wrapper -->
	<!-- jQuery -->
	<script");
                BeginWriteAttribute("src", " src=\"", 7369, "\"", 7429, 1);
#nullable restore
#line 249 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7375, Url.Content("~/Content/plugins/jquery/jquery.min.js"), 7375, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- jQuery UI 1.11.4 -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 7478, "\"", 7544, 1);
#nullable restore
#line 251 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7484, Url.Content("~/Content/plugins/jquery-ui/jquery-ui.min.js"), 7484, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->\r\n\t<script>\r\n\t\t$.widget.bridge(\'uibutton\', $.ui.button)\r\n\t</script>\r\n\t<!-- Bootstrap 4 -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 7727, "\"", 7803, 1);
#nullable restore
#line 257 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7733, Url.Content("~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js"), 7733, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- ChartJS -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 7843, "\"", 7904, 1);
#nullable restore
#line 259 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7849, Url.Content("~/Content/plugins/chart.js/Chart.min.js"), 7849, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- Sparkline -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 7946, "\"", 8009, 1);
#nullable restore
#line 261 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7952, Url.Content("~/Content/plugins/sparklines/sparkline.js"), 7952, 57, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- JQVMap -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 8048, "\"", 8113, 1);
#nullable restore
#line 263 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8054, Url.Content("~/Content/plugins/jqvmap/jquery.vmap.min.js"), 8054, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 8134, "\"", 8204, 1);
#nullable restore
#line 264 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8140, Url.Content("~/Content/plugins/jqvmap/maps/jquery.vmap.usa.js"), 8140, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- jQuery Knob Chart -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 8254, "\"", 8324, 1);
#nullable restore
#line 266 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8260, Url.Content("~/Content/plugins/jquery-knob/jquery.knob.min.js"), 8260, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- daterangepicker -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 8372, "\"", 8432, 1);
#nullable restore
#line 268 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8378, Url.Content("~/Content/plugins/moment/moment.min.js"), 8378, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 8453, "\"", 8527, 1);
#nullable restore
#line 269 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8459, Url.Content("~/Content/plugins/daterangepicker/daterangepicker.js"), 8459, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- Tempusdominus Bootstrap 4 -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 8585, "\"", 8686, 1);
#nullable restore
#line 271 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8591, Url.Content("~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js"), 8591, 95, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- Summernote -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 8729, "\"", 8801, 1);
#nullable restore
#line 273 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8735, Url.Content("~/Content/plugins/summernote/summernote-bs4.min.js"), 8735, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- overlayScrollbars -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 8851, "\"", 8943, 1);
#nullable restore
#line 275 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8857, Url.Content("~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js"), 8857, 86, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- AdminLTE App -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 8988, "\"", 9039, 1);
#nullable restore
#line 277 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8994, Url.Content("~/Content/dist/js/adminlte.js"), 8994, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- AdminLTE dashboard demo (This is only for demo purposes) -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 9128, "\"", 9186, 1);
#nullable restore
#line 279 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9134, Url.Content("~/Content/dist/js/pages/dashboard.js"), 9134, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<!-- AdminLTE for demo purposes -->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 9245, "\"", 9292, 1);
#nullable restore
#line 281 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9251, Url.Content("~/Content/dist/js/demo.js"), 9251, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n\t<!--buscar-->\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 9331, "\"", 9407, 1);
#nullable restore
#line 284 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9337, Url.Content("~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js"), 9337, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 9428, "\"", 9499, 1);
#nullable restore
#line 285 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9434, Url.Content("~/Content/plugins/datatables/jquery.dataTables.js"), 9434, 65, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 9520, "\"", 9602, 1);
#nullable restore
#line 286 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9526, Url.Content("~/Content/plugins/datatables-bs4/js/dataTables.bootstrap4.js"), 9526, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n\t<script");
                BeginWriteAttribute("src", " src=\"", 9625, "\"", 9668, 1);
#nullable restore
#line 288 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9631, Url.Content("~/Scripts/Employee.js"), 9631, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n\t");
#nullable restore
#line 290 "C:\Users\User\Desktop\HistClinica\HistClinica\HistClinica\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
