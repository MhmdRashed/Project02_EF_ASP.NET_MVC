#pragma checksum "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e7ad90a1e93bb69fdce3992cb4dd133de79c2db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Search), @"mvc.1.0.view", @"/Views/Games/Search.cshtml")]
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
#line 1 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\_ViewImports.cshtml"
using PlayerReview;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\_ViewImports.cshtml"
using PlayerReview.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7ad90a1e93bb69fdce3992cb4dd133de79c2db", @"/Views/Games/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03bb7a3be957112645a1110b35d51fd795051c70", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Search.cshtml"
  
    Layout = "_myLayout";

    var searchRes = (List<Game>)ViewData["searchRes"];
    var target = (string)ViewData["target"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<h1>SEARCH RESULTS FOR: ");
#nullable restore
#line 10 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Search.cshtml"
                   Write(target);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n<hr />\r\n\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Search.cshtml"
     foreach (var game in searchRes)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 mb-5\">\r\n\r\n            <div class=\"card bg-light text-dark\">\r\n\r\n                <img");
            BeginWriteAttribute("src", " src=", 381, "", 397, 1);
#nullable restore
#line 23 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Search.cshtml"
WriteAttributeValue("", 386, game.Image, 386, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                     class=\"card-img-top p-1\"\r\n                     alt=\"game image\"\r\n                     width=\"200px\"\r\n                     height=\"250px\" />\r\n\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 30 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Search.cshtml"
                                      Write(game.GameName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <div class=\"text-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 741, "\"", 771, 2);
            WriteAttributeValue("", 748, "/games/details/", 748, 15, true);
#nullable restore
#line 32 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Search.cshtml"
WriteAttributeValue("", 763, game.Id, 763, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary \">\r\n                            More INFO\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Search.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591