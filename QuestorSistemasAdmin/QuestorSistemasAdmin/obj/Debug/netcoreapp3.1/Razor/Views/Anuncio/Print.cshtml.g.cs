#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e204d4b302db8c28cc8bb899c8201d73391222e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncio_Print), @"mvc.1.0.view", @"/Views/Anuncio/Print.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
using QuestorSistemasAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e204d4b302db8c28cc8bb899c8201d73391222e1", @"/Views/Anuncio/Print.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e287e82abf8b3d39cd943b3451445c548dd8de", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Print : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Anuncio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sticky-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e204d4b302db8c28cc8bb899c8201d73391222e14073", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0\">\r\n    <title>");
#nullable restore
#line 11 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Administrativo</title>\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 340, "\"", 350, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <link rel=""shortcut icon"" href=""#"" type=""image/png"">

    <link href=""/js/iCheck/skins/minimal/minimal.css"" rel=""stylesheet"">
    <link href=""/js/iCheck/skins/square/square.css"" rel=""stylesheet"">
    <link href=""/js/iCheck/skins/square/red.css"" rel=""stylesheet"">
    <link href=""/js/iCheck/skins/square/blue.css"" rel=""stylesheet"">
    <link href=""/css/clndr.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""/js/morris-chart/morris.css"">
    <link href=""/css/style.css"" rel=""stylesheet"">
    <link href=""/css/style-responsive.css"" rel=""stylesheet"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e204d4b302db8c28cc8bb899c8201d73391222e16302", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"col-md-12\">\r\n        <div class=\"box box-warning\">\r\n            <div class=\"box-body\">\r\n                <div class=\"form-group\">\r\n                </div>\r\n                <table class=\"table table-bordered table-striped responsive\">\r\n");
#nullable restore
#line 32 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                     if (Model != null && Model.Count > 0)
                    {
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tbody>\r\n                                <tr>\r\n                                    <td width=\"200\">Marca</td>\r\n                                    <td>");
#nullable restore
#line 39 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                   Write(item.Marca);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <td width=\"200\">Modelo</td>\r\n                                    <td>");
#nullable restore
#line 44 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                   Write(Html.Raw(item.Modelo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                  
                                    int compra = Int32.Parse(@item.ValorCompra);
                                    int venda = Int32.Parse(@item.ValorVenda);
                                    var lucro = venda - compra;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <tr>\r\n                                    <td width=\"200\">Lucro</td>\r\n                                    <td> R$ ");
#nullable restore
#line 54 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                       Write(lucro);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <td width=\"200\">Cor</td>\r\n                                    <td> ");
#nullable restore
#line 59 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                    Write(item.Cor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n\r\n");
#nullable restore
#line 62 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                   
                                    var comb = @item.Combustível == "1" ? "Gasolina" : (@item.Combustível == "2" ? "Alcool" : "Gas");
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td width=\"200\">Combustivel</td>\r\n                                    <td> ");
#nullable restore
#line 67 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                    Write(comb);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <td width=\"200\">Final Placa</td>\r\n                                    <td> ");
#nullable restore
#line 72 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                    Write(item.FinalPlaca);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <td width=\"200\">Portas</td>\r\n                                    <td> ");
#nullable restore
#line 77 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                    Write(item.Portas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <td>Status</td>\r\n                                    <td>");
#nullable restore
#line 82 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                   Write(Html.Raw((item.Ativo) ? "Ativo" : "Inativo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Data de Cadastro</td>\r\n                                    <td>");
#nullable restore
#line 86 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                                   Write(item.DataVenda.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td></td>\r\n                                    <td></td>\r\n                                </tr>\r\n                            </tbody>\r\n");
#nullable restore
#line 93 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Anuncio\Print.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <script src=""/js/jquery-1.10.2.min.js""></script>
    <script src=""/js/jquery-ui-1.9.2.custom.min.js""></script>
    <script src=""/js/jquery-migrate-1.2.1.min.js""></script>
    <script src=""/js/bootstrap.min.js""></script>
    <script src=""/js/modernizr.min.js""></script>
    <script src=""/js/jquery.nicescroll.js""></script>
    <script src=""/js/scripts.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            window.print();
        });
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Anuncio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
