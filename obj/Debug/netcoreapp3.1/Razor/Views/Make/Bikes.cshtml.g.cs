#pragma checksum "A:\Project\Pratice\Bike\Bike\Views\Make\Bikes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3beab5874530a057b3d9350dcebde380cb7448fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Make_Bikes), @"mvc.1.0.view", @"/Views/Make/Bikes.cshtml")]
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
#nullable restore
#line 1 "A:\Project\Pratice\Bike\Bike\Views\_ViewImports.cshtml"
using Bike;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Project\Pratice\Bike\Bike\Views\_ViewImports.cshtml"
using Bike.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3beab5874530a057b3d9350dcebde380cb7448fa", @"/Views/Make/Bikes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f16220117be28cc4f6ba147eeb56452a4f99d22", @"/Views/_ViewImports.cshtml")]
    public class Views_Make_Bikes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bike.Models.Make>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "A:\Project\Pratice\Bike\Bike\Views\Make\Bikes.cshtml"
  
    ViewData["Title"] = "Bikes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "A:\Project\Pratice\Bike\Bike\Views\Make\Bikes.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bike.Models.Make> Html { get; private set; }
    }
}
#pragma warning restore 1591
