#pragma checksum "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebd87f9cc59614ac07047f5c030bc22d25329b5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_ViewAll), @"mvc.1.0.view", @"/Views/Room/ViewAll.cshtml")]
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
#line 1 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\_ViewImports.cshtml"
using HotelManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\_ViewImports.cshtml"
using HotelManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebd87f9cc59614ac07047f5c030bc22d25329b5c", @"/Views/Room/ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b38080ad3dc6b6a015d86f98af6d0cb8ff65f4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Room_ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelManagementSystem.Data.Rooms.Room>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
  
    ViewData["Title"] = "ViewAll";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewAll</h1>\r\n\r\n<div class=\"alert-success\">");
#nullable restore
#line 9 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
                      Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"alert-danger\">");
#nullable restore
#line 10 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
                     Write(ViewBag.ErrorMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebd87f9cc59614ac07047f5c030bc22d25329b5c4596", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.MaxPersonAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoomNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoomFloor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoomType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaxPersonAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
               Write(Html.ActionLink("Edit", "UpdateCheck", new { number = item.RoomNumber }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 62 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { number = item.RoomNumber }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\user\Desktop\DotNet Core\DotNet Core Assignment\HotelManagementSystem\HotelManagementSystem\Views\Room\ViewAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelManagementSystem.Data.Rooms.Room>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
