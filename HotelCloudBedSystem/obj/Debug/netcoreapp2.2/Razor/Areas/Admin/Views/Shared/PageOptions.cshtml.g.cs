#pragma checksum "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\PageOptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf18aafb8cdb7c6dbfa3190fa1d009b4fa86801"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_PageOptions), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/PageOptions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/PageOptions.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_PageOptions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf18aafb8cdb7c6dbfa3190fa1d009b4fa86801", @"/Areas/Admin/Views/Shared/PageOptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_PageOptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\PageOptions.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 201, true);
            WriteLiteral("\r\n<div class=\"container-fluid mt-2\">\r\n    <div class=\"row m-1\">\r\n        <div class=\"col\"></div>\r\n        <div class=\"col-1\">\r\n            <label class=\"col-form-label\">Search</label>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1085, 350, true);
            WriteLiteral(@"        <div class=""col""></div>
    </div>

    <div class=""row m-1"">
        <div class=""col""></div>
        <div class=""col-1"">
            <label class=""col-form-label"">Sort</label>
        </div>
        <div class=""col-3"">
            <select form=""pageform"" name=""options.OrderPropertyName""
                    class=""form-control"">
");
            EndContext();
#line 43 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\PageOptions.cshtml"
                 foreach (string s in ViewBag.sorts as string[]) {

#line default
#line hidden
            BeginContext(1503, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1519, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bf18aafb8cdb7c6dbfa3190fa1d009b4fa868014335", async() => {
                BeginContext(1614, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1638, 57, false);
#line 46 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\PageOptions.cshtml"
                Write(s.IndexOf('.') == -1 ? s : s.Substring(0, s.IndexOf('.')));

#line default
#line hidden
                EndContext();
                BeginContext(1696, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 44 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\PageOptions.cshtml"
                   WriteLiteral(s);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 45 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\PageOptions.cshtml"
AddHtmlAttributeValue("", 1573, Model.Options.OrderPropertyName == s, 1573, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1723, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\PageOptions.cshtml"
}

#line default
#line hidden
            BeginContext(1728, 283, true);
            WriteLiteral(@"            </select>
        </div>
        <div class=""col form-check form-check-inline"">
            <input form=""pageform"" type=""checkbox"" name=""Options.DescendingOrder""
                   id=""Options.DescendingOrder""
                   class=""form-check-input"" value=""true""");
            EndContext();
            BeginWriteAttribute("checked", "\r\n                   checked=\"", 2011, "\"", 2071, 1);
#line 55 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\PageOptions.cshtml"
WriteAttributeValue("", 2041, Model.Options.DescendingOrder, 2041, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2072, 321, true);
            WriteLiteral(@" />
            <label class=""form-check-label"">Descending Order</label>
        </div>
        <div class=""col-1 text-right"">
            <button form=""pageform"" class=""btn btn-secondary"" type=""submit"">
                Sort
            </button>
        </div>
        <div class=""col""></div>
    </div>
</div>");
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