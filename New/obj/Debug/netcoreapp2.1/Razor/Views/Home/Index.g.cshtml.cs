#pragma checksum "E:\New\New\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55028d59373cc1d84ea4e9553266b795d0757d9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\New\New\Views\_ViewImports.cshtml"
using New;

#line default
#line hidden
#line 2 "E:\New\New\Views\_ViewImports.cshtml"
using New.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55028d59373cc1d84ea4e9553266b795d0757d9c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba3e2599a2d6344fe25b68d3144d692246d03a3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "E:\New\New\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(72, 388, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Customer Details</p>
</div>

<h2>Customer</h2>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <td>CustonerID</td>
            <td>Name</td>
            <td>CustonerCode</td>
            <td>Address</td>
            <td>Edit</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 26 "E:\New\New\Views\Home\Index.cshtml"
         foreach (var cust in Model)
        {

#line default
#line hidden
            BeginContext(509, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(548, 15, false);
#line 29 "E:\New\New\Views\Home\Index.cshtml"
               Write(cust.customerID);

#line default
#line hidden
            EndContext();
            BeginContext(563, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(591, 9, false);
#line 30 "E:\New\New\Views\Home\Index.cshtml"
               Write(cust.name);

#line default
#line hidden
            EndContext();
            BeginContext(600, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(628, 9, false);
#line 31 "E:\New\New\Views\Home\Index.cshtml"
               Write(cust.code);

#line default
#line hidden
            EndContext();
            BeginContext(637, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(665, 12, false);
#line 32 "E:\New\New\Views\Home\Index.cshtml"
               Write(cust.address);

#line default
#line hidden
            EndContext();
            BeginContext(677, 186, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <!--<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal2\">Edit</button>-->\r\n                    ");
            EndContext();
            BeginContext(864, 97, false);
#line 35 "E:\New\New\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = cust.customerID }, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(961, 147, true);
            WriteLiteral("\r\n                    <!-- <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"\">Delete</button>-->\r\n                    ");
            EndContext();
            BeginContext(1109, 100, false);
#line 37 "E:\New\New\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = cust.customerID }, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "E:\New\New\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1264, 32, true);
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1297, 79, false);
#line 47 "E:\New\New\Views\Home\Index.cshtml"
Write(Html.ActionLink("AddCustomer", "AddCustomer", new {@class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
