#pragma checksum "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Areas\Identity\Pages\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "372c2e3ce51aacc6e867cfbea3c4a7d1e28ce6c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__ViewStart), @"mvc.1.0.view", @"/Areas/Identity/Pages/_ViewStart.cshtml")]
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
#line 1 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Areas\Identity\Pages\_ViewImports.cshtml"
using nyanlearnDotNet.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Areas\Identity\Pages\_ViewImports.cshtml"
using nyanlearnDotNet.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"372c2e3ce51aacc6e867cfbea3c4a7d1e28ce6c5", @"/Areas/Identity/Pages/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca3c128b626299ddc555480e904bbb2f1a55cf7", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Areas\Identity\Pages\_ViewStart.cshtml"
   if (User.IsInRole("admin"))
    {
        Layout = "/Views/Shared/_LayoutAdmin.cshtml";
    }
    else if (User.IsInRole("instructor"))
    { 
    Layout = "/Views/Shared/_LayoutAdmin.cshtml";
    }
    else
    {
    Layout = "/Views/Shared/_Layout.cshtml";
    }
    

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
