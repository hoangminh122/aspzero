#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameFooter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d85027aafa4cb1a458ffd1e53c9686814b3bb30e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Shared_Components_AppAreaNameFooter_Default), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Shared/Components/AppAreaNameFooter/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Shared/Components/AppAreaNameFooter/Default.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Shared_Components_AppAreaNameFooter_Default))]
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
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameFooter\Default.cshtml"
using GSoft.AbpZeroTemplate;

#line default
#line hidden
#line 2 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameFooter\Default.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Layout;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d85027aafa4cb1a458ffd1e53c9686814b3bb30e", @"/Areas/AppAreaName/Views/Shared/Components/AppAreaNameFooter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Shared_Components_AppAreaNameFooter_Default : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<FooterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameFooter\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(141, 397, true);
            WriteLiteral(@"<footer class=""m-grid__item m-footer "">
    <div class=""m-container m-container--fluid m-container--full-height m-page__container"">
        <div class=""m-stack m-stack--flex-tablet-and-mobile m-stack--ver m-stack--desktop"">
            <div class=""m-stack__item m-stack__item--left m-stack__item--middle m-stack__item--last"">
                <span class=""m-footer__copyright"">
                    ");
            EndContext();
            BeginContext(539, 33, false);
#line 12 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameFooter\Default.cshtml"
               Write(Model.GetProductNameWithEdition());

#line default
#line hidden
            EndContext();
            BeginContext(572, 29, true);
            WriteLiteral(" <br />\n                    v");
            EndContext();
            BeginContext(603, 24, false);
#line 13 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameFooter\Default.cshtml"
                 Write(AppVersionHelper.Version);

#line default
#line hidden
            EndContext();
            BeginContext(628, 2, true);
            WriteLiteral(" [");
            EndContext();
            BeginContext(631, 49, false);
#line 13 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameFooter\Default.cshtml"
                                             Write(AppVersionHelper.ReleaseDate.ToString("yyyyMMdd"));

#line default
#line hidden
            EndContext();
            BeginContext(680, 204, true);
            WriteLiteral("]\n                </span>\n            </div>\n            <div class=\"m-stack__item m-stack__item--right m-stack__item--middle m-stack__item--first\">\n\n            </div>\n        </div>\n    </div>\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FooterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
