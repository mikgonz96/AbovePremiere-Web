#pragma checksum "C:\Users\Miiku\Desktop\DV\4to Cuatrimestre\Plataformas de Desarrollo\AbovePremierWeb\AbovePremierWeb\Views\Home\Download.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a540bab0641bb3fe4edb6c58a81d76d5575a04d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Download), @"mvc.1.0.view", @"/Views/Home/Download.cshtml")]
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
#line 1 "C:\Users\Miiku\Desktop\DV\4to Cuatrimestre\Plataformas de Desarrollo\AbovePremierWeb\AbovePremierWeb\Views\_ViewImports.cshtml"
using AbovePremierWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Miiku\Desktop\DV\4to Cuatrimestre\Plataformas de Desarrollo\AbovePremierWeb\AbovePremierWeb\Views\_ViewImports.cshtml"
using AbovePremierWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a540bab0641bb3fe4edb6c58a81d76d5575a04d", @"/Views/Home/Download.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819d75058165ba53645893df0852a99a79a8914b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Download : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Instalador/AbovePremiere.rar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("download", new global::Microsoft.AspNetCore.Html.HtmlString("AbovePremiere.rar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Miiku\Desktop\DV\4to Cuatrimestre\Plataformas de Desarrollo\AbovePremierWeb\AbovePremierWeb\Views\Home\Download.cshtml"
  
    ViewData["Title"] = "Download";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Pricing Section -->\r\n    <div class=\"w3-container w3-center\" style=\"padding:128px 16px\">\r\n\r\n\r\n        <span class=\"w3-jumbo w3-text-white\">");
#nullable restore
#line 10 "C:\Users\Miiku\Desktop\DV\4to Cuatrimestre\Plataformas de Desarrollo\AbovePremierWeb\AbovePremierWeb\Views\Home\Download.cshtml"
                                        Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Descarga nuestro programa acá</span>
        
        <div class=""w3-center"">
            <div class=""w3-row-padding"" style=""margin-top:64px"">
                <div class=""w3-third"">
                    <br />
                </div>
                <div class=""w3-third"">
                    <ul class=""w3-ul w3-white w3-hover-shadow"">
                        <li class=""w3-pink w3-xlarge w3-padding-48"">Above Premier Desktop</li>
                        <li class=""w3-padding-16"">Peso <b>555 KB</b></li>

                        <li class=""w3-light-grey w3-padding-24"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a540bab0641bb3fe4edb6c58a81d76d5575a04d5356", async() => {
                WriteLiteral("<button class=\"w3-button w3-black w3-padding-large\">Descargar</button> ");
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
            WriteLiteral("\r\n</li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"w3-third\">\r\n                    <br />\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>");
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
