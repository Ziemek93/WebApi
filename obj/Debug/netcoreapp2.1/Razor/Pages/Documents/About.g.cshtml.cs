#pragma checksum "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c87124cbdfcaa1e5a31dc82b35c4915cc84fe1e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApi.Pages.Documents.Pages_Documents_About), @"mvc.1.0.razor-page", @"/Pages/Documents/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Documents/About.cshtml", typeof(WebApi.Pages.Documents.Pages_Documents_About), null)]
namespace WebApi.Pages.Documents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\_ViewImports.cshtml"
using WebApi;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c87124cbdfcaa1e5a31dc82b35c4915cc84fe1e9", @"/Pages/Documents/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc86429f864e99f8d293e7e5b1723b7baef7a7e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Documents_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(85, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(90, 17, false);
#line 6 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(107, 136, true);
            WriteLiteral("</h2>\n<p>Use this area to provide additional information.</p>\n<div class=\"panel panel-default\">\n    <div class=\"panel-heading\">\n        ");
            EndContext();
            BeginContext(244, 60, false);
#line 10 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
   Write(Html.DisplayNameFor(model => model.RepoDetails[1].Pushed_at));

#line default
#line hidden
            EndContext();
            BeginContext(304, 120, true);
            WriteLiteral("\n    </div>\n    <div class=\"panel-body\">Created: 312123123</div>\n    <div class=\"panel-body\">Last push: 231231231</div>\n");
            EndContext();
#line 14 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
     if (Model.RepoDetails.FirstOrNull() != null)
    {
        foreach (var item in Model.RepoDetails)
        {

#line default
#line hidden
            BeginContext(538, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(597, 45, false);
#line 20 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
               Write(Html.DisplayFor(modelItem => item.Created_at));

#line default
#line hidden
            EndContext();
            BeginContext(642, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(707, 44, false);
#line 23 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pushed_at));

#line default
#line hidden
            EndContext();
            BeginContext(751, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 26 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"

        }

    }

#line default
#line hidden
            BeginContext(810, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApi.Pages.Documents.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApi.Pages.Documents.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApi.Pages.Documents.AboutModel>)PageContext?.ViewData;
        public WebApi.Pages.Documents.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591