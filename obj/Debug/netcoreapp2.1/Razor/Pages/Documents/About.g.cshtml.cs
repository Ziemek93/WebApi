#pragma checksum "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad74f445fa52fd0fcefabeae658a85d82a38782a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad74f445fa52fd0fcefabeae658a85d82a38782a", @"/Pages/Documents/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc86429f864e99f8d293e7e5b1723b7baef7a7e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Documents_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
  
    ViewData["Title"] = "About repositority";

#line default
#line hidden
            BeginContext(98, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(103, 17, false);
#line 6 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(120, 78, true);
            WriteLiteral("</h2>\n<div class=\"panel panel-default\">\n    <div class=\"panel-body\"><h4>Name: ");
            EndContext();
            BeginContext(199, 51, false);
#line 8 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
                                 Write(Html.DisplayFor(model => model.RepoDetails[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(250, 88, true);
            WriteLiteral("</h4></div>\n    <div class=\"panel-heading\">\n        <div class=\"panel-body\"><p>Created: ");
            EndContext();
            BeginContext(339, 57, false);
#line 10 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
                                       Write(Html.DisplayFor(model => model.RepoDetails[0].Created_at));

#line default
#line hidden
            EndContext();
            BeginContext(396, 57, true);
            WriteLiteral("</p></div>\n        <div class=\"panel-body\"><p>Last push: ");
            EndContext();
            BeginContext(454, 56, false);
#line 11 "C:\Users\Ziemowit\source\repos\WebApi\WebApi\Pages\Documents\About.cshtml"
                                         Write(Html.DisplayFor(model => model.RepoDetails[0].Pushed_at));

#line default
#line hidden
            EndContext();
            BeginContext(510, 29, true);
            WriteLiteral("</p></div>\n    </div>\n</div>\n");
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
