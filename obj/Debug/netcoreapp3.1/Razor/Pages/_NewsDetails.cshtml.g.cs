#pragma checksum "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\_NewsDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39449ab65d1f8c1caa65e3b786465db9db199f9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DguSite.Pages.Pages__NewsDetails), @"mvc.1.0.view", @"/Pages/_NewsDetails.cshtml")]
namespace DguSite.Pages
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
#line 1 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\_ViewImports.cshtml"
using DguSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\_ViewImports.cshtml"
using DguSite.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39449ab65d1f8c1caa65e3b786465db9db199f9f", @"/Pages/_NewsDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfce1eb4958b4a9329d12759f51c657c682ef7c", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages__NewsDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DguDomain.DataNews>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-5\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 88, "\"", 142, 2);
            WriteAttributeValue("", 94, "https://localhost:44325/Files/News/", 94, 35, true);
#nullable restore
#line 5 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\_NewsDetails.cshtml"
WriteAttributeValue("", 129, Model.Avatar, 129, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 8 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\_NewsDetails.cshtml"
   Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    </div>
</div>
<div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <img class=""d-block w-100"" src=""..."" alt=""First slide"">
        </div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""..."" alt=""Second slide"">
        </div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""..."" alt=""Third slide"">
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DguDomain.DataNews> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
