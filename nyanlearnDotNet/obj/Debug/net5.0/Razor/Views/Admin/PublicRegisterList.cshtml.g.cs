#pragma checksum "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55c553ee296ba49e92ff6abf15fc0702825ff8ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PublicRegisterList), @"mvc.1.0.view", @"/Views/Admin/PublicRegisterList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c553ee296ba49e92ff6abf15fc0702825ff8ba", @"/Views/Admin/PublicRegisterList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68331feb9ccebe2bda8b4672fe66e6af3d48ef0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_PublicRegisterList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<PublicRegisterViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"content-wrapper\">\r\n");
            WriteLiteral("\r\n        <h1>Public Register List</h1>\r\n\r\n");
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <td>Name</td>
                <td>Email</td>
                <td>Father Name</td>
                <td>NRC</td>
                <td>DOB</td>
                <td>Address</td>
                <td>Phone</td>

                <td>Action</td>
                <td></td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
             foreach (var t in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
               Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
               Write(t.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
               Write(t.FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
               Write(t.NRC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
               Write(t.DOB.ToString("yyyy-MM--dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
               Write(t.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
               Write(t.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 969, "\"", 1009, 2);
            WriteAttributeValue("", 976, "/Admin/BanPublicRegister?Id=", 976, 28, true);
#nullable restore
#line 34 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
WriteAttributeValue("", 1004, t.Id, 1004, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" role=\"button\">Ban</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1128, 2);
            WriteAttributeValue("", 1091, "/Admin/ApprovePublicRegister?Id=", 1091, 32, true);
#nullable restore
#line 35 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
WriteAttributeValue("", 1123, t.Id, 1123, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" onclick=\"return confirm(\'Are you sure to delete this record?\')\">Approve</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\PublicRegisterList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<PublicRegisterViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591