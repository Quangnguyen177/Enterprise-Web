<<<<<<< Updated upstream
#pragma checksum "D:\FinalProject\Newest\COMP1640\Views\QAManager\CommentIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d369fc122730ef4aad6d89a7db2f4933dd66a04"
=======
#pragma checksum "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\QAManager\CommentIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a899af9017f59f3dd4e0ac72fa953e0d7b48725"
>>>>>>> Stashed changes
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QAManager_CommentIdea), @"mvc.1.0.view", @"/Views/QAManager/CommentIdea.cshtml")]
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
<<<<<<< Updated upstream
#line 1 "D:\FinalProject\Newest\COMP1640\Views\_ViewImports.cshtml"
=======
#line 1 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
>>>>>>> Stashed changes
using COMP1640;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< Updated upstream
#line 2 "D:\FinalProject\Newest\COMP1640\Views\_ViewImports.cshtml"
=======
#line 2 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
>>>>>>> Stashed changes
using COMP1640.Models;

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d369fc122730ef4aad6d89a7db2f4933dd66a04", @"/Views/QAManager/CommentIdea.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a899af9017f59f3dd4e0ac72fa953e0d7b48725", @"/Views/QAManager/CommentIdea.cshtml")]
>>>>>>> Stashed changes
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eeaa803526b4e6038dbcef939715caa86a48ae1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QAManager_CommentIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/res_qa_comment.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<<<<<<< Updated upstream
#line 2 "D:\FinalProject\Newest\COMP1640\Views\QAManager\CommentIdea.cshtml"
=======
#line 2 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\QAManager\CommentIdea.cshtml"
>>>>>>> Stashed changes
  
    Layout = "_QAM";
    ViewData["Title"] = "Latest Comment";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d369fc122730ef4aad6d89a7db2f4933dd66a044048", async() => {
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
#nullable restore
<<<<<<< Updated upstream
#line 7 "D:\FinalProject\Newest\COMP1640\Views\QAManager\CommentIdea.cshtml"
=======
#line 6 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\QAManager\CommentIdea.cshtml"
>>>>>>> Stashed changes
 if (User.Identity.IsAuthenticated && User.IsInRole("Quality Assurance Manager"))
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
                        <td>False</td>
                 ");
            WriteLiteral(@"       <td>1</td>
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
                        <td>6</td>
                        <td>Hel");
            WriteLiteral(@"lo</td>
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
<<<<<<< Updated upstream
#line 75 "D:\FinalProject\Newest\COMP1640\Views\QAManager\CommentIdea.cshtml"
=======
#line 74 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\QAManager\CommentIdea.cshtml"
>>>>>>> Stashed changes
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
