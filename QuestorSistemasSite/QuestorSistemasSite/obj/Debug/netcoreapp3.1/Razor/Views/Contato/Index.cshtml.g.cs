#pragma checksum "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87bdd07973768f3d5833e60881c6955a092c3433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Contato\Index.cshtml"
using QuestorSistemasSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bdd07973768f3d5833e60881c6955a092c3433", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf42bea604fb765d805f3d0d4c27881f721f61ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contato>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Contato\Index.cshtml"
  
    ViewData["Title"] = "Fale Conosco";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"box-section contact-section triggerAnimation animated\" data-animate=\"flipInY\">\r\n    <h2>Contact us</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87bdd07973768f3d5833e60881c6955a092c34334802", async() => {
                WriteLiteral(@"
        <div class=""text-fields"">
            <div class=""float-input"">
                <input name=""Nome"" id=""name"" type=""text"" placeholder=""Name"">
                <span><i class=""fa fa-user""></i></span>
                <span id=""Error1""></span>
            </div>
            <div class=""float-input"">
                <input name=""Email"" id=""email"" type=""text"" placeholder=""e-mail"">
                <span><i class=""fa fa-envelope-o""></i></span>
                <span id=""Error2""></span>
            </div>
            <div class=""float-input"">
                <input name=""website"" id=""website"" type=""text"" placeholder=""website"" disabled=""disabled"">
                <span><i class=""fa fa-link""></i></span>
            </div>
        </div>
        <div class=""comment-area"">
            <textarea name=""Descricao"" id=""comment"" placeholder=""Message""></textarea>
        </div>
        <div class=""submit-area"">
            <button type=""submit"" name=""contact-submit"" id=""submit"">
                <i c");
                WriteLiteral("lass=\"fa fa-envelope-o\"></i>\r\n                Send Message\r\n            </button>\r\n        </div>\r\n        <div id=\"msg\" class=\"message\"></div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script type=""text/javascript"">
    $('#contact-form').submit(function (e) {
        $('#submit').prop(""disabled"", true);
        e.preventDefault();
        e.returnValue = false;        

            var erro = 0;
            $('#Error1, #Error2').css('display', 'none');

            var nome = $('#Nome').val();
            var email = $('#Email').val();
            var descricao = $('#Descricao').val();

            if (nome == """") {
                $('#submit').prop(""disabled"", false);
                $('#Error1').html('Preencha o Nome');
                $('#Error1').css('display', 'block');
                erro++;
            }

            if (email == """") {
                $('#submit').prop(""disabled"", false);
                $('#Error2').html('Preencha o E-mail');
                $('#Error2').css('display', 'block');
                erro++;
            }

            if (erro > 0) {
                return false;
            }

            $.ajax({
          ");
            WriteLiteral("          url: \'");
#nullable restore
#line 71 "C:\Users\JuninhoDRZ\source\ProjetoQuestorSistemas\ProjetoQuestorSistemas\QuestorSistemasSite\QuestorSistemasSite\Views\Contato\Index.cshtml"
                     Write(Url.Action("Index", "Contato"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    type: 'Post',
                    dataType: 'json',
                    data: { Nome: nome, Email: email, Descricao: descricao},
                    success: function (result) {
                        if (result != null) {
                            swal(""Cadastrado!"", ""Seu cadastro foi realizado com sucesso!"", ""success"");
                            //location.reload();
                        }
                        else {
                            swal(""Falha ao Cadastrar!"", ""Confira novamente os campos!"", ""error"");
                            console.log(model);
                        }
                    },
                    error: function (result) {
                        swal(""Falha ao Cadastrar!"", ""Confira novamente os campos!"", ""error"");
                        console.log(model);
                    }
                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contato> Html { get; private set; }
    }
}
#pragma warning restore 1591
