#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d13dea5dd81b5f789f340d61d6ce145d178bc1ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Modelo_Index), @"mvc.1.0.view", @"/Views/Modelo/Index.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
using QuestorSistemasAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d13dea5dd81b5f789f340d61d6ce145d178bc1ae", @"/Views/Modelo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e287e82abf8b3d39cd943b3451445c548dd8de", @"/Views/_ViewImports.cshtml")]
    public class Views_Modelo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Modelo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
  
    ViewData["Title"] = "Lista de Modelos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <section class=\"panel\">\r\n                    <header class=\"panel-heading\">\r\n                        Listagem de Modelos (");
#nullable restore
#line 12 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
                                        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")
                        <span class=""tools pull-right"">
                            <a href=""javascript:;"" class=""fa fa-chevron-down""></a>
                            <a href=""javascript:;"" class=""fa fa-times""></a>
                        </span>
                    </header>
                    <div class=""panel-body"">
                        <div class=""adv-table editable-table "">
                            <div class=""clearfix"">
                                <div class=""btn-group"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 896, "\"", 934, 1);
#nullable restore
#line 22 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
WriteAttributeValue("", 903, Url.Action("Create", "Modelo"), 903, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <button id=""editable-sample_new"" class=""btn btn-primary"">
                                            Cadastrar <i class=""fa fa-plus""></i>
                                        </button>
                                    </a>
                                </div>
                            </div>
                            <br />
                            <div class=""space15""></div>
                            <table class=""table table-striped table-hover table-bordered"" id=""editable-sample"">
                                <thead>
                                    <tr>
                                        <th>Modelos</th>
                                        <th>Data</th>
                                        <th>Detalhes</th>
                                        <th>Editar</th>
                                        <th>Deletar</th>
                                    </tr>
                                </thead>
          ");
            WriteLiteral("                      <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
                                     if (Model != null && Model.Count() > 0)
                                    {
                                        foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr");
            BeginWriteAttribute("class", " class=\"", 2266, "\"", 2274, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <td>");
#nullable restore
#line 47 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
                                               Write(Html.Raw(item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 48 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
                                               Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2511, "\"", 2573, 1);
#nullable restore
#line 49 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
WriteAttributeValue("", 2518, Url.Action("Detalhes", "Modelo", new { id = item.Id }), 2518, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalhes</a></td>\r\n                                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2648, "\"", 2708, 1);
#nullable restore
#line 50 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
WriteAttributeValue("", 2655, Url.Action("Editar", "Modelo", new { id = item.Id }), 2655, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                                                <td><a class=\"delete\"");
            BeginWriteAttribute("href", " href=\"", 2796, "\"", 2856, 1);
#nullable restore
#line 51 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
WriteAttributeValue("", 2803, Url.Action("Excluir", "Modelo", new { id = item.Id}), 2803, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Deletar</a></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Index.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Modelo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
