#pragma checksum "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c5eb3d415d1dc984220b3fcd60b1b6a2dc4784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_EditIdea), @"mvc.1.0.view", @"/Views/Staff/EditIdea.cshtml")]
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
#line 1 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
using COMP1640;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\_ViewImports.cshtml"
using COMP1640.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c5eb3d415d1dc984220b3fcd60b1b6a2dc4784", @"/Views/Staff/EditIdea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47bc00708d873f7e313183e39901136d2a34b3e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Staff_EditIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Idea>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fb-icons/bx-arrow-back.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fb-icons/theme.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("theme"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fb-icons/smile.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("smile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TermsConditions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Staff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditIdea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
  
    Layout = "_LayoutPostIdea";
    ViewData["Title"] = "Edit Idea";
    Profile logginnedUser = (Profile)ViewBag.LogginedUser;
    var evt = ViewBag.Event;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Staff"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"wrapper\">\r\n        <section class=\"post\">\r\n            <header class=\"row\">\r\n                <a class=\"col-2\" href=\"javascript:history.back()\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc47848929", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                <div class=\"col-8\">Create Idea</div>\r\n            </header>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478410062", async() => {
                WriteLiteral("\r\n                <div class=\"content\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 718, "\"", 754, 2);
                WriteAttributeValue("", 724, "/Avatars/", 724, 9, true);
#nullable restore
#line 20 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
WriteAttributeValue("", 733, logginnedUser.Avatar, 733, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"logo\">\r\n                    <div class=\"details\">\r\n                        <p><b>");
#nullable restore
#line 22 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                         Write(logginnedUser.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n                        <div class=\"option\" style=\"height: 75px;\">\r\n                            <label class=\"switch\">\r\n");
#nullable restore
#line 25 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                 if (@Model.idea_anonymous){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                     <input type=\"checkbox\" name=\"isAnonymous\" value=\"true\" checked>  ");
#nullable restore
#line 26 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                                                                                                    
                                } else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                                     <input type=\"checkbox\" name=\"isAnonymous\" value=\"true\">  ");
#nullable restore
#line 28 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                                                                                            
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""slider""></div>
                                <div class=""slider-card"">
                                    <div class=""slider-card-face slider-card-front""></div>
                                    <div class=""slider-card-face slider-card-back""></div>
                                </div>
                            </label>
                            <h5>Anonymous</h5>
                        </div>
                    </div>
                </div>
                <div class=""box"">
                    <input type=""text"" name=""title"" placeholder=""Title""");
                BeginWriteAttribute("value", " value=\"", 1975, "\"", 2000, 1);
#nullable restore
#line 41 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
WriteAttributeValue("", 1983, Model.idea_title, 1983, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />   ");
                WriteLiteral("\r\n                </div>\r\n                <input type=\"hidden\" name=\"ideaId\"");
                BeginWriteAttribute("value", " value=\"", 2101, "\"", 2122, 1);
#nullable restore
#line 43 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
WriteAttributeValue("", 2109, Model.IdeaId, 2109, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
                WriteLiteral("\r\n                <textarea form=\"edit\" name=\"content\" placeholder=\"Post content idea here...\" required>");
#nullable restore
#line 44 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                                                                                 Write(Model.idea_content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>   ");
                WriteLiteral("\r\n                <div class=\"theme-emoji\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478414863", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478416058", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"options\">\r\n                    <div class=\"row\">\r\n                        <input type=\"file\" id=\"uploadedFiles\" name=\"uploadedFiles\" class=\"buttonDownload col-3\"  multiple> ");
                WriteLiteral("\r\n                        <div class=\"form-group col-5\">\r\n                            <select class=\"form-select-category\" name=\"categoryName\" required>\r\n");
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478417744", async() => {
                    WriteLiteral("Category");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 56 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                 foreach (var c in @ViewBag.Category)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                     if(@c.CategoryId == (@Model.CategoryId))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478419779", async() => {
#nullable restore
#line 60 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                                                            Write(c.category_name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                          WriteLiteral(c.category_name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 61 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                    }                                   
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478422513", async() => {
#nullable restore
#line 64 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                                                   Write(c.category_name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                          WriteLiteral(c.category_name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 65 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>
                            <span class=""text-danger""></span>
                        </div>
                        <div class=""form-group col-4"">
                            <select class=""form-select-event"" name=""eventId"" required>
");
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478425381", async() => {
                    WriteLiteral("Event");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 74 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                 foreach (var e in evt)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                     if(@e.EventId == @Model.EventId)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478427391", async() => {
#nullable restore
#line 78 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                                                      Write(e.EventName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                          WriteLiteral(e.EventId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 79 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                    }                                   
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478430109", async() => {
#nullable restore
#line 82 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                                             Write(e.EventName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                          WriteLiteral(e.EventId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 83 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
                                     
                                  
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>
                            <span class=""text-danger""></span>
                        </div>
                    </div>
                </div>
                <button type=""button"" data-toggle=""modal"" data-target=""#exampleModal"">Update</button>

                <!--Modal-->
                <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""exampleModalLabel""><b style=""font-size:20px"">Privacy</b></h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>");
                WriteLiteral("\r\n                            <div class=\"modal-body\">\r\n                                <input type=\"checkbox\" required />\r\n                                <span>I agree ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c5eb3d415d1dc984220b3fcd60b1b6a2dc478433927", async() => {
                    WriteLiteral("Terms & Conditions of Website Use ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</span>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                                <button type=""submit"" id=""submit"" class=""btn btn-primary"">Submit</button>      ");
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </section>\r\n    </div>\r\n");
#nullable restore
#line 117 "F:\F2G - UOG\COMP1640 - Enterprise Web Software Development\Enterprise-Web\COMP1640\Views\Staff\EditIdea.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Idea> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
