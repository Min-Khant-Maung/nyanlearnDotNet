#pragma checksum "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf9dba317e6b0a04d71a96187b859ac136fba342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_CourseLessonLearn), @"mvc.1.0.view", @"/Views/Student/CourseLessonLearn.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9dba317e6b0a04d71a96187b859ac136fba342", @"/Views/Student/CourseLessonLearn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68331feb9ccebe2bda8b4672fe66e6af3d48ef0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_CourseLessonLearn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LessonViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"content-wrapper\">\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
      
        var linkRegex = new Regex(@"^(http|https|ftp)://.*$");
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div style=\"padding:3%\">\r\n     <h1 style=\"margin-bottom: 50px;\">");
#nullable restore
#line 11 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1> \r\n     <div>");
#nullable restore
#line 12 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
     Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n     <div style=\"width:60%\">\r\n");
#nullable restore
#line 15 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
                             if (Model.FilePath != null && linkRegex.IsMatch(Model.FilePath))
                    {
                       
                         if (Regex.IsMatch(Model.FilePath, @"\.(jpg|jpeg|png|gif)$", RegexOptions.IgnoreCase))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 668, "\"", 689, 1);
#nullable restore
#line 20 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
WriteAttributeValue("", 674, Model.FilePath, 674, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n");
#nullable restore
#line 21 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <iframe class=\"embed-responsive-item\"");
            BeginWriteAttribute("src", " src=\"", 875, "\"", 896, 1);
#nullable restore
#line 24 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
WriteAttributeValue("", 881, Model.FilePath, 881, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" allowfullscreen></iframe>\r\n");
#nullable restore
#line 25 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
                        }

                    }
                    else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
                          if (Model.FilePath != null && !linkRegex.IsMatch(Model.FilePath))
                    {
                        if (Regex.IsMatch(Model.FilePath, @"\.(mp4|avi|mov|wmv|flv|mkv)$", RegexOptions.IgnoreCase))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <video controls class=\"embed-responsive-item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bf9dba317e6b0a04d71a96187b859ac136fba3428083", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1359, "~/uploads/lesson/", 1359, 17, true);
#nullable restore
#line 33 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
AddHtmlAttributeValue("", 1376, Model.FilePath, 1376, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </video>\r\n");
#nullable restore
#line 35 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
                        }
                        else if (Regex.IsMatch(Model.FilePath, @"\.(jpg|jpeg|png|gif)$", RegexOptions.IgnoreCase))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bf9dba317e6b0a04d71a96187b859ac136fba34210067", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1641, "~/uploads/lesson/", 1641, 17, true);
#nullable restore
#line 38 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
AddHtmlAttributeValue("", 1658, Model.FilePath, 1658, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </div>\r\n    \r\n    \r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1789, "\"", 1842, 2);
            WriteAttributeValue("", 1796, "/Student/Course/Lesson/Quiz?lessonid=", 1796, 37, true);
#nullable restore
#line 44 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\CourseLessonLearn.cshtml"
WriteAttributeValue("", 1833, Model.Id, 1833, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Take Quiz</a>\r\n\r\n\r\n   </div>\r\n            \r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LessonViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591