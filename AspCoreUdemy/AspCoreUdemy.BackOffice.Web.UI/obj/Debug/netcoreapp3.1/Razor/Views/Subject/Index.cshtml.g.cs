#pragma checksum "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18fbff00379aa748baabab0199ec6612fc696b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subject_Index), @"mvc.1.0.view", @"/Views/Subject/Index.cshtml")]
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
#nullable restore
#line 7 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
using AspCoreUdemy.BackOffice.Web.UI.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18fbff00379aa748baabab0199ec6612fc696b6e", @"/Views/Subject/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0ee267fbc96d1b5f29f0ce5b714e8df68ddfc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AspCoreUdemy.Core.Data.Models.Subject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
  
    ViewData["Title"] = "Subjects";
    Layout = "~/Views/Shared/_Layout.cshtml";

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18fbff00379aa748baabab0199ec6612fc696b6e4512", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>Subjects</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18fbff00379aa748baabab0199ec6612fc696b6e5591", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-striped table-sm\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>");
#nullable restore
#line 27 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Exam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Exam.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            <td class=\"float-right\">\r\n                    <button type=\"button\" class=\"btn btn-warning btn-sm\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 1306, "\'", 1368, 1);
#nullable restore
#line 46 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
WriteAttributeValue("", 1313, Url.Action("Details", "Subject", new { id = item.Id }), 1313, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-info-circle-fill"" fill=""white"" xmlns=""http://www.w3.org/2000/svg"">
                                <path fill-rule=""evenodd"" d=""M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm.93-9.412l-2.29.287-.082.38.45.083c.294.07.352.176.288.469l-.738 3.468c-.194.897.105 1.319.808 1.319.545 0 1.178-.252 1.465-.598l.088-.416c-.2.176-.492.246-.686.246-.275 0-.375-.193-.304-.533L8.93 6.588zM8 5.5a1 1 0 1 0 0-2 1 1 0 0 0 0 2z"" />
                            </svg>
                        </a>
                    </button>
                    <button type=""button"" class=""btn btn-info btn-sm"">
                        <a");
            BeginWriteAttribute("href", " href=\'", 2067, "\'", 2126, 1);
#nullable restore
#line 53 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2074, Url.Action("Edit", "Subject", new { id = item.Id }), 2074, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-pencil-fill"" fill=""white"" xmlns=""http://www.w3.org/2000/svg"">
                                <path fill-rule=""evenodd"" d=""M12.854.146a.5.5 0 0 0-.707 0L10.5 1.793 14.207 5.5l1.647-1.646a.5.5 0 0 0 0-.708l-3-3zm.646 6.061L9.793 2.5 3.293 9H3.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.207l6.5-6.5zm-7.468 7.468A.5.5 0 0 1 6 13.5V13h-.5a.5.5 0 0 1-.5-.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.5-.5V10h-.5a.499.499 0 0 1-.175-.032l-.179.178a.5.5 0 0 0-.11.168l-2 5a.5.5 0 0 0 .65.65l5-2a.5.5 0 0 0 .168-.11l.178-.178z"" />
                            </svg>
                        </a>
                    </button>
                    <button type=""button"" class=""btn btn-danger btn-sm"">
                        <a");
            BeginWriteAttribute("href", " href=\'", 2986, "\'", 3047, 1);
#nullable restore
#line 60 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2993, Url.Action("Delete", "Subject", new { id = item.Id }), 2993, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-x-square-fill"" fill=""white"" xmlns=""http://www.w3.org/2000/svg"">
                                <path fill-rule=""evenodd"" d=""M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2zm3.354 4.646a.5.5 0 1 0-.708.708L7.293 8l-2.647 2.646a.5.5 0 0 0 .708.708L8 8.707l2.646 2.647a.5.5 0 0 0 .708-.708L8.707 8l2.647-2.646a.5.5 0 0 0-.708-.708L8 7.293 5.354 4.646z"" />
                            </svg>
                        </a>
                    </button>
                </td>
            </tr>
");
#nullable restore
#line 68 "C:\git\AspCore\AspCoreUdemy\AspCoreUdemy.BackOffice.Web.UI\Views\Subject\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>           ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AspCoreUdemy.Core.Data.Models.Subject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
