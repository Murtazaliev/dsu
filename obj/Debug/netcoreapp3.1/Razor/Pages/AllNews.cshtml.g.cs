#pragma checksum "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "571ac6d2db919e46c9d4885290a2a88be272c3a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DguSite.Pages.Pages_AllNews), @"mvc.1.0.razor-page", @"/Pages/AllNews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571ac6d2db919e46c9d4885290a2a88be272c3a2", @"/Pages/AllNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfce1eb4958b4a9329d12759f51c657c682ef7c", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_AllNews : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-tag-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
  
    ViewData["isForeign"] = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container news-all\" style=\"margin-top:225px;\">\r\n   <h1>");
#nullable restore
#line 7 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
   Write(Model.SearchTag == null ? "Новости" : $"Новости по теме: {Model.SearchTag}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n   <table class=\"table\">\r\n");
#nullable restore
#line 9 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
         foreach (var item in Model.News.ToList())
        {  

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n                   <td>\r\n                       <div class=\"row p-2\">\r\n                           <div class=\"col-3\">\r\n                               <img");
            BeginWriteAttribute("src", " src=\"", 499, "\"", 517, 1);
#nullable restore
#line 15 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
WriteAttributeValue("", 505, item.Avatar, 505, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top"" alt=""..."">
                           </div>
                           <div class=""col-9"">
                               <div class=""card-body text-left news-main"">
                                   <p class=""card-text news-main""><small class=""text-muted"">");
#nullable restore
#line 19 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                                                                                       Write(item.DateAdd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                                   <a");
            BeginWriteAttribute("href", " href=\"", 867, "\"", 901, 2);
            WriteAttributeValue("", 874, "/NewsDetail?newsId=", 874, 19, true);
#nullable restore
#line 20 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
WriteAttributeValue("", 893, item.Id, 893, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                       <h5 class=\"card-title font-news text-darkblue text-uppercase\">");
#nullable restore
#line 21 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                                                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>                                    \r\n                                   </a>\r\n                                   <div class=\"card-annotation card-annotation--all-news font-news\">");
#nullable restore
#line 23 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                                                                                               Write(Html.Raw(@item.Annotation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                   <ul class=\"card-tags\">\r\n");
#nullable restore
#line 25 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                                         foreach (var tag in item.Tags)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"card-tag\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571ac6d2db919e46c9d4885290a2a88be272c3a27841", async() => {
                WriteLiteral("\r\n                                                    ");
#nullable restore
#line 29 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                                               Write(tag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1535, "~/AllNews?pageNumber=1&nt=1&tag=", 1535, 32, true);
#nullable restore
#line 28 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
AddHtmlAttributeValue("", 1567, tag.Name, 1567, 9, false);

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
            WriteLiteral("\r\n                                            </li>\r\n");
#nullable restore
#line 32 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                               </div>\r\n                           </div>\r\n                       </div>\r\n                   </td>\r\n               </tr>\r\n");
#nullable restore
#line 39 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </table>\r\n   <nav aria-label=\"...\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 43 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
             for (var x = 0; x < Model.CountPages-1; x++)
            {
                int pageNumber = x + 1;
                if (pageNumber == Model.CurrentPage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571ac6d2db919e46c9d4885290a2a88be272c3a211015", async() => {
#nullable restore
#line 48 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                                                                                                                                 Write(pageNumber);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2361, "~/AllNews?pageNumber=", 2361, 21, true);
#nullable restore
#line 48 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
AddHtmlAttributeValue("", 2382, pageNumber, 2382, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2393, "&nt=", 2393, 4, true);
#nullable restore
#line 48 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
AddHtmlAttributeValue("", 2397, Model.NType, 2397, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 49 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571ac6d2db919e46c9d4885290a2a88be272c3a213481", async() => {
#nullable restore
#line 52 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                                                                                                                          Write(pageNumber);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2570, "~/AllNews?pageNumber=", 2570, 21, true);
#nullable restore
#line 52 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
AddHtmlAttributeValue("", 2591, pageNumber, 2591, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2602, "&nt=", 2602, 4, true);
#nullable restore
#line 52 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
AddHtmlAttributeValue("", 2606, Model.NType, 2606, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 53 "C:\Users\User\Documents\Проекты\DguAdmin (2)\dsu.ru\Pages\AllNews.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n</nav>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DguSite.Pages.AllNewsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DguSite.Pages.AllNewsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DguSite.Pages.AllNewsModel>)PageContext?.ViewData;
        public DguSite.Pages.AllNewsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
