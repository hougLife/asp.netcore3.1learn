#pragma checksum "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\First\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca485059965960965e07bc19c06cef6419281af4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_First_Index), @"mvc.1.0.view", @"/Views/First/Index.cshtml")]
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
#line 1 "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\_ViewImports.cshtml"
using NETCore3_1Basis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\_ViewImports.cshtml"
using NETCore3_1Basis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\First\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca485059965960965e07bc19c06cef6419281af4", @"/Views/First/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3821007eb2d6feee361bfc8964ee0e9b55f5db48", @"/Views/_ViewImports.cshtml")]
    public class Views_First_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\First\Index.cshtml"
  

    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<h1>");
#nullable restore
#line 8 "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\First\Index.cshtml"
Write(TempData["u1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 9 "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\First\Index.cshtml"
Write(ViewBag.u2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 10 "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\First\Index.cshtml"
Write(Context.Session.GetString("u3"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 11 "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\First\Index.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 12 "E:\DOTNET\GitHub\hougLife\asp.netcore3.1learn\NETCore3_1\NETCore3_1Basis\Views\First\Index.cshtml"
Write(ViewData["u4"]);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591