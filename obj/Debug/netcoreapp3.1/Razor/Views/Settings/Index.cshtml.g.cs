#pragma checksum "C:\Projects\BootstrapThemesForAspNet\AdminKitTemplateTheme\Views\Settings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cb49bcd6df0864e5d6218fd5f5bac0dc8676426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_Index), @"mvc.1.0.view", @"/Views/Settings/Index.cshtml")]
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
#line 1 "C:\Projects\BootstrapThemesForAspNet\AdminKitTemplateTheme\Views\_ViewImports.cshtml"
using AdminKitTemplateTheme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BootstrapThemesForAspNet\AdminKitTemplateTheme\Views\_ViewImports.cshtml"
using AdminKitTemplateTheme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb49bcd6df0864e5d6218fd5f5bac0dc8676426", @"/Views/Settings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27a34a76403ac2ee4664614de5f48406811e719", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\BootstrapThemesForAspNet\AdminKitTemplateTheme\Views\Settings\Index.cshtml"
  
ViewData["Title"] = "Settings";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid p-0"">

    <h1 class=""h3 mb-3"">Settings</h1>

    <div class=""row"">
        <div class=""col-md-3 col-xl-2"">

            <div class=""card"">
                <div class=""card-header"">
                    <h5 class=""card-title mb-0"">Profile Settings</h5>
                </div>

                <div class=""list-group list-group-flush"" role=""tablist"">
                    <a class=""list-group-item list-group-item-action active"" data-toggle=""list"" href=""#account"" role=""tab"">
                        Account
                    </a>
                    <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#password"" role=""tab"">
                        Password
                    </a>
                    <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#"" role=""tab"">
                        Privacy and safety
                    </a>
                    <a class=""list-group-item list-group-item-action"" data-toggle=""list"" h");
            WriteLiteral(@"ref=""#"" role=""tab"">
                        Email notifications
                    </a>
                    <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#"" role=""tab"">
                        Web notifications
                    </a>
                    <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#"" role=""tab"">
                        Widgets
                    </a>
                    <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#"" role=""tab"">
                        Your data
                    </a>
                    <a class=""list-group-item list-group-item-action"" data-toggle=""list"" href=""#"" role=""tab"">
                        Delete account
                    </a>
                </div>
            </div>
        </div>

        <div class=""col-md-9 col-xl-10"">
            <div class=""tab-content"">
                <div class=""tab-pane fade show active"" id=""account"" role=""tabpanel"">

  ");
            WriteLiteral(@"                  <div class=""card"">
                        <div class=""card-header"">

                            <h5 class=""card-title mb-0"">Public info</h5>
                        </div>
                        <div class=""card-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb49bcd6df0864e5d6218fd5f5bac0dc86764266087", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-8"">
                                        <div class=""mb-3"">
                                            <label class=""form-label"" for=""inputUsername"">Username</label>
                                            <input type=""text"" class=""form-control"" id=""inputUsername"" placeholder=""Username"">
                                        </div>
                                        <div class=""mb-3"">
                                            <label class=""form-label"" for=""inputUsername"">Biography</label>
                                            <textarea rows=""2"" class=""form-control"" id=""inputBio"" placeholder=""Tell something about yourself""></textarea>
                                        </div>
                                    </div>
                                    <div class=""col-md-4"">
                                        <div class=""text-center"">
                        ");
                WriteLiteral(@"                    <img alt=""Charles Hall"" src=""img/avatars/avatar.jpg"" class=""rounded-circle img-responsive mt-2"" width=""128"" height=""128"" />
                                            <div class=""mt-2"">
                                                <span class=""btn btn-primary""><i class=""fas fa-upload""></i> Upload</span>
                                            </div>
                                            <small>For best results, use an image at least 128px by 128px in .jpg format</small>
                                        </div>
                                    </div>
                                </div>

                                <button type=""submit"" class=""btn btn-primary"">Save changes</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

                    <div class=""card"">
                        <div class=""card-header"">

                            <h5 class=""card-title mb-0"">Private info</h5>
                        </div>
                        <div class=""card-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb49bcd6df0864e5d6218fd5f5bac0dc86764269556", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""mb-3 col-md-6"">
                                        <label class=""form-label"" for=""inputFirstName"">First name</label>
                                        <input type=""text"" class=""form-control"" id=""inputFirstName"" placeholder=""First name"">
                                    </div>
                                    <div class=""mb-3 col-md-6"">
                                        <label class=""form-label"" for=""inputLastName"">Last name</label>
                                        <input type=""text"" class=""form-control"" id=""inputLastName"" placeholder=""Last name"">
                                    </div>
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""inputEmail4"">Email</label>
                                    <input type=""email"" class=""form-control"" id=""inputEmail4"" placehol");
                WriteLiteral(@"der=""Email"">
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""inputAddress"">Address</label>
                                    <input type=""text"" class=""form-control"" id=""inputAddress"" placeholder=""1234 Main St"">
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""inputAddress2"">Address 2</label>
                                    <input type=""text"" class=""form-control"" id=""inputAddress2"" placeholder=""Apartment, studio, or floor"">
                                </div>
                                <div class=""row"">
                                    <div class=""mb-3 col-md-6"">
                                        <label class=""form-label"" for=""inputCity"">City</label>
                                        <input type=""text"" class=""form-control"" id=""inputCity"">
                ");
                WriteLiteral(@"                    </div>
                                    <div class=""mb-3 col-md-4"">
                                        <label class=""form-label"" for=""inputState"">State</label>
                                        <select id=""inputState"" class=""form-control"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb49bcd6df0864e5d6218fd5f5bac0dc867642612349", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb49bcd6df0864e5d6218fd5f5bac0dc867642613734", async() => {
                    WriteLiteral("...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </select>
                                    </div>
                                    <div class=""mb-3 col-md-2"">
                                        <label class=""form-label"" for=""inputZip"">Zip</label>
                                        <input type=""text"" class=""form-control"" id=""inputZip"">
                                    </div>
                                </div>
                                <button type=""submit"" class=""btn btn-primary"">Save changes</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                <div class=""tab-pane fade"" id=""password"" role=""tabpanel"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Password</h5>

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb49bcd6df0864e5d6218fd5f5bac0dc867642616656", async() => {
                WriteLiteral(@"
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""inputPasswordCurrent"">Current password</label>
                                    <input type=""password"" class=""form-control"" id=""inputPasswordCurrent"">
                                    <small><a href=""#"">Forgot your password?</a></small>
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""inputPasswordNew"">New password</label>
                                    <input type=""password"" class=""form-control"" id=""inputPasswordNew"">
                                </div>
                                <div class=""mb-3"">
                                    <label class=""form-label"" for=""inputPasswordNew2"">Verify password</label>
                                    <input type=""password"" class=""form-control"" id=""inputPasswordNew2"">
                                </div>
      ");
                WriteLiteral("                          <button type=\"submit\" class=\"btn btn-primary\">Save changes</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
