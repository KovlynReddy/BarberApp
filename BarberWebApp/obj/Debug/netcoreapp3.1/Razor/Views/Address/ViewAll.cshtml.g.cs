#pragma checksum "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa92324d835fc75106a2849bc13fc3bb8789913"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_ViewAll), @"mvc.1.0.view", @"/Views/Address/ViewAll.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\_ViewImports.cshtml"
using BarberWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\_ViewImports.cshtml"
using BarberWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa92324d835fc75106a2849bc13fc3bb8789913", @"/Views/Address/ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31dacd10e601cc4500006addedc05b0dd15de824", @"/Views/_ViewImports.cshtml")]
    public class Views_Address_ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BarberAppDLL.Models.ViewModels.AddressViewModel>>
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
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa92324d835fc75106a2849bc13fc3bb87899133488", async() => {
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
#line 10 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.MainStreet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Suburb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.PostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.lon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Caption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.ModelGuid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.MainStreet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Suburb));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.lon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.Caption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModelGuid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 77 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 78 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Address\ViewAll.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BarberAppDLL.Models.ViewModels.AddressViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591