#pragma checksum "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0de9d5b1059916166ce74889a041092a75a3926"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0de9d5b1059916166ce74889a041092a75a3926", @"/Views/Customers/Index.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BarberAppDLL.Models.DomainModel.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModelGUID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeletedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompletedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModelGUID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeletedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompletedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1640, "\"", 1663, 1);
#nullable restore
#line 58 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1655, item.Id, 1655, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1716, "\"", 1739, 1);
#nullable restore
#line 59 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1731, item.Id, 1731, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1794, "\"", 1817, 1);
#nullable restore
#line 60 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1809, item.Id, 1809, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Customers\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BarberAppDLL.Models.DomainModel.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591