#pragma checksum "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e6e5623c1ee31a074d31c2a70b45aa05679f36c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6e5623c1ee31a074d31c2a70b45aa05679f36c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93043113f9b48239bd48a031a31458e7ab84990c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/header.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e6e5623c1ee31a074d31c2a70b45aa05679f36c5343", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.14.0/css/all.css"" integrity=""sha384-HzLeBuhoNPvSl5KYnjx0BT+WB0QEEqLprO+NBkkk5gbc67FTaL7XIGa2w1L0Xbgc"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e6e5623c1ee31a074d31c2a70b45aa05679f36c5927", async() => {
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
#nullable restore
#line 8 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Shared\_Layout.cshtml"
Write(RenderSection("styles", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <title>Oxu az</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e6e5623c1ee31a074d31c2a70b45aa05679f36c8096", async() => {
                WriteLiteral(@"
    <header class=""header"">

        <div class=""header-container"">
            <div class=""wrapper"">
                <a class=""logo logo-oxu"" href=""/"">oxu.az</a>
                
                
                <div class=""header-side"">
              
                    <a class=""oxu-link"" href=""/pages/about"">Haqqımızda</a>
                    <a class=""oxu-link"" href=""/pages/advertise"">Reklam</a>
                    <div class=""social-logos"">
                        <a class=""social-logos-item social-logos-item_facebook""
                           href=""//facebook.com/421309791269484"">Facebook</a>
                        <a class=""social-logos-item social-logos-item_twitter""
                           href=""//twitter.com/oxuaz"">Twitter</a>
                        <a class=""social-logos-item social-logos-item_android""
                           href=""https://play.google.com/store/apps/details?id=az.start.android.oxu""><i class=""fab fa-android""></i></a>
                        <a class=""s");
                WriteLiteral(@"ocial-logos-item social-logos-item_ios""
                           href=""https://itunes.apple.com/app/id634362981"">iOS App</a>
                    </div>
                    <div class=""search-toggle"" title=""Axtarış""></div>
                    <div class=""search-container"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e6e5623c1ee31a074d31c2a70b45aa05679f36c9761", async() => {
                    WriteLiteral(@"
                            <input class=""search-input""
                                   placeholder=""Axtarış"" />
                            <button class=""search-submit""
                                    type=""submit""
                                    value=""Axtar""></button>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <a class=""lang-switcher lang-switcher_ru"" href=""https://ru.oxu.az/"">ru</a>
                </div>

                <div class=""nav-toggle"">Kateqoriyalar</div>
            </div>
        </div>

        <div class=""nav-container"">
            <div class=""wrapper"">
                <nav class=""nav"">
                    <a class=""nav-item"" href=""/"">Baş səhifə</a><a class=""nav-item"" href=""/politics"">Siyasət</a><a class=""nav-item"" href=""/economy"">İqtisadiyyat</a><a class=""nav-item"" href=""/society"">Cəmiyyət</a><a class=""nav-item"" href=""/showbiz"">Şou-biznes</a><a class=""nav-item"" href=""/war"">Müharibə</a><a class=""nav-item"" href=""/sport"">İdman</a><a class=""nav-item"" href=""/criminal"">Kriminal</a><a class=""nav-item"" href=""/culture"">Mədəniyyət</a><a class=""nav-item"" href=""/world"">Dünya</a><a class=""nav-item"" href=""/auto-moto"">Avto-Moto</a><a class=""nav-item"" href=""/ict"">İKT</a><a class=""nav-item"" href=""/turism"">Turizm</a><a class=""nav-item"" href=""/interesting"">M");
                WriteLiteral(@"araqlı</a><a class=""nav-item"" href=""/interview"">Müsahibə</a><a class=""nav-item"" href=""/tv"">Baku TV</a><a class=""nav-item"" href=""/cinemaplus"">CinemaPlus</a>
                </nav>
            </div>
            <div class=""nav-banner-container"">
                <div class=""wrapper"">
                    <a class=""nav-item nav-item_coronavirus"" href=""/coronavirus-azerbaijan"">Azərbaycanda koronavirusla bağlı xəbərlər</a><a class=""nav-item nav-item_coronavirus_stats"" href=""/pages/coronastats"">Koronavirus Onlayn Statistika</a><a class=""nav-item nav-item_all""");
                BeginWriteAttribute("href", " href=\"", 3739, "\"", 3746, 0);
                EndWriteAttribute();
                WriteLiteral(@">Bütün xəbərlər</a>
                </div>
            </div>
        </div>
    </header>
    <div class=""coronavirus-mobile"">
        <div class=""wrapper"">
            <a class=""nav-coronavirus"" href=""/coronavirus-azerbaijan"">Azərbaycanda koronavirusla bağlı xəbərlər</a>
            <a class=""nav-coronavirus-stats"" href=""/pages/coronastats"">Koronavirus Onlayn Statistika</a>
        </div>
    </div>
    <main>
        <div class=""wrapper"">
            ");
#nullable restore
#line 71 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </main>
    <div class=""footer-container"">
        <footer class=""footer wrapper"">
            <div class=""copyright-email"">
                <span class=""copyright"">© Oxu.az, 2013—2020</span>Məlumatdan istifadə etdikdə istinad mütləqdir. <nobr>(012) 525-49-00, (055) 224-76-86, </nobr>
                <a class=""footer-email"" href=""mailto:info@oxu.az%2C%20editor@oxu.az"">info@oxu.az, editor@oxu.az</a>

            </div>
            <div class=""social-logos"">
                <a class=""social-logos-item social-logos-item_facebook"" href=""//facebook.com/421309791269484"">Facebook</a>
                <a class=""social-logos-item social-logos-item_twitter"" href=""//twitter.com/oxuaz"">Twitter</a>
                <a class=""social-logos-item social-logos-item_android"" href=""https://play.google.com/store/apps/details?id=az.start.android.oxu"">Android App</a>
                <a class=""social-logos-item social-logos-item_ios"" href=""https://itunes.apple.com/app/id634362981"">iOS App</a>
       ");
                WriteLiteral("     </div>\r\n        </footer>\r\n    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e6e5623c1ee31a074d31c2a70b45aa05679f36c15104", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e6e5623c1ee31a074d31c2a70b45aa05679f36c16204", async() => {
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
                WriteLiteral("\r\n    ");
#nullable restore
#line 91 "C:\Users\HP\source\repos\NewsSiteCoreApp\NewsSiteCoreApp\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
