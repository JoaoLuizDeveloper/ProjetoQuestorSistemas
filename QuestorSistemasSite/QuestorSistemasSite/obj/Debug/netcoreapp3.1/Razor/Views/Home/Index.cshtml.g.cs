#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a7e5faa3ce6d747ec48c52c826716be1e4d971f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
using QuestorSistemasSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7e5faa3ce6d747ec48c52c826716be1e4d971f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf42bea604fb765d805f3d0d4c27881f721f61ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

    var Anuncios = ViewBag.Anuncio as List<Anuncio>;
    var Marcas = ViewBag.Marcas as List<Marca>;
    var Modelos = ViewBag.Modelos as List<Modelo>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"slider\" class=\"box-section triggerAnimation animated\" data-animate=\"rollIn\">\r\n    <div class=\"flexslider\">\r\n        <ul class=\"slides\">\r\n");
#nullable restore
#line 13 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
             if (Anuncios != null && Anuncios.Count > 0)
            {
                foreach (var item in Anuncios)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li style=\"width: 800px;height: 400px;\">\r\n                        <img");
            BeginWriteAttribute("alt", " alt=\"", 610, "\"", 616, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 617, "\"", 654, 2);
            WriteAttributeValue("", 623, "/Conteudo/Anuncios/", 623, 19, true);
#nullable restore
#line 18 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 642, item.Imagem, 642, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n                        <p class=\"flex-caption\">");
#nullable restore
#line 19 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
                                           Write(Html.Raw(item.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </li>\r\n");
#nullable restore
#line 21 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"box-section float-image-section triggerAnimation animated\" data-animate=\"rollIn\">\r\n    <p style=\"text-align: center;\">Marcas</p>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 30 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
         if (Marcas != null && Marcas.Count > 0)
        {
            foreach (var item in Marcas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-5\">\r\n                    <div class=\"image-box\">\r\n                        <img");
            BeginWriteAttribute("alt", " alt=\"", 1231, "\"", 1237, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1238, "\"", 1273, 2);
            WriteAttributeValue("", 1244, "/Conteudo/Marcas/", 1244, 17, true);
#nullable restore
#line 36 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1261, item.Imagem, 1261, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""row triggerAnimation animated"" data-animate=""bounceInLeft"">   
    <div class=""col-md-6"">
        <div class=""box-section skills-section"">
            <h2>Contagem dos dados</h2>
            <div class=""skills-progress"">
                <p>Anuncios <span>");
#nullable restore
#line 49 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
                             Write(Anuncios.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></p>\r\n                <div class=\"meter nostrips wp\">\r\n                    <span");
            BeginWriteAttribute("style", " style=\"", 1752, "\"", 1783, 3);
            WriteAttributeValue("", 1760, "width:", 1760, 6, true);
#nullable restore
#line 51 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1766, Anuncios.Count, 1767, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1782, "%", 1782, 1, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                </div>\r\n                <p>Marcas <span>");
#nullable restore
#line 53 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
                           Write(Marcas.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></p>\r\n                <div class=\"meter nostrips css\">\r\n                    <span");
            BeginWriteAttribute("style", " style=\"", 1952, "\"", 1981, 3);
            WriteAttributeValue("", 1960, "width:", 1960, 6, true);
#nullable restore
#line 55 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1966, Marcas.Count, 1967, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1980, "%", 1980, 1, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                </div>\r\n                <p>Modelos <span> ");
#nullable restore
#line 57 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
                             Write(Modelos.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></p>\r\n                <div class=\"meter nostrips html\">\r\n                    <span");
            BeginWriteAttribute("style", " style=\"", 2154, "\"", 2184, 3);
            WriteAttributeValue("", 2162, "width:", 2162, 6, true);
#nullable restore
#line 59 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2168, Modelos.Count, 2169, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2183, "%", 2183, 1, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
