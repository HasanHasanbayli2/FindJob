#pragma checksum "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e0b782a2cb3eba6b4337edca7066a2758f75d76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_CompanyProfile), @"mvc.1.0.view", @"/Views/Users/CompanyProfile.cshtml")]
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
#line 2 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\_ViewImports.cshtml"
using FindJob.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\_ViewImports.cshtml"
using FindJob.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b782a2cb3eba6b4337edca7066a2758f75d76", @"/Views/Users/CompanyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c244eaceb285b2f481d71d6b8938f7e88b2ee52e", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_CompanyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/Users/prof.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("brand logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/c-logo-01.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/c-logo-02.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
  
    ViewData["Title"] = "CompanyProfile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""header_01 header_inner"">
    <div class=""header_main header_job_single_main"">
        <div class=""header_btm header_job_single"">
            <div class=""header_job_single_inner container"">
                <div class=""poster_company"">
");
#nullable restore
#line 11 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                     if (Model.Image != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e0b782a2cb3eba6b4337edca7066a2758f75d765684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 433, "~/assets/images/Users/", 433, 22, true);
#nullable restore
#line 13 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
AddHtmlAttributeValue("", 455, Model.Image, 455, 12, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e0b782a2cb3eba6b4337edca7066a2758f75d767554", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"poster_details\">\r\n                    <h2>");
#nullable restore
#line 21 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                   Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"varified\"><i class=\"fas fa-check\"></i>Verified</span></h2>\r\n                    <h5>About company</h5>\r\n                    <ul>\r\n");
            WriteLiteral("                        <li>\r\n                            <i class=\"fas fa-map-marker-alt\"></i>\r\n                            ");
#nullable restore
#line 36 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                       Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"far fa-clock\"></i>\r\n                            Since ");
#nullable restore
#line 40 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                             Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</header>
<main>
    <div class=""single_job"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""row "">
                        <div class=""col-md-12 single_job_main"">
                            <h2>About Company</h2>
                            <p>");
#nullable restore
#line 56 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                          Write(Html.Raw(Model.AboutCompanyDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                        <div class=""section-divider""></div>
                        <div class=""col-md-12 single_job_main"">
                            <h2>Location</h2>
                            <iframe class=""full-width-iframe"" src=""https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12157.569688213613!2d49.8547166!3d40.3779945!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d077c61fef3%3A0xfa4594c97092ca01!2sAF%20Business%20House!5e0!3m2!1saz!2s!4v1608373987476!5m2!1saz!2s"" width=""1000"" height=""300"" frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2815, "\"", 2833, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""false"" tabindex=""0""></iframe>
                        </div>
                        <div class=""section-divider""></div>
                        <div class=""col-md-12 single_job_main"">
                            <h2> Open Positions</h2>
                            <div class=""row two_col featured_box_outer"">
                                <div class=""col-sm-6"">
                                    <div class=""featured_box "">
                                        <div class=""fb_image"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e0b782a2cb3eba6b4337edca7066a2758f75d7612289", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                        <div class=""fb_content"">
                                            <h4>2000 Words English to German</h4>
                                            <ul>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""fas fa-landmark""></i>
                                                        Magna Aliqua
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""fas fa-map-marker-alt""></i>
                                                        New York
                                                    </a>
                                            ");
            WriteLiteral(@"    </li>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""far fa-clock""></i>
                                                        2 days ago
                                                    </a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class=""fb_action"">
                                            <a title=""add to favourite"" href=""#""><i class=""far fa-heart""></i></a>
                                            <a class=""btn btn-third"" href=""#"">Apply Now</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-6"">
                                    <div class=""featured_box "">
 ");
            WriteLiteral("                                       <div class=\"fb_image\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e0b782a2cb3eba6b4337edca7066a2758f75d7615653", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                        <div class=""fb_content"">
                                            <h4>Fix Python Selenium Code</h4>
                                            <ul>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""fas fa-landmark""></i>
                                                        Magna Aliqua
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""fas fa-map-marker-alt""></i>
                                                        New York
                                                    </a>
                                                ");
            WriteLiteral(@"</li>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""far fa-clock""></i>
                                                        3 days ago
                                                    </a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class=""fb_action"">
                                            <a title=""add to favourite"" href=""#""><i class=""fas fa-heart""></i></a>
                                            <a class=""btn btn-third"" href=""#"">Apply Now</a>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
    ");
            WriteLiteral("        </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
