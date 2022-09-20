#pragma checksum "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ed18d271c1dc3433a4b4a3e5237876aec9203af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deals_Create), @"mvc.1.0.view", @"/Views/Deals/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed18d271c1dc3433a4b4a3e5237876aec9203af", @"/Views/Deals/Create.cshtml")]
    public class Views_Deals_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BarberAppDLL.Models.DomainModel.Deal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Deal</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""BarberGuid"" class=""control-label""></label>
                <input asp-for=""BarberGuid"" class=""form-control"" />
                <span asp-validation-for=""BarberGuid"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StartDate"" class=""control-label""></label>
                <input asp-for=""StartDate"" class=""form-control"" />
                <span asp-validation-for=""StartDate"" class=""t");
            WriteLiteral(@"ext-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EndDate"" class=""control-label""></label>
                <input asp-for=""EndDate"" class=""form-control"" />
                <span asp-validation-for=""EndDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Reason"" class=""control-label""></label>
                <input asp-for=""Reason"" class=""form-control"" />
                <span asp-validation-for=""Reason"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Percentage"" class=""control-label""></label>
                <input asp-for=""Percentage"" class=""form-control"" />
                <span asp-validation-for=""Percentage"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Amount"" class=""control-label""></label>
                <input asp-for=""Amou");
            WriteLiteral(@"nt"" class=""form-control"" />
                <span asp-validation-for=""Amount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ModelGUID"" class=""control-label""></label>
                <input asp-for=""ModelGUID"" class=""form-control"" />
                <span asp-validation-for=""ModelGUID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IsDeleted"" class=""control-label""></label>
                <input asp-for=""IsDeleted"" class=""form-control"" />
                <span asp-validation-for=""IsDeleted"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedDateTime"" class=""control-label""></label>
                <input asp-for=""CreatedDateTime"" class=""form-control"" />
                <span asp-validation-for=""CreatedDateTime"" class=""text-danger""></span>
            </div>
            <div class=""form-");
            WriteLiteral(@"group"">
                <label asp-for=""DeletedDateTime"" class=""control-label""></label>
                <input asp-for=""DeletedDateTime"" class=""form-control"" />
                <span asp-validation-for=""DeletedDateTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CompletedDateTime"" class=""control-label""></label>
                <input asp-for=""CompletedDateTime"" class=""form-control"" />
                <span asp-validation-for=""CompletedDateTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatorId"" class=""control-label""></label>
                <input asp-for=""CreatorId"" class=""form-control"" />
                <span asp-validation-for=""CreatorId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </d");
            WriteLiteral("iv>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Deals\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BarberAppDLL.Models.DomainModel.Deal> Html { get; private set; }
    }
}
#pragma warning restore 1591
