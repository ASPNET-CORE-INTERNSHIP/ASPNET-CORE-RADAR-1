#pragma checksum "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816e8f3f46fdeb8729bbd7eca598c4a98db98476"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Scan_Show), @"mvc.1.0.view", @"/Views/Scan/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816e8f3f46fdeb8729bbd7eca598c4a98db98476", @"/Views/Scan/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8114726577ba02b0c53af550574d2018d71987ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Scan_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPNETAOP.Models.SubModeInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
  
    ViewData["Title"] = "Scan's Informations";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Scan\'s Informations</h1>\r\n\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-9\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "816e8f3f46fdeb8729bbd7eca598c4a98db984765114", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "816e8f3f46fdeb8729bbd7eca598c4a98db984765384", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
              
                var ID = "Model.Scan.ID";
                var scan_name = "Model.Scan.name";
                var type = "Model.Scan.type";
                var main_aspect = "Model.Scan.main_aspect";
                var scan_angle = "Model.Scan.scan_angle";
                var scan_rate = "Model.Scan.scan_rate";
                var hits_per_scan = "Model.Scan.hits_per_scan";

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 733, "\"", 741, 1);
#nullable restore
#line 22 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 738, ID, 738, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 742, "\"", 752, 1);
#nullable restore
#line 22 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 749, ID, 749, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 753, "\"", 775, 1);
#nullable restore
#line 22 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 761, Model.Scan.ID, 761, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 817, "\"", 832, 1);
#nullable restore
#line 23 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 822, scan_name, 822, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 833, "\"", 850, 1);
#nullable restore
#line 23 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 840, scan_name, 840, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 851, "\"", 875, 1);
#nullable restore
#line 23 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 859, Model.Scan.name, 859, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 917, "\"", 927, 1);
#nullable restore
#line 24 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 922, type, 922, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 928, "\"", 940, 1);
#nullable restore
#line 24 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 935, type, 935, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 941, "\"", 965, 1);
#nullable restore
#line 24 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 949, Model.Scan.type, 949, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 1007, "\"", 1024, 1);
#nullable restore
#line 25 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1012, main_aspect, 1012, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1025, "\"", 1044, 1);
#nullable restore
#line 25 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1032, main_aspect, 1032, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1045, "\"", 1076, 1);
#nullable restore
#line 25 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1053, Model.Scan.main_aspect, 1053, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 1118, "\"", 1134, 1);
#nullable restore
#line 26 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1123, scan_angle, 1123, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1135, "\"", 1153, 1);
#nullable restore
#line 26 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1142, scan_angle, 1142, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1154, "\"", 1184, 1);
#nullable restore
#line 26 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1162, Model.Scan.scan_angle, 1162, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 1226, "\"", 1241, 1);
#nullable restore
#line 27 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1231, scan_rate, 1231, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1242, "\"", 1259, 1);
#nullable restore
#line 27 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1249, scan_rate, 1249, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1260, "\"", 1289, 1);
#nullable restore
#line 27 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1268, Model.Scan.scan_rate, 1268, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 1331, "\"", 1350, 1);
#nullable restore
#line 28 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1336, hits_per_scan, 1336, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1351, "\"", 1372, 1);
#nullable restore
#line 28 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1358, hits_per_scan, 1358, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1373, "\"", 1406, 1);
#nullable restore
#line 28 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 1381, Model.Scan.hits_per_scan, 1381, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "816e8f3f46fdeb8729bbd7eca598c4a98db9847615060", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 30 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Scan.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
AddHtmlAttributeValue("", 1503, ID, 1503, 3, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("                <h1>---------------------------------------------------------------------</h1>\r\n                <table>\r\n                    <tr>\r\n                        <th>Name:</th>\r\n                        <th>");
#nullable restore
#line 36 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
                       Write(Model.Scan.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Type:</th>\r\n                        <th>");
#nullable restore
#line 40 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
                       Write(Model.Scan.type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Main Aspect:</th>\r\n                        <th>");
#nullable restore
#line 44 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
                       Write(Model.Scan.main_aspect);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Scan Rate:</th>\r\n                        <th>");
#nullable restore
#line 48 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
                       Write(Model.Scan.scan_rate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Scan Angle:</th>\r\n                        <th>");
#nullable restore
#line 52 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
                       Write(Model.Scan.scan_angle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Hits Per Scan:</th>\r\n                        <th>");
#nullable restore
#line 56 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
                       Write(Model.Scan.hits_per_scan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    </tr>\r\n                </table>\r\n                <h1>---------------------------------------------------------------------</h1>\r\n");
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<h1>---------------------------------------------------------------------</h1>
<h3>Antennas That Works With This Scan</h3>
<div class=""row"">
    <table>
        <tr>
            <th>Antenna Name</th>
            <th>Type</th>
            <th>Duty</th>
            <th></th>
        </tr>
");
#nullable restore
#line 74 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
          for (int i = 0; i < Model.ListOfAntennas.Count; i++)
            {
                var name = Model.ListOfAntennas[i].name;
                var antenna_type = Model.ListOfAntennas[i].type;
                var duty = Model.ListOfAntennas[i].duty;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3321, "\"", 3331, 1);
#nullable restore
#line 79 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 3326, name, 3326, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3332, "\"", 3344, 1);
#nullable restore
#line 79 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 3339, name, 3339, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3345, "\"", 3382, 1);
#nullable restore
#line 79 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 3353, Model.ListOfAntennas[i].name, 3353, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3424, "\"", 3442, 1);
#nullable restore
#line 80 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 3429, antenna_type, 3429, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3443, "\"", 3463, 1);
#nullable restore
#line 80 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 3450, antenna_type, 3450, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3464, "\"", 3501, 1);
#nullable restore
#line 80 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 3472, Model.ListOfAntennas[i].type, 3472, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3543, "\"", 3553, 1);
#nullable restore
#line 81 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 3548, duty, 3548, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3554, "\"", 3566, 1);
#nullable restore
#line 81 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 3561, duty, 3561, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3567, "\"", 3604, 1);
#nullable restore
#line 81 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 3575, Model.ListOfAntennas[i].duty, 3575, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 83 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 84 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
                   Write(antenna_type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 85 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
                   Write(duty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 87 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<h1>            </h1>\r\n<h1>---------------------------------------------------------------------</h1>\r\n<b>");
#nullable restore
#line 93 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n<div>\r\n    <input type=\"button\" style=\"background-color:mediumblue; border-color:mediumblue; color:white; width:150px; height:40px;\" title=\"Back\" value=\"Back\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4109, "\"", 4162, 3);
            WriteAttributeValue("", 4119, "location.href=\'", 4119, 15, true);
#nullable restore
#line 95 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
WriteAttributeValue("", 4134, Url.Action("Back", "Scan"), 4134, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4161, "\'", 4161, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\ENA\source\repos\ASPNET-CORE-RADAR\Views\Scan\Show.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPNETAOP.Models.SubModeInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
