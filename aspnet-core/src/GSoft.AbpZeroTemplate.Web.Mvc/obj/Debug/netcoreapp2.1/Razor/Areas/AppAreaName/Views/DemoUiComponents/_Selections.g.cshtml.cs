#pragma checksum "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_Selections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "951c7cdc835def2a10b69b927ae16fe07ad8af13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_DemoUiComponents__Selections), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/DemoUiComponents/_Selections.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/DemoUiComponents/_Selections.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_DemoUiComponents__Selections))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"951c7cdc835def2a10b69b927ae16fe07ad8af13", @"/Areas/AppAreaName/Views/DemoUiComponents/_Selections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_DemoUiComponents__Selections : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 385, true);
            WriteLiteral(@"<div class=""m-portlet m-portlet--mobile"">
    <div class=""m-portlet__head"">
        <div class=""m-portlet__head-caption"">
            <div class=""m-portlet__head-title"">
                <h3 class=""m-portlet__head-text"">
                    Select2 Dropdowns With Autocomplete
                </h3>
            </div>
        </div>
    </div>
    <div class=""m-portlet__body"">
        ");
            EndContext();
            BeginContext(385, 1690, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a0fbd1265824f6493e5cc2c2ab47936", async() => {
                BeginContext(403, 468, true);
                WriteLiteral(@"

            <div class=""form-group m-form__group row"">
                <label for=""select2SingleSelect"" class=""col-lg-12"">Single select</label>
                <div class=""col-lg-10 col-md-9 col-sm-8"">
                    <select id=""select2SingleSelect"" class=""form-control m-select2""></select>
                </div>
                <div class=""col-lg-2 col-md-3 col-sm-4"">
                    <button class=""btn btn-primary test-btn-select2-single"" type=""button"">");
                EndContext();
                BeginContext(872, 11, false);
#line 20 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_Selections.cshtml"
                                                                                     Write(L("Submit"));

#line default
#line hidden
                EndContext();
                BeginContext(883, 550, true);
                WriteLiteral(@"</button>
                </div>
            </div>
            
            <div class=""form-group m-form__group row"">
                <label for=""select2MultiSelect"" class=""col-lg-12"">Multi select</label>
                <div class=""col-lg-10 col-md-9 col-sm-8"">
                    <select id=""select2MultiSelect"" class=""form-control m-select2"" multiple=""multiple""></select>
                </div>
                <div class=""col-lg-2 col-md-3 col-sm-4"">
                    <button class=""btn btn-primary test-btn-select2-multiple"" type=""button"">");
                EndContext();
                BeginContext(1434, 11, false);
#line 30 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_Selections.cshtml"
                                                                                       Write(L("Submit"));

#line default
#line hidden
                EndContext();
                BeginContext(1445, 550, true);
                WriteLiteral(@"</button>
                </div>
            </div>
            
            <div class=""form-group m-form__group row"">
                <label for=""select2Tagging"" class=""col-lg-12"">Tagging support</label>
                <div class=""col-lg-10 col-md-9 col-sm-8"">
                    <select id=""select2Tagging"" class=""form-control select2-tagging"" multiple=""multiple""></select>
                </div>
                <div class=""col-lg-2 col-md-3 col-sm-4"">
                    <button class=""btn btn-primary test-btn-select2-tagging"" type=""button"">");
                EndContext();
                BeginContext(1996, 11, false);
#line 40 "D:\aspzero\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_Selections.cshtml"
                                                                                      Write(L("Submit"));

#line default
#line hidden
                EndContext();
                BeginContext(2007, 61, true);
                WriteLiteral("</button>\n                </div>\n            </div>\n\n        ");
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
            BeginContext(2075, 18, true);
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
