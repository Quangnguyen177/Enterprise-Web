#pragma checksum "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a803036d291382d3932702a0ac0e4563d2ecd9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_AddIdea), @"mvc.1.0.view", @"/Views/Staff/AddIdea.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a803036d291382d3932702a0ac0e4563d2ecd9c", @"/Views/Staff/AddIdea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47bc00708d873f7e313183e39901136d2a34b3e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Staff_AddIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleIdea.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fb-icons/bx-arrow-back.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fb-icons/theme.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("theme"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fb-icons/smile.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("smile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddIdea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Staff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
  
    Layout = "_Staff";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a803036d291382d3932702a0ac0e4563d2ecd9c8395", async() => {
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
            WriteLiteral("   \r\n");
#nullable restore
#line 5 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
    ViewData["Title"] = "Add Idea";
    Profile logginnedUser = (Profile)ViewBag.LogginedUser;
    var evt = ViewBag.Event;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
 if (User.Identity.IsAuthenticated && User.IsInRole("Staff"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"wrapper\">\r\n        <section class=\"post\">\r\n            <header class=\"row\">\r\n                <a class=\"col-2\" href=\"javascript:history.back()\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a803036d291382d3932702a0ac0e4563d2ecd9c10194", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                <div class=\"col-8\">Create Idea</div>\r\n            </header>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a803036d291382d3932702a0ac0e4563d2ecd9c11328", async() => {
                WriteLiteral("\r\n                <div class=\"content\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 773, "\"", 809, 2);
                WriteAttributeValue("", 779, "/Avatars/", 779, 9, true);
#nullable restore
#line 20 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
WriteAttributeValue("", 788, logginnedUser.Avatar, 788, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"logo\">\r\n                    <div class=\"details\">\r\n                        <p><b>");
#nullable restore
#line 22 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
                         Write(logginnedUser.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></p>\r\n                        <div class=\"option\" style=\"height: 75px;\">\r\n                            <label class=\"switch\">\r\n                                <input type=\"checkbox\" name=\"isAnonymous\" value=\"true\">  ");
                WriteLiteral(@"
                                <div class=""slider""></div>
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
                    <input type=""text"" name=""title"" placeholder=""Title"" required />   ");
                WriteLiteral("\r\n                </div>\r\n                <input type=\"hidden\" name=\"profileId\"");
                BeginWriteAttribute("value", " value=\"", 1872, "\"", 1897, 1);
#nullable restore
#line 39 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
WriteAttributeValue("", 1880, logginnedUser.Id, 1880, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
                WriteLiteral("\r\n                <textarea form=\"add\" name=\"content\" placeholder=\"Post content idea here...\" required></textarea>   ");
                WriteLiteral("\r\n                <div class=\"theme-emoji\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a803036d291382d3932702a0ac0e4563d2ecd9c14089", async() => {
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
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a803036d291382d3932702a0ac0e4563d2ecd9c15284", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"options\">\r\n                    <div class=\"row\">\r\n                        <input type=\"file\" id=\"uploadedFiles\" name=\"uploadedFiles\" class=\"buttonDownload col-3\" multiple> ");
                WriteLiteral("\r\n                        <div class=\"form-group col-5\">\r\n                            <select class=\"form-select-category\" name=\"categoryName\" required>\r\n");
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a803036d291382d3932702a0ac0e4563d2ecd9c16969", async() => {
                    WriteLiteral("Category");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 52 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
                                 foreach (var c in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a803036d291382d3932702a0ac0e4563d2ecd9c18589", async() => {
#nullable restore
#line 54 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
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
#line 54 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
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
#line 55 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a803036d291382d3932702a0ac0e4563d2ecd9c21027", async() => {
                    WriteLiteral("Event");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 63 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
                                 foreach (var e in evt)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a803036d291382d3932702a0ac0e4563d2ecd9c22642", async() => {
#nullable restore
#line 65 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
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
#line 65 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
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
#line 66 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>
                            <span class=""text-danger""></span>
                        </div>
                    </div>
                </div>

                <button type=""button"" data-toggle=""modal"" data-target=""#exampleModal"">
                    Post
                </button>

                <!--Modal-->
                   <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""exampleModalLabel""><b style=""font-size:23px"">Terms & Conditions of Website Use</b></h5>
");
                WriteLiteral(@"                            </div>
                            <div class=""modal-body"">
                                    <div class=""terms_conditions"">
                                        <div class=""title_term"">
                                            <span>Siintor values your privacy and is committed to protecting your personal information at all times. In this document, the word ""personal information"" refers to your name, address, email address, phone number, or any other personal information you disclose to or collect as required by law. current. This article is intended to help you understand what personal information we gather and how we use it.</span>
                                            <span>We reserve the right to update, modify, add, and/or remove elements of these Conditions of Use at any time in our sole discretion. It is your duty to check these Terms of Service for modifications on a regular basis. Your continued use of the Website following the posting of changes indicat");
                WriteLiteral(@"es that you acknowledge and consent to such changes. We provide you a personal, non-exclusive, non-transferable, limited right to access and use the Site as long as you comply with these Conditions of Use.</span>
                                            <span>We realize that by accessing and using the website (including registering for online services), you fully agree to the terms of this policy.</span>
                                        </div>
                                        <div class=""heading_term"">
                                            <div class=""heading1"">
                                                <h3>1. Content idea</h3>
                                                <span>
                                                    Any documents, user interfaces, visual interfaces, images, trademarks, logos, and computer code (collectively, ""Content""), including but not limited to design, structure, selection, coordination, and expression (collectively, ""Content""). The Sit");
                WriteLiteral(@"e's Content is owned, controlled, or licensed by Siintor Company and is protected by trade dress, copyright, patent and trademark law, and other intellectual property rights and unfair competition laws.
                                                </span>
                                                <span>
                                                    Unless specifically stated otherwise in these Conditions of Use, you may not copy, republish, upload, or transmit any content (including ""mirroring"") to any computer, server, website, or other means for publishing or distribution, or for any business venture, without our prior written approval.
                                                </span>
                                                <span>You may use information about our products and services (such as knowledge base articles and similar documents) provided by Siintor Corporation for download from the Website, provided that you (1) do not remove any proprietary ideas in all such co");
                WriteLiteral(@"pies of the material, (2) use such information only for your personal, non-commercial purposes and do not copy or post the information on any networked computer or broadcast on any medium, (3) do not modify any information, and (4) do not remove any proprietary ideas in all such copies of the material.</span>
                                            </div>
                                            <div class=""heading1"">
                                                <h3>2. Personal posting requirements</h3>
                                                <span>Ascertain that you are a school employee. Because this is the Siintor Foundation's own private software, you may not use the Website under any circumstances or for any reason if you are not an employee of the institution. We may refuse to supply the Services to any individual or business at our sole discretion and amend our eligibility requirements at any time.</span>
                                            </div>
                       ");
                WriteLiteral(@"                     <div class=""heading1"">
                                                <h3>3. Content idea conditions</h3>
                                                <span>Siintor reserves the right to refuse content that is false, misleading, dishonest, or inaccurate, or that is illegal, threatening, abusive, harassing, defamatory, fraudulent, fraudulent, invading other people's privacy, torturing, obscene, vulgar, obscene, offensive, contains or depicts nudity, contains or depicts sexual activity, or is otherwise inappropriate in our sole discretion. If the post is found, it will be removed immediately.</span>
                                            </div>
                                            <div class=""heading1"">
                                                <h3>4. Information security </h3>
                                                <span>We will use the information you submit to respond to your request, or we may contact you by letter, email, or phone. By submitting inf");
                WriteLiteral(@"ormation to us - via this website, you acknowledge and consent to the collection, use, and sharing of the aforementioned personal information for some of the objectives outlined on this site.</span>
                                                <span>You completely agree and accept that the personal information you submit when using the website may be preserved in the system's archives, and that you have the option to hide or make your information public.</span>
                                                <span>Siintor is dedicated to respecting your privacy and will never buy, sell, or trade your personal information with other companies for promotional purposes.</span>
                                            </div>
                                            <div class=""heading1"">
                                                <h3>5. Usage of the Website by You</h3>
                                                <span>You agree not to use any ""deep-link,"" ""page-scrape,"" ""robot,"" ""spider,"" ");
                WriteLiteral(@"or other automated device, program, algorithm, or method, or any similar manual process or equivalent, to access, collect, copy, or monitor any part of the website or any Content, or to reproduce or circumvent the navigation or presentation structure of the Website or any Content in any way, to obtain or attempt to obtain any materials, records, or information from the Website. We reserve the right to forbid such behavior.</span>
                                                <span>You agree not to attempt to gain unauthorized access to any portion or feature of the Website, as well as any other system or network linked to the Website, any of our servers, or any other service. provided on or through the Website, by hacking, using ""mining"" passwords, or by any other illegal means.</span>
                                                <span>You agree not to probe, scan, or test the vulnerability of the Website or any network linked to the Website, or to violate the Website's or any network connected to the ");
                WriteLiteral(@"Website's security or authentication procedures. Webpage. You will not reverse search, track, or attempt to track any information about any user or visitor to the Website or any other Siintor staff, including any of our accounts not owned by you, the source or exploitation of the Website, or any services or information available or provided by or through the Website, for any purpose other than to disclose any information, including but not limited to personally identifiable information.</span>
                                            </div>
                                        </div>
                                    </div>
                                 <br>

                                <input type=""checkbox"" class=""term_checkbox"" required />
                               <label id=""term_checkbox"" style=""color: #050595;"">I agree Terms & Conditions of Website Use</label>
                            </div>
                            <div class=""modal-footer"">
                         ");
                WriteLiteral("       <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\r\n                                <button type=\"submit\" id=\"submit\" class=\"btn btn-primary\">Submit</button>      ");
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </section>\r\n    </div>\r\n");
#nullable restore
#line 142 "E:\GitHub\Enterprise-Web\COMP1640\Views\Staff\AddIdea.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
