#pragma checksum "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\HotelReview\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f7689ea81eccaca75b023e1ea803ae7483d0e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HotelReview_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HotelReview/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/HotelReview/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_HotelReview_Default))]
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
#line 1 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\_ViewImports.cshtml"
using HotelCloudBedSystem;

#line default
#line hidden
#line 2 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\_ViewImports.cshtml"
using HotelCloudBedSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f7689ea81eccaca75b023e1ea803ae7483d0e04", @"/Views/Shared/Components/HotelReview/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9034ffdb067ecc64202c0cae2f57cc19e57bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HotelReview_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelCloudBedSystem.ViewModels.HotelReviewViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/aa.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px;height:60px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\HotelReview\Default.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
            BeginContext(106, 74, true);
            WriteLiteral("   <div class=\"alert alert-warning\">\r\n       No Review found!\r\n   </div>\r\n");
            EndContext();
#line 9 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\HotelReview\Default.cshtml"
}
else
{
    foreach(var review in Model)
    {

#line default
#line hidden
            BeginContext(233, 64, true);
            WriteLiteral("<div class=\"row\" style=\"margin-top:15px;margin-left:20px\">\r\n    ");
            EndContext();
            BeginContext(297, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f7689ea81eccaca75b023e1ea803ae7483d0e044933", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(356, 65, true);
            WriteLiteral("\r\n    <strong style=\"margin-top:16px;margin-left:10px\">\r\n        ");
            EndContext();
            BeginContext(422, 15, false);
#line 17 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\HotelReview\Default.cshtml"
   Write(review.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(437, 25, true);
            WriteLiteral("\r\n    </strong>\r\n</div>\r\n");
            EndContext();
            BeginContext(464, 49, true);
            WriteLiteral("<strong style=\"color:peru;margin-left:100px\">\r\n\r\n");
            EndContext();
#line 23 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\HotelReview\Default.cshtml"
     for (int i = 0; i < review.ReviewStar; i++)
    {

#line default
#line hidden
            BeginContext(570, 36, true);
            WriteLiteral("        <i class=\"fa fa-star\"></i>\r\n");
            EndContext();
#line 26 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\HotelReview\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(613, 34, true);
            WriteLiteral("<span style=\"color:#A93226\">\r\n    ");
            EndContext();
            BeginContext(648, 17, false);
#line 28 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\HotelReview\Default.cshtml"
Write(review.ReviewStar);

#line default
#line hidden
            EndContext();
            BeginContext(665, 27, true);
            WriteLiteral("\r\n</span>\r\n   \r\n</strong>\r\n");
            EndContext();
            BeginContext(694, 62, true);
            WriteLiteral("        <p style=\"color:gray;margin-left:20px\" >\r\n            ");
            EndContext();
            BeginContext(757, 13, false);
#line 34 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\HotelReview\Default.cshtml"
       Write(review.Review);

#line default
#line hidden
            EndContext();
            BeginContext(770, 32, true);
            WriteLiteral("\r\n        </p>\r\n        <hr />\r\n");
            EndContext();
#line 37 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\HotelReview\Default.cshtml"
    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelCloudBedSystem.ViewModels.HotelReviewViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591