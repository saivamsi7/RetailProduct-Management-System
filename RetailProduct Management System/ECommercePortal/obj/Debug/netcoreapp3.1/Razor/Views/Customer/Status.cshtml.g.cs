#pragma checksum "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\Customer\Status.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f39812017dd021f22d221a6cd0e238aab12e78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Status), @"mvc.1.0.view", @"/Views/Customer/Status.cshtml")]
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
#line 1 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\_ViewImports.cshtml"
using ECommercePortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\_ViewImports.cshtml"
using ECommercePortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f39812017dd021f22d221a6cd0e238aab12e78", @"/Views/Customer/Status.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fde9f79e8837843a935f8519e8c368b45ccc36c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Status : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommercePortal.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/TableStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProductToCart1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\Customer\Status.cshtml"
  
    ViewData["Title"] = "Status";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f8f39812017dd021f22d221a6cd0e238aab12e784885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h2>Product Detail</h2>\r\n<br />\r\n\r\n<table>\r\n    <tr>\r\n        <th>\r\n            Product ID\r\n        </th>\r\n        <td>\r\n            ");
#nullable restore
#line 17 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\Customer\Status.cshtml"
       Write(Html.DisplayFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>\r\n            Product Name\r\n        </th>\r\n        <td>\r\n            ");
#nullable restore
#line 25 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\Customer\Status.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>\r\n            Product Description\r\n        </th>\r\n        <td>\r\n            ");
#nullable restore
#line 33 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\Customer\Status.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>\r\n            Image Name\r\n        </th>\r\n        <td>\r\n            ");
#nullable restore
#line 41 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\Customer\Status.cshtml"
       Write(Html.DisplayFor(model => model.ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>\r\n            Price\r\n        </th>\r\n        <td>\r\n            ");
#nullable restore
#line 49 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\Customer\Status.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>\r\n            Product Rating\r\n        </th>\r\n        <td>\r\n            ");
#nullable restore
#line 57 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\Customer\Status.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n<br />\r\n");
            WriteLiteral("\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f39812017dd021f22d221a6cd0e238aab12e788526", async() => {
                WriteLiteral("Add To Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "E:\My Documents\Cogni\MFPE\RetailProductManagement\ECommercePortal\Views\Customer\Status.cshtml"
                                               WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f39812017dd021f22d221a6cd0e238aab12e7810773", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp   &nbsp\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommercePortal.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
