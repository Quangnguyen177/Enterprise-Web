#pragma checksum "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QAManager\Idea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4226dd7a00f944fc8f3488efda0ae227d34c83ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QAManager_Idea), @"mvc.1.0.view", @"/Views/QAManager/Idea.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4226dd7a00f944fc8f3488efda0ae227d34c83ac", @"/Views/QAManager/Idea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47bc00708d873f7e313183e39901136d2a34b3e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QAManager_Idea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Idea>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QAManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadCSV", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QAManager\Idea.cshtml"
  
    Layout = "_QAM";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QAManager\Idea.cshtml"
  
    ViewData["Title"] = "List Idea";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QAManager\Idea.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Quality Assurance Manager"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"idea\">\r\n");
            WriteLiteral(@"        <div class=""dropdown"">
            <button class=""btn_dropdown dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fa-solid fa-filter""></i>
            </button>
            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                <a class=""dropdown-item"" href=""#"">Most Popular Ideas</a>
                <a class=""dropdown-item"" href=""#"">Most Viewed Ideas</a>
                <a class=""dropdown-item"" href=""#"">Latest Ideas</a>
            </div>
        </div>

        <div class=""download_doc"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4226dd7a00f944fc8f3488efda0ae227d34c83ac5467", async() => {
                WriteLiteral(@"
                <button class=""download-button"">
                    <div class=""docs""><svg class=""css-i6dzq1"" stroke-linejoin=""round"" stroke-linecap=""round"" fill=""none"" stroke-width=""2"" stroke=""currentColor"" height=""20"" width=""20"" viewBox=""0 0 24 24""><path d=""M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z""></path><polyline points=""14 2 14 8 20 8""></polyline><line y2=""13"" x2=""8"" y1=""13"" x1=""16""></line><line y2=""17"" x2=""8"" y1=""17"" x1=""16""></line><polyline points=""10 9 9 9 8 9""></polyline></svg> Docs</div>
                    <div class=""download"">
                        <svg class=""css-i6dzq1"" stroke-linejoin=""round"" stroke-linecap=""round"" fill=""none"" stroke-width=""2"" stroke=""currentColor"" height=""24"" width=""24"" viewBox=""0 0 24 24""><path d=""M21 15v4a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2v-4""></path><polyline points=""7 10 12 15 17 10""></polyline><line y2=""3"" x2=""12"" y1=""15"" x1=""12""></line></svg>
                    </div>
                </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"download_csv\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4226dd7a00f944fc8f3488efda0ae227d34c83ac7957", async() => {
                WriteLiteral(@"
                <button class=""download-button"">
                    <div class=""docs""><svg class=""css-i6dzq1"" stroke-linejoin=""round"" stroke-linecap=""round"" fill=""none"" stroke-width=""2"" stroke=""currentColor"" height=""20"" width=""20"" viewBox=""0 0 24 24""><path d=""M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z""></path><polyline points=""14 2 14 8 20 8""></polyline><line y2=""13"" x2=""8"" y1=""13"" x1=""16""></line><line y2=""17"" x2=""8"" y1=""17"" x1=""16""></line><polyline points=""10 9 9 9 8 9""></polyline></svg> CSV</div>
                    <div class=""download"">
                        <svg class=""css-i6dzq1"" stroke-linejoin=""round"" stroke-linecap=""round"" fill=""none"" stroke-width=""2"" stroke=""currentColor"" height=""24"" width=""24"" viewBox=""0 0 24 24""><path d=""M21 15v4a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2v-4""></path><polyline points=""7 10 12 15 17 10""></polyline><line y2=""3"" x2=""12"" y1=""15"" x1=""12""></line></svg>
                    </div>
                </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        
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
            WriteLiteral(@"         <td>18/5/2023 3:45 PM</td>
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
            WriteLiteral(@"       <td>18/5/2023 3:45 PM</td>
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
#line 152 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\QAManager\Idea.cshtml"
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
