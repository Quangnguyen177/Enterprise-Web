#pragma checksum "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\Shared\_LayoutManageInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6035028a467cb2419841d3023c6edf22f0659e72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutManageInformation), @"mvc.1.0.view", @"/Views/Shared/_LayoutManageInformation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6035028a467cb2419841d3023c6edf22f0659e72", @"/Views/Shared/_LayoutManageInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47bc00708d873f7e313183e39901136d2a34b3e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__LayoutManageInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageInformation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageClosureDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn d-inline-flex btn-sm btn-primary mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6035028a467cb2419841d3023c6edf22f0659e727629", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-U A-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <!--Link Font-->
    <script src=""https://kit.fontawesome.com/1e27f03b11.js"" crossorigin=""anonymous""></script>

    <!--Link bootstrap-->
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js"" integrity=""sha");
                WriteLiteral("384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl\" crossorigin=\"anonymous\"></script>\r\n\r\n    <!--Link Css-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6035028a467cb2419841d3023c6edf22f0659e729121", async() => {
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
                WriteLiteral("\r\n\r\n    <title>Manage Account</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6035028a467cb2419841d3023c6edf22f0659e7211049", async() => {
                WriteLiteral(@"
    <div class=""d-flex flex-column flex-lg-row bg-surface-secondary"">
        <!-- Vertical Navbar -->
        <nav class=""navbar show navbar-vertical h-lg-screen navbar-expand-lg px-0 py-3 navbar-light bg-light border-bottom border-bottom-lg-0 border-end-lg"" id=""navbarVertical"">
            <div class=""container-fluid"">
                <!-- Brand -->
                <a class=""navbar-brand py-lg-3 mb-lg-5 px-lg-6 me-0"" href=""#"">
                    <img src=""https://logos.textgiraffe.com/logos/logo-name/Admin-designstyle-candy-m.png"" alt=""..."">
                </a>
                <!-- Collapse -->
                <div class=""collapse navbar-collapse"" id=""sidebarCollapse"">
                    <!-- Navigation -->
                    <ul class=""navbar-nav"">
                        <li class=""nav-item"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6035028a467cb2419841d3023c6edf22f0659e7212184", async() => {
                    WriteLiteral("\r\n                                <i class=\"fa fa-home\"></i> Dashboard\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <i class=""fa fa-area-chart""></i> Analysis
                            </a>
                        </li>
                        <li class=""nav-item"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6035028a467cb2419841d3023c6edf22f0659e7214166", async() => {
                    WriteLiteral("\r\n                                <i class=\"fa fa-pencil-square-o\"></i> Manage information staff\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6035028a467cb2419841d3023c6edf22f0659e7215925", async() => {
                    WriteLiteral("\r\n                                <i class=\"fa fa-pencil-square-o\"></i> Manage account staff\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6035028a467cb2419841d3023c6edf22f0659e7217680", async() => {
                    WriteLiteral("\r\n                                <i class=\"fa fa-cog\"></i> Setting event date\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
                    </ul>
                    <!-- Divider -->
                    <hr class=""navbar-divider my-5 opacity-20"">
                    <!-- Navigation -->
                    <ul class=""navbar-nav mb-md-4"">
                        <li>
                            <div class=""nav-link text-xs font-semibold text-uppercase text-muted ls-wide"" href=""#"">
                                <div style=""font-size:20px"">Contacts</div>
                                <span class=""badge bg-opacity-30 bg-primary text-primary rounded-pill d-inline-flex align-items-center ms-4"">3</span>
                            </div>
                        </li>
                        <li>
                            <a href=""#"" class=""nav-link d-flex align-items-center"">
                                <div class=""me-4"">
                                    <div class=""position-relative d-inline-block text-white"">
                                        <img alt=""..."" src=""http");
                WriteLiteral(@"s://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg"" class=""avatar rounded-circle"">
                                        <span class=""position-absolute bottom-2 end-2 transform translate-x-1/2 translate-y-1/2 border-2 border-solid border-current w-3 h-3 bg-danger rounded-circle""></span>
                                    </div>
                                </div>
                                <div>
                                    <span class=""d-block text-sm font-semibold"">
                                        Dan Truong
                                    </span>
                                    <span class=""d-block text-xs text-muted font-regular"">
                                        Hanoi, HN
                                    </span>
                                </div>
                                <div class=""ms-auto"">
                                    <i class=""fa fa-comment""></i>
                                </div>
                   ");
                WriteLiteral(@"         </a>
                        </li>
                        <li>
                            <a href=""#"" class=""nav-link d-flex align-items-center"">
                                <div class=""me-4"">
                                    <div class=""position-relative d-inline-block text-white"">
                                        <img alt=""..."" src=""https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg"" class=""avatar rounded-circle"">
                                        <span class=""position-absolute bottom-2 end-2 transform translate-x-1/2 translate-y-1/2 border-2 border-solid border-current w-3 h-3 bg-danger rounded-circle""></span>
                                    </div>
                                </div>
                                <div>
                                    <span class=""d-block text-sm font-semibold"">
                                        Minh ne
                                    </span>
                                    <spa");
                WriteLiteral(@"n class=""d-block text-xs text-muted font-regular"">
                                        HoChiMinh, HCM
                                    </span>
                                </div>
                                <div class=""ms-auto"">
                                    <i class=""fa fa-comment""></i>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""#"" class=""nav-link d-flex align-items-center"">
                                <div class=""me-4"">
                                    <div class=""position-relative d-inline-block text-white"">
                                        <img alt=""..."" src=""https://icon-library.com/images/avatar-icon-images/avatar-icon-images-4.jpg"" class=""avatar rounded-circle"">
                                        <span class=""position-absolute bottom-2 end-2 transform translate-x-1/2 translate-y-1/2 border-2 border-solid border-current w-3 h-3 ");
                WriteLiteral(@"bg-danger rounded-circle""></span>
                                    </div>
                                </div>
                                <div>
                                    <span class=""d-block text-sm font-semibold"">
                                        Eimi Fukada
                                    </span>
                                    <span class=""d-block text-xs text-muted font-regular"">
                                        Tokyo, JP
                                    </span>
                                </div>
                                <div class=""ms-auto"">
                                    <i class=""fa fa-comment""></i>
                                </div>
                            </a>
                        </li>
                    </ul>
                    <!-- Push content down -->
                    <div class=""mt-auto""></div>
                    <!-- User (md) -->
                    <ul class=""navbar-nav"">
                      ");
                WriteLiteral(@"  <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <i class=""fa fa-user-circle-o""></i> Account
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">
                                <i class=""fa fa-sign-out""></i> Logout
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <!-- Main content -->
        <div class=""h-screen flex-grow-1 overflow-y-lg-auto"">
            <!-- Header -->
            <header class=""bg-surface-primary border-bottom pt-6"">
                <div class=""container-fluid"">
                    <div class=""mb-npx"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-6 col-12 mb-4 mb-sm-0"">
                                <!-- Title -->
       ");
                WriteLiteral(@"                         <h1 class=""h2 mb-0 ls-tight"">Application</h1>
                            </div>
                            <!-- Actions -->
                            <div class=""col-sm-6 col-12 text-sm-end"">
                                <div class=""mx-n1"">
");
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6035028a467cb2419841d3023c6edf22f0659e7226137", async() => {
                    WriteLiteral(@"
                                        <span class="" pe-2"">
                                            <i class=""fa fa-plus-circle""></i>
                                        </span>
                                        <span>Create</span>
                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <!-- Nav -->
                        <ul class=""nav nav-tabs mt-4 overflow-x border-0"">
                            <li class=""nav-item "">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6035028a467cb2419841d3023c6edf22f0659e7228249", async() => {
                    WriteLiteral("All Content");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n");
                WriteLiteral(@"                            <li class=""nav-item"">
                                <a class=""nav-link font-regular"">Shared</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </header>
            <!-- Main -->
            <main class=""py-6 bg-surface-secondary"">
                <div class=""container-fluid"">
                    <div class=""card mb-7"">
                        <div class=""card-header"">
                            <h5 class=""mb-0"">Manage information staff</h5>
                        </div>
                        <div class=""table-responsive"">
                            <table class=""table table-hover table-nowrap"">
                                <thead class=""table-light"">
                                    <tr>
                                        <th scope=""col"">No.</th>
                                        <th scope=""col"">Username</th>
                                        <th scope=""");
                WriteLiteral(@"col"">Phone</th>
                                        <th scope=""col"">Date of birth</th>
                                        <th scope=""col"">Address</th>
                                        <th scope=""col"">Gender</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>1</td>
                                        <td>Harris</td>
                                        <td><i class=""fa fa-phone""></i> 0987654312</td>
                                        <td>Feb 17, 2002</td>
                                        <td><i class=""fa fa-map-marker""></i>Ha Noi</td>
                                        <td>Male</td>
                                    </tr>
                                    <tr>
                                        <td>2</td>
                                        <td>Harris</td>
                         ");
                WriteLiteral(@"               <td><i class=""fa fa-phone""></i> 0987654312</td>
                                        <td>Feb 17, 2002</td>
                                        <td><i class=""fa fa-map-marker""></i>Ha Noi</td>
                                        <td>Male</td>
                                    </tr>
                                    <tr>
                                        <td>3</td>
                                        <td>Harris</td>
                                        <td><i class=""fa fa-phone""></i> 0987654312</td>
                                        <td>Feb 17, 2002</td>
                                        <td><i class=""fa fa-map-marker""></i>Ha Noi</td>
                                        <td>Male</td>
                                    </tr>
                                    <tr>
                                        <td>4</td>
                                        <td>Harris</td>
                                        <td><i class=""fa fa-phone""></");
                WriteLiteral(@"i> 0987654312</td>
                                        <td>Feb 17, 2002</td>
                                        <td><i class=""fa fa-map-marker""></i>Ha Noi</td>
                                        <td>Male</td>
                                    </tr>
                                    <tr>
                                        <td>5</td>
                                        <td>Harris</td>
                                        <td><i class=""fa fa-phone""></i> 0987654312</td>
                                        <td>Feb 17, 2002</td>
                                        <td><i class=""fa fa-map-marker""></i>Ha Noi</td>
                                        <td>Male</td>
                                    </tr>
                                    <tr>
                                        <td>6</td>
                                        <td>Harris</td>
                                        <td><i class=""fa fa-phone""></i> 0987654312</td>
                        ");
                WriteLiteral(@"                <td>Feb 17, 2002</td>
                                        <td><i class=""fa fa-map-marker""></i>Ha Noi</td>
                                        <td>Male</td>
                                    </tr>
                                    <tr>
                                        <td>7</td>
                                        <td>Harris</td>
                                        <td><i class=""fa fa-phone""></i> 0987654312</td>
                                        <td>Feb 17, 2002</td>
                                        <td><i class=""fa fa-map-marker""></i>Ha Noi</td>
                                        <td>Male</td>
                                    </tr>
                                    <tr>
                                        <td>8</td>
                                        <td>Harris</td>
                                        <td><i class=""fa fa-phone""></i> 0987654312</td>
                                        <td>Feb 17, 2002</td>
     ");
                WriteLiteral(@"                                   <td><i class=""fa fa-map-marker""></i>Ha Noi</td>
                                        <td>Male</td>
                                    </tr>
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
    </div>


    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 297 "C:\COMP1640_EnterpriseWeb\Code\Enterprise-Web\COMP1640\Views\Shared\_LayoutManageInformation.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
