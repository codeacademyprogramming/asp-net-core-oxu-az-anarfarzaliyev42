#pragma checksum "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0684e5a55fe2ba74c4fe080a3ffb05557cd449ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\_ViewImports.cshtml"
using NewsSiteCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\_ViewImports.cshtml"
using NewsSiteCoreApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0684e5a55fe2ba74c4fe080a3ffb05557cd449ab", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93043113f9b48239bd48a031a31458e7ab84990c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/news-details.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

    Layout = "_Layout";



#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0684e5a55fe2ba74c4fe080a3ffb05557cd449ab4354", async() => {
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
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("<div class=\"news-container\">\r\n    <div class=\"news\">\r\n        <div class=\"left-info\">\r\n        <div class=\"when\">\r\n            <div class=\"when-date\">\r\n                <div class=\"date-day\">");
#nullable restore
#line 19 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
                                 Write(Model.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</div>\r\n                <div class=\"date-month\">");
#nullable restore
#line 20 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
                                   Write(Model.Date.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"date-year\">");
#nullable restore
#line 21 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
                                  Write(Model.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"when-time\">");
#nullable restore
#line 23 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
                              Write(Model.Date.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"stats\" data-id=\"");
#nullable restore
#line 25 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
                               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <div class=\"stats-item-container stats_views\">\r\n                <span class=\"stats-item\">");
#nullable restore
#line 27 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
                                    Write(Model.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"stats-item-container stats-like-active stats_likes\">\r\n                <span class=\"stats-item\">");
#nullable restore
#line 30 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
                                    Write(Model.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"stats-item-container stats-like-active stats_dislikes\">\r\n                <span class=\"stats-item\">");
#nullable restore
#line 33 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
                                    Write(Model.Dislikes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        </div>\r\n        <img");
            BeginWriteAttribute("alt", " alt=\"", 1199, "\"", 1205, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n             class=\"news-img\"");
            BeginWriteAttribute("src", "\r\n             src=\"", 1237, "\"", 1304, 1);
#nullable restore
#line 39 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
WriteAttributeValue("", 1257, Url.Content($"~/news-images/{Model.FileName}"), 1257, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

        <div class=""banner"">
            <a href=""http://www.virtualkarabakh.az"">
                <img src=""https://cdn.oxu.az/assets/virtual_karabakh-605cf02fb76ac210bc1eb9ba1e93be46a88eec0da9461b289506a3f277f9c359.jpg"" alt=""Virtual karabakh"">
            </a>
        </div>
        <div class=""news-content"">
            <h1>“");
#nullable restore
#line 47 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("“</h1>\r\n            <p>\r\n                ");
#nullable restore
#line 49 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Home\Details.cshtml"
           Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p>&nbsp;</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
          
            var headerContainer = $("".header-container"");
            var sticky = $(headerContainer).offset().top;
            var leftInfo = $("".left-info"");
            var sticky2 = $(leftInfo).offset().top;
            $(window).scroll(function () {

                if ($(window).scrollTop() >sticky) {
                    $(headerContainer).addClass(""sticky"")
              
                } else if ($(window).scrollTop() == sticky) {
                    $(headerContainer).removeClass(""sticky"");
                    
                }
                if ($(window).scrollTop()+90>= sticky2) {
                    $(leftInfo).addClass(""sticky2"")
                } else {
                    $(leftInfo).removeClass(""sticky2"");
                }
            })
        })
    </script>
    

");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News> Html { get; private set; }
    }
}
#pragma warning restore 1591
