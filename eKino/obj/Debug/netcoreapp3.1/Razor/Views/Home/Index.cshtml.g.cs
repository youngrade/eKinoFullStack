#pragma checksum "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9065da7cb70b89c4478b030e03665fe080e0789"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9065da7cb70b89c4478b030e03665fe080e0789", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6389742b6eb56452126cf8f2709477a138e9e00", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"komponente\">\r\n    <div id=\"navigacija\">\r\n        <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n            <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 10 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                 for (int i = 0; i < Model.Vijesti.Count; i++)
                {
                    if (i == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 14 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 15 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 18 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 19 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ol>\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 23 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                 for (int i = 0; i < Model.Vijesti.Count; i++)
                {
                    if (i == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"carousel-item active\"");
            BeginWriteAttribute("href", " href=\"", 964, "\"", 1008, 2);
            WriteAttributeValue("", 971, "/Home/Vijesti?ID=", 971, 17, true);
#nullable restore
#line 27 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
WriteAttributeValue("", 988, Model.Vijesti[i].ID, 988, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1066, "\"", 1098, 1);
#nullable restore
#line 28 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
WriteAttributeValue("", 1072, Model.Vijesti[i].SlikaUrl, 1072, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n                            <div class=\"carousel-caption d-none d-md-block vijest-link\">");
#nullable restore
#line 29 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                                                                                   Write(Model.Vijesti[i].Naslov);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </a>\r\n");
#nullable restore
#line 31 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"carousel-item\"");
            BeginWriteAttribute("href", "  href=\"", 1390, "\"", 1435, 2);
            WriteAttributeValue("", 1398, "/Home/Vijesti?ID=", 1398, 17, true);
#nullable restore
#line 34 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
WriteAttributeValue("", 1415, Model.Vijesti[i].ID, 1415, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1493, "\"", 1525, 1);
#nullable restore
#line 35 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
WriteAttributeValue("", 1499, Model.Vijesti[i].SlikaUrl, 1499, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n                            <div class=\"carousel-caption d-none d-md-block vijest-link\">");
#nullable restore
#line 36 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                                                                                   Write(Model.Vijesti[i].Naslov);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </a>\r\n");
#nullable restore
#line 38 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only""></span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only""></span>
            </a>
        </div>

    </div>
    <div class=""pregled-ponude"">
        <div class=""pregled-ponude-dani"">
");
#nullable restore
#line 55 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
             foreach (var p in Model.Dani)
            {
                if (p.Value == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"dan\" id=\"dan-active\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2553, "\"", 2585, 3);
            WriteAttributeValue("", 2563, "ucitajPonudu(", 2563, 13, true);
#nullable restore
#line 59 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
WriteAttributeValue("", 2576, p.Value, 2576, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2584, ")", 2584, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"color:#f4eade\">");
#nullable restore
#line 59 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                                                                                                     Write(p.DanUSedmici);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 60 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"dan\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2723, "\"", 2755, 3);
            WriteAttributeValue("", 2733, "ucitajPonudu(", 2733, 13, true);
#nullable restore
#line 63 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
WriteAttributeValue("", 2746, p.Value, 2746, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2754, ")", 2754, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"color:#f4eade\">");
#nullable restore
#line 63 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                                                                                     Write(p.DanUSedmici);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 64 "D:\0FIT\RS1\eKino\eKino\Views\Home\Index.cshtml"
                }
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div id=""filmovi-lista"">
        </div>
    </div>
</div>

<script>
    ucitajPonudu(0);

    //Funkcije za ajax brisanje i ucitavanje
    function ucitajPonudu(dan) {
        let url = ""/Ponuda/Prikaz?dan="" + dan;
        $.get(url, function (data) {
            $(""#filmovi-lista"").html(data);
        });
    }



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
