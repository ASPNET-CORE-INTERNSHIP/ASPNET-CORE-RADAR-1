#pragma checksum "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b9a1193a3f18ee977ecb82e798cf920bae504f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AntennaScan_NewAntennaScan), @"mvc.1.0.view", @"/Views/AntennaScan/NewAntennaScan.cshtml")]
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
#line 1 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\_ViewImports.cshtml"
using ASPNETAOP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\_ViewImports.cshtml"
using ASPNETAOP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9a1193a3f18ee977ecb82e798cf920bae504f2", @"/Views/AntennaScan/NewAntennaScan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8114726577ba02b0c53af550574d2018d71987ed", @"/Views/_ViewImports.cshtml")]
    public class Views_AntennaScan_NewAntennaScan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPNETAOP.Models.Antenna.AntennaList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewAntennaScan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
  
    ViewData["Title"] = "NewAntennaScan";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Build Relationship</h1>\r\n\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-9\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9a1193a3f18ee977ecb82e798cf920bae504f24888", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9a1193a3f18ee977ecb82e798cf920bae504f25158", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
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
                WriteLiteral(@"
            <table class=""table"">
                <tr>
                    <th>Name</th>
                    <th>Type</th>
                    <th>Horizontal Beamwidth</th>
                    <th>Vertical Beamwidth</th>
                    <th>Polarization</th>
                    <th>Number of Feed</th>
                    <th>Horizontal Dimension</th>
                    <th>Vertical Dimension</th>
                    <th>Location</th>
                    <th>Select</th>
                </tr>
");
#nullable restore
#line 27 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                 for (int i = 0; i < Model.antennas.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Model.antennas[i].name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Model.antennas[i].type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Model.antennas[i].horizontal_beamwidth);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Model.antennas[i].vertical_beamwidth);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Model.antennas[i].polarization);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Model.antennas[i].number_of_feed);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Model.antennas[i].horizontal_dimension);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Model.antennas[i].vertical_dimension);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Model.antennas[i].location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                       Write(Html.CheckBoxFor(m => Model.antennas[i].IsChecked));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </table>
            <div class=""form-group"">
            </div>
            <div>
                <input type=""submit"" value=""Add"" class=""btn btn-primary"" />
            </div>
            <div>
                <input type=""button"" title=""AddSubmode"" value=""Add Submode""");
                BeginWriteAttribute("onclick", " onclick=\"", 1959, "\"", 2026, 3);
                WriteAttributeValue("", 1969, "location.href=\'", 1969, 15, true);
#nullable restore
#line 49 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
WriteAttributeValue("", 1984, Url.Action("GoToSubmode", "AntennaScan"), 1984, 41, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2025, "\'", 2025, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <input type=\"button\" title=\"AddMode\" value=\"Add Mode\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2140, "\"", 2204, 3);
                WriteAttributeValue("", 2150, "location.href=\'", 2150, 15, true);
#nullable restore
#line 52 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
WriteAttributeValue("", 2165, Url.Action("GoToMode", "AntennaScan"), 2165, 38, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2203, "\'", 2203, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <input type=\"button\" title=\"Done\" value=\"DONE!\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2312, "\"", 2372, 3);
                WriteAttributeValue("", 2322, "location.href=\'", 2322, 15, true);
#nullable restore
#line 55 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
WriteAttributeValue("", 2337, Url.Action("Done", "AntennaScan"), 2337, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2371, "\'", 2371, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <b>");
#nullable restore
#line 57 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
          Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9a1193a3f18ee977ecb82e798cf920bae504f214687", async() => {
                WriteLiteral("Turn back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\ENA\Source\Repos\ASPNET-CORE-RADAR\Views\AntennaScan\NewAntennaScan.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPNETAOP.Models.Antenna.AntennaList> Html { get; private set; }
    }
}
#pragma warning restore 1591
