#pragma checksum "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Barber\_BarberView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d720bc77eadcd858af10fd86bc5b49a5f177fb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Barber__BarberView), @"mvc.1.0.view", @"/Views/Barber/_BarberView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d720bc77eadcd858af10fd86bc5b49a5f177fb0", @"/Views/Barber/_BarberView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31dacd10e601cc4500006addedc05b0dd15de824", @"/Views/_ViewImports.cshtml")]
    public class Views_Barber__BarberView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BarberAppDLL.Models.DomainModel.Barber>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/DefaultProfile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d720bc77eadcd858af10fd86bc5b49a5f177fb04320", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"card-body\">\r\n        <h3 class=\"card-title\">");
#nullable restore
#line 7 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Barber\_BarberView.cshtml"
                          Write(Model.BarberName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 8 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Barber\_BarberView.cshtml"
                          Write(Model.BarberEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n        <h6 class=\"card-title\">");
#nullable restore
#line 9 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Barber\_BarberView.cshtml"
                          Write(Model.AverageRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Barber\_BarberView.cshtml"
                          Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <p class=\"card-text\">");
#nullable restore
#line 11 "C:\Users\User\OneDrive\Documents\Projects\BarberApp\BarberWebApp\Views\Barber\_BarberView.cshtml"
                        Write(Model.ModelGUID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a href=\"#\" class=\"btn btn-primary\">Book</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BarberAppDLL.Models.DomainModel.Barber> Html { get; private set; }
    }
}
#pragma warning restore 1591