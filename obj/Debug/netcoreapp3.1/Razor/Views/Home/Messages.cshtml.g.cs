#pragma checksum "F:\2-oop\Core\NewsApp\NewsApp\Views\Home\Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf56d5faaf7b65f37cf52cc3f2b14ec34decba4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Messages), @"mvc.1.0.view", @"/Views/Home/Messages.cshtml")]
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
#line 1 "F:\2-oop\Core\NewsApp\NewsApp\Views\_ViewImports.cshtml"
using NewsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\2-oop\Core\NewsApp\NewsApp\Views\_ViewImports.cshtml"
using NewsApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf56d5faaf7b65f37cf52cc3f2b14ec34decba4", @"/Views/Home/Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee3bfdea42c54347df92675d2462c147d0ad7987", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsApp.Models.ContactUS>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/testimonials/testimonials-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\2-oop\Core\NewsApp\NewsApp\Views\Home\Messages.cshtml"
  
    ViewData["Title"] = "Messages";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section id=\"testimonials\" class=\"testimonials\">\r\n    <div class=\"container aos-init aos-animate\" data-aos=\"fade-up\">\r\n\r\n        <div class=\"section-title\">\r\n            <h2>Users Opinions</h2>\r\n           \r\n        </div>\r\n        <center>\r\n");
#nullable restore
#line 13 "F:\2-oop\Core\NewsApp\NewsApp\Views\Home\Messages.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"owl-item cloned col-8\" >\r\n                    <div class=\"testimonial-item\">\r\n                        <h2>");
#nullable restore
#line 17 "F:\2-oop\Core\NewsApp\NewsApp\Views\Home\Messages.cshtml"
                       Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>\r\n                            <i class=\"bx bxs-quote-alt-left quote-icon-left\"></i>\r\n                            ");
#nullable restore
#line 20 "F:\2-oop\Core\NewsApp\NewsApp\Views\Home\Messages.cshtml"
                       Write(item.Massage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <i class=\"bx bxs-quote-alt-right quote-icon-right\"></i>\r\n                        </p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ddf56d5faaf7b65f37cf52cc3f2b14ec34decba45668", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h3>");
#nullable restore
#line 25 "F:\2-oop\Core\NewsApp\NewsApp\Views\Home\Messages.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <h4>");
#nullable restore
#line 26 "F:\2-oop\Core\NewsApp\NewsApp\Views\Home\Messages.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 29 "F:\2-oop\Core\NewsApp\NewsApp\Views\Home\Messages.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </center>\r\n    </div>\r\n</section><!-- End Testimonials Section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsApp.Models.ContactUS>> Html { get; private set; }
    }
}
#pragma warning restore 1591
