#pragma checksum "D:\FinalProject\Newest\COMP1640\Views\Admin\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebd2f25df7870db21085b23c8fb441283ab32c83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Home), @"mvc.1.0.view", @"/Views/Admin/Home.cshtml")]
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
#line 1 "D:\FinalProject\Newest\COMP1640\Views\_ViewImports.cshtml"
using COMP1640;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalProject\Newest\COMP1640\Views\_ViewImports.cshtml"
using COMP1640.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebd2f25df7870db21085b23c8fb441283ab32c83", @"/Views/Admin/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eeaa803526b4e6038dbcef939715caa86a48ae1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/res_admin_db.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\FinalProject\Newest\COMP1640\Views\Admin\Home.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ebd2f25df7870db21085b23c8fb441283ab32c833940", async() => {
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
            WriteLiteral("\n");
            WriteLiteral(@"
<!-- Main content -->
<div class=""h-screen flex-grow-1 overflow-y-lg-auto"">
    <!-- Header -->
    <!-- Main -->
    <main class=""py-6 bg-surface-secondary"">
        <div class=""container-fluid"">
            <!-- Card stats -->
            <div class=""row g-6 mb-6"">
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <span class=""h6 font-semibold text-muted text-sm d-block mb-2"">Idea Post</span>
                                    <span class=""h3 font-bold mb-0"">200</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-tertiary text-white text-lg rounded-circle"">
                                        <i class=""fa fa-newspaper-o""></i>
                                    </div>");
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""mt-2 mb-0 text-sm"">
                                <span class=""badge badge-pill bg-opacity-30 bg-success text-success me-2"">
                                    <i class=""fa fa-arrow-up""></i>11%
                                </span>
                                <span class=""text-nowrap text-xs text-muted"">Since last week</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <span class=""h6 font-semibold text-muted text-sm d-block mb-2"">Like</span>
                                    <span class=""h3 font-bold mb-0"">21k</span>
                            ");
            WriteLiteral(@"    </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-primary text-white text-lg rounded-circle"">
                                        <i class=""fa fa-thumbs-o-up""></i>
                                    </div>
                                </div>
                            </div>
                            <div class=""mt-2 mb-0 text-sm"">
                                <span class=""badge badge-pill bg-opacity-30 bg-success text-success me-2"">
                                    <i class=""fa fa-arrow-up""></i>4%
                                </span>
                                <span class=""text-nowrap text-xs text-muted"">Since last month</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                     ");
            WriteLiteral(@"       <div class=""row"">
                                <div class=""col"">
                                    <span class=""h6 font-semibold text-muted text-sm d-block mb-2"">Dislike</span>
                                    <span class=""h3 font-bold mb-0"">149</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-info text-white text-lg rounded-circle"">
                                        <i class=""fa fa-thumbs-o-down""></i>
                                    </div>
                                </div>
                            </div>
                            <div class=""mt-2 mb-0 text-sm"">
                                <span class=""badge badge-pill bg-opacity-30 bg-danger text-danger me-2"">
                                    <i class=""fa fa-arrow-down""></i>  -5%
                                </span>
                                <span class=""text-nowrap text-xs text-muted"">Since");
            WriteLiteral(@" last month</span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col"">
                                    <span class=""h6 font-semibold text-muted text-sm d-block mb-2"">Comments</span>
                                    <span class=""h3 font-bold mb-0"">31k</span>
                                </div>
                                <div class=""col-auto"">
                                    <div class=""icon icon-shape bg-warning text-white text-lg rounded-circle"">
                                        <i class=""fa fa-comments-o""></i>
                                    </div>
                                </div>
                            </div>
                            <div class=""mt-2 mb-0 text-sm"">
  ");
            WriteLiteral(@"                              <span class=""badge badge-pill bg-opacity-30 bg-success text-success me-2"">
                                    <i class=""fa fa-arrow-up""></i>15%
                                </span>
                                <span class=""text-nowrap text-xs text-muted"">Since last month</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card mb-7"">
                <div class=""card-header"">
                    <h5 class=""mb-0"">Idea Information</h5>
                </div>
                <div class=""table-responsive"">
                    <table class=""table table-hover table-nowrap"">
                        <thead class=""table-light"">
                            <tr>
                                <th scope=""col"">Username</th>
                                <th scope=""col"">Title</th>
                                <th scope=""col"">Department</th>
                             ");
            WriteLiteral(@"   <th scope=""col"">Created date</th>
                                <th scope=""col"">Anonymous</th>
                                <th scope=""col"">View</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <img alt=""..."" src=""https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg"" class=""avatar avatar-sm rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Harris
                                    </a>
                                </td>
                                <td>
                                    Sport
                                </td>
                                <td>
                                    <img alt=""..."" src=""https://preview.webpixels.io/web/img/other/logos/logo-1.png"" class=""avatar avatar-xs rounded-circl");
            WriteLiteral(@"e me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Frontend Developer
                                    </a>
                                </td>
                                <td>
                                    Feb 17, 2023
                                </td>
                                <td>
                                    False
                                </td>
                                <td>
                                    300
                                </td>
");
            WriteLiteral(@"                            </tr>
                            <tr>
                                <td>
                                    <img alt=""..."" src=""https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg"" class=""avatar avatar-sm rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Mike Tke Duke
                                    </a>
                                </td>
                                <td>
                                    Gaming
                                </td>
                                <td>
                                    <img alt=""..."" src=""https://preview.webpixels.io/web/img/other/logos/logo-2.png"" class=""avatar avatar-xs rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Backend Developer
                                    </a>
                       ");
            WriteLiteral(@"         </td>
                                <td>
                                    Feb 17, 2023
                                </td>
                                <td>
                                    False
                                </td>
                                <td>
                                    300
                                </td>
");
            WriteLiteral(@"                            </tr>
                            <tr>
                                <td>
                                    <img alt=""..."" src=""https://scontent.fhan5-8.fna.fbcdn.net/v/t1.6435-1/171830266_1017338032130536_2499925604087986830_n.jpg?stp=dst-jpg_s320x320&_nc_cat=108&ccb=1-7&_nc_sid=7206a8&_nc_ohc=T2-wHnnniUoAX_ydlvB&_nc_ht=scontent.fhan5-8.fna&oh=00_AfDxfES3mJqNC5bJGp4MROu5c70dsxZDfW7pmbRNlioJlw&oe=641FF165"" class=""avatar avatar-sm rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Quang Doi
                                    </a>
                                </td>
                                <td>
                                    Cooking
                                </td>
                                <td>
                                    <img alt=""..."" src=""https://preview.webpixels.io/web/img/other/logos/logo-3.png"" class=""avatar avatar-xs rounded-circle me-2"">
    ");
            WriteLiteral(@"                                <a class=""text-heading font-semibold"" href=""#"">
                                        Scrum Master
                                    </a>
                                </td>
                                <td>
                                    Feb 17, 2023
                                </td>
                                <td>
                                    False
                                </td>
                                <td>
                                    300
                                </td>
");
            WriteLiteral(@"                            </tr>
                            <tr>
                                <td>
                                    <img alt=""..."" src=""https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg"" class=""avatar avatar-sm rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Thuy Duong
                                    </a>
                                </td>
                                <td>
                                    Shopping
                                </td>
                                <td>
                                    <img alt=""..."" src=""https://preview.webpixels.io/web/img/other/logos/logo-4.png"" class=""avatar avatar-xs rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Business Analysis
                                    </a>
                        ");
            WriteLiteral(@"        </td>
                                <td>
                                    Sep 22, 2023
                                </td>
                                <td>
                                    False
                                </td>
                                <td>
                                    300
                                </td>
");
            WriteLiteral(@"                            </tr>
                            <tr>
                                <td>
                                    <img alt=""..."" src=""https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg"" class=""avatar avatar-sm rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Harris
                                    </a>
                                </td>
                                <td>
                                    Chilling
                                </td>
                                <td>
                                    <img alt=""..."" src=""https://preview.webpixels.io/web/img/other/logos/logo-1.png"" class=""avatar avatar-xs rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Frontend Developer
                                    </a>
                           ");
            WriteLiteral(@"     </td>
                                <td>
                                    Feb 17, 2023
                                </td>
                                <td>
                                    False
                                </td>
                                <td>
                                    300
                                </td>
");
            WriteLiteral(@"                            </tr>
                            <tr>
                                <td>
                                    <img alt=""..."" src=""https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg"" class=""avatar avatar-sm rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Mike Tke Duke
                                    </a>
                                </td>
                                <td>
                                    Coding
                                </td>
                                <td>
                                    <img alt=""..."" src=""https://preview.webpixels.io/web/img/other/logos/logo-2.png"" class=""avatar avatar-xs rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Backend Developer
                                    </a>
                       ");
            WriteLiteral(@"         </td>
                                <td>
                                    Feb 17, 2023
                                </td>
                                <td>
                                    False
                                </td>
                                <td>
                                    300
                                </td>
");
            WriteLiteral(@"                            </tr>
                            <tr>
                                <td>
                                    <img alt=""..."" src=""https://scontent.fhan5-8.fna.fbcdn.net/v/t1.6435-1/171830266_1017338032130536_2499925604087986830_n.jpg?stp=dst-jpg_s320x320&_nc_cat=108&ccb=1-7&_nc_sid=7206a8&_nc_ohc=T2-wHnnniUoAX_ydlvB&_nc_ht=scontent.fhan5-8.fna&oh=00_AfDxfES3mJqNC5bJGp4MROu5c70dsxZDfW7pmbRNlioJlw&oe=641FF165"" class=""avatar avatar-sm rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Quang Doi
                                    </a>
                                </td>
                                <td>
                                    Hang out
                                </td>
                                <td>
                                    <img alt=""..."" src=""https://preview.webpixels.io/web/img/other/logos/logo-3.png"" class=""avatar avatar-xs rounded-circle me-2"">
   ");
            WriteLiteral(@"                                 <a class=""text-heading font-semibold"" href=""#"">
                                        Scrum Master
                                    </a>
                                </td>
                                <td>
                                    Feb 17, 2023
                                </td>
                                <td>
                                    False
                                </td>
                                <td>
                                    300
                                </td>
");
            WriteLiteral(@"                            </tr>
                            <tr>
                                <td>
                                    <img alt=""..."" src=""https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg"" class=""avatar avatar-sm rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Thuy Duong
                                    </a>
                                </td>
                                <td>
                                    Gym
                                </td>
                                <td>
                                    <img alt=""..."" src=""https://preview.webpixels.io/web/img/other/logos/logo-4.png"" class=""avatar avatar-xs rounded-circle me-2"">
                                    <a class=""text-heading font-semibold"" href=""#"">
                                        Business Analysis
                                    </a>
                             ");
            WriteLiteral(@"   </td>
                                <td>
                                    Sep 22, 2023
                                </td>
                                <td>
                                    False
                                </td>
                                <td>
                                    300
                                </td>
");
            WriteLiteral(@"                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class=""card-footer border-0 py-5"">
                    <span class=""text-muted text-sm"">Showing 8 post idea out of 100 results found</span>
                </div>
            </div>
        </div>
    </main>
</div>
");
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
