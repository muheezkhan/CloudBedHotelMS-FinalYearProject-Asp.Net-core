#pragma checksum "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f40afe42b8ab0499ad101aba2e2480b44257613f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MultiHotelMap_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MultiHotelMap/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MultiHotelMap/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MultiHotelMap_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40afe42b8ab0499ad101aba2e2480b44257613f", @"/Views/Shared/Components/MultiHotelMap/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9034ffdb067ecc64202c0cae2f57cc19e57bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MultiHotelMap_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelCloudBedSystem.ViewModels.HotelMaplocationViewModel>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(85, 877, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f40afe42b8ab0499ad101aba2e2480b44257613f3620", async() => {
                BeginContext(91, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(171, 784, true);
                WriteLiteral(@"        <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAuoOeYDXkpylbep3Fx4tx-jHvhRe7t5uE""
                type=""text/javascript""></script>

        <style>

            .content {
                padding: 16px;
            }

            /* The sticky class is added to the header with JS when it reaches its scroll position */
            .sticky {
                position: fixed;
                top: 0;
                width: 100%
            }

                /* Add some top padding to the page content to prevent sudden quick movement (as the header gets a new position at the top of the page (position:fixed and top:0) */
                .sticky + .content {
                    padding-top: 102px;
                }
        </style>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(962, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(964, 4071, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f40afe42b8ab0499ad101aba2e2480b44257613f5703", async() => {
                BeginContext(970, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 28 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
       
        string citylat = null;
        string citylong = null;
        
    

#line default
#line hidden
                BeginContext(1063, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 33 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
     foreach(var location in Model)
    {
        citylat = location.CityLatitude;
        citylong = location.CityLongitude;
        break;

    }

#line default
#line hidden
                BeginContext(1218, 152, true);
                WriteLiteral("    <div id=\"myDiv\"  style=\"width:600px;height:600px;\"></div>\r\n   \r\n    <script type=\"text/javascript\">\r\n        var myAddress = new google.maps.LatLng(");
                EndContext();
                BeginContext(1371, 7, false);
#line 43 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                                          Write(citylat);

#line default
#line hidden
                EndContext();
                BeginContext(1378, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(1381, 8, false);
#line 43 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                                                    Write(citylong);

#line default
#line hidden
                EndContext();
                BeginContext(1389, 813, true);
                WriteLiteral(@");

        var mapOptions = {
            center: myAddress,
            zoom: 11,
            minZoom: 5,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            mapTypeControl: false,
            
        };

        var map = new google.maps.Map(document.getElementById(""myDiv""), mapOptions);

         var image = {
             url: 'https://image.flaticon.com/icons/svg/1775/1775269.svg',
    // This marker is 20 pixels wide by 32 pixels high.
             size: new google.maps.Size(151, 150),
             origin: new google.maps.Point(0, 0),
             anchor: new google.maps.Point(19, 30),
             scaledSize: new google.maps.Size(40, 40)
        };
        var shape = {
            coords: [1, 1, 1, 20, 18, 20, 18, 1],
            type: 'poly'
        };
");
                EndContext();
#line 68 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
         foreach(var location in Model) {
            

#line default
#line hidden
                BeginContext(2263, 123, true);
                WriteLiteral("\r\n                var marker = new google.maps.Marker({\r\n                    map:map,\r\n                    position: {lat: ");
                EndContext();
                BeginContext(2387, 22, false);
#line 72 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                               Write(location.HotelLatitude);

#line default
#line hidden
                EndContext();
                BeginContext(2409, 7, true);
                WriteLiteral(", lng: ");
                EndContext();
                BeginContext(2417, 23, false);
#line 72 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                                                             Write(location.HotelLongitude);

#line default
#line hidden
                EndContext();
                BeginContext(2440, 33, true);
                WriteLiteral(" },\r\n                    title: \'");
                EndContext();
                BeginContext(2474, 18, false);
#line 73 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                       Write(location.HotelName);

#line default
#line hidden
                EndContext();
                BeginContext(2492, 751, true);
                WriteLiteral(@" +Hotel',
                    icon: image,
                    //animation: google.maps.Animation.BOUNCE

                });


                (function (marker) {
                    // add click event
                    google.maps.event.addListener(marker, 'mouseover', function () {
                        infowindow = new google.maps.InfoWindow({
                            content: '<div style=""width:400px;"">' +
            '<div class=""row"" style=""width:400px"">' +
            '<div class=""col-5"">' +
            '<img src=""/image/r6.jpg"" style=""width:140px;height:120px"" />' +
            '</div>' +
            '<div class=""col-6"">' +
            '<h6 style=""font-weight: bold;color:#A93226""> <i class=""fa fa-home""></i> ");
                EndContext();
                BeginContext(3244, 18, false);
#line 90 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                                                                                Write(location.HotelName);

#line default
#line hidden
                EndContext();
                BeginContext(3262, 119, true);
                WriteLiteral("</h6>\' +\r\n            \'<p style=\"font-weight: bold;color:#D4AC0D\"> <i class=\"fa fa-map-marker\" aria-hidden=\"true\"></i> ");
                EndContext();
                BeginContext(3382, 17, false);
#line 91 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                                                                                                        Write(location.CityName);

#line default
#line hidden
                EndContext();
                BeginContext(3399, 65, true);
                WriteLiteral("</p>\' +\r\n            \'<div class=\"row\" style=\"margin-left:10px\"> ");
                EndContext();
#line 92 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                                                         for (int i = 0; i < location.AverageSatr; i++) {

#line default
#line hidden
                BeginContext(3513, 49, true);
                WriteLiteral("<i class=\"fa fa-star\" style=\"color:#D4AC0D\"></i> ");
                EndContext();
#line 92 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                                                                                                                                                          }

#line default
#line hidden
                BeginContext(3563, 103, true);
                WriteLiteral(" <b style=\"margin-left:3px;color:brown\">4</b>\' +\r\n            \'<p style=\"margin-left:25px;color:grey\"> ");
                EndContext();
                BeginContext(3667, 21, false);
#line 93 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                                                Write(location.totalreviews);

#line default
#line hidden
                EndContext();
                BeginContext(3688, 268, true);
                WriteLiteral(@" Reviews</p></div > <hr />' +
            '</div>' +
            '</div>' +
            '<div class=""row"" style=""margin-left:30px;margin-top:10px"">' +
            '<strong style=""font-weight: bold"">our lowest price' +
            '<span style = ""color:red"" > RS: ");
                EndContext();
                BeginContext(3957, 21, false);
#line 98 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                                        Write(location.AveragePrice);

#line default
#line hidden
                EndContext();
                BeginContext(3978, 415, true);
                WriteLiteral(@"</span ></strong > <p style=""margin-left:5px"">per Night</p>' +
            '</div>' +
                                '</div>'


                        });
                        infowindow.open(map, marker);
                    });
                    marker.addListener('mouseout', function () {
                        infowindow.close();
                    });
            })(marker)
            ");
                EndContext();
#line 110 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Views\Shared\Components\MultiHotelMap\Default.cshtml"
                   
        }

#line default
#line hidden
                BeginContext(4413, 615, true);
                WriteLiteral(@"        window.onscroll = function () { myFunction() };

        // Get the header
        var header = document.getElementById(""myDiv"");

        // Get the offset position of the navbar
        var sticky = header.offsetTop;

        // Add the sticky class to the header when you reach its scroll position. Remove ""sticky"" when you leave the scroll position
        function myFunction() {
            if (window.pageYOffset > sticky) {
                header.classList.add(""sticky"");
            } else {
                header.classList.remove(""sticky"");
            }
        }
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5035, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelCloudBedSystem.ViewModels.HotelMaplocationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591