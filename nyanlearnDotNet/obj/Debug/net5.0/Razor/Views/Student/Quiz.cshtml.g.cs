#pragma checksum "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11dd9f10e4297d54849171202e2cd2f4be3d6b66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Quiz), @"mvc.1.0.view", @"/Views/Student/Quiz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11dd9f10e4297d54849171202e2cd2f4be3d6b66", @"/Views/Student/Quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68331feb9ccebe2bda8b4672fe66e6af3d48ef0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Quiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<AnswerQuizViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"content-wrapper\">\r\n");
#nullable restore
#line 3 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
      
        var lessonId = @TempData["lessonId"];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>List All Courses</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
          for (int i = 0; i < Model.Count; i++)
        {          

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"quizQuestion\" style=\"margin: 30px;\">\r\n                     <input type=\"hidden\" name=\"QuizId\"");
            BeginWriteAttribute("value", " value=\"", 357, "\"", 377, 1);
#nullable restore
#line 13 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 365, Model[i].Id, 365, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div style=\"display: flex;  justify-content: space-between;\">\r\n                        <div style=\"margin-left:2%\">");
#nullable restore
#line 15 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
                                               Write(Html.Raw(@Model[i].Question));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <p style=\"border:1px solid rgb(55, 166, 206);padding:2px;border-radius:3px\">1 point</p>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 720, "\"", 725, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                        <ol>\r\n                            <li>\r\n                                <div class=\"form-check\">\r\n                            <input class=\"form-check-input\" type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 927, "\"", 953, 2);
            WriteAttributeValue("", 932, "flexRadioDefault_", 932, 17, true);
#nullable restore
#line 24 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 949, i_1, 949, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"SelectedOption\" value=\"Option1\">\r\n                            <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 1054, "\"", 1081, 2);
            WriteAttributeValue("", 1060, "flexRadioDefault_", 1060, 17, true);
#nullable restore
#line 25 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 1077, i_1, 1077, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 26 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
                           Write(Model[i].Option1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </label>
                                </div>
                            </li>


                            <li>
                                                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""SelectedOption""");
            BeginWriteAttribute("id", " id=\"", 1463, "\"", 1489, 2);
            WriteAttributeValue("", 1468, "flexRadioDefault_", 1468, 17, true);
#nullable restore
#line 34 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 1485, i_2, 1485, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Option2\">\r\n                            <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 1568, "\"", 1595, 2);
            WriteAttributeValue("", 1574, "flexRadioDefault_", 1574, 17, true);
#nullable restore
#line 35 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 1591, i_2, 1591, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                 ");
#nullable restore
#line 36 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
                            Write(Model[i].Option2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </label>
                        </div>
                            </li>


                            <li>
                                 <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""SelectedOption""");
            BeginWriteAttribute("id", " id=\"", 1947, "\"", 1973, 2);
            WriteAttributeValue("", 1952, "flexRadioDefault_", 1952, 17, true);
#nullable restore
#line 44 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 1969, i_3, 1969, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Option3\">\r\n                            <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 2052, "\"", 2079, 2);
            WriteAttributeValue("", 2058, "flexRadioDefault_", 2058, 17, true);
#nullable restore
#line 45 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 2075, i_3, 2075, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                 ");
#nullable restore
#line 46 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
                            Write(Model[i].Option3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </label>
                        </div>
                            </li>


                            <li>

                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""SelectedOption""");
            BeginWriteAttribute("id", " id=\"", 2424, "\"", 2450, 2);
            WriteAttributeValue("", 2429, "flexRadioDefault_", 2429, 17, true);
#nullable restore
#line 55 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 2446, i_4, 2446, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Option4\">\r\n                            <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 2529, "\"", 2556, 2);
            WriteAttributeValue("", 2535, "flexRadioDefault_", 2535, 17, true);
#nullable restore
#line 56 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 2552, i_4, 2552, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                 ");
#nullable restore
#line 57 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
                            Write(Model[i].Option4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n                        </div>\r\n                            </li>\r\n                        </ol>\r\n\r\n\r\n\r\n\r\n                       \r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 72 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n     <a");
            BeginWriteAttribute("href", " href=\"", 2867, "\"", 2927, 2);
            WriteAttributeValue("", 2874, "/Student/Course/Lesson/Quiz/Result?lessonid=", 2874, 44, true);
#nullable restore
#line 76 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Quiz.cshtml"
WriteAttributeValue("", 2918, lessonId, 2918, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Take Quiz</a>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<AnswerQuizViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591