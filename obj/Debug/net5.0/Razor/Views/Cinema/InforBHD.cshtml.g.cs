#pragma checksum "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7caf762aa51eb80215cb37d8eaa4a4727832ccdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cinema_InforBHD), @"mvc.1.0.view", @"/Views/Cinema/InforBHD.cshtml")]
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
#line 1 "D:\gr1\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\gr1\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7caf762aa51eb80215cb37d8eaa4a4727832ccdc", @"/Views/Cinema/InforBHD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Cinema_InforBHD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.Cinema>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
  
    ViewData["Title"] = "BHD";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Movie List</h1>\r\n\r\n<table class=\"table\">\r\n        <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
           Write(Html.DisplayNameFor(model => model.Movies[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
           Write(Html.DisplayNameFor(model => model.Movies[0].ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
           Write(Html.DisplayNameFor(model => model.Movies[0].Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
           Write(Html.DisplayNameFor(model => model.Movies[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
           Write(Html.DisplayNameFor(model => model.Movies[0].Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
         foreach (var item in Model.Movies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 50 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
#nullable restore
#line 54 "D:\gr1\MvcMovie\Views\Cinema\InforBHD.cshtml"
Write(Html.ActionLink("Cinema List", "Index", "Cinema"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.Cinema> Html { get; private set; }
    }
}
#pragma warning restore 1591
