#pragma checksum "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Home\PublicRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4996dbce17c5acfaabe7ea04f996925651f2ba4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PublicRegister), @"mvc.1.0.view", @"/Views/Home/PublicRegister.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4996dbce17c5acfaabe7ea04f996925651f2ba4", @"/Views/Home/PublicRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68331feb9ccebe2bda8b4672fe66e6af3d48ef0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PublicRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/PublicRegister"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4996dbce17c5acfaabe7ea04f996925651f2ba44593", async() => {
                WriteLiteral(@"
    <h4>Create a new account.</h4>
    <hr />
    <div class=""text-danger""></div>
    <div class=""form-group"">
        <label>Name</label>
        <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Name"" required>
        <span class=""text-danger""></span>
    </div>
    <div class=""form-group"">
        <label>DOB</label>
        <input type=""date"" class=""form-control"" name=""DOB"" required>
        <span class=""text-danger""></span>
    </div>
    <div class=""form-group"">
        <label>Email</label>
        <input type=""email"" class=""form-control"" name=""Email"" placeholder=""Email"">
        <span class=""text-danger""></span>
    </div>
    <div class=""form-group"">
        <label>NRC</label>
        <input type=""text"" class=""form-control"" name=""NRC"" placeholder=""NRC"" required>
        <span class=""text-danger""></span>
    </div>
    <div class=""form-group"">
        <label>Address</label>
        <textarea name=""Address"" class=""form-control""></textarea>
        <span class=""");
                WriteLiteral(@"text-danger""></span>
    </div>
    <div class=""form-group"">
        <label>Phone</label>
        <input type=""text"" class=""form-control"" name=""Phone"" placeholder=""Phone"" required>
        <span class=""text-danger""></span>
    </div>
    <div class=""form-group"">
        <label>FatherName</label>
        <input type=""text"" class=""form-control"" name=""FatherName"" required>
        <span class=""text-danger""></span>
    </div>

    <div class=""form-group"">
        <div class=""input-group mb-3"" id=""imageUpload"">
            <input type=""file"" class=""form-control-file"" id=""Photo"" name=""Photo"">
        </div>
    </div>
    <hr />
    <button type=""submit"" class=""btn btn-primary"">Register</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
