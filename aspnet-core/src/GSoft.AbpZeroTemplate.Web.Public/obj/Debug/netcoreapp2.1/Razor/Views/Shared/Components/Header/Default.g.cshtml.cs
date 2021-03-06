#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e14fce185f9770a1c9e11f658bf0cccf4e4498eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Header/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Header_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 2 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
using Abp.Extensions;

#line default
#line hidden
#line 3 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
using GSoft.AbpZeroTemplate.Web.Public.Views.Shared.Components.Header;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e14fce185f9770a1c9e11f658bf0cccf4e4498eb", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"569c2a1b8ca5466c904c9d26a9bfcd9d295f4fd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : GSoft.AbpZeroTemplate.Web.Public.Views.AbpZeroTemplateRazorPage<HeaderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(146, 538, true);
            WriteLiteral(@"<div class=""pre-header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 additional-shop-info"">
                <ul class=""list-unstyled list-inline"">
                    <li><i class=""fa fa-phone""></i><span>+1 456 6717</span></li>
                    <li><i class=""fa fa-envelope-o""></i><span>info@mydomain.com</span></li>
                </ul>
            </div>
            <div class=""col-md-6 col-sm-6 additional-nav"">
                <ul class=""list-unstyled list-inline pull-right"">
");
            EndContext();
#line 16 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                     if (Model.Languages.Count > 1)
                    {

#line default
#line hidden
            BeginContext(758, 274, true);
            WriteLiteral(@"                        <li>
                            <div id=""LanguageDropDown"" class=""btn-group dropdown"">
                                <button type=""button"" class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"" data-delay=""1000"" data-close-others=""true""><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1032, "\"", 1067, 1);
#line 20 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1040, Model.CurrentLanguage.Icon, 1040, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1068, 6, true);
            WriteLiteral("></i> ");
            EndContext();
            BeginContext(1075, 33, false);
#line 20 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                                                                                                                                                                                                       Write(Model.CurrentLanguage.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 114, true);
            WriteLiteral(" <i class=\"fa fa-angle-down\"></i></button>\n                                <ul class=\"dropdown-menu\" role=\"menu\">\n");
            EndContext();
#line 22 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                                     foreach (var language in Model.Languages)
                                    {
                                        if (Model.CurrentLanguage.Name == language.Name)
                                        {
                                            continue;
                                        }


#line default
#line hidden
            BeginContext(1567, 118, true);
            WriteLiteral("                                        <li class=\"language-menu-item\">\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1685, "\"", 1800, 5);
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1692, Url.Action("ChangeCulture", "AbpLocalization"), 1692, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 1739, "?cultureName=", 1739, 13, true);
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1752, language.Name, 1752, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1768, "&returnUrl=", 1768, 11, true);
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1779, Context.Request.Path, 1779, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1801, 3, true);
            WriteLiteral("><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1804, "\"", 1826, 1);
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1812, language.Icon, 1812, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1827, 12, true);
            WriteLiteral("></i> <span>");
            EndContext();
            BeginContext(1840, 20, false);
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                                                                                                                                                                                                   Write(language.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1860, 58, true);
            WriteLiteral("</span></a>\n                                        </li>\n");
            EndContext();
#line 32 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1956, 103, true);
            WriteLiteral("                                </ul>\n                            </div>\n                        </li>\n");
            EndContext();
