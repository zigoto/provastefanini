#pragma checksum "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ad0cd100fe3202a5bd84be5d583b84a1db6c1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Index.cshtml", typeof(AspNetCore.Views_Usuarios_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ad0cd100fe3202a5bd84be5d583b84a1db6c1e", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b24291f6dca77ab32891f0a40a93f57091ed98", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProvaHigorCouto.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Usuarios/Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(97, 187, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <h2><span class=\"glyphicon glyphicon-user\"></span> Usuários</h2>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <br />\r\n        ");
            EndContext();
            BeginContext(284, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c14efb71e574fe2a058ca1b6c20384b", async() => {
                BeginContext(345, 17, true);
                WriteLiteral("Cadastrar usuário");
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
            BeginContext(366, 205, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<table class=\"tabela\">\r\n    <thead >\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Perfil</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml"
         if (!Model.Any())
        {

#line default
#line hidden
            BeginContext(610, 121, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\" colspan=\"3\">Nenhum usuário cadastrado</td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(742, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 32 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml"
         foreach (var usuario in Model)
        {

#line default
#line hidden
            BeginContext(794, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(817, 12, false);
#line 35 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml"
       Write(usuario.nome);

#line default
#line hidden
            EndContext();
            BeginContext(829, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(849, 19, false);
#line 36 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml"
       Write(usuario.Perfil.nome);

#line default
#line hidden
            EndContext();
            BeginContext(868, 52, true);
            WriteLiteral("</td>\r\n        <td class=\"text-right\">\r\n            ");
            EndContext();
            BeginContext(920, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d2f1bbbbbf4114875a796e752e3d46", async() => {
                BeginContext(958, 61, true);
                WriteLiteral("<span class=\"btn btn-info glyphicon glyphicon-pencil\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 929, "~/Usuarios/Form/", 929, 16, true);
#line 38 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml"
AddHtmlAttributeValue("", 945, usuario.id, 945, 11, false);

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
            BeginContext(1023, 16, true);
            WriteLiteral("\r\n            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1039, "\"", 1093, 3);
            WriteAttributeValue("", 1049, "Confirmacao(\'/Usuarios/Excluir/", 1049, 31, true);
#line 39 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 1080, usuario.id, 1080, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1091, "\')", 1091, 2, true);
            EndWriteAttribute();
            BeginContext(1094, 95, true);
            WriteLiteral("><span class=\"btn btn-danger glyphicon glyphicon-trash\"></span></a>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 42 "C:\Projetos\ProvaHigorCouto\ProvaHigorCouto\ProvaHigorCouto\Views\Usuarios\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1200, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProvaHigorCouto.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
