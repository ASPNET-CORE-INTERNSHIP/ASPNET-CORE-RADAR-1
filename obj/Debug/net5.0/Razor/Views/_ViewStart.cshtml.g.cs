#pragma checksum "C:\Users\Cenk\OneDrive\Desktop\Test2\ASPNET-CORE-RADAR-main\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b84708f802e5df6685bd4f4c06efe90651b711b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
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
#line 1 "C:\Users\Cenk\OneDrive\Desktop\Test2\ASPNET-CORE-RADAR-main\Views\_ViewImports.cshtml"
using ASPNETAOP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cenk\OneDrive\Desktop\Test2\ASPNET-CORE-RADAR-main\Views\_ViewImports.cshtml"
using ASPNETAOP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b84708f802e5df6685bd4f4c06efe90651b711b", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8114726577ba02b0c53af550574d2018d71987ed", @"/Views/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Cenk\OneDrive\Desktop\Test2\ASPNET-CORE-RADAR-main\Views\_ViewStart.cshtml"
   

    if(TempData["ResultMessage"] == null)
    {
        Layout = "~/Views/Shared/_PreLoginLayout.cshtml";
    }
    else
    {
        if (TempData["ResultMessage"].Equals("Admin"))
        {
            Layout = "~/Views/Shared/_AdminLayout.cshtml";
        }
        else
        {
            Layout = "~/Views/Shared/_Layout.cshtml";
        }
    }

#line default
#line hidden
#nullable disable
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
