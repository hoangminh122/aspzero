#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "423c0f8e809d430a2f917751e6098ee03f4dcdff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterResult), @"mvc.1.0.view", @"/Views/Account/RegisterResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/RegisterResult.cshtml", typeof(AspNetCore.Views_Account_RegisterResult))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"423c0f8e809d430a2f917751e6098ee03f4dcdff", @"/Views/Account/RegisterResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RegisterResult : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<GSoft.AbpZeroTemplate.Web.Models.Account.RegisterResultViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-login__form m-form login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 110, true);
            WriteLiteral("<div class=\"m-login__signin\">\n    <div class=\"m-login__head\">\n        <h3 class=\"m-login__title\">\n            ");
            EndContext();
            BeginContext(183, 27, false);
#line 5 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
       Write(L("SuccessfullyRegistered"));

#line default
#line hidden
            EndContext();
            BeginContext(210, 30, true);
            WriteLiteral("\n        </h3>\n    </div>\n    ");
            EndContext();
            BeginContext(240, 950, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90bc78d57cf54fa8ac906bf9979caee4", async() => {
                BeginContext(286, 55, true);
                WriteLiteral("\n        <ul>\n            <li><span class=\"text-muted\">");
                EndContext();
                BeginContext(342, 16, false);
#line 10 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("NameSurname"));

#line default
#line hidden
                EndContext();
                BeginContext(358, 9, true);
                WriteLiteral(":</span> ");
                EndContext();
                BeginContext(368, 20, false);
#line 10 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                              Write(Model.NameAndSurname);

#line default
#line hidden
                EndContext();
                BeginContext(388, 47, true);
                WriteLiteral("</li>\n            <li><span class=\"text-muted\">");
                EndContext();
                BeginContext(436, 16, false);
#line 11 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("TenancyName"));

#line default
#line hidden
                EndContext();
                BeginContext(452, 9, true);
                WriteLiteral(":</span> ");
                EndContext();
                BeginContext(462, 17, false);
#line 11 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                              Write(Model.TenancyName);

#line default
#line hidden
                EndContext();
                BeginContext(479, 47, true);
                WriteLiteral("</li>\n            <li><span class=\"text-muted\">");
                EndContext();
                BeginContext(527, 13, false);
#line 12 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("UserName"));

#line default
#line hidden
                EndContext();
                BeginContext(540, 9, true);
                WriteLiteral(":</span> ");
                EndContext();
                BeginContext(550, 14, false);
#line 12 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                           Write(Model.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(564, 47, true);
                WriteLiteral("</li>\n            <li><span class=\"text-muted\">");
                EndContext();
                BeginContext(612, 17, false);
#line 13 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("EmailAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(629, 9, true);
                WriteLiteral(":</span> ");
                EndContext();
                BeginContext(639, 18, false);
#line 13 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                               Write(Model.EmailAddress);

#line default
#line hidden
                EndContext();
                BeginContext(657, 34, true);
                WriteLiteral("</li>\n        </ul>\n        <div>\n");
                EndContext();
#line 16 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
             if (Model.IsEmailConfirmationRequired)
            {

#line default
#line hidden
                BeginContext(757, 83, true);
                WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\n                    ");
                EndContext();
                BeginContext(841, 70, false);
#line 19 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
               Write(L("ConfirmationMailSentPleaseClickLinkInTheEmail", Model.EmailAddress));

#line default
#line hidden
                EndContext();
                BeginContext(911, 24, true);
                WriteLiteral("\n                </div>\n");
                EndContext();
#line 21 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
            }

#line default
#line hidden
                BeginContext(949, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 22 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
             if (!Model.IsActive)
            {

#line default
#line hidden
                BeginContext(997, 83, true);
                WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\n                    ");
                EndContext();
                BeginContext(1081, 45, false);
#line 25 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
               Write(L("YourAccountIsWaitingToBeActivatedByAdmin"));

#line default
#line hidden
                EndContext();
                BeginContext(1126, 24, true);
                WriteLiteral("\n                </div>\n");
                EndContext();
#line 27 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Account\RegisterResult.cshtml"
            }

#line default
#line hidden
                BeginContext(1164, 19, true);
                WriteLiteral("        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1190, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GSoft.AbpZeroTemplate.Web.Models.Account.RegisterResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
