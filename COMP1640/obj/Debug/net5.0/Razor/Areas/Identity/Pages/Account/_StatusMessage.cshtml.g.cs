<<<<<<< HEAD
#pragma checksum "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
=======
#pragma checksum "G:\Git\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
>>>>>>> 1ae43a96018334f0bd00599065228aba1f6be3ae
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Areas\Identity\Pages\_ViewImports.cshtml"
=======
#line 1 "G:\Git\Enterprise-Web\COMP1640\Areas\Identity\Pages\_ViewImports.cshtml"
>>>>>>> 1ae43a96018334f0bd00599065228aba1f6be3ae
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Areas\Identity\Pages\_ViewImports.cshtml"
=======
#line 2 "G:\Git\Enterprise-Web\COMP1640\Areas\Identity\Pages\_ViewImports.cshtml"
>>>>>>> 1ae43a96018334f0bd00599065228aba1f6be3ae
using COMP1640.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Areas\Identity\Pages\_ViewImports.cshtml"
=======
#line 3 "G:\Git\Enterprise-Web\COMP1640\Areas\Identity\Pages\_ViewImports.cshtml"
>>>>>>> 1ae43a96018334f0bd00599065228aba1f6be3ae
using COMP1640.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 1 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_ViewImports.cshtml"
=======
#line 1 "G:\Git\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_ViewImports.cshtml"
>>>>>>> 1ae43a96018334f0bd00599065228aba1f6be3ae
using COMP1640.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0723a602e84d5a261d35f2702dcc54883c69cad5", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eaf05b314e6e7556e952e2adabc3d8667af26c2", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64975573b0d302e8f2f8a70adb4d5135e997e9fc", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
=======
#line 3 "G:\Git\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
>>>>>>> 1ae43a96018334f0bd00599065228aba1f6be3ae
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#nullable restore
<<<<<<< HEAD
#line 6 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
=======
#line 6 "G:\Git\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
>>>>>>> 1ae43a96018334f0bd00599065228aba1f6be3ae
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
<<<<<<< HEAD
#line 8 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
=======
#line 8 "G:\Git\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
>>>>>>> 1ae43a96018334f0bd00599065228aba1f6be3ae
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 10 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
=======
#line 10 "G:\Git\Enterprise-Web\COMP1640\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
>>>>>>> 1ae43a96018334f0bd00599065228aba1f6be3ae
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
