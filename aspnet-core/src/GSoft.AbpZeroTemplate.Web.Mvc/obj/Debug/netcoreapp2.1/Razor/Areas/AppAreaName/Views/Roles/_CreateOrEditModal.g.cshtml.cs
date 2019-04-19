#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afbad7ad7e73e842660fbfc5bc185e31ec9803ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Roles__CreateOrEditModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Roles/_CreateOrEditModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Roles/_CreateOrEditModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Roles__CreateOrEditModal))]
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
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
using Abp.Extensions;

#line default
#line hidden
#line 2 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
using GSoft.AbpZeroTemplate.Authorization.Roles;

#line default
#line hidden
#line 3 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
#line 4 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Roles;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afbad7ad7e73e842660fbfc5bc185e31ec9803ab", @"/Areas/AppAreaName/Views/Roles/_CreateOrEditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Roles__CreateOrEditModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<CreateOrEditRoleModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("RoleInformationsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(245, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(247, 190, false);
#line 7 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(Model.IsEditMode ? (L("EditRole") + ": " + Model.Role.DisplayName) : L("CreateNewRole"))));

#line default
#line hidden
            EndContext();
            BeginContext(437, 255, true);
            WriteLiteral("\n\n<div class=\"modal-body\">\n\n    <ul class=\"nav nav-tabs  m-tabs-line\" role=\"tablist\">\n        <li class=\"nav-item m-tabs__item\">\n            <a href=\"#RoleInformationsTab\" class=\"nav-link m-tabs__link active\" data-toggle=\"tab\" role=\"tab\">\n                ");
            EndContext();
            BeginContext(693, 19, false);
#line 14 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
           Write(L("RoleProperties"));

#line default
#line hidden
            EndContext();
            BeginContext(712, 189, true);
            WriteLiteral("\n            </a>\n        </li>\n        <li class=\"nav-item m-tabs__item\">\n            <a href=\"#PermissionsTab\" class=\"nav-link m-tabs__link\" data-toggle=\"tab\" role=\"tab\">\n                ");
            EndContext();
            BeginContext(902, 16, false);
#line 19 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
           Write(L("Permissions"));

#line default
#line hidden
            EndContext();
            BeginContext(918, 165, true);
            WriteLiteral("\n            </a>\n        </li>\n    </ul>\n\n\n    <div class=\"tab-content\">\n        <div class=\"tab-pane active\" id=\"RoleInformationsTab\" role=\"tabpanel\">\n            ");
            EndContext();
            BeginContext(1083, 1099, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67f3c4b390364c1fa421c36e36ae1c11", async() => {
                BeginContext(1164, 2, true);
                WriteLiteral("\n\n");
                EndContext();
#line 29 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                 if (Model.IsEditMode)
                {

#line default
#line hidden
                BeginContext(1223, 50, true);
                WriteLiteral("                    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1273, "\"", 1295, 1);
#line 31 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1281, Model.Role.Id, 1281, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1296, 3, true);
                WriteLiteral("/>\n");
                EndContext();
#line 32 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                }

#line default
#line hidden
                BeginContext(1317, 84, true);
                WriteLiteral("\n                <div class=\"form-group\">\n                    <label for=\"RoleName\">");
                EndContext();
                BeginContext(1402, 13, false);
#line 35 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                                     Write(L("RoleName"));

#line default
#line hidden
                EndContext();
                BeginContext(1415, 49, true);
                WriteLiteral("</label>\n                    <input id=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1464, "\"", 1542, 2);
                WriteAttributeValue("", 1472, "form-control", 1472, 12, true);
#line 36 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1484, Model.Role.DisplayName.IsNullOrEmpty() ? "" : " edited", 1484, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1543, 31, true);
                WriteLiteral(" type=\"text\" name=\"DisplayName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1574, "\"", 1605, 1);
#line 36 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1582, Model.Role.DisplayName, 1582, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1606, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1615, "\"", 1653, 1);
#line 36 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1627, Role.MaxDisplayNameLength, 1627, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1654, 236, true);
                WriteLiteral(">\n                </div>\n                \n                <div class=\"m-checkbox-list\">\n                    <label class=\"m-checkbox\">\n                        <input id=\"EditRole_IsDefault\" type=\"checkbox\" name=\"IsDefault\" value=\"true\" ");
                EndContext();
                BeginContext(1891, 59, false);
#line 41 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                                                                                                Write(Html.Raw(Model.Role.IsDefault ? "checked=\"checked\"" : ""));

#line default
#line hidden
                EndContext();
                BeginContext(1950, 26, true);
                WriteLiteral(">\n                        ");
                EndContext();
                BeginContext(1977, 12, false);
#line 42 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                   Write(L("Default"));

#line default
#line hidden
                EndContext();
                BeginContext(1989, 113, true);
                WriteLiteral("\n                        <span></span>\n                    </label>\n                    <span class=\"help-block\">");
                EndContext();
                BeginContext(2103, 28, false);
#line 45 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
                                        Write(L("DefaultRole_Description"));

#line default
#line hidden
                EndContext();
                BeginContext(2131, 44, true);
                WriteLiteral("</span>\n                </div>\n\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2182, 95, true);
            WriteLiteral("\n        </div>\n        <div class=\"tab-pane\" id=\"PermissionsTab\" role=\"tabpanel\">\n            ");
            EndContext();
            BeginContext(2278, 78, false);
#line 51 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
       Write(Html.Partial("~/Areas/AppAreaName/Views/Common/_PermissionTree.cshtml", Model));

#line default
#line hidden
            EndContext();
            BeginContext(2356, 105, true);
            WriteLiteral("\n        </div>\n    </div>\n\n\n    <div class=\"alert alert-warning\" style=\"margin-top: 30px;\">\n        <em>");
            EndContext();
            BeginContext(2462, 41, false);
#line 57 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
       Write(L("Note_RefreshPageForPermissionChanges"));

#line default
#line hidden
            EndContext();
            BeginContext(2503, 25, true);
            WriteLiteral("</em>\n    </div>\n</div>\n\n");
            EndContext();
            BeginContext(2529, 92, false);
#line 61 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Roles\_CreateOrEditModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateOrEditRoleModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
