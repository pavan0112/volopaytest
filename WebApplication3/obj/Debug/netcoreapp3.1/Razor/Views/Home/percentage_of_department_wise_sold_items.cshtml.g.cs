#pragma checksum "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\Home\percentage_of_department_wise_sold_items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4557d7c21ff8cd7d0bf36be32facdcd1527487f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_percentage_of_department_wise_sold_items), @"mvc.1.0.view", @"/Views/Home/percentage_of_department_wise_sold_items.cshtml")]
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
#line 1 "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4557d7c21ff8cd7d0bf36be32facdcd1527487f", @"/Views/Home/percentage_of_department_wise_sold_items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_percentage_of_department_wise_sold_items : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Modelclasses.perc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\Home\percentage_of_department_wise_sold_items.cshtml"
   
    int r = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <thead>\r\n        <tr>\r\n            <td>index</td>\r\n            <td>department</td>\r\n            <td>seats</td>\r\n            <td>percentage</td>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 14 "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\Home\percentage_of_department_wise_sold_items.cshtml"
     foreach (var t in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\Home\percentage_of_department_wise_sold_items.cshtml"
            Write(r++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\Home\percentage_of_department_wise_sold_items.cshtml"
           Write(t.department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>  </td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\Home\percentage_of_department_wise_sold_items.cshtml"
           Write(t.seats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\Home\percentage_of_department_wise_sold_items.cshtml"
           Write(t.percentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\pavan\source\repos\WebApplication3\WebApplication3\Views\Home\percentage_of_department_wise_sold_items.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.Modelclasses.perc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
