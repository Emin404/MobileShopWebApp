#pragma checksum "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c71249b268814bd460fbbb12a60399bde0db12c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NabavkaStavke_Index), @"mvc.1.0.view", @"/Views/NabavkaStavke/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NabavkaStavke/Index.cshtml", typeof(AspNetCore.Views_NabavkaStavke_Index))]
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
#line 1 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
using NoviProjekat.Web.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c71249b268814bd460fbbb12a60399bde0db12c", @"/Views/NabavkaStavke/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64bea66b5b10d5dcb2e9880e52115b00d6e674d4", @"/Views/_ViewImports.cshtml")]
    public class Views_NabavkaStavke_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NabavkaStavkeIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(108, 262, true);
            WriteLiteral(@"
<h2>Spisak artikala</h2>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Artikal</th>
            <th>Kolicina</th>
            <th>UkupnaCijena</th>
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
         foreach (var x in Model.rows)
        {

#line default
#line hidden
            BeginContext(421, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(460, 9, false);
#line 23 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
               Write(x.Artikal);

#line default
#line hidden
            EndContext();
            BeginContext(469, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(497, 10, false);
#line 24 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
               Write(x.Kolicina);

#line default
#line hidden
            EndContext();
            BeginContext(507, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(535, 14, false);
#line 25 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
               Write(x.UkupnaCijena);

#line default
#line hidden
            EndContext();
            BeginContext(549, 79, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 628, "\"", 649, 2);
            WriteAttributeValue("", 633, "dugmeBrisi-", 633, 11, true);
#line 27 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
WriteAttributeValue("", 644, x.Id, 644, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(650, 87, true);
            WriteLiteral(">Obrisi</button>\r\n                    <script>\r\n                        $(\"#dugmeBrisi-");
            EndContext();
            BeginContext(738, 4, false);
#line 29 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
                                  Write(x.Id);

#line default
#line hidden
            EndContext();
            BeginContext(742, 91, true);
            WriteLiteral("\").click(function (event) {\r\n\r\n                            $.get(\"/NabavkaStavke/Obrisi?Id=");
            EndContext();
            BeginContext(834, 4, false);
#line 31 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
                                                       Write(x.Id);

#line default
#line hidden
            EndContext();
            BeginContext(838, 281, true);
            WriteLiteral(@"""
                                , function (rezultat, status) {
                                    $(""#neki"").html(rezultat);
                                })
                        });

                    </script>
                    <button class=""btn btn-warning""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1119, "\"", 1140, 2);
            WriteAttributeValue("", 1124, "dugmeUredi-", 1124, 11, true);
#line 38 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
WriteAttributeValue("", 1135, x.Id, 1135, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1141, 88, true);
            WriteLiteral(">Uredi</button>\r\n                    <script>\r\n\r\n                        $(\"#dugmeUredi-");
            EndContext();
            BeginContext(1230, 4, false);
#line 41 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
                                  Write(x.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 90, true);
            WriteLiteral("\").click(function (event) {\r\n\r\n                            $.get(\"/NabavkaStavke/Uredi?Id=");
            EndContext();
            BeginContext(1325, 4, false);
#line 43 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
                                                      Write(x.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 270, true);
            WriteLiteral(@"""
                                , function (rezultat, status) {
                                    $(""#neki"").html(rezultat);
                                })
                        });
                    </script>
                </td>
            </tr>
");
            EndContext();
#line 51 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1610, 193, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<button id=\"ButtonId\" class=\"btn btn-primary\">Dodaj</button>\r\n<script>\r\n\r\n    $(\"#ButtonId\").click(function (event) {\r\n\r\n        $.get(\"/NabavkaStavke/Dodaj?NabavkaId=");
            EndContext();
            BeginContext(1804, 15, false);
#line 60 "C:\Users\hasic_000\Desktop\NoviProjekat - Copy\NoviProjekat.Web\Views\NabavkaStavke\Index.cshtml"
                                         Write(Model.NabavkaId);

#line default
#line hidden
            EndContext();
            BeginContext(1819, 132, true);
            WriteLiteral("\"\r\n            , function (rezultat, status) {\r\n                $(\"#neki\").html(rezultat);\r\n            })\r\n    });\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NabavkaStavkeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
