#pragma checksum "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57b88cc5fb0fe73dcb4fb17080f70bde8645405a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Filmovi_Prikaz), @"mvc.1.0.view", @"/Views/Filmovi/Prikaz.cshtml")]
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
#line 1 "D:\0FIT\RS1\eKino\eKino\Views\_ViewImports.cshtml"
using eKino;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\0FIT\RS1\eKino\eKino\Views\_ViewImports.cshtml"
using eKino.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b88cc5fb0fe73dcb4fb17080f70bde8645405a", @"/Views/Filmovi/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6389742b6eb56452126cf8f2709477a138e9e00", @"/Views/_ViewImports.cshtml")]
    public class Views_Filmovi_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmoviPrikazVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
  
    ViewData["Title"] = "Svi filmovi";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"filmovi-container\">\r\n");
#nullable restore
#line 8 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
     foreach (var f in Model.Filmovi)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"film-prikaz\">\r\n            <div class=\"film-naslov\">\r\n                <h1>");
#nullable restore
#line 12 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
               Write(f.FilmIme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1> \r\n                <p style=\"font-size: 25px\">(");
#nullable restore
#line 13 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
                                       Write(f.Godina);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n            </div>\r\n            <div class=\"film-podnaslov\">\r\n                <p>Trajanje: ");
#nullable restore
#line 16 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
                        Write(f.Trajanje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Žanr: ");
#nullable restore
#line 17 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
                    Write(f.Zanr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div .class=\"film-prikaz-gore\">\r\n                <div><img");
            BeginWriteAttribute("src", " src=\"", 590, "\"", 607, 1);
#nullable restore
#line 20 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
WriteAttributeValue("", 596, f.SlikaURL, 596, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></div>\r\n                <div><iframe");
            BeginWriteAttribute("src", " src=\"", 646, "\"", 665, 1);
#nullable restore
#line 21 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
WriteAttributeValue("", 652, f.TrailerURL, 652, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></iframe></div>\r\n            </div>\r\n            <div .class=\"film-prikaz-dolje\">\r\n                <div>\r\n                    <p>Reditelj: ");
#nullable restore
#line 25 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
                            Write(f.Reditelj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Glumci: ");
#nullable restore
#line 26 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
                          Write(f.Glumci);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div>\r\n                    <h4>");
#nullable restore
#line 29 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
                   Write(f.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n            </div>\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1035, "\"", 1069, 2);
            WriteAttributeValue("", 1042, "/Filmovi/Dodaj?ID=", 1042, 18, true);
#nullable restore
#line 33 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
WriteAttributeValue("", 1060, f.FilmID, 1060, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1100, "\"", 1135, 2);
            WriteAttributeValue("", 1107, "/Filmovi/Obrisi?ID=", 1107, 19, true);
#nullable restore
#line 34 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
WriteAttributeValue("", 1126, f.FilmID, 1126, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Obriši</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "D:\0FIT\RS1\eKino\eKino\Views\Filmovi\Prikaz.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmoviPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591