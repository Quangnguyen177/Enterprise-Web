#pragma checksum "E:\GitHub\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d8118706361995ceac92e5b02dea4522c476156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QACoordinator_ListIdea), @"mvc.1.0.view", @"/Views/QACoordinator/ListIdea.cshtml")]
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
#line 1 "E:\GitHub\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
using COMP1640;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHub\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
using COMP1640.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8118706361995ceac92e5b02dea4522c476156", @"/Views/QACoordinator/ListIdea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47bc00708d873f7e313183e39901136d2a34b3e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QACoordinator_ListIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Idea>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\GitHub\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
  
    Layout = "_QAC";
    ViewData["Title"] = "List Idea";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\GitHub\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Quality Assurance Coordinator"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""idea"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Title</th>
                    <th scope=""col"">Content</th>
                    <th scope=""col"">Date</th>
                    <th scope=""col"">Frist_clourse</th>
                    <th scope=""col"">Last_closure</th>
                    <th scope=""col"">Anonymous</th>
                    <th scope=""col"">View</th>
                    <th scope=""col"">Profile ID</th>
                    <th scope=""col"">Category ID</th>
                    <th scope=""col"">React Point</th>
                    <th scope=""col"">Documnet</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>HI</td>
                    <td>I am a student of GW</td>
                    <td>3/5/2023 3:45 PM</td>
                    <td>13/5/2023 3:45 PM</td>
               ");
            WriteLiteral(@"     <td>18/5/2023 3:45 PM</td>
                    <td>False</td>
                    <td>300</td>
                    <td>1</td>
                    <td>20</td>
                    <td>1</td>
                    <td>doc.file</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>HI</td>
                    <td>I am a student of GW</td>
                    <td>3/5/2023 3:45 PM</td>
                    <td>13/5/2023 3:45 PM</td>
                    <td>18/5/2023 3:45 PM</td>
                    <td>False</td>
                    <td>300</td>
                    <td>1</td>
                    <td>20</td>
                    <td>1</td>
                    <td>doc.file</td>
                </tr>

                <tr>
                    <td>3</td>
                    <td>HI</td>
                    <td>I am a student of GW</td>
                    <td>3/5/2023 3:45 PM</td>
                    <td>13/5/2023 3:45 PM</td>
                 ");
            WriteLiteral(@"   <td>18/5/2023 3:45 PM</td>
                    <td>False</td>
                    <td>300</td>
                    <td>1</td>
                    <td>20</td>
                    <td>1</td>
                    <td>doc.file</td>
                </tr>
                <tr>
                    <td>4</td>
                    <td>HI</td>
                    <td>I am a student of GW</td>
                    <td>3/5/2023 3:45 PM</td>
                    <td>13/5/2023 3:45 PM</td>
                    <td>18/5/2023 3:45 PM</td>
                    <td>False</td>
                    <td>300</td>
                    <td>1</td>
                    <td>20</td>
                    <td>1</td>
                    <td>doc.file</td>
                </tr>
                <tr>
                    <td>5</td>
                    <td>HI</td>
                    <td>I am a student of GW</td>
                    <td>3/5/2023 3:45 PM</td>
                    <td>13/5/2023 3:45 PM</td>
                    <");
            WriteLiteral(@"td>18/5/2023 3:45 PM</td>
                    <td>False</td>
                    <td>300</td>
                    <td>1</td>
                    <td>20</td>
                    <td>1</td>
                    <td>doc.file</td>
                </tr>
                <tr>
                    <td>6</td>
                    <td>HI</td>
                    <td>I am a student of GW</td>
                    <td>3/5/2023 3:45 PM</td>
                    <td>13/5/2023 3:45 PM</td>
                    <td>18/5/2023 3:45 PM</td>
                    <td>False</td>
                    <td>300</td>
                    <td>1</td>
                    <td>20</td>
                    <td>1</td>
                    <td>doc.file</td>
                </tr>
            </tbody>
        </table>
    </div>
");
#nullable restore
#line 116 "E:\GitHub\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Idea>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
