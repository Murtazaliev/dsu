#pragma checksum "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91964d59d80696bd48146e3fe0cfdc0df67d2995"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DguSite.Pages.Pages_NewsDetail), @"mvc.1.0.razor-page", @"/Pages/NewsDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91964d59d80696bd48146e3fe0cfdc0df67d2995", @"/Pages/NewsDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfce1eb4958b4a9329d12759f51c657c682ef7c", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_NewsDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-tag-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
  
    ViewData["isForeign"] = false;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row news-content"" style=""margin:225px 25px 0 25px; "">
            <div class=""col-7"" style=""max-height:360px; display:table;    background-image: linear-gradient(to right, rgb(217 217 217 / 0%), rgb(22 71 108));"">

                <div style=""background-color:#16476c;display:table-caption;"" class=""p-2 text-white-50"">
                <strong>");
#nullable restore
#line 11 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
                   Write(Model.DataNewsDetail.DateAdd.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </div>\r\n\r\n\r\n                <h1 class=\"text-uppercase\" style=\"display: table-cell; vertical-align: middle;\">");
#nullable restore
#line 15 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
                                                                                           Write(Html.Raw(Model.DataNewsDetail?.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n            </div>\r\n            <div class=\"col-5\" style=\"max-height:360px;background-color: #16476c;display:table; padding:0px 0;\">\r\n");
#nullable restore
#line 19 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
             if (Model.DataNewsDetail?.DataNewsSliders?.Count() > 0)
            {
                int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\" style=\"max-height: 360px;display:table-row; vertical-align:central;\">\r\n                    <div class=\"carousel-inner\" style=\"display:table;\">\r\n");
#nullable restore
#line 24 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
                         foreach (var item in Model.DataNewsDetail.DataNewsSliders)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 1355, "\"", 1406, 2);
            WriteAttributeValue("", 1363, "carousel-item", 1363, 13, true);
#nullable restore
#line 26 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
WriteAttributeValue(" ", 1376, index == 0 ? "active" : "", 1377, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1472, "\"", 1489, 1);
#nullable restore
#line 27 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
WriteAttributeValue("", 1478, item.Image, 1478, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\" style=\"max-height: 360px;\">\r\n                                </div>\r\n");
#nullable restore
#line 29 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
                            index++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Пред</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">След</span>
                    </a>
                </div>
");
#nullable restore
#line 41 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 2379, "\"", 2413, 1);
#nullable restore
#line 44 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
WriteAttributeValue("", 2385, Model.DataNewsDetail.Avatar, 2385, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height: 360px;\">\r\n");
#nullable restore
#line 45 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n<div class=\"col-12 mt-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
       Write(Html.Raw(Model.DataNewsDetail?.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
             if (Model.Tags.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <span>Темы: </span>\r\n                    <ul class=\"card-tags\">\r\n");
#nullable restore
#line 55 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
                         foreach (var tag in Model.Tags)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"card-tag\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91964d59d80696bd48146e3fe0cfdc0df67d29959883", async() => {
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 59 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
                               Write(tag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2891, "~/AllNews?pageNumber=1&nt=1&tag=", 2891, 32, true);
#nullable restore
#line 58 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
AddHtmlAttributeValue("", 2923, tag.Name, 2923, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 62 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div> \r\n");
#nullable restore
#line 65 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\NewsDetail.cshtml"
             }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n   </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DguSite.Pages.NewsDetailModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DguSite.Pages.NewsDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DguSite.Pages.NewsDetailModel>)PageContext?.ViewData;
        public DguSite.Pages.NewsDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591