#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4deea6fb30829d3da0654dedd759c4fa7cbc8f7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
using System.Globalization;

#line default
#line hidden
#line 2 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
using Abp.Extensions;

#line default
#line hidden
#line 3 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#line 4 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
using GSoft.AbpZeroTemplate.Identity;

#line default
#line hidden
#line 5 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4deea6fb30829d3da0654dedd759c4fa7cbc8f7f", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<GSoft.AbpZeroTemplate.Web.Models.Account.LoginFormViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Views/Account/Login.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-login__form m-form login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExternalLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Scripts", async() => {
                BeginContext(270, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(275, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f79f37c6c244fffb0d7e6bb27702ad1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 10 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper.AppendVersion = __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion;
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(367, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(370, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 13 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
 if (!Model.SuccessMessage.IsNullOrEmpty())
{

#line default
#line hidden
            BeginContext(417, 87, true);
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\n        ");
            EndContext();
            BeginContext(505, 20, false);
#line 16 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
   Write(Model.SuccessMessage);

#line default
#line hidden
            EndContext();
            BeginContext(525, 167, true);
            WriteLiteral("\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n            <span aria-hidden=\"true\">&times;</span>\n        </button>\n    </div>\n");
            EndContext();
#line 21 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
}

#line default
#line hidden
            BeginContext(694, 111, true);
            WriteLiteral("\n<div class=\"m-login__signin\">\n    <div class=\"m-login__head\">\n        <h3 class=\"m-login__title\">\n            ");
            EndContext();
            BeginContext(806, 10, false);
#line 26 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
       Write(L("LogIn"));

#line default
#line hidden
            EndContext();
            BeginContext(816, 30, true);
            WriteLiteral("\n        </h3>\n    </div>\n    ");
            EndContext();
            BeginContext(846, 1517, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46b7e6ef3a2d41d7aae309eaf95dd296", async() => {
                BeginContext(925, 46, true);
                WriteLiteral("\n        <input type=\"hidden\" name=\"returnUrl\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 971, "\"", 997, 1);
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 979, ViewBag.ReturnUrl, 979, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(998, 95, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"returnUrlHash\" />\n        <input type=\"hidden\" name=\"ss\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1093, "\"", 1122, 1);
#line 32 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 1101, ViewBag.SingleSignIn, 1101, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1123, 110, true);
                WriteLiteral(" />\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control m-input\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1233, "\"", 1268, 1);
#line 34 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 1247, L("UserNameOrEmail"), 1247, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1269, 49, true);
                WriteLiteral(" name=\"usernameOrEmailAddress\" autocomplete=\"off\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1318, "\"", 1363, 1);
#line 34 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 1326, Model.UserNameOrEmailAddress ?? "", 1326, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1364, 162, true);
                WriteLiteral(" required>\n        </div>\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control m-input m-login__form-input--last\" type=\"password\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1526, "\"", 1554, 1);
#line 37 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 1540, L("Password"), 1540, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1555, 299, true);
                WriteLiteral(@" name=""password"" autocomplete=""off"" >
        </div>
        <div class=""row m-login__form-sub"">
            <div class=""col m--align-left"">
                <label class=""m-checkbox m-checkbox--primary"">
                    <input type=""checkbox"" name=""rememberMe"" value=""true"">
                    ");
                EndContext();
                BeginContext(1855, 15, false);
#line 43 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
               Write(L("RememberMe"));

#line default
#line hidden
                EndContext();
                BeginContext(1870, 142, true);
                WriteLiteral("\n                    <span></span>\n                </label>\n            </div>\n            <div class=\"col m--align-right\">\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2012, "\"", 2059, 1);
#line 48 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 2019, Url.Action("ForgotPassword", "Account"), 2019, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2060, 53, true);
                WriteLiteral(" id=\"forget-password\" class=\"m-link forget-password\">");
                EndContext();
                BeginContext(2114, 19, false);
#line 48 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
                                                                                                                  Write(L("ForgotPassword"));

#line default
#line hidden
                EndContext();
                BeginContext(2133, 183, true);
                WriteLiteral("</a>\n            </div>\n        </div>\n        <div class=\"m-login__form-action\">\n            <button type=\"submit\" class=\"btn btn-primary m-btn m-btn--pill m-btn--custom m-btn--air\">");
                EndContext();
                BeginContext(2317, 10, false);
#line 52 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
                                                                                                Write(L("LogIn"));

#line default
#line hidden
                EndContext();
                BeginContext(2327, 29, true);
                WriteLiteral("</button>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2363, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
#line 57 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
  
    var loginProviders = (await SignInManager.GetExternalAuthenticationSchemesAsync())
        .Where(s => !s.DisplayName.IsNullOrWhiteSpace())
        .ToList();

    Func<string, string> getSocialIconClass = (provider) =>
    {
        provider = provider.ToLower(CultureInfo.InvariantCulture);

        return provider;
    };

#line default
#line hidden
            BeginContext(2707, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 70 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
 if ((AbpSession.MultiTenancySide != MultiTenancySides.Host || !ViewBag.IsMultiTenancyEnabled) && loginProviders.Count > 0)
{

#line default
#line hidden
            BeginContext(2834, 44, true);
            WriteLiteral("    <div class=\"login-options\">\n        <h4>");
            EndContext();
            BeginContext(2879, 14, false);
#line 73 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
       Write(L("LoginWith"));

#line default
#line hidden
            EndContext();
            BeginContext(2893, 52, true);
            WriteLiteral("</h4>\n        <ul class=\"social-icons\">\n            ");
            EndContext();
            BeginContext(2945, 701, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "673b644e3fe8484d823c732efcd791b3", async() => {
                BeginContext(2992, 54, true);
                WriteLiteral("\n                <input type=\"hidden\" name=\"returnUrl\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3046, "\"", 3072, 1);
#line 76 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 3054, ViewBag.ReturnUrl, 3054, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3073, 115, true);
                WriteLiteral(" />\n                <input type=\"hidden\" name=\"provider\" value=\"\" />\n                <input type=\"hidden\" name=\"ss\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3188, "\"", 3217, 1);
#line 78 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 3196, ViewBag.SingleSignIn, 3196, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3218, 5, true);
                WriteLiteral(" />\n\n");
                EndContext();
#line 80 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
                 foreach (var p in loginProviders)
                {

#line default
#line hidden
                BeginContext(3292, 51, true);
                WriteLiteral("                    <li>\n                        <a");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3343, "\"", 3421, 3);
                WriteAttributeValue("", 3351, "social-login-icon", 3351, 17, true);
                WriteAttributeValue(" ", 3368, "social-icon-color", 3369, 18, true);
#line 83 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue(" ", 3386, getSocialIconClass(p.DisplayName), 3387, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", "\n                           title=\"", 3422, "\"", 3471, 1);
#line 84 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 3457, p.DisplayName, 3457, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3472, 43, true);
                WriteLiteral("\n                           data-provider=\"");
                EndContext();
                BeginContext(3516, 13, false);
#line 85 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
                                     Write(p.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(3529, 80, true);
                WriteLiteral("\"\n                           href=\"javascript:;\"></a>\n                    </li>\n");
                EndContext();
#line 88 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
                }

#line default
#line hidden
                BeginContext(3627, 12, true);
                WriteLiteral("            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3646, 26, true);
            WriteLiteral("\n        </ul>\n    </div>\n");
            EndContext();
#line 92 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
}

#line default
#line hidden
            BeginContext(3674, 86, true);
            WriteLiteral("\n<div class=\"m-stack__item m-stack__item--center\">\n    <div class=\"m-login__account\">\n");
            EndContext();
#line 96 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
         if (Model.IsSelfRegistrationEnabled)
        {

#line default
#line hidden
            BeginContext(3816, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3830, "\"", 3937, 1);
#line 98 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 3837, Url.Action("Register", "Account", new { ss = ViewBag.SingleSignIn, returnUrl = ViewBag.ReturnUrl }), 3837, 100, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3938, 72, true);
            WriteLiteral(" id=\"register-btn\" class=\"m-link m-link--primary m-login__account-link\">");
            EndContext();
            BeginContext(4011, 20, false);
#line 98 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
                                                                                                                                                                                             Write(L("CreateAnAccount"));

#line default
#line hidden
            EndContext();
            BeginContext(4031, 55, true);
            WriteLiteral("</a>\n            <span class=\"pipe-divider\"> | </span>\n");
            EndContext();
#line 100 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
        }

#line default
#line hidden
            BeginContext(4096, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 101 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
         if (Model.IsTenantSelfRegistrationEnabled)
        {

#line default
#line hidden
            BeginContext(4158, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4172, "\"", 4229, 1);
#line 103 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 4179, Url.Action("SelectEdition", "TenantRegistration"), 4179, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4230, 72, true);
            WriteLiteral(" id=\"register-btn\" class=\"m-link m-link--primary m-login__account-link\">");
            EndContext();
            BeginContext(4303, 14, false);
#line 103 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
                                                                                                                                           Write(L("NewTenant"));

#line default
#line hidden
            EndContext();
            BeginContext(4317, 55, true);
            WriteLiteral("</a>\n            <span class=\"pipe-divider\"> | </span>\n");
            EndContext();
#line 105 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
        }

#line default
#line hidden
            BeginContext(4382, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4392, "\"", 4440, 1);
#line 106 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
WriteAttributeValue("", 4399, Url.Action("EmailActivation", "Account"), 4399, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4441, 80, true);
            WriteLiteral(" id=\"email-activation-btn\" class=\"m-link m-link--primary m-login__account-link\">");
            EndContext();
            BeginContext(4522, 20, false);
#line 106 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\Login.cshtml"
                                                                                                                                      Write(L("EmailActivation"));

#line default
#line hidden
            EndContext();
            BeginContext(4542, 22, true);
            WriteLiteral("</a>\n    </div>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GSoft.AbpZeroTemplate.Web.Models.Account.LoginFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
