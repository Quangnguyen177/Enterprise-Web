#pragma checksum "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d00ed37cd29a30aa894c3b5772c97f59bdfb7d6d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d00ed37cd29a30aa894c3b5772c97f59bdfb7d6d", @"/Views/QACoordinator/ListIdea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47bc00708d873f7e313183e39901136d2a34b3e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QACoordinator_ListIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Idea>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/res_qa_idea.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
  
    Layout = "_QAC";
    ViewData["Title"] = "List Idea";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d00ed37cd29a30aa894c3b5772c97f59bdfb7d6d4173", async() => {
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
#line 8 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
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
                    <th scope=""col"">First Closure</th>
                    <th scope=""col"">Last Closure</th>
                    <th scope=""col"">Anonymous</th>
                    <th scope=""col"">View</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Category </th>
                    <th scope=""col"">Thumbs Up</th>
                    <th scope=""col"">Thumbs Down</th>
                    <th scope=""col"">Document</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                 foreach (var i in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 33 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.IdeaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.idea_title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.idea_content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.created_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.Event.First_closure_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.Event.Last_closure_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.idea_anonymous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.idea_view);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.Profile.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.Category.category_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.Reacpoint.ThumbUp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                       Write(i.Reacpoint.ThumbDown);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>doc.file</td>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QACoordinator\ListIdea.cshtml"
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
