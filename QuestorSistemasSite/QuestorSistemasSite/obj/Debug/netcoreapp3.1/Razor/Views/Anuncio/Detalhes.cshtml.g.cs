#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c4aa63106dcfe25753eea59bafa350becdb834b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncio_Detalhes), @"mvc.1.0.view", @"/Views/Anuncio/Detalhes.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\_ViewImports.cshtml"
using QuestorSistemasSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
using QuestorSistemasSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4aa63106dcfe25753eea59bafa350becdb834b", @"/Views/Anuncio/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf42bea604fb765d805f3d0d4c27881f721f61ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Anuncio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes" + Model.Slug;
    var comb = @Model.Combustível == "1" ? "Gasolina" : (@Model.Combustível == "2" ? "Alcool" : "Gas");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"box-section banner-section triggerAnimation animated\" data-animate=\"rollIn\">\r\n    <div class=\"banner\">\r\n        <img src=\"/upload/banners/2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 371, "\"", 377, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1><span>Detalhes</span></h1>\r\n    </div>\r\n    <div class=\"pager-line\">\r\n        <a class=\"prev\"");
            BeginWriteAttribute("href", " href=\"", 486, "\"", 558, 1);
#nullable restore
#line 14 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
WriteAttributeValue("", 493, Url.Action("Detalhes", "Anuncio", new { Slug = @ViewBag.Before}), 493, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-long-arrow-left\"></i>Previous Page</a>\r\n        <a class=\"next\"");
            BeginWriteAttribute("href", " href=\"", 639, "\"", 710, 1);
#nullable restore
#line 15 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
WriteAttributeValue("", 646, Url.Action("Detalhes", "Anuncio", new { Slug = @ViewBag.After}), 646, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-long-arrow-right\"></i>Next Page</a>\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n        \r\n<div class=\"single-post triggerAnimation animated\" data-animate=\"flipInY\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 1055, "\"", 1093, 2);
            WriteAttributeValue("", 1061, "/Conteudo/Anuncios/", 1061, 19, true);
#nullable restore
#line 24 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
WriteAttributeValue("", 1080, Model.Imagem, 1080, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1094, "\"", 1113, 1);
#nullable restore
#line 24 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
WriteAttributeValue("", 1100, Model.Imagem, 1100, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"single-post-content\">\r\n        <h1>");
#nullable restore
#line 26 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
       Write(Model.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <ul class=\"post-tags\">\r\n            <li>\r\n                <i class=\"fa fa-calendar-o\"> </i>\r\n                <span>");
#nullable restore
#line 30 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
                 Write(Model.DataVenda.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li>\r\n                <i>Final Placa ");
#nullable restore
#line 33 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
                          Write(Model.FinalPlaca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n            </li>\r\n            <li>\r\n                <i>Combustivel</i>\r\n                <a href=\"#\">");
#nullable restore
#line 37 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
                       Write(comb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n            <li>\r\n                <i>Cor</i>\r\n                <a href=\"#\">");
#nullable restore
#line 41 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
                       Write(Model.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n            <li>\r\n                <i>Portas <a href=\"#\">");
#nullable restore
#line 44 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
                                 Write(Model.Portas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></i>\r\n                \r\n            </li>\r\n            <li>\r\n                <i class=\"fa fa-dollar\"> </i>\r\n                <a href=\"#\">");
#nullable restore
#line 49 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
                       Write(Model.ValorVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n        </ul>\r\n        ");
#nullable restore
#line 52 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Anuncio\Detalhes.cshtml"
   Write(Html.Raw(Model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Anuncio> Html { get; private set; }
    }
}
#pragma warning restore 1591
