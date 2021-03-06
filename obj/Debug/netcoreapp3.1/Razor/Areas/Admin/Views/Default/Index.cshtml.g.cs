#pragma checksum "F:\2-oop\Core\NewsApp\NewsApp\Areas\Admin\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cba7434a8597f34f4ed41b94f4904fa7076f761"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Default_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Default/Index.cshtml")]
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
#line 1 "F:\2-oop\Core\NewsApp\NewsApp\Areas\Admin\Views\_ViewImports.cshtml"
using NewsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\2-oop\Core\NewsApp\NewsApp\Areas\Admin\Views\_ViewImports.cshtml"
using NewsApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\2-oop\Core\NewsApp\NewsApp\Areas\Admin\Views\Default\Index.cshtml"
using NewsApp.Areas.Admin.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cba7434a8597f34f4ed41b94f4904fa7076f761", @"/Areas/Admin/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfdefa2e4658ce338aae803837059871d78faece", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!---->  \r\n");
#nullable restore
#line 3 "F:\2-oop\Core\NewsApp\NewsApp\Areas\Admin\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Dashboard</h1>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""overview-wrap"">
            <h2 class=""title-1"">overview</h2>
            <!-- <button class=""au-btn au-btn-icon au-btn--blue"">
         <i class=""zmdi zmdi-plus""></i>add item
     </button>-->
        </div>
    </div>
</div>
<div class=""row m-t-25"">
    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c1"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-account-o""></i>
                    </div>
                    <div class=""text"">
                        <h2>");
#nullable restore
#line 29 "F:\2-oop\Core\NewsApp\NewsApp\Areas\Admin\Views\Default\Index.cshtml"
                       Write(Model.cats);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span>Categories</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <canvas id=""widgetChart1""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c2"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-shopping-cart""></i>
                    </div>
                    <div class=""text"">
                        <h2>");
#nullable restore
#line 47 "F:\2-oop\Core\NewsApp\NewsApp\Areas\Admin\Views\Default\Index.cshtml"
                       Write(Model.news);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span>News</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <canvas id=""widgetChart2""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c3"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-calendar-note""></i>
                    </div>
                    <div class=""text"">
                        <h2>");
#nullable restore
#line 65 "F:\2-oop\Core\NewsApp\NewsApp\Areas\Admin\Views\Default\Index.cshtml"
                       Write(Model.contact);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span>Messages of Users</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <canvas id=""widgetChart3""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-6 col-lg-3"">
        <div class=""overview-item overview-item--c4"">
            <div class=""overview__inner"">
                <div class=""overview-box clearfix"">
                    <div class=""icon"">
                        <i class=""zmdi zmdi-money""></i>
                    </div>
                    <div class=""text"">
                        <h2>");
#nullable restore
#line 83 "F:\2-oop\Core\NewsApp\NewsApp\Areas\Admin\Views\Default\Index.cshtml"
                       Write(Model.team);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span>Team</span>
                    </div>
                </div>
                <div class=""overview-chart"">
                    <canvas id=""widgetChart4""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""au-card recent-report"">
            <div class=""au-card-inner"">
                <h3 class=""title-2"">recent reports</h3>
                <div class=""chart-info"">
                    <div class=""chart-info__left"">
                        <div class=""chart-note"">
                            <span class=""dot dot--blue""></span>
                            <span>News</span>
                        </div>
                        <div class=""chart-note mr-0"">
                            <span class=""dot dot--green""></span>
                            <span>Categories</span>
                        </div>
                    </div>
                    <div cl");
            WriteLiteral(@"ass=""chart-info__right"">
                        <div class=""chart-statis"">
                            <span class=""index incre"">
                                <i class=""zmdi zmdi-long-arrow-up""></i>25%
                            </span>
                            <span class=""label"">News</span>
                        </div>
                        <div class=""chart-statis mr-0"">
                            <span class=""index decre"">
                                <i class=""zmdi zmdi-long-arrow-down""></i>10%
                            </span>
                            <span class=""label"">Categories</span>
                        </div>
                    </div>
                </div>
                <div class=""recent-report__chart"">
                    <canvas id=""recent-rep-chart""></canvas>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-6"">
        <div class=""au-card chart-percent-card"">
            <div class=""au-card-inner"">
 ");
            WriteLiteral(@"               <h3 class=""title-2 tm-b-5"">char by %</h3>
                <div class=""row no-gutters"">
                    <div class=""col-xl-6"">
                        <div class=""chart-note-wrap"">
                            <div class=""chart-note mr-0 d-block"">
                                <span class=""dot dot--blue""></span>
                                <span>News</span>
                            </div>
                            <div class=""chart-note mr-0 d-block"">
                                <span class=""dot dot--red""></span>
                                <span>Categories</span>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-6"">
                        <div class=""percent-chart"">
                            <canvas id=""percent-chart""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
