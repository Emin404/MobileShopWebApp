#pragma checksum "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "683f8705c01afbecd2f33e405310da8b441b8437"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ObavijestProdavac_Uredi), @"mvc.1.0.view", @"/Views/ObavijestProdavac/Uredi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ObavijestProdavac/Uredi.cshtml", typeof(AspNetCore.Views_ObavijestProdavac_Uredi))]
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
#line 1 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\_ViewImports.cshtml"
using NoviProjekat.Web;

#line default
#line hidden
#line 2 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml"
using NoviProjekat.Web.ViewModels;

#line default
#line hidden
#line 1 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml"
using NoviProjekat.Data.EntityModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"683f8705c01afbecd2f33e405310da8b441b8437", @"/Views/ObavijestProdavac/Uredi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64bea66b5b10d5dcb2e9880e52115b00d6e674d4", @"/Views/_ViewImports.cshtml")]
    public class Views_ObavijestProdavac_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Obavijest/Snimi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml"
  
    ViewData["Title"] = "Uredi";
    ObavijestDodajVM model = ViewData["podaci"] as ObavijestDodajVM;
    ObavijestProdavac o1 = ViewData["obavijest"] as ObavijestProdavac;

#line default
#line hidden
            BeginContext(258, 20, true);
            WriteLiteral("\r\n<h2>Uredi</h2>\r\n\r\n");
            EndContext();
            BeginContext(278, 729, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa21512cdb7f40d197e1fcc167f00b5c", async() => {
                BeginContext(310, 74, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        <input type=\"hidden\" name=\"Id\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 384, "\"", 398, 1);
#line 14 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml"
WriteAttributeValue("", 392, o1.Id, 392, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(399, 158, true);
                WriteLiteral(" />\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Opis: </label>\r\n        <div>\r\n            <input type=\"text\" name=\"Opis\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 557, "\"", 573, 1);
#line 20 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml"
WriteAttributeValue("", 565, o1.Opis, 565, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(574, 177, true);
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label>Prodavac : </label>\r\n        <div>\r\n            <select name=\"ProdavacId\" class=\"form-control\">\r\n");
                EndContext();
#line 28 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml"
                 foreach (var x in model.prodavac)
                {

#line default
#line hidden
                BeginContext(822, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(842, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7037881787947bbb893fd29647dde9f", async() => {
                    BeginContext(868, 6, false);
#line 30 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml"
                                        Write(x.Text);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 30 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml"
                       WriteLiteral(x.Value);

#line default
#line hidden
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
                EndContext();
                BeginContext(883, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\ObavijestProdavac\Uredi.cshtml"
                }

#line default
#line hidden
                BeginContext(904, 96, true);
                WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n\r\n    <input type=\"submit\" value=\"Snimi\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
