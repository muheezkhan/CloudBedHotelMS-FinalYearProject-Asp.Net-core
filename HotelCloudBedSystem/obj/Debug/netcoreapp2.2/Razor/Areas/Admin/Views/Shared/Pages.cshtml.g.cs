#pragma checksum "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "448d55b84baa7b8fd1b8be615c27c1d482ecf595"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Pages), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Pages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Pages.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Pages))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"448d55b84baa7b8fd1b8be615c27c1d482ecf595", @"/Areas/Admin/Views/Shared/Pages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Pages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pageform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(31, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(35, 1735, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448d55b84baa7b8fd1b8be615c27c1d482ecf5954555", async() => {
                BeginContext(103, 40, true);
                WriteLiteral("\r\n    <button name=\"options.currentPage\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 143, "\"", 174, 1);
#line 9 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 151, Model.CurrentPage -1, 151, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", "\r\n            class=\"", 175, "\"", 263, 3);
                WriteAttributeValue("", 196, "btn", 196, 3, true);
                WriteAttributeValue(" ", 199, "btn-outline-primary", 200, 20, true);
#line 10 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 219, !Model.HasPreviousPage ? "disabled" : "", 220, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(264, 64, true);
                WriteLiteral("\r\n            type=\"submit\">\r\n        Previous \r\n    </button>\r\n");
                EndContext();
#line 14 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
     for (int i = 1; i <= 3 && i <= Model.TotalPages; i++)
    {

#line default
#line hidden
                BeginContext(395, 42, true);
                WriteLiteral("        <button name=\"options.currentPage\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 437, "\"", 447, 1);
#line 16 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 445, i, 445, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(448, 14, true);
                WriteLiteral(" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("class", "\r\n                class=\"", 462, "\"", 544, 3);
                WriteAttributeValue("", 487, "btn", 487, 3, true);
                WriteAttributeValue(" ", 490, "btn-primary", 491, 12, true);
#line 17 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 502, Model.CurrentPage == i ? "active" : "", 503, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(545, 15, true);
                WriteLiteral(">\r\n            ");
                EndContext();
                BeginContext(561, 1, false);
#line 18 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
       Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(562, 21, true);
                WriteLiteral("\r\n        </button>\r\n");
                EndContext();
#line 20 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
    }

#line default
#line hidden
                BeginContext(590, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 21 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
     if (Model.CurrentPage > 3 && Model.TotalPages - Model.CurrentPage >= 3)
    {

#line default
#line hidden
                BeginContext(675, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(685, 60, true);
                WriteLiteral("...\r\n        <button class=\"btn btn-outline-primary active\">");
                EndContext();
                BeginContext(746, 17, false);
#line 24 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
                                                  Write(Model.CurrentPage);

#line default
#line hidden
                EndContext();
                BeginContext(763, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 25 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
    }

#line default
#line hidden
                BeginContext(781, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 26 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
     if (Model.TotalPages > 3)
    {

#line default
#line hidden
                BeginContext(820, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(830, 5, true);
                WriteLiteral("...\r\n");
                EndContext();
#line 29 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
         for (int i = Math.Max(4, Model.TotalPages - 2);
          i <= Model.TotalPages; i++)
        {

#line default
#line hidden
                BeginContext(943, 46, true);
                WriteLiteral("            <button name=\"options.currentPage\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 989, "\"", 999, 1);
#line 32 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 997, i, 997, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1000, 14, true);
                WriteLiteral(" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("class", "\r\n                    class=\"", 1014, "\"", 1101, 3);
                WriteAttributeValue("", 1043, "btn", 1043, 3, true);
                WriteAttributeValue(" ", 1046, "btn-primary", 1047, 12, true);
#line 33 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
WriteAttributeValue("\r\n", 1058, Model.CurrentPage == i ? "active" : "", 1060, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1102, 19, true);
                WriteLiteral(">\r\n                ");
                EndContext();
                BeginContext(1122, 1, false);
#line 35 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
           Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(1123, 25, true);
                WriteLiteral("\r\n            </button>\r\n");
                EndContext();
#line 37 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
        }

#line default
#line hidden
#line 37 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
         
    }

#line default
#line hidden
                BeginContext(1166, 38, true);
                WriteLiteral("    <button name=\"options.currentPage\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1204, "\"", 1235, 1);
#line 39 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 1212, Model.CurrentPage +1, 1212, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1236, 14, true);
                WriteLiteral(" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("class", "\r\n            class=\"", 1250, "\"", 1333, 3);
                WriteAttributeValue("", 1271, "btn", 1271, 3, true);
                WriteAttributeValue(" ", 1274, "btn-outline-primary", 1275, 20, true);
#line 40 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 1294, !Model.HasNextPage? "disabled" : "", 1295, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1334, 101, true);
                WriteLiteral(">\r\n        Next\r\n    </button>\r\n    <select name=\"options.pageSize\" class=\"form-control ml-1 mr-1\">\r\n");
                EndContext();
#line 44 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
         foreach (int val in new int[] { 1, 2, 4, 6, 8, 100 })
        {

#line default
#line hidden
                BeginContext(1510, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(1522, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448d55b84baa7b8fd1b8be615c27c1d482ecf59513604", async() => {
                    BeginContext(1580, 3, false);
#line 46 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
                                                                Write(val);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 46 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
               WriteLiteral(val);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 46 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
AddHtmlAttributeValue("", 1553, Model.PageSize == val, 1553, 24, false);

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
                BeginContext(1592, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Shared\Pages.cshtml"
        }

#line default
#line hidden
                BeginContext(1605, 158, true);
                WriteLiteral("    </select>\r\n    <input type=\"hidden\" name=\"options.currentPage\" value=\"1\" />\r\n    <button type=\"submit\" class=\"btn btn-primary\">Change Page Size</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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