#pragma checksum "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e83e27791fee6fcd8de4b00267c0f7cc488b329e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRadarList_RadarList), @"mvc.1.0.view", @"/Views/AdminRadarList/RadarList.cshtml")]
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
#line 1 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\_ViewImports.cshtml"
using ASPNETAOP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\_ViewImports.cshtml"
using ASPNETAOP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83e27791fee6fcd8de4b00267c0f7cc488b329e", @"/Views/AdminRadarList/RadarList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8114726577ba02b0c53af550574d2018d71987ed", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRadarList_RadarList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASPNETAOP.Models.RadarInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
  
    ViewData["Title"] = "RadarList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Radar List</h1>\r\n\r\n<table class=\"table table-bordered table-responsive table-hover\">\r\n    <tr>\r\n        <th>Radar Name</th>\r\n        <th>Transmitter Name</th>\r\n        <th>Receiver Name</th>\r\n        <th>Location Name</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
     foreach (RadarInfo radar in Model)
    {
        var id = radar.Radar.ID;
        var RadarName = radar.Radar.name;
        var TransmitterName = radar.Transmitter.name;
        var ReceiverName = radar.Receiver.name;
        var LocationName = radar.Location.name;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 637, "\"", 645, 1);
#nullable restore
#line 24 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 642, id, 642, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 646, "\"", 656, 1);
#nullable restore
#line 24 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 653, id, 653, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 657, "\"", 680, 1);
#nullable restore
#line 24 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 665, radar.Radar.ID, 665, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 714, "\"", 729, 1);
#nullable restore
#line 25 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 719, RadarName, 719, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 730, "\"", 747, 1);
#nullable restore
#line 25 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 737, RadarName, 737, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 748, "\"", 773, 1);
#nullable restore
#line 25 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 756, radar.Radar.name, 756, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 807, "\"", 828, 1);
#nullable restore
#line 26 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 812, TransmitterName, 812, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 829, "\"", 852, 1);
#nullable restore
#line 26 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 836, TransmitterName, 836, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 853, "\"", 884, 1);
#nullable restore
#line 26 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 861, radar.Transmitter.name, 861, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 918, "\"", 936, 1);
#nullable restore
#line 27 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 923, ReceiverName, 923, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 937, "\"", 957, 1);
#nullable restore
#line 27 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 944, ReceiverName, 944, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 958, "\"", 986, 1);
#nullable restore
#line 27 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 966, radar.Receiver.name, 966, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 1020, "\"", 1038, 1);
#nullable restore
#line 28 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 1025, LocationName, 1025, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1039, "\"", 1059, 1);
#nullable restore
#line 28 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 1046, LocationName, 1046, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1060, "\"", 1088, 1);
#nullable restore
#line 28 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 1068, radar.Location.name, 1068, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
           Write(radar.Radar.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
           Write(radar.Transmitter.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
           Write(radar.Receiver.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
           Write(radar.Location.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <input type=\"button\" style=\"background-color:royalblue; color:white; width:150px; height:40px;\" title=\"Edit\" value=\"Edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1437, "\"", 1534, 3);
            WriteAttributeValue("", 1447, "location.href=\'", 1447, 15, true);
#nullable restore
#line 36 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
WriteAttributeValue("", 1462, Url.Action("GoToEdit", "AdminRadarList", new { id = @radar.Radar.ID }), 1462, 71, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1533, "\'", 1533, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <b>");
#nullable restore
#line 41 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
  Write(Data.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 42 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\AdminRadarList\RadarList.cshtml"
       Data.message = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASPNETAOP.Models.RadarInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
