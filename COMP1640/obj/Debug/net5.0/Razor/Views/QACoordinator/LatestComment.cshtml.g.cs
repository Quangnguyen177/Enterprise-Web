#pragma checksum "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\LatestComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc57ca5e914ac7370ed0a98f8e9daa83166d869c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QACoordinator_LatestComment), @"mvc.1.0.view", @"/Views/QACoordinator/LatestComment.cshtml")]
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
#line 1 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
using COMP1640;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
using COMP1640.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc57ca5e914ac7370ed0a98f8e9daa83166d869c", @"/Views/QACoordinator/LatestComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47bc00708d873f7e313183e39901136d2a34b3e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QACoordinator_LatestComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\LatestComment.cshtml"
  
    Layout = "_QAC";
    ViewData["Title"] = "Latest Comment";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\LatestComment.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Quality Assurance Coordinator"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""comment"">
        <div class=""comment_table"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">ID</th>
                        <th scope=""col"">Content</th>
                        <th scope=""col"">Date</th>
                        <th scope=""col"">Anonymous</th>
                        <th scope=""col"">Profile ID</th>
                        <th scope=""col"">Idea ID</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>Hello</td>
                        <td>5/3/2023 11:03PM</td>
                        <td>False</td>
                        <td>1</td>
                        <td>2</td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>Hello</td>
                        <td>5/3/2023 11:03PM</td>
                        <td>Fa");
            WriteLiteral(@"lse</td>
                        <td>1</td>
                        <td>2</td>
                    </tr>
                    <tr>
                        <td>3</td>
                        <td>Hello</td>
                        <td>5/3/2023 11:03PM</td>
                        <td>False</td>
                        <td>1</td>
                        <td>2</td>
                    </tr>
                    <tr>
                        <td>4</td>
                        <td>Hello</td>
                        <td>5/3/2023 11:03PM</td>
                        <td>False</td>
                        <td>1</td>
                        <td>2</td>
                    </tr>
                    <tr>
                        <td>5</td>
                        <td>Hello</td>
                        <td>5/3/2023 11:03PM</td>
                        <td>False</td>
                        <td>1</td>
                        <td>2</td>
                    </tr>
                    <tr>
             ");
            WriteLiteral(@"           <td>6</td>
                        <td>Hello</td>
                        <td>5/3/2023 11:03PM</td>
                        <td>False</td>
                        <td>1</td>
                        <td>2</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
");
#nullable restore
#line 74 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\LatestComment.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
