#pragma checksum "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Funcionalidades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c328bd62f36b8969a806821ca751f3565e03cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionalidades_Index), @"mvc.1.0.view", @"/Views/Funcionalidades/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionalidades/Index.cshtml", typeof(AspNetCore.Views_Funcionalidades_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c328bd62f36b8969a806821ca751f3565e03cb", @"/Views/Funcionalidades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b24291f6dca77ab32891f0a40a93f57091ed98", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionalidades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProvaHigorCouto.Models.Funcionalidade>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Funcionalidades/Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Funcionalidades\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(106, 207, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <h2><span class=\"glyphicon glyphicon glyphicon-th-list\"></span> Funcionalidades</h2>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <br />\r\n        ");
            EndContext();
            BeginContext(313, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36e1f4bbd1f04fc787d92d1e705cd2ec", async() => {
                BeginContext(381, 24, true);
                WriteLiteral("Cadastrar funcionalidade");
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
            BeginContext(409, 175, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<table class=\"tabela\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Funcionalidades\Index.cshtml"
         if (!Model.Any())
        {

#line default
#line hidden
            BeginContext(623, 129, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\" colspan=\"2\">Nenhuma funcionalidade cadastrada</td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Funcionalidades\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(763, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 32 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Funcionalidades\Index.cshtml"
         foreach (var funcionalidade in Model)
        {

#line default
#line hidden
            BeginContext(822, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(861, 19, false);
#line 35 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Funcionalidades\Index.cshtml"
               Write(funcionalidade.nome);

#line default
#line hidden
            EndContext();
            BeginContext(880, 68, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(948, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65336f41f6284add87b1da9b13271ba6", async() => {
                BeginContext(1000, 61, true);
                WriteLiteral("<span class=\"btn btn-info glyphicon glyphicon-pencil\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 957, "~/Funcionalidades/Form/", 957, 23, true);
#line 37 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Funcionalidades\Index.cshtml"
AddHtmlAttributeValue("", 980, funcionalidade.id, 980, 18, false);

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
            BeginContext(1065, 24, true);
            WriteLiteral("\r\n                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1089, "\"", 1157, 3);
            WriteAttributeValue("", 1099, "Confirmacao(\'/Funcionalidades/Excluir/", 1099, 38, true);
#line 38 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Funcionalidades\Index.cshtml"
WriteAttributeValue("", 1137, funcionalidade.id, 1137, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1155, "\')", 1155, 2, true);
            EndWriteAttribute();
            BeginContext(1158, 111, true);
            WriteLiteral("><span class=\"btn btn-danger glyphicon glyphicon-trash\"></span></a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 41 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Funcionalidades\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1280, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProvaHigorCouto.Models.Funcionalidade>> Html { get; private set; }
    }
}
#pragma warning restore 1591