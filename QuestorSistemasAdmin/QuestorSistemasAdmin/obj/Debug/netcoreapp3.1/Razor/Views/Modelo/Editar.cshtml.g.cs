#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fac091f3144f93b0b7b6d9484034428a2a3ec12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Modelo_Editar), @"mvc.1.0.view", @"/Views/Modelo/Editar.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
using QuestorSistemasAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fac091f3144f93b0b7b6d9484034428a2a3ec12", @"/Views/Modelo/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e287e82abf8b3d39cd943b3451445c548dd8de", @"/Views/_ViewImports.cshtml")]
    public class Views_Modelo_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Modelo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
  
    ViewData["Title"] = "Editar Modelo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <section class=""panel"">
                <header class=""panel-heading"">
                    Editar Modelo
                    <span class=""tools pull-right"">
                        <a class=""fa fa-chevron-down"" href=""javascript:;""></a>
                        <a class=""fa fa-times"" href=""javascript:;""></a>
                    </span>
                </header>
                <div class=""panel-body"">
                    <div class=""form"">
");
#nullable restore
#line 20 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                         using (Html.BeginForm("Editar", "Modelo", FormMethod.Post, new { role = "form", enctype = "multipart/form-data", @class = "form-horizontal" }))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-group\">\r\n                                <div class=\"col-sm-12\">\r\n                                    ");
#nullable restore
#line 26 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                               Write(Html.LabelFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <select name=\"IdMarca\" id=\"IdMarca\" class=\"form-control\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fac091f3144f93b0b7b6d9484034428a2a3ec126079", async() => {
                WriteLiteral("Selecionar...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                                         foreach (var item in ViewBag.Marca)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fac091f3144f93b0b7b6d9484034428a2a3ec127664", async() => {
#nullable restore
#line 31 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                                                                   Write(item.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                                               WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </select>\r\n\r\n                                    <br />\r\n                                    ");
#nullable restore
#line 36 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                               Write(Html.LabelFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 37 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                               Write(Html.TextAreaFor(model => model.Nome, new { @class = "form-control ckeditor", Maxlength = "100", rows = "6" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 38 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    <br />\r\n                                    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 44 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasAdmin\QuestorSistemasAdmin\Views\Modelo\Editar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </section>
        </div>
    </div>
</div>

<script type=""text/javascript"" src=""/js/ckeditor/ckeditor.js""></script>
<script type=""text/javascript"" src=""/js/bootstrap-wysihtml5/wysihtml5-0.3.0.js""></script>
<script type=""text/javascript"" src=""/js/bootstrap-wysihtml5/bootstrap-wysihtml5.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('.wysihtml5').wysihtml5();
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Modelo> Html { get; private set; }
    }
}
#pragma warning restore 1591
