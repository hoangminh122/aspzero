#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53a336d8dd045be737c43cd3274b2c0d0f491023"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Shared_Components_AppAreaNameMenu_Default), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Shared/Components/AppAreaNameMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Shared/Components/AppAreaNameMenu/Default.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Shared_Components_AppAreaNameMenu_Default))]
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
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Layout;

#line default
#line hidden
#line 2 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameSideBar;

#line default
#line hidden
#line 3 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
using GSoft.AbpZeroTemplate.Web.Theme;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a336d8dd045be737c43cd3274b2c0d0f491023", @"/Areas/AppAreaName/Views/Shared/Components/AppAreaNameMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Shared_Components_AppAreaNameMenu_Default : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<MenuViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(270, 20, true);
            WriteLiteral("<nav id=\"m_ver_menu\"");
            EndContext();
            BeginWriteAttribute("aria-label", "\n     aria-label=\"", 290, "\"", 322, 1);
#line 10 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
WriteAttributeValue("", 308, L("LeftMenu"), 308, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", "\n     class=\"", 323, "\"", 710, 6);
            WriteAttributeValue("", 336, "m-aside-menu", 336, 12, true);
            WriteAttributeValue("  \n            ", 348, "m-aside-menu--skin-", 363, 34, true);
#line 12 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
WriteAttributeValue("", 382, UiThemeCustomizer.LeftAsideAsideSkin, 382, 37, false);

#line default
#line hidden
            WriteAttributeValue(" \n            ", 419, "m-aside-menu--submenu-skin-", 433, 41, true);
#line 13 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
WriteAttributeValue("", 460, UiThemeCustomizer.LeftAsideDropdownSubmenuSkin == "inherit" ? UiThemeCustomizer.LeftAsideAsideSkin: UiThemeCustomizer.LeftAsideDropdownSubmenuSkin, 460, 149, false);

#line default
#line hidden
#line 13 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
WriteAttributeValue(" \n            ", 609, UiThemeCustomizer.LeftAsideSubmenuToggle == "dropdown" ? "m-aside-menu--dropdown":"", 623, 87, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(711, 37, true);
            WriteLiteral("\n     data-menu-vertical=\"true\"\n     ");
            EndContext();
            BeginContext(750, 87, false);
#line 16 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
 Write(UiThemeCustomizer.LeftAsideSubmenuToggle == "dropdown" ? "data-menu-dropdown=true" : "");

#line default
#line hidden
            EndContext();
            BeginContext(838, 7, true);
            WriteLiteral(" \n     ");
            EndContext();
            BeginContext(847, 98, false);
#line 17 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
 Write(UiThemeCustomizer.LeftAsideFixedAside ? "data-menu-scrollable=true" : "data-menu-scrollable=false");

#line default
#line hidden
            EndContext();
            BeginContext(946, 42, true);
            WriteLiteral(" data-menu-dropdown-timeout=\"500\">\n    <ul");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 988, "\"", 1103, 3);
            WriteAttributeValue("", 996, "m-menu__nav", 996, 11, true);
#line 18 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
WriteAttributeValue("  ", 1007, UiThemeCustomizer.LeftAsideDropdownSubmenuArrow ? "m-menu__nav--dropdown-submenu-arrow":"", 1009, 93, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1102, "", 1103, 1, true);
            EndWriteAttribute();
            BeginContext(1104, 24, true);
            WriteLiteral(" \n        role=\"menubar\"");
            EndContext();
            BeginWriteAttribute("aria-label", " \n        aria-label=\"", 1128, "\"", 1164, 1);
#line 20 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
WriteAttributeValue("", 1150, L("LeftMenu"), 1150, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1165, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 21 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
         for (var i = 0; i < Model.Menu.Items.Count; i++)
        {
            var menuItem = Model.Menu.Items[i];
            

#line default
#line hidden
            BeginContext(1296, 273, false);
#line 24 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
       Write(Html.Partial("Components/AppAreaNameMenu/_UserMenuItem", new UserMenuItemViewModel
            {
                MenuItem = menuItem,
                MenuItemIndex = i,
                RootLevel = true,
                CurrentPageName = Model.CurrentPageName
            }));

#line default
#line hidden
            EndContext();
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Shared\Components\AppAreaNameMenu\Default.cshtml"
              
        }

#line default
#line hidden
            BeginContext(1580, 16, true);
            WriteLiteral("    </ul>\n</nav>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUiThemeCustomizer UiThemeCustomizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
