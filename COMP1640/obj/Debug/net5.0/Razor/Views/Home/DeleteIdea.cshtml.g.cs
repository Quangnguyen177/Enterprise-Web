#pragma checksum "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\Home\DeleteIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fb335b1d059c883d49300558d41fad3c76d3a07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DeleteIdea), @"mvc.1.0.view", @"/Views/Home/DeleteIdea.cshtml")]
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
#line 1 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
using COMP1640;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
using COMP1640.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fb335b1d059c883d49300558d41fad3c76d3a07", @"/Views/Home/DeleteIdea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eeaa803526b4e6038dbcef939715caa86a48ae1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_DeleteIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\Home\DeleteIdea.cshtml"
  
    Layout = "_Staff";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\Home\DeleteIdea.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Staff"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Button trigger modal -->\n    <button type=\"button\" class=\"btn btn-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal\">\n       Delete\n    </button>\n");
            WriteLiteral(@"    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    ...
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("    <script>\n        var myModal = document.getElementById(\'myModal\')\n        var myInput = document.getElementById(\'myInput\')\n\n        myModal.addEventListener(\'shown.bs.modal\', function () {\n            myInput.focus()\n        })\n    </script>\n");
#nullable restore
#line 38 "D:\FinalProject\Web\Enterprise-Web\COMP1640\Views\Home\DeleteIdea.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
