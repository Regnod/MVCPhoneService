#pragma checksum "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae14986444753f94bccfe0a8febdd07fc7d8b982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserExceededDataPlans_Index), @"mvc.1.0.view", @"/Views/UserExceededDataPlans/Index.cshtml")]
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
#line 1 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/_ViewImports.cshtml"
using MVCPhoneServiceWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae14986444753f94bccfe0a8febdd07fc7d8b982", @"/Views/UserExceededDataPlans/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b079a1b91f763a65c62bc3475ec22a4692397af7", @"/Views/_ViewImports.cshtml")]
    public class Views_UserExceededDataPlans_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.ViewModels.UserExceededDataPlan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Users who have exceeded calling plans</h1>
<div class=""row"">
        <div class=""form-group"">
            <input type=""text"" name=""month""/>month
            
            <input type=""text"" name=""year""/> Year
        </div>
    <div>
        <input type=""submit"" value=""Index"" class=""btn btn-primary""/>
    </div>
</div>
<table class=""table"">
    <thead>
    <tr>
        <th>
            ");
#nullable restore
#line 25 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 28 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 31 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 34 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.DataPlanId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 37 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.CostCenter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 40 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.NationalDataExceeded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 43 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.InternationalDataExceeded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th></th>\n    </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 49 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 53 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 59 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 62 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataPlanId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 65 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CostCenter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 68 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NationalDataExceeded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 71 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InternationalDataExceeded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n");
            WriteLiteral("        </tr>\n");
#nullable restore
#line 79 "/mnt/69F79531507E7A36/CS/MyStuff/Base de Datos II/Proyecto/MVCPhoneService/MVCPhoneServiceWeb/Views/UserExceededDataPlans/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.ViewModels.UserExceededDataPlan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
