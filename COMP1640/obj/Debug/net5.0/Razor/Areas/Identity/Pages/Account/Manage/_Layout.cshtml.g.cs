#pragma checksum "D:\FinalProject\WEB\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd556abf69e62faf5ee8ab67485c41b3b8d27ed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
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
#line 1 "D:\FinalProject\WEB\Enterprise-Web\COMP1640\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalProject\WEB\Enterprise-Web\COMP1640\Areas\Identity\Pages\_ViewImports.cshtml"
using COMP1640.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FinalProject\WEB\Enterprise-Web\COMP1640\Areas\Identity\Pages\_ViewImports.cshtml"
using COMP1640.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\FinalProject\WEB\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using COMP1640.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\FinalProject\WEB\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using COMP1640.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd556abf69e62faf5ee8ab67485c41b3b8d27ed3", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2177de55b00e940e2764822a6736ff23649d44f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64975573b0d302e8f2f8a70adb4d5135e997e9fc", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f7a6a06257b694594fb41697b5e7431069316c", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\FinalProject\WEB\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
  
    if (ViewData.TryGetValue("ParentLayout", out var parentLayout))
    {
        Layout = (string)parentLayout;
    }
    else
    {
        Layout = "/areas/identity/pages/_layout.cshtml";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Manage your account</h2>\n\n<div>\n    <h4>Change your account settings</h4>\n    <hr />\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd556abf69e62faf5ee8ab67485c41b3b8d27ed35157", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"col-md-9\">\n            ");
#nullable restore
#line 22 "D:\FinalProject\WEB\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 28 "D:\FinalProject\WEB\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
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
