#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847917d4390ddd71816d41598c2be232c1dbaddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Users_Index), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Users/Index.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Users_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 2 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
using Abp.Application.Services.Dto;

#line default
#line hidden
#line 3 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
using Abp.Json;

#line default
#line hidden
#line 4 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
using GSoft.AbpZeroTemplate.Authorization;

#line default
#line hidden
#line 5 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Users;

#line default
#line hidden
#line 6 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Startup;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847917d4390ddd71816d41598c2be232c1dbaddf", @"/Areas/AppAreaName/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Users_Index : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<UsersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-href", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/AppAreaName/Views/Users/Index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("abp-src", new global::Microsoft.AspNetCore.Html.HtmlString("/view-resources/Areas/AppAreaName/Views/_Bundles/user-list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateLinkHrefTagHelper __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateLinkHrefTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 8 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
  
    ViewBag.CurrentPageName = AppAreaNamePageNames.Common.Users;

#line default
#line hidden
            DefineSection("Styles", async() => {
                BeginContext(361, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(366, 118, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13503eaed8c74dd0afad1ec85ff22e88", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateLinkHrefTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateLinkHrefTagHelper>();
                __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateLinkHrefTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 13 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateLinkHrefTagHelper.AppendVersion = __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion;
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(484, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(509, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(514, 115, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b2c616860484639b38d52d55f97776d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper = CreateTagHelper<global::GSoft.AbpZeroTemplate.Web.TagHelpers.AbpZeroTemplateScriptSrcTagHelper>();
                __tagHelperExecutionContext.Add(__GSoft_AbpZeroTemplate_Web_TagHelpers_AbpZeroTemplateScriptSrcTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 17 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
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
                BeginContext(629, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(632, 212, true);
            WriteLiteral("<div class=\"m-subheader\">\n    <div class=\"row align-items-center\">\n        <div class=\"mr-auto col-sm-12 col-md-6\">\n            <h3 class=\"m-subheader__title m-subheader__title--separator\">\n                <span>");
            EndContext();
            BeginContext(845, 10, false);
#line 23 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                 Write(L("Users"));

#line default
#line hidden
            EndContext();
            BeginContext(855, 84, true);
            WriteLiteral("</span>\n            </h3>\n            <span class=\"m-section__sub\">\n                ");
            EndContext();
            BeginContext(940, 20, false);
#line 26 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
           Write(L("UsersHeaderInfo"));

#line default
#line hidden
            EndContext();
            BeginContext(960, 205, true);
            WriteLiteral("\n            </span>\n        </div>\n        <div class=\"col-sm-12 col-md-6 text-right\">\n            <button id=\"ExportUsersToExcelButton\" class=\"btn btn-outline-success\"><i class=\"fa fa-file-excel-o\"></i> ");
            EndContext();
            BeginContext(1166, 18, false);
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                                                                                                                Write(L("ExportToExcel"));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 10, true);
            WriteLiteral("</button>\n");
            EndContext();
#line 31 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
             if (IsGranted(AppPermissions.Pages_Administration_Users_Create))
            {

#line default
#line hidden
            BeginContext(1286, 100, true);
            WriteLiteral("                <button id=\"CreateNewUserButton\" class=\"btn btn-primary\"><i class=\"fa fa-plus\"></i> ");
            EndContext();
            BeginContext(1387, 18, false);
#line 33 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                                                                                               Write(L("CreateNewUser"));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 10, true);
            WriteLiteral("</button>\n");
            EndContext();
#line 34 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1429, 554, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<div class=""m-content"">
    <div class=""m-portlet m-portlet--mobile"">
        <div class=""m-portlet__body"">
            <div class=""m-form m-form--label-align-right"">
                <div class=""row align-items-center m--margin-bottom-10"">
                    <div class=""col-xl-12"">
                        <div class=""form-group m-form__group align-items-center"">
                            <div class=""input-group"">
                                <input type=""text"" id=""UsersTableFilter"" class=""form-control m-input""");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1983, "\"", 2021, 1);
#line 46 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
WriteAttributeValue("", 1997, L("SearchWithThreeDot"), 1997, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2022, "\"", 2047, 1);
#line 46 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
WriteAttributeValue("", 2030, Model.FilterText, 2030, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2048, 195, true);
            WriteLiteral(">\n                                <span class=\"input-group-btn\">\n                                    <button id=\"GetUsersButton\" class=\"btn btn-primary\" type=\"submit\"><i class=\"flaticon-search-1\"");
            EndContext();
            BeginWriteAttribute("aria-label", " aria-label=\"", 2243, "\"", 2268, 1);
#line 48 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
WriteAttributeValue("", 2256, L("Search"), 2256, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2269, 300, true);
            WriteLiteral(@"></i></button>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                <div id=""AdvacedAuditFiltersArea"" style=""display: none"" class=""row m--margin-bottom-10"">
                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2569, "\"", 2659, 1);
#line 55 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
WriteAttributeValue("", 2577, IsGranted(AppPermissions.Pages_Administration_Roles) ? "col-xl-6" : "col-xl-12", 2577, 82, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2660, 79, true);
            WriteLiteral(">\n                        <div class=\"form-group\">\n                            ");
            EndContext();
            BeginContext(2740, 563, false);
#line 57 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                       Write(Html.DropDownList(
                                    "PermissionSelectionCombobox", Model.Permissions.Select(i => i.ToSelectListItem()),
                                    new
                                    {
                                        @class = "form-control selectpicker",
                                        data_live_search = "true",
                                        data_none_selected_text = L("FilterByPermission"),
                                        id = "PermissionSelectionCombo"
                                    }));

#line default
#line hidden
            EndContext();
            BeginContext(3303, 59, true);
            WriteLiteral("\n                        </div>\n                    </div>\n");
            EndContext();
#line 68 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                     if (IsGranted(AppPermissions.Pages_Administration_Roles))
                    {

#line default
#line hidden
            BeginContext(3463, 132, true);
            WriteLiteral("                        <div class=\"col-xl-6\">\n                            <div class=\"form-group\">\n                                ");
            EndContext();
            BeginContext(3596, 571, false);
#line 72 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(Html.DropDownList(
                                        "RoleSelectionCombobox", Model.Roles.Select(i => i.ToSelectListItem()),
                                        new
                                        {
                                            @class = "form-control selectpicker",
                                            data_live_search = "true",
                                            data_none_selected_text = L("FilterByRole"),
                                            id = "RoleSelectionCombo"
                                        }));

#line default
#line hidden
            EndContext();
            BeginContext(4167, 67, true);
            WriteLiteral("\n                            </div>\n                        </div>\n");
            EndContext();
#line 83 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4256, 166, true);
            WriteLiteral("                    <div class=\"col-xl-12 text-right\">\n                        <button id=\"RefreshUserListButton\" class=\"btn btn-metal\"><i class=\"fa fa-refresh\"></i> ");
            EndContext();
            BeginContext(4423, 12, false);
#line 85 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                                                                                                          Write(L("Refresh"));

#line default
#line hidden
            EndContext();
            BeginContext(4435, 284, true);
            WriteLiteral(@"</button>
                    </div>
                </div>
                <div class=""row m--margin-bottom-10"">
                    <div class=""col-xl-12"">
                        <span id=""ShowAdvancedFiltersSpan"" class=""text-muted clickable-item""><i class=""fa fa-angle-down""></i> ");
            EndContext();
            BeginContext(4720, 24, false);
#line 90 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                                                                                                                         Write(L("ShowAdvancedFilters"));

#line default
#line hidden
            EndContext();
            BeginContext(4744, 154, true);
            WriteLiteral("</span>\n                        <span id=\"HideAdvancedFiltersSpan\" class=\"text-muted clickable-item\" style=\"display: none\"><i class=\"fa fa-angle-up\"></i> ");
            EndContext();
            BeginContext(4899, 24, false);
#line 91 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                                                                                                                                             Write(L("HideAdvancedFilters"));

#line default
#line hidden
            EndContext();
            BeginContext(4923, 377, true);
            WriteLiteral(@"</span>
                    </div>
                </div>
            </div>
            <div class=""row align-items-center"">
                <table id=""UsersTable"" class=""display table table-striped table-bordered table-hover dt-responsive nowrap"">
                    <thead>
                        <tr>
                            <th></th>
                            <th>");
            EndContext();
            BeginContext(5301, 12, false);
#line 100 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(5313, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(5352, 13, false);
#line 101 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("UserName"));

#line default
#line hidden
            EndContext();
            BeginContext(5365, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(5404, 9, false);
#line 102 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(5413, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(5452, 12, false);
#line 103 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("Surname"));

#line default
#line hidden
            EndContext();
            BeginContext(5464, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(5503, 10, false);
#line 104 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("Roles"));

#line default
#line hidden
            EndContext();
            BeginContext(5513, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(5552, 17, false);
#line 105 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("EmailAddress"));

#line default
#line hidden
            EndContext();
            BeginContext(5569, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(5608, 17, false);
#line 106 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("EmailConfirm"));

#line default
#line hidden
            EndContext();
            BeginContext(5625, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(5664, 11, false);
#line 107 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("Active"));

#line default
#line hidden
            EndContext();
            BeginContext(5675, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(5714, 18, false);
#line 108 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("LastLoginTime"));

#line default
#line hidden
            EndContext();
            BeginContext(5732, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(5771, 17, false);
#line 109 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\Index.cshtml"
                           Write(L("CreationTime"));

#line default
#line hidden
            EndContext();
            BeginContext(5788, 142, true);
            WriteLiteral("</th>\n                        </tr>\n                    </thead>\n                </table>\n            </div>\n\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
