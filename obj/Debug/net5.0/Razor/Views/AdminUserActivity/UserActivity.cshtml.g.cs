#pragma checksum "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d869ce11af192e04bf4cbb5aba00d7536a116b05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminUserActivity_UserActivity), @"mvc.1.0.view", @"/Views/AdminUserActivity/UserActivity.cshtml")]
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
#line 1 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\_ViewImports.cshtml"
using ASPNETAOP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\_ViewImports.cshtml"
using ASPNETAOP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d869ce11af192e04bf4cbb5aba00d7536a116b05", @"/Views/AdminUserActivity/UserActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8114726577ba02b0c53af550574d2018d71987ed", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminUserActivity_UserActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASPNETAOP.Models.AdminUserActivity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml"
  
    ViewData["Title"] = "UserActivity";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Users</h1>

<table class=""table table-bordered table-responsive table-hover"">
    <tr>
        <th>ID</th>
        <th>User Name</th>
        <th>Mail</th>
        <th>Role</th>
        <th>Login Date</th>
        <th>IsLoggedIn</th>
    </tr>
");
#nullable restore
#line 18 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml"
           Write(user.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml"
           Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml"
           Write(user.Usermail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml"
           Write(user.Rolename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml"
           Write(user.LoginDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml"
           Write(user.IsLoggedIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Cenk\source\repos\ASPNET-CORE-RADAR\Views\AdminUserActivity\UserActivity.cshtml"
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASPNETAOP.Models.AdminUserActivity>> Html { get; private set; }
    }
}
#pragma warning restore 1591