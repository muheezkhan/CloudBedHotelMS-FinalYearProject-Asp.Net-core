#pragma checksum "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22e7001c286b0aff2a6c05bb13629521d2c70be0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_RequestAccept_Accept), @"mvc.1.0.view", @"/Areas/Admin/Views/RequestAccept/Accept.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/RequestAccept/Accept.cshtml", typeof(AspNetCore.Areas_Admin_Views_RequestAccept_Accept))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e7001c286b0aff2a6c05bb13629521d2c70be0", @"/Areas/Admin/Views/RequestAccept/Accept.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_RequestAccept_Accept : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelCloudBedSystem.Models.AppUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("updateuser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccountRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:-50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
  
    ViewData["Title"] = "Accept";

#line default
#line hidden
            BeginContext(98, 581, true);
            WriteLiteral(@"
<section class=""content-header"">
    <h1>
        UsersList
        <small>AcceptedRequest</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Tables</a></li>
        <li class=""active"">Data tables</li>
    </ol>
</section>
<div class=""box-body"" id=""Alluserlist"">
    <div id=""example1_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap"">
        <div class=""row"">

            <div class=""text-center"" style=""margin-top:30px;margin-left:-400px;"">

                ");
            EndContext();
            BeginContext(680, 28, false);
#line 23 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
           Write(Html.Partial("Pages", Model));

#line default
#line hidden
            EndContext();
            BeginContext(708, 24, true);
            WriteLiteral("\r\n\r\n            </div>\r\n");
            EndContext();
            BeginContext(924, 39, true);
            WriteLiteral("\r\n            <div class=\"col-sm-12\">\r\n");
            EndContext();
#line 31 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                 if (Model == null)
                {

#line default
#line hidden
            BeginContext(1019, 127, true);
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        Empty Data Found..\r\n                    </div>\r\n");
            EndContext();
#line 36 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1206, 1222, true);
            WriteLiteral(@"                    <table id=""example1"" class=""table table-bordered table-striped dataTable"" role=""grid"" aria-describedby=""example1_info"" style=""margin-top:25px;"">
                        <thead>
                            <tr role=""row"">
                                <th class=""sorting_asc"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column descending"" style=""width: 150px;"">Manager</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column ascending"" style=""width: 180px;"">EMail Address</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""Engine version: activate to sort column ascending"" style=""width: 130px;"">Phone No</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1");
            WriteLiteral("\" aria-label=\"CSS grade: activate to sort column ascending\" style=\"width: 150px;\">Actions</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 49 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                             foreach (var user in Model)
                            {


#line default
#line hidden
            BeginContext(2519, 119, true);
            WriteLiteral("                                <tr role=\"row\" class=\"odd\">\r\n                                    <td class=\"sorting_1\">");
            EndContext();
            BeginContext(2639, 14, false);
#line 53 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                                                     Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2653, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2655, 13, false);
#line 53 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                                                                     Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2668, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2716, 10, false);
#line 54 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                                   Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2726, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2774, 16, false);
#line 55 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                                   Write(user.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2790, 89, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2879, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22e7001c286b0aff2a6c05bb13629521d2c70be010713", async() => {
                BeginContext(3040, 94, true);
                WriteLiteral("\r\n                                            Detail\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                                                                                                                                                        WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3138, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 62 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                            }

#line default
#line hidden
            BeginContext(3253, 72, true);
            WriteLiteral("\r\n\r\n\r\n                        </tbody>\r\n\r\n                    </table>\r\n");
            EndContext();
#line 69 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
                }

#line default
#line hidden
            BeginContext(3344, 135, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"text-center\" style=\"margin-top:15px;margin-left:-400px;\">\r\n    ");
            EndContext();
            BeginContext(3480, 28, false);
#line 77 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\RequestAccept\Accept.cshtml"
Write(Html.Partial("Pages", Model));

#line default
#line hidden
            EndContext();
            BeginContext(3508, 16, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelCloudBedSystem.Models.AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
