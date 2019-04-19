#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f479f0b7071ab9caa814b92b3e7657c4379a138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Users__PermissionsModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Users/_PermissionsModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Users/_PermissionsModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Users__PermissionsModal))]
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
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
#line 2 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Users;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f479f0b7071ab9caa814b92b3e7657c4379a138", @"/Areas/AppAreaName/Views/Users/_PermissionsModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Users__PermissionsModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<UserPermissionsEditViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(172, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(174, 149, false);
#line 5 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("Permissions") + " - " + Model.User.UserName)));

#line default
#line hidden
            EndContext();
            BeginContext(323, 31, true);
            WriteLiteral("\n\n<div class=\"modal-body\">\n    ");
            EndContext();
            BeginContext(355, 78, false);
#line 8 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/_PermissionTree.cshtml", Model));

#line default
#line hidden
            EndContext();
            BeginContext(433, 97, true);
            WriteLiteral("\n    \n    <div class=\"note note-warning\" style=\"margin-bottom: 0; margin-top: 15px\">\n        <em>");
            EndContext();
            BeginContext(531, 41, false);
#line 11 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml"
       Write(L("Note_RefreshPageForPermissionChanges"));

#line default
#line hidden
            EndContext();
            BeginContext(572, 158, true);
            WriteLiteral("</em>\n    </div>\n</div>\n\n<div class=\"modal-footer\">\n    <button type=\"button\" class=\"btn btn-default pull-left reset-permissions-button\" data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 730, "\"", 767, 1);
#line 16 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml"
WriteAttributeValue("", 738, L("ResetPermissionsTooltip"), 738, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(768, 28, true);
            WriteLiteral(" data-placement=\"top\"><span>");
            EndContext();
            BeginContext(797, 28, false);
#line 16 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml"
                                                                                                                                                                       Write(L("ResetSpecialPermissions"));

#line default
#line hidden
            EndContext();
            BeginContext(825, 97, true);
            WriteLiteral("</span></button>\n    <button type=\"button\" class=\"btn default close-button\" data-dismiss=\"modal\">");
            EndContext();
            BeginContext(923, 11, false);
#line 17 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml"
                                                                           Write(L("Cancel"));

#line default
#line hidden
            EndContext();
            BeginContext(934, 105, true);
            WriteLiteral("</button>\n    <button type=\"button\" class=\"btn btn-primary save-button\"><i class=\"fa fa-save\"></i> <span>");
            EndContext();
            BeginContext(1040, 9, false);
#line 18 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_PermissionsModal.cshtml"
                                                                                          Write(L("Save"));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 25, true);
            WriteLiteral("</span></button>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserPermissionsEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591