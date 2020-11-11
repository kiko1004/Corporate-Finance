#pragma checksum "C:\Users\kiril\source\repos\Corporate Finance\CorporateFinance\Pages\DetailedCompounding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd37ce4fdbf330465a0f476524931f4401e3017"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CorporateFinance.Pages.Pages_DetailedCompounding), @"mvc.1.0.razor-page", @"/Pages/DetailedCompounding.cshtml")]
namespace CorporateFinance.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kiril\source\repos\Corporate Finance\CorporateFinance\Pages\_ViewImports.cshtml"
using CorporateFinance;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd37ce4fdbf330465a0f476524931f4401e3017", @"/Pages/DetailedCompounding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916adc5eceee6903d43b90805b5c52c368bdcdef", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DetailedCompounding : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 3 "C:\Users\kiril\source\repos\Corporate Finance\CorporateFinance\Pages\DetailedCompounding.cshtml"
  
    ViewData["Title"] = "Detailed Compounding";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>\r\n    EFFECTIVE ANNUAL RATES AND COMPOUNDING\r\n</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd37ce4fdbf330465a0f476524931f4401e30173407", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""C"">Initial Investment</label>
        <input type=""text"" class=""form-control"" name=""C"" id=""C"" placeholder=""C"">

    </div>
    <div class=""form-group"">
        <label>% return per period</label>
        <input type=""text"" class=""form-control"" name=""R"" placeholder=""R"" id=""exampleInputPassword1"">
    </div>
    <div class=""form-group"">
        <label>Num of payments per period</label>
        <input type=""text"" class=""form-control"" name=""payments"" placeholder=""Number of payments per period"" id=""exampleInputPassword1"">
    </div>
    <div class=""form-group"">
        <label>Number of periods</label>
        <input type=""text"" class=""form-control"" name=""N"" placeholder=""N"" id=""exampleInputPassword1"">
    </div>

    <button type=""submit"" class=""btn btn-primary"">Submit</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<label>FV</label>\r\n<div class=\"shadow-lg p-3 mb-5 bg-white rounded\">");
#nullable restore
#line 32 "C:\Users\kiril\source\repos\Corporate Finance\CorporateFinance\Pages\DetailedCompounding.cshtml"
                                            Write(Model.rett);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<label>EAR</label>\r\n<div class=\"shadow-lg p-3 mb-5 bg-white rounded\">");
#nullable restore
#line 34 "C:\Users\kiril\source\repos\Corporate Finance\CorporateFinance\Pages\DetailedCompounding.cshtml"
                                            Write(Model.EAR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Result</th>\r\n            \r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\kiril\source\repos\Corporate Finance\CorporateFinance\Pages\DetailedCompounding.cshtml"
         foreach (var d in @Model.ca)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\kiril\source\repos\Corporate Finance\CorporateFinance\Pages\DetailedCompounding.cshtml"
               Write(d.index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\kiril\source\repos\Corporate Finance\CorporateFinance\Pages\DetailedCompounding.cshtml"
               Write(d.res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\kiril\source\repos\Corporate Finance\CorporateFinance\Pages\DetailedCompounding.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CorporateFinance.Pages.DetailedCompoundingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CorporateFinance.Pages.DetailedCompoundingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CorporateFinance.Pages.DetailedCompoundingModel>)PageContext?.ViewData;
        public CorporateFinance.Pages.DetailedCompoundingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
