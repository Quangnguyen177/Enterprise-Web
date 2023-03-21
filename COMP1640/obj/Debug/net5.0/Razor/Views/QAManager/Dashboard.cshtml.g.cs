#pragma checksum "D:\FinalProject\Enterprise-Web-main\COMP1640\Views\QAManager\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef8f958060cc66a42ec7c5664445ace3345ada70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QAManager_Dashboard), @"mvc.1.0.view", @"/Views/QAManager/Dashboard.cshtml")]
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
#line 1 "D:\FinalProject\Enterprise-Web-main\COMP1640\Views\_ViewImports.cshtml"
using COMP1640;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalProject\Enterprise-Web-main\COMP1640\Views\_ViewImports.cshtml"
using COMP1640.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef8f958060cc66a42ec7c5664445ace3345ada70", @"/Views/QAManager/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eeaa803526b4e6038dbcef939715caa86a48ae1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QAManager_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/create-chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\FinalProject\Enterprise-Web-main\COMP1640\Views\QAManager\Dashboard.cshtml"
  
    Layout = "_QAM";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FinalProject\Enterprise-Web-main\COMP1640\Views\QAManager\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FinalProject\Enterprise-Web-main\COMP1640\Views\QAManager\Dashboard.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Quality Assurance Manager"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""dashboard"">
        <div class=""header_db"">
            <div class=""numOf_idea"">
                <div class=""col-4"">
                    <span>70%</span>
                </div>
                <div class=""col-8"">
                    <h5>Total Idea</h5>
                    <span>1000</span>
                </div>
            </div>
            <div class=""numOf_contributors"">
                <div class=""col-4"">
                    <span>98%</span>
                </div>
                <div class=""col-8"">
                    <h5>Total Contributor</h5>
                    <span>100</span>
                </div>
            </div>
            <div class=""react_idea"">
                <div class=""col-4"">
                    <span>100%</span>
                </div>
                <div class=""col-8"">
                    <h5>React Idea</h5>
                    <span>1000</span>
                </div>
            </div>
            <div class=""numOf_comment"">
                <div class=""col-4"">
      ");
            WriteLiteral(@"              <span>100%</span>
                </div>
                <div class=""col-8"">
                    <h5>Comment</h5>
                    <span>1000</span>
                </div>
            </div>
        </div>
         <div class=""body_db"">
            <div class=""dashboard"">
                <div class=""colom1"">
                    <div class=""chartCard"">
                        <div class=""chartBox"">
                            <h5>Number of ideas per department/year </h5>
                            <canvas id=""line-chart"" width=""500"" height=""300""></canvas>
                        </div>
                    </div>
                    <div class=""chart_contributor"">
                        <div class=""chart_contributors"">
                            <h5>Numbers of contributors per departments </h5>
                            <canvas id=""pie-chart""></canvas>
                        </div>
                    </div>
                </div>
                <div class=""colom1"">
                    <");
            WriteLiteral(@"div class=""chartCard"">
                        <div class=""chartBox"">
                            <h5>Category per year </h5>
                            <canvas id=""bar-chart"" width=""500"" height=""300""></canvas>
                        </div>
                    </div>
                    <div class=""chartCard"">
                        <div class=""chartBox"">
                               <h5>Number of point per event </h5>
                            <canvas id=""mixed-chart"" width=""500"" height=""300""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""contributor"">
                <h4>Contributor table</h4>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Profile ID</th>
                            <th scope=""col"">Name</th>
                            <th scope=""col"">DoB</th>
              ");
            WriteLiteral(@"              <th scope=""col"">Gender</th>
                            <th scope=""col"">Address</th>
                            <th scope=""col"">DepID</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">1</th>
                            <td>P1</td>
                            <td>Minh Luu thi</td>
                            <td>28/06/2002</td>
                            <td>Female</td>
                            <td>Hung Yen</td>
                            <td>1</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
");
#nullable restore
#line 108 "D:\FinalProject\Enterprise-Web-main\COMP1640\Views\QAManager\Dashboard.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("]\n<script src=\"https://cdn.jsdelivr.net/npm/chart.js\"></script>\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.4/jquery.min.js\"></script>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef8f958060cc66a42ec7c5664445ace3345ada708457", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
