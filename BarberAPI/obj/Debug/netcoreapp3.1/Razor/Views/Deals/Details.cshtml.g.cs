#pragma checksum "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6273f0d692bb2963c0176751d867fd36832ce60f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deals_Details), @"mvc.1.0.view", @"/Views/Deals/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6273f0d692bb2963c0176751d867fd36832ce60f", @"/Views/Deals/Details.cshtml")]
    public class Views_Deals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BarberAppDLL.Models.DomainModel.Deal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Deal</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BarberGuid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.BarberGuid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Percentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Percentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModelGUID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModelGUID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeletedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeletedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompletedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompletedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3023, "\"", 3047, 1);
#nullable restore
#line 94 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Details.cshtml"
WriteAttributeValue("", 3038, Model.Id, 3038, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BarberAppDLL.Models.DomainModel.Deal> Html { get; private set; }
    }
}
#pragma warning restore 1591
