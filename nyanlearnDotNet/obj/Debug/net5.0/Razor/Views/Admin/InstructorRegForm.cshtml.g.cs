#pragma checksum "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\InstructorRegForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fafd1f03ac94550181b79055ff8f86c047f1d223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_InstructorRegForm), @"mvc.1.0.view", @"/Views/Admin/InstructorRegForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fafd1f03ac94550181b79055ff8f86c047f1d223", @"/Views/Admin/InstructorRegForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68331feb9ccebe2bda8b4672fe66e6af3d48ef0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_InstructorRegForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<NRCViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/AddInstructor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"content-wrapper\">\r\n");
#nullable restore
#line 3 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\InstructorRegForm.cshtml"
      
        string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(Model);
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"teacherForm\" style=\"width: 70%; margin:auto; padding:5% 0%;\">\r\n        <h1>Instructor Registration Form</h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fafd1f03ac94550181b79055ff8f86c047f1d2234881", async() => {
                WriteLiteral(@"


            <div class=""mb-3 teacher-inputs"">
                <label class=""form-label"">Name</label>
                <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Teacher Name"" required>
            </div>

            <div class=""mb-3 teacher-inputs"">
                <label class=""form-label"">Email</label>
                <input type=""email"" class=""form-control"" name=""Email"" placeholder=""Teacher Email"">
            </div>

            <div class=""mb-3 teacher-inputs"">
                <label class=""form-label"">Password</label>
                <input type=""password"" class=""form-control"" name=""Password"" placeholder=""Teacher Password"">
            </div>

            <div class=""mb-3 teacher-inputs"">
                <label class=""form-label"">DOB</label>
                <input type=""date"" class=""form-control"" name=""DOB"" required>
            </div>

            <div class=""mb-3 teacher-inputs"">
                <label class=""form-label"">Father Name</label>
           ");
                WriteLiteral(@"     <input type=""text"" class=""form-control"" name=""FatherName"" required>
            </div>

            <div class=""mb-3 teacher-inputs"">
                <label class=""form-label"">National Register of Citizens(NRC)</label>
                <input type=""text"" class=""form-control"" name=""NRC"" placeholder=""Teacher NRC"" required>
            </div>

            <div class=""mb-3 teacher-inputs"">
                <label class=""form-label"">Position</label>
                <select class=""form-control"" name=""Position"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fafd1f03ac94550181b79055ff8f86c047f1d2236817", async() => {
                    WriteLiteral("Senior");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fafd1f03ac94550181b79055ff8f86c047f1d2237851", async() => {
                    WriteLiteral("Junior");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>

            <div id=""address_form"">

                <div class=""teacher-inputs"">
                    <label class=""form-label"">NRC Code</label>
                    <select class=""form-control"" name=""nrc_code"" id=""nrc_code_dd"">
                    </select>
                </div>


                <div class=""teacher-inputs"">
                    <label class=""form-label"">Name(EN)</label>
                    <select class=""form-control"" name=""name_en"" id=""name_en_dd"">
                    </select>
                </div>

            </div>

            <div class=""mb-3 teacher-inputs"">
                <label class=""form-label"">Address</label>
                <textarea name=""Address"" class=""form-control""></textarea>
            </div>

            <div class=""mb-3 teacher-inputs"">
                <label class=""form-label"">Phone</label>
                <input type=""text"" class=""form-control"" name=""Phone"" placeholder=""Teacher Phone"" requir");
                WriteLiteral(@"ed>
            </div>


            <div class=""mb-3 teacher-inputs"">
                <div class=""row"">
                    <div class=""col"">
                        <input type=""submit"" class=""btn btn-success"" value=""Entry"" />
                    </div>
                    <div class=""col"">
                        <input type=""reset"" class=""btn btn-secondary"" value=""Cancel"" />
                    </div>
                </div>
            </div>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<script>\r\n    var data = ");
#nullable restore
#line 91 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Admin\InstructorRegForm.cshtml"
          Write(Html.Raw(jsonData));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    let nrc_code_dd = document.getElementById(""nrc_code_dd"");
    let name_en_dd = document.getElementById(""name_en_dd"");
    nrc_code_dd.innerHTML = ""<option></option>"";
    for (let i = 1; i <= 14; i++) {
        nrc_code_dd.innerHTML += `<option value=""${i}"">${i}</option>`;
    }


    nrc_code_dd.addEventListener(""change"", (event) => {
        clickedNRCode(event.target.value);
    });


    function clickedNRCode(code) {
        name_en_dd.innerHTML = """";
        let temp = data.filter((d) => d.nrc_code === parseInt(code)).sort();
        console.log(temp);
        for (let i = 0; i < temp.length; i++) {
            name_en_dd.innerHTML += `<option value=""${temp[i].name_en}"">${temp[i].name_en}</option>`;
        }

    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<NRCViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
