#pragma checksum "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Perfis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35ff4f2b4606f6fc1b89e84834bdf67937c5e7fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfis_Index), @"mvc.1.0.view", @"/Views/Perfis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Perfis/Index.cshtml", typeof(AspNetCore.Views_Perfis_Index))]
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
#line 1 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\_ViewImports.cshtml"
using ProvaHigorCouto;

#line default
#line hidden
#line 2 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\_ViewImports.cshtml"
using ProvaHigorCouto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ff4f2b4606f6fc1b89e84834bdf67937c5e7fb", @"/Views/Perfis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b24291f6dca77ab32891f0a40a93f57091ed98", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProvaHigorCouto.Models.Perfil>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Perfis/Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Perfis\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(98, 198, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <h2><span class=\"glyphicon glyphicon glyphicon-th-list\"></span> Perfis</h2>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <br />\r\n        ");
            EndContext();
            BeginContext(296, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786967862cf1428285b765c6f5683370", async() => {
                BeginContext(355, 16, true);
                WriteLiteral("Cadastrar perfil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(375, 175, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<table class=\"tabela\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Perfis\Index.cshtml"
         if (!Model.Any())
        {

#line default
#line hidden
            BeginContext(589, 120, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\" colspan=\"2\">Nenhum perfil cadastrado</td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Perfis\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(720, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 32 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Perfis\Index.cshtml"
         foreach (var perfil in Model)
        {

#line default
#line hidden
            BeginContext(771, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(810, 11, false);
#line 35 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Perfis\Index.cshtml"
               Write(perfil.nome);

#line default
#line hidden
            EndContext();
            BeginContext(821, 68, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(889, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e314a3b474b04974ae3a4181e6df4a2b", async() => {
                BeginContext(924, 61, true);
                WriteLiteral("<span class=\"btn btn-info glyphicon glyphicon-pencil\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 898, "~/Perfis/Form/", 898, 14, true);
#line 37 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Perfis\Index.cshtml"
AddHtmlAttributeValue("", 912, perfil.id, 912, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(989, 24, true);
            WriteLiteral("\r\n                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1013, "\"", 1064, 3);
            WriteAttributeValue("", 1023, "Confirmacao(\'/Perfis/Excluir/", 1023, 29, true);
#line 38 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Perfis\Index.cshtml"
WriteAttributeValue("", 1052, perfil.id, 1052, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1062, "\')", 1062, 2, true);
            EndWriteAttribute();
            BeginContext(1065, 111, true);
            WriteLiteral("><span class=\"btn btn-danger glyphicon glyphicon-trash\"></span></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 41 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Perfis\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1187, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProvaHigorCouto.Models.Perfil>> Html { get; private set; }
    }
}
#pragma warning restore 1591
