#pragma checksum "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b525eb50c32eee91df0653614da4114ef4690920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__partialWeatherDetails), @"mvc.1.0.view", @"/Views/Home/_partialWeatherDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_partialWeatherDetails.cshtml", typeof(AspNetCore.Views_Home__partialWeatherDetails))]
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
#line 1 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\_ViewImports.cshtml"
using WeatherApp;

#line default
#line hidden
#line 2 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\_ViewImports.cshtml"
using WeatherApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b525eb50c32eee91df0653614da4114ef4690920", @"/Views/Home/_partialWeatherDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5982ed880600284e9d1c6d2e6f98bfd2936ac1ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__partialWeatherDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeatherApp.Models.ClientWeather>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
 if (Model != null)
{
    if (Model.id > 0)
    {

#line default
#line hidden
            BeginContext(124, 38, true);
            WriteLiteral("        <html>\r\n            LOCATION: ");
            EndContext();
            BeginContext(163, 10, false);
#line 11 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                 Write(Model.city);

#line default
#line hidden
            EndContext();
            BeginContext(173, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(176, 13, false);
#line 11 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                              Write(Model.country);

#line default
#line hidden
            EndContext();
            BeginContext(189, 50, true);
            WriteLiteral("\r\n            <br>\r\n            WEATHER FORECAST: ");
            EndContext();
            BeginContext(240, 35, false);
#line 13 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                         Write(Model.weather.FirstOrDefault().main);

#line default
#line hidden
            EndContext();
            BeginContext(275, 45, true);
            WriteLiteral("\r\n            <br>\r\n            DESCRIPTION: ");
            EndContext();
            BeginContext(321, 42, false);
#line 15 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                    Write(Model.weather.FirstOrDefault().description);

#line default
#line hidden
            EndContext();
            BeginContext(363, 45, true);
            WriteLiteral("\r\n            <br>\r\n            TEMPERATURE: ");
            EndContext();
            BeginContext(410, 24, false);
#line 17 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                     Write(Model.main.temp - 273.15);

#line default
#line hidden
            EndContext();
            BeginContext(435, 62, true);
            WriteLiteral(" &#8451;\r\n            <br>\r\n            ATMOSPHERIC PRESSURE: ");
            EndContext();
            BeginContext(498, 19, false);
#line 19 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                             Write(Model.main.pressure);

#line default
#line hidden
            EndContext();
            BeginContext(517, 46, true);
            WriteLiteral(" hPa\r\n            <br>\r\n            HUMIDITY: ");
            EndContext();
            BeginContext(564, 19, false);
#line 21 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                 Write(Model.main.humidity);

#line default
#line hidden
            EndContext();
            BeginContext(583, 46, true);
            WriteLiteral(" %\r\n            <br>\r\n            WIND SPEED: ");
            EndContext();
            BeginContext(630, 16, false);
#line 23 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                   Write(Model.wind.speed);

#line default
#line hidden
            EndContext();
            BeginContext(646, 55, true);
            WriteLiteral(" meter/ sec\r\n            <br>\r\n            CLOUDINESS: ");
            EndContext();
            BeginContext(702, 16, false);
#line 25 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                   Write(Model.clouds.all);

#line default
#line hidden
            EndContext();
            BeginContext(718, 48, true);
            WriteLiteral(" %\r\n            <br>\r\n            SUNRISE TIME: ");
            EndContext();
            BeginContext(767, 76, false);
#line 27 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                     Write(DateTimeOffset.FromUnixTimeSeconds(Model.sys.sunrise).DateTime.ToLocalTime());

#line default
#line hidden
            EndContext();
            BeginContext(843, 45, true);
            WriteLiteral("\r\n            <br>\r\n            SUNSET TIME: ");
            EndContext();
            BeginContext(889, 75, false);
#line 29 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
                    Write(DateTimeOffset.FromUnixTimeSeconds(Model.sys.sunset).DateTime.ToLocalTime());

#line default
#line hidden
            EndContext();
            BeginContext(964, 37, true);
            WriteLiteral("\r\n            <br>\r\n        </html>\r\n");
            EndContext();
#line 32 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1025, 109, true);
            WriteLiteral("        <html>\r\n        NO DATA TO SHOW.\r\n        <br>\r\n        PLEASE CHECK ENTERED LOCATION.\r\n    </html>\r\n");
            EndContext();
#line 40 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
    }

}
else
{

#line default
#line hidden
            BeginContext(1155, 109, true);
            WriteLiteral("    <html>\r\n            NO DATA TO SHOW.\r\n    <br>\r\n            PLEASE CHECK ENTERED LOCATION.\r\n    </html>\r\n");
            EndContext();
#line 50 "D:\Judy\LeadHornet\WeatherApp\WeatherApp\Views\Home\_partialWeatherDetails.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherApp.Models.ClientWeather> Html { get; private set; }
    }
}
#pragma warning restore 1591