#pragma checksum "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b5bad4ddf0a84fe6f6dcbb28a70ce5810a83ad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Vijesti), @"mvc.1.0.view", @"/Views/Home/Vijesti.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5bad4ddf0a84fe6f6dcbb28a70ce5810a83ad3", @"/Views/Home/Vijesti.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6389742b6eb56452126cf8f2709477a138e9e00", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vijesti : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VijestiPrikazVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"sve\">\r\n");
#nullable restore
#line 7 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
     foreach (var v in Model.Vijesti)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"vijest-container\">\r\n        <div>\r\n            <div><h2><a");
            BeginWriteAttribute("href", " href=\"", 197, "\"", 226, 2);
            WriteAttributeValue("", 204, "/Home/Vijesti?ID=", 204, 17, true);
#nullable restore
#line 11 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
WriteAttributeValue("", 221, v.ID, 221, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
                                                 Write(v.Naslov);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2></div>\r\n            <div><b>Napisao: </b>");
#nullable restore
#line 12 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
                            Write(v.Korisnik);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 12 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
                                         Write(v.Datum.ToString("d.M.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(". u ");
#nullable restore
#line 12 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
                                                                          Write(v.Datum.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" sati</div>\r\n        </div>\r\n        <div>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 419, "\"", 436, 1);
#nullable restore
#line 15 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
WriteAttributeValue("", 425, v.SlikaUrl, 425, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 300px\" />\r\n        </div>\r\n");
#nullable restore
#line 17 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
         if (Model.Vijesti.Count == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <p>");
#nullable restore
#line 20 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
              Write(v.Sadrzaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 22 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 24 "D:\0FIT\RS1\eKino\eKino\Views\Home\Vijesti.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VijestiPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