#line 36 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(2081, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 37 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                     if (Model.LoginInformations?.User == null && Model.IsMultiTenancyEnabled && Model.TenantRegistrationEnabled && Model.IsInHostView)
                    {

#line default
#line hidden
            BeginContext(2255, 59, true);
            WriteLiteral("                        <li>\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2314, "\"", 2435, 1);
#line 40 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 2321, string.Format("{0}{1}", Model.AdminWebSiteRootAddress,"?redirect=TenantRegistration&forceNewRegistration=true"), 2321, 114, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2436, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2438, 14, false);
#line 40 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                                                                                                                                                    Write(L("NewTenant"));

#line default
#line hidden
            EndContext();
            BeginContext(2452, 35, true);
            WriteLiteral("</a>\n                        </li>\n");
            EndContext();
#line 42 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(2509, 25, true);
            WriteLiteral("                    <li>\n");
            EndContext();
#line 44 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                         if (Model.LoginInformations?.User != null)
                        {

#line default
#line hidden
            BeginContext(2628, 243, true);
            WriteLiteral("                            <div id=\"LanguageDropDown\" class=\"btn-group dropdown\">\n                                <button type=\"button\" class=\"btn btn-default dropdown-toggle\" data-toggle=\"dropdown\" data-delay=\"1000\" data-close-others=\"true\">");
            EndContext();
            BeginContext(2872, 25, false);
#line 47 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                                                                                                                                                           Write(Model.GetShownLoginName());

#line default
#line hidden
            EndContext();
            BeginContext(2897, 224, true);
            WriteLiteral(" <i class=\"fa fa-angle-down\"></i></button>\n                                <ul class=\"dropdown-menu\" role=\"menu\">\n                                    <li class=\"language-menu-item\">\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3121, "\"", 3160, 1);
#line 50 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 3128, Url.Action("Logout", "Account"), 3128, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3161, 35, true);
            WriteLiteral("><i class=\"icon-logout\"></i> <span>");
            EndContext();
            BeginContext(3197, 11, false);
#line 50 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                                                                                                                Write(L("Logout"));

#line default
#line hidden
            EndContext();
            BeginContext(3208, 127, true);
            WriteLiteral("</span></a>\n                                    </li>\n                                </ul>\n                            </div>\n");
            EndContext();
#line 54 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3416, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3446, "\"", 3600, 1);
#line 57 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 3453, string.Format("{0}{1}?ss={2}&returnUrl={3}", Model.AdminWebSiteRootAddress, "account/login", "true", Model.WebSiteRootAddress + "Account/Login"), 3453, 147, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3601, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3603, 10, false);
#line 57 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                                                                                                                                                                                     Write(L("LogIn"));

#line default
#line hidden
            EndContext();
            BeginContext(3613, 53, true);
            WriteLiteral("</a> <!-- TODO: get url from setting or Request. -->\n");
            EndContext();
#line 58 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(3692, 177, true);
            WriteLiteral("                    </li>\n                </ul>\n            </div>\n        </div>\n    </div>\n</div>\n<div class=\"header\">\n    <div class=\"container\">\n        <a class=\"site-logo\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3869, "\"", 3904, 1);
#line 67 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 3876, Url.Action("Index", "Home"), 3876, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3905, 18, true);
            WriteLiteral(">\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3923, "\"", 3963, 1);
#line 68 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 3929, Model.GetLogoUrl(ApplicationPath), 3929, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3964, 128, true);
            WriteLiteral(" alt=\"\" width=\"139\" height=\"35\" />\n        </a>\n        <a href=\"javascript:void(0);\" class=\"mobi-toggler\"><i class=\"fa fa-bars\"");
            EndContext();
            BeginWriteAttribute("aria-label", " aria-label=\"", 4092, "\"", 4117, 1);
#line 70 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 4105, L("Toggle"), 4105, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4118, 101, true);
            WriteLiteral("></i></a>\n        <div class=\"header-navigation pull-right font-transform-inherit\">\n            <ul>\n");
            EndContext();
#line 73 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                 foreach (var menuItem in @Model.Menu.Items)
                {
                    

#line default
#line hidden
            BeginContext(4319, 114, false);
#line 75 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
               Write(Html.Partial("Components/Header/_HeaderMenuItem", new HeaderMenuItemViewModel(menuItem, 0, Model.CurrentPageName)));

#line default
#line hidden
            EndContext();
#line 75 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Public\Views\Shared\Components\Header\Default.cshtml"
                                                                                                                                       
                }

#line default
#line hidden
            BeginContext(4452, 50, true);
            WriteLiteral("            </ul>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HeaderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
