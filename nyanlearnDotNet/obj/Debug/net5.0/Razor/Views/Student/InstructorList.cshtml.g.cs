#pragma checksum "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b82782e2d95810d47e94c903bd8163781d3f6276"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_InstructorList), @"mvc.1.0.view", @"/Views/Student/InstructorList.cshtml")]
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
#line 1 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\_ViewImports.cshtml"
using nyanlearnDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\_ViewImports.cshtml"
using nyanlearnDotNet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\_ViewImports.cshtml"
using nyanlearnDotNet.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b82782e2d95810d47e94c903bd8163781d3f6276", @"/Views/Student/InstructorList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68331feb9ccebe2bda8b4672fe66e6af3d48ef0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_InstructorList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<InstructorViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"content-wrapper\">\r\n");
            WriteLiteral("\r\n        <h1>Teacher List</h1>\r\n\r\n");
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <td>Name</td>
                <td>Email</td>
                <td>Father Name</td>
                <td>NRC</td>
                <td>DOB</td>
                <td>Address</td>
                <td>Position</td>
                <td>Phone</td>

                <td>Action</td>
                <td></td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
             foreach (var t in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
               Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
               Write(t.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
               Write(t.FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
               Write(t.NRC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
               Write(t.DOB.ToString("yyyy-MM--dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
               Write(t.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
               Write(t.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
               Write(t.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1030, "\"", 1057, 2);
            WriteAttributeValue("", 1037, "/Admin/Edit?Id=", 1037, 15, true);
#nullable restore
#line 36 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
WriteAttributeValue("", 1052, t.Id, 1052, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" role=\"button\">Edit</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1134, "\"", 1163, 2);
            WriteAttributeValue("", 1141, "/Admin/Delete?Id=", 1141, 17, true);
#nullable restore
#line 37 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
WriteAttributeValue("", 1158, t.Id, 1158, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" onclick=\"return confirm(\'Are you sure to delete this record?\')\">Delete</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\InstructorList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<InstructorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
