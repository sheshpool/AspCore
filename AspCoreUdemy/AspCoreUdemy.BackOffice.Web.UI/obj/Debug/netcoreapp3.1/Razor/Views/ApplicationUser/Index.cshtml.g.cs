#pragma checksum "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b18fe30b3e16923fca8a0ec2eec7d23a07936479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationUser_Index), @"mvc.1.0.view", @"/Views/ApplicationUser/Index.cshtml")]
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
#line 1 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\_ViewImports.cshtml"
using AspCoreUdemy.BackOffice.Web.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\_ViewImports.cshtml"
using AspCoreUdemy.BackOffice.Web.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b18fe30b3e16923fca8a0ec2eec7d23a07936479", @"/Views/ApplicationUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0ee267fbc96d1b5f29f0ce5b714e8df68ddfc3", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AspCoreUdemy.Core.Data.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n\r\n<p>\r\n    <button type=\"button\" class=\"btn btn-light btn-sm\">\r\n        <a");
            BeginWriteAttribute("href", " href=\'", 251, "\'", 279, 1);
#nullable restore
#line 13 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
WriteAttributeValue("", 258, Url.Action("Create"), 258, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <i class=""fas fa-plus"" style="" font-size: 20px;     color: steelblue;""> Add</i>
        </a>
    </button>
</p>

<table class=""table table-striped table-sm"">
    <thead class=""thead-dark"">
        <tr>
            <th>
                ");
#nullable restore
#line 23 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"float-right btn-group\">\r\n                <button type=\"button\" class=\"btn btn-sm btn-primary-outline\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 1375, "\'", 1445, 1);
#nullable restore
#line 49 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
WriteAttributeValue("", 1382, Url.Action("Details", "ApplicationUser", new { id = item.Id }), 1382, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-eye\" style=\"font-size: 20px; color: seagreen;\"></i>\r\n                    </a>\r\n                </button>\r\n                <button type=\"button\" class=\"btn btn-sm btn-primary-outline\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 1697, "\'", 1775, 1);
#nullable restore
#line 54 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
WriteAttributeValue("", 1704, Url.Action("Edit", "ApplicationUser", new { id = item.Id.ToString() }), 1704, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"far fa-edit\" style=\"font-size: 20px; color: steelblue;\"></i>\r\n                    </a>\r\n                </button>\r\n                <button type=\"button\" class=\"btn btn-sm btn-primary-outline\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\'", 2029, "\'", 2098, 1);
#nullable restore
#line 59 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
WriteAttributeValue("", 2036, Url.Action("Delete", "ApplicationUser", new { id = item.Id }), 2036, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"far fa-trash-alt\" style=\"font-size: 20px; color: orangered;\"></i>\r\n                    </a>\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 65 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\ApplicationUser\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AspCoreUdemy.Core.Data.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
