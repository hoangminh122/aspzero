#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f26eb911b41628fcd8a18255dfb37180863bdc9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TenantRegistration_Register), @"mvc.1.0.view", @"/Views/TenantRegistration/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TenantRegistration/Register.cshtml", typeof(AspNetCore.Views_TenantRegistration_Register))]
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
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
using Abp.Json;

#line default
#line hidden
#line 2 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
using GSoft.AbpZeroTemplate.MultiTenancy;

#line default
#line hidden
#line 3 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
using GSoft.AbpZeroTemplate.Web.Models.TenantRegistration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f26eb911b41628fcd8a18255dfb37180863bdc9a", @"/Views/TenantRegistration/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Views/_ViewImports.cshtml")]
    public class Views_TenantRegistration_Register : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<TenantRegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/TenantRegistration/Register.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/TenantRegistration/Register.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectEdition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TenantRegistration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-login__form m-form register-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formTenantRegister"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaScriptTagHelper __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaTagHelper __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
  
    ViewBag.DisableTenantChange = true;

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(267, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(272, 138, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c0ca5b2f54c49eeb3970fd9ca1ba91f", async() => {
                    BeginContext(280, 44, true);
                    WriteLiteral("\n        window.passwordComplexitySetting = ");
                    EndContext();
                    BeginContext(325, 70, false);
#line 12 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
                                      Write(Html.Raw(Model.PasswordComplexitySetting.ToJsonString(indented: true)));

#line default
#line hidden
                    EndContext();
                    BeginContext(395, 6, true);
                    WriteLiteral(";\n    ");
                    EndContext();
                }
                );
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(410, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(415, 164, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76dbdcd09172472e900bd1d2e7c6ca66", async() => {
                    BeginContext(448, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(457, 103, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce45db62eb134cea80708d39fdef1840", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
                    __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 15 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
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
                    BeginContext(560, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(579, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(585, 175, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32ad0741c6d549e3bf34f962c0ee0c34", async() => {
                    BeginContext(625, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(634, 107, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67f25a538ad7411d8d846914e750169f", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
                    __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 19 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
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
                    BeginContext(741, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(760, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(766, 20, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha-script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32eeca9d308a41f7846e2b6a420cf43a", async() => {
                }
                );
                __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper = CreateTagHelper<global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaScriptTagHelper>();
                __tagHelperExecutionContext.Add(__PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaScriptTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(786, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(789, 118, true);
            WriteLiteral("<div class=\"m-login m-login__signin\">\n    <div class=\"m-login__head\">\n        <h3 class=\"m-login__title\">\n            ");
            EndContext();
            BeginContext(908, 17, false);
#line 27 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
       Write(L("TenantSignUp"));

#line default
#line hidden
            EndContext();
            BeginContext(925, 31, true);
            WriteLiteral("\n        </h3>\n        <small>\n");
            EndContext();
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
             if (Model.EditionId.HasValue)
            {

#line default
#line hidden
            BeginContext(1013, 47, true);
            WriteLiteral("                <div class=\"hint text-center\">(");
            EndContext();
            BeginContext(1061, 12, false);
#line 32 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
                                          Write(L("Edition"));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1076, 25, false);
#line 32 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
                                                         Write(Model.Edition.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1101, 8, true);
            WriteLiteral(")</div>\n");
            EndContext();
#line 33 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
            }

#line default
#line hidden
            BeginContext(1123, 32, true);
            WriteLiteral("        </small>\n    </div>\n    ");
            EndContext();
            BeginContext(1155, 3066, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "398b841b99e74ef9924ad9bf64e50b37", async() => {
                BeginContext(1264, 46, true);
                WriteLiteral("\n        <input type=\"hidden\" Name=\"EditionId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1310, "\"", 1334, 1);
#line 37 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 1318, Model.EditionId, 1318, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1335, 4, true);
                WriteLiteral(" />\n");
                EndContext();
#line 38 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
         if (Model.EditionId.HasValue)
        {

#line default
#line hidden
                BeginContext(1388, 61, true);
                WriteLiteral("            <input type=\"hidden\" Name=\"SubscriptionStartType\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1449, "\"", 1485, 1);
#line 40 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 1457, Model.SubscriptionStartType, 1457, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1486, 66, true);
                WriteLiteral(" />\n                <input type=\"hidden\" name=\"EditionPaymentType\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1552, "\"", 1585, 1);
#line 41 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 1560, Model.EditionPaymentType, 1560, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1586, 55, true);
                WriteLiteral(" />\n                <input type=\"hidden\" name=\"Gateway\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1641, "\"", 1663, 1);
#line 42 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 1649, Model.Gateway, 1649, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1664, 57, true);
                WriteLiteral(" />\n                <input type=\"hidden\" name=\"PaymentId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1721, "\"", 1745, 1);
#line 43 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 1729, Model.PaymentId, 1729, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1746, 4, true);
                WriteLiteral(" />\n");
                EndContext();
#line 44 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
        }

#line default
#line hidden
                BeginContext(1760, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 46 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
         if (@ViewBag.ErrorMessage != null)
        {

#line default
#line hidden
                BeginContext(1815, 91, true);
                WriteLiteral("            <div class=\"alert alert-danger\">\n                <i class=\"fa fa-warning\"></i> ");
                EndContext();
                BeginContext(1907, 20, false);
#line 49 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
                                         Write(ViewBag.ErrorMessage);

#line default
#line hidden
                EndContext();
                BeginContext(1927, 20, true);
                WriteLiteral("\n            </div>\n");
                EndContext();
#line 51 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
        }

#line default
#line hidden
                BeginContext(1957, 49, true);
                WriteLiteral("\n        <h4 class=\"m-login__title\">\n            ");
                EndContext();
                BeginContext(2007, 23, false);
#line 54 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
       Write(L("TenantInformations"));

#line default
#line hidden
                EndContext();
                BeginContext(2030, 134, true);
                WriteLiteral("\n        </h4>\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control form-control m-input\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2164, "\"", 2195, 1);
#line 57 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 2178, L("TenancyName"), 2178, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2196, 28, true);
                WriteLiteral(" name=\"TenancyName\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2224, "\"", 2264, 1);
#line 57 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 2236, Tenant.MaxTenancyNameLength, 2236, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2265, 138, true);
                WriteLiteral(" />\n        </div>\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control form-control m-input\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2403, "\"", 2427, 1);
#line 60 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 2417, L("Name"), 2417, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2428, 21, true);
                WriteLiteral(" name=\"Name\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2449, "\"", 2522, 1);
#line 60 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 2461, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxNameLength, 2461, 61, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2523, 85, true);
                WriteLiteral(" />\n        </div>\n\n        <h4 class=\"m-login__title m--margin-top-20\">\n            ");
                EndContext();
                BeginContext(2609, 20, false);
#line 64 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
       Write(L("AccountSettings"));

#line default
#line hidden
                EndContext();
                BeginContext(2629, 135, true);
                WriteLiteral("\n        </h4>\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control form-control m-input\" type=\"email\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2764, "\"", 2801, 1);
#line 67 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 2778, L("AdminEmailAddress"), 2778, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2802, 34, true);
                WriteLiteral(" name=\"AdminEmailAddress\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2836, "\"", 2917, 1);
#line 67 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 2848, GSoft.AbpZeroTemplate.Authorization.Users.User.MaxEmailAddressLength, 2848, 69, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2918, 180, true);
                WriteLiteral(" />\n        </div>\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control form-control m-input\" type=\"password\" autocomplete=\"off\" id=\"AdminPassword\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 3098, "\"", 3131, 1);
#line 70 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 3112, L("AdminPassword"), 3112, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3132, 191, true);
                WriteLiteral(" name=\"AdminPassword\" required />\n        </div>\n        <div class=\"form-group m-form__group\">\n            <input class=\"form-control form-control m-input\" type=\"password\" autocomplete=\"off\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 3323, "\"", 3362, 1);
#line 73 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
WriteAttributeValue("", 3337, L("AdminPasswordRepeat"), 3337, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3363, 55, true);
                WriteLiteral(" name=\"AdminPasswordRepeat\" required />\n        </div>\n");
                EndContext();
#line 75 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
         if (ViewBag.UseCaptcha)
        {


#line default
#line hidden
                BeginContext(3462, 73, true);
                WriteLiteral("            <h4 class=\"m-login__title m--margin-top-20\">\n                ");
                EndContext();
                BeginContext(3536, 16, false);
#line 79 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
           Write(L("Captha_Hint"));

#line default
#line hidden
                EndContext();
                BeginContext(3552, 19, true);
                WriteLiteral("\n            </h4>\n");
                EndContext();
                BeginContext(3572, 70, true);
                WriteLiteral("            <div class=\"form-group margin-bottom-20\">\n                ");
                EndContext();
                BeginContext(3642, 13, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("recaptcha", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3ef4e22fa17424eb9c14fb5629a867f", async() => {
                }
                );
                __PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaTagHelper = CreateTagHelper<global::PaulMiami.AspNetCore.Mvc.Recaptcha.TagHelpers.RecaptchaTagHelper>();
                __tagHelperExecutionContext.Add(__PaulMiami_AspNetCore_Mvc_Recaptcha_TagHelpers_RecaptchaTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3655, 20, true);
                WriteLiteral("\n            </div>\n");
                EndContext();
#line 85 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
        }

#line default
#line hidden
                BeginContext(3685, 101, true);
                WriteLiteral("        <div class=\"m-portlet__body\">\n            <div class=\"m-login__form-action\">\n                ");
                EndContext();
                BeginContext(3786, 237, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d2b47e50454cf1a0567d01a23cb0a0", async() => {
                    BeginContext(3852, 131, true);
                    WriteLiteral("\n                    <button type=\"button\" id=\"register-back-btn\" class=\"btn btn-outline-primary  m-btn m-btn--pill m-btn--custom\">");
                    EndContext();
                    BeginContext(3984, 9, false);
#line 89 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
                                                                                                                             Write(L("Back"));

#line default
#line hidden
                    EndContext();
                    BeginContext(3993, 26, true);
                    WriteLiteral("</button>\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4023, 131, true);
                WriteLiteral("\n                <button type=\"submit\" id=\"register-submit-btn\" class=\"btn btn-primary m-btn m-btn--pill m-btn--custom m-btn--air\">");
                EndContext();
                BeginContext(4155, 11, false);
#line 91 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\TenantRegistration\Register.cshtml"
                                                                                                                             Write(L("Submit"));

#line default
#line hidden
                EndContext();
                BeginContext(4166, 48, true);
                WriteLiteral("</button>\n            </div>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4221, 11, true);
            WriteLiteral("\n</div>    ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TenantRegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
