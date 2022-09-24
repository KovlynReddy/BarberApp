#pragma checksum "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Bookings\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a000f881cff6d1e9b193d1ddd21e861849e01a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Create), @"mvc.1.0.view", @"/Views/Bookings/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a000f881cff6d1e9b193d1ddd21e861849e01a8", @"/Views/Bookings/Create.cshtml")]
    public class Views_Bookings_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BarberAppDLL.Models.DomainModel.Booking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Bookings\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Booking</h4>
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
                <label asp-for=""UserGuid"" class=""control-label""></label>
                <input asp-for=""UserGuid"" class=""form-control"" />
                <span asp-validation-for=""UserGuid"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Reason"" class=""control-label""></label>
                <input asp-for=""Reason"" class=""form-control"" />
                <span asp-validation-for=""Reason"" class=""text-danger""></s");
            WriteLiteral(@"pan>
            </div>
            <div class=""form-group"">
                <label asp-for=""Rating"" class=""control-label""></label>
                <input asp-for=""Rating"" class=""form-control"" />
                <span asp-validation-for=""Rating"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""BookingTime"" class=""control-label""></label>
                <input asp-for=""BookingTime"" class=""form-control"" />
                <span asp-validation-for=""BookingTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ArriveTime"" class=""control-label""></label>
                <input asp-for=""");
            WriteLiteral(@"ArriveTime"" class=""form-control"" />
                <span asp-validation-for=""ArriveTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CompletionTime"" class=""control-label""></label>
                <input asp-for=""CompletionTime"" class=""form-control"" />
                <span asp-validation-for=""CompletionTime"" class=""text-danger""></span>
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
            <div cla");
            WriteLiteral(@"ss=""form-group"">
                <label asp-for=""CreatedDateTime"" class=""control-label""></label>
                <input asp-for=""CreatedDateTime"" class=""form-control"" />
                <span asp-validation-for=""CreatedDateTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
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
                <input");
            WriteLiteral(@" asp-for=""CreatorId"" class=""form-control"" />
                <span asp-validation-for=""CreatorId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 97 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberAPI\Views\Bookings\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BarberAppDLL.Models.DomainModel.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
