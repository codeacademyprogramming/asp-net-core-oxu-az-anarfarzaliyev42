#pragma checksum "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53aae8d38c8a97befa244c29411e1bc9395aebdf"
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
#line 1 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\_ViewImports.cshtml"
using NewsSiteCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\_ViewImports.cshtml"
using NewsSiteCoreApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53aae8d38c8a97befa244c29411e1bc9395aebdf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93043113f9b48239bd48a031a31458e7ab84990c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/slider.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/homeIndexScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "53aae8d38c8a97befa244c29411e1bc9395aebdf5098", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "53aae8d38c8a97befa244c29411e1bc9395aebdf6276", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""slider-container"">


    <div class=""slider"">
        <div class=""slider-arrow  slider-arrow_prev"">
            <i class=""fas fa-chevron-left slider-left-arrow""></i>
        </div>
        <div class=""slider-arrow slider-arrow_next"">   <i class=""fas fa-chevron-right slider-right-arrow""></i></div>

        <div class=""slider-content"">
");
#nullable restore
#line 19 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"slider-item\"");
            BeginWriteAttribute("href", " href=\"", 647, "\"", 676, 2);
            WriteAttributeValue("", 654, "/home/details/", 654, 14, true);
#nullable restore
#line 21 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 668, item.Id, 668, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("alt", " alt=\"", 704, "\"", 710, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                         class=\"slider-item-img\"");
            BeginWriteAttribute("src", "\r\n                         src=\'", 761, "\'", 839, 1);
#nullable restore
#line 24 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 793, Url.Content($"~/news-images/{item.FileName}"), 793, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"slider-item-content\">\r\n                        <div class=\"slider-item-meta-container\">\r\n                            <div class=\"slider-item-meta\">\r\n                                <span class=\"slider-item-date\"> ");
#nullable restore
#line 28 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                                           Write(item.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                                                          Write(item.Date.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"slider-item-time\">");
#nullable restore
#line 29 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                                          Write(item.Date.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"slider-item-views\">");
#nullable restore
#line 30 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                                           Write(item.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"slider-item-text\">\r\n                            <div class=\"slider-item-title\">\r\n                                ");
#nullable restore
#line 35 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"slider-item-description\"></div>\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 41 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<section class=\"news-list\">\r\n");
#nullable restore
#line 46 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
     foreach (var news in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"news-item\">\r\n            <a class=\"news-item-inner\"");
            BeginWriteAttribute("href", " href=\"", 1937, "\"", 1966, 2);
            WriteAttributeValue("", 1944, "/home/details/", 1944, 14, true);
#nullable restore
#line 49 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1958, news.Id, 1958, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"news-item-img-container\">\r\n                    <div class=\"news-item-img\"");
            BeginWriteAttribute("style", " style=\"", 2071, "\"", 2145, 4);
            WriteAttributeValue("", 2079, "background:", 2079, 11, true);
            WriteAttributeValue(" ", 2090, "url(\'", 2091, 6, true);
#nullable restore
#line 51 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2096, Url.Content($"~/news-images/{news.FileName}"), 2096, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2142, "\');", 2142, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n                <div class=\"news-item-content\">\r\n                    <div class=\"when\">\r\n                        <div class=\"when-date\">\r\n                            <div class=\"date-day\">");
#nullable restore
#line 56 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                             Write(news.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n                            <div class=\"date-month\">");
#nullable restore
#line 57 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                               Write(news.Date.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"date-year\">");
#nullable restore
#line 58 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                              Write(news.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"when-time\">");
#nullable restore
#line 60 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                          Write(news.Date.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"title\">\r\n                        ");
#nullable restore
#line 63 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                   Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"description\"></div>\r\n                </div>\r\n            </a>\r\n            <div class=\"stats\" data-id=\"");
#nullable restore
#line 68 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                   Write(news.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <div class=\"stats-item-container stats-like-active stats_likes\">\r\n                    <span class=\"stats-item\">");
#nullable restore
#line 70 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                        Write(news.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"stats-item-container stats-like-active stats_dislikes\">\r\n                    <span class=\"stats-item\">");
#nullable restore
#line 73 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                        Write(news.Dislikes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"stats-item-container stats_views\">\r\n                    <span class=\"stats-item\">");
#nullable restore
#line 76 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
                                        Write(news.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 80 "C:\Users\HP\Source\Repos\asp-net-core-oxu-az-anarfarzaliyev42\NewsSiteCoreApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53aae8d38c8a97befa244c29411e1bc9395aebdf17624", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
