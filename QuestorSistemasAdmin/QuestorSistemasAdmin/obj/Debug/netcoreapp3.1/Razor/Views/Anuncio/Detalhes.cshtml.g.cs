#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "403dc8ec89275f756d5b32696c206d2e1299055e"
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\_ViewImports.cshtml"
using QuestorSistemasAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
using QuestorSistemasAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403dc8ec89275f756d5b32696c206d2e1299055e", @"/Views/Anuncio/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e287e82abf8b3d39cd943b3451445c548dd8de", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Anuncio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes" + @Model.Slug;
    int compra = Int32.Parse(@Model.ValorCompra);
    int venda = Int32.Parse(@Model.ValorVenda);
    var lucro =  venda - compra;

    var comb = @Model.Combustível == "1" ? "Gasolina" : (@Model.Combustível == "2" ? "Alcool" : "Gas");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""box box-warning"">            
            <div class=""box-body"">
                <div class=""form-group"">
                </div>
                <table class=""table table-bordered table-striped responsive"">
                    <tbody>
                        <tr>
                            <td width=""200"">Marca</td>
                            <td>");
#nullable restore
#line 21 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                           Write(Html.DisplayFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td width=\"200\">Modelo</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                           Write(Html.Raw(Model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td width=\"200\">Lucro</td>\r\n                            <td> R$ ");
#nullable restore
#line 31 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                               Write(lucro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td width=\"200\">Cor</td>\r\n                            <td> ");
#nullable restore
#line 36 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                            Write(Model.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td width=\"200\">Combustivel</td>\r\n                            <td> ");
#nullable restore
#line 41 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                            Write(comb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td width=\"200\">Final Placa</td>\r\n                            <td> ");
#nullable restore
#line 46 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                            Write(Model.FinalPlaca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td width=\"200\">Portas</td>\r\n                            <td> ");
#nullable restore
#line 51 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                            Write(Model.Portas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n");
#nullable restore
#line 54 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                         if (!string.IsNullOrEmpty(Model.Imagem))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>Imagem</td>\r\n                                <td><img");
            BeginWriteAttribute("src", " src=\"", 2090, "\"", 2128, 2);
            WriteAttributeValue("", 2096, "/Conteudo/Anuncios/", 2096, 19, true);
#nullable restore
#line 58 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
WriteAttributeValue("", 2115, Model.Imagem, 2115, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2129, "\"", 2150, 1);
#nullable restore
#line 58 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
WriteAttributeValue("", 2137, Model.Imagem, 2137, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <tr>\r\n                            <td>Status</td>\r\n                            <td>");
#nullable restore
#line 65 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                           Write(Html.Raw((Model.Ativo) ? "Ativo" : "Inativo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Data de Cadastro</td>\r\n                            <td>");
#nullable restore
#line 69 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
                           Write(Model.DataVenda.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        <div class=\"box-footer\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2735, "\"", 2801, 1);
#nullable restore
#line 76 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
WriteAttributeValue("", 2742, Url.Action("Editar", "Anuncio", new { Slug = Model.Slug }), 2742, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Editar</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2853, "\"", 2891, 1);
#nullable restore
#line 77 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Detalhes.cshtml"
WriteAttributeValue("", 2860, Url.Action("Index", "Anuncio"), 2860, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Voltar</a>\r\n        </div>\r\n    </div>\r\n</div>");
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
