#pragma checksum "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b9947852108ad6bddc92ae05c3c0675fa1556d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Result), @"mvc.1.0.view", @"/Views/Student/Result.cshtml")]
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
#line 1 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Result.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b9947852108ad6bddc92ae05c3c0675fa1556d2", @"/Views/Student/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68331feb9ccebe2bda8b4672fe66e6af3d48ef0b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Result.cshtml"
  
            var courseresults = TempData["courseResults"];
            var lessonresults = TempData["lessonResults"];
            var percentages = TempData["percentages"];
            // Configure the JSON serializer settings
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

// Serialize the course results using the configured JSON serializer settings
            string CourseResults = Newtonsoft.Json.JsonConvert.SerializeObject(courseresults,jsonSerializerSettings);
            string LessonResults = Newtonsoft.Json.JsonConvert.SerializeObject(lessonresults,jsonSerializerSettings);
            string Percentages = Newtonsoft.Json.JsonConvert.SerializeObject(percentages,jsonSerializerSettings);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-wrapper\">\r\n\r\n    <div id=\"accordion\">\r\n");
            WriteLiteral("      </div>\r\n</div>\r\n\r\n<script>\r\n    let courseResults = ");
#nullable restore
#line 85 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Result.cshtml"
                   Write(Html.Raw(CourseResults));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    let lessonResults = ");
#nullable restore
#line 86 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Result.cshtml"
                   Write(Html.Raw(LessonResults));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    let percentages = ");
#nullable restore
#line 87 "C:\Users\Min Khant Maung\source\repos\nyanlearnDotNet\nyanlearnDotNet\Views\Student\Result.cshtml"
                 Write(Html.Raw(Percentages));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";



    let accordion     = document.getElementById(""accordion"");

        
if(courseResults && lessonResults)
{
    for (let index = 0; index < courseResults.length; index++) {
        const element           = courseResults[index];
        const courseName        = element.Course.Name;
        const courseId        = element.Course.Id;
        const enrolledDate      = element.Course.CreatedDate;
        const instructorName    = element.Instructor.Name;
        const courseResult      = element.ResultPercentage; 

        const numOfLessons        = percentages.filter(p=>p.CourseId===courseId)[0].numOfLessons;
        
        let str                 = `<div class=""card"">
        <div class=""card-header"" id=""heading${index}"">
          <h5 class=""mb-0"">
    
              
                              
              <div class=""d-flex justify-content-between"">
                  
                  <div>
                      <h5>Course : ${courseName}</h5>
                  </");
            WriteLiteral(@"div>
    
                  <div>
                      <h5>Instructor : ${instructorName}</h5>
                  </div>
    
                  <div>
                      <h5>Enrolled Date : ${enrolledDate.split(""T"")[0]}</h5>
                  </div>
    
                  <div>
                      <h5>Course Result : ${(courseResult/numOfLessons).toFixed(2)} %</h5>
                  </div>
    
                  <div>
                      <input type=""text"" class=""course${index}Id""  hidden>
                      <h5 class=""expandables"" data=""${courseId}"" index=""${index}"" data-toggle=""collapse"" data-target=""#collapse${index}"" aria-expanded=""true"" aria-controls=""collapse${index}"" onClick=""showLessonResult(event)"">Lesson Results</h5>
                  </div>
    
              </div>
           
          </h5>
        </div>
    
        <div id=""collapse${index}"" class=""collapse show"" aria-labelledby=""heading${index}"" data-parent=""#accordion"">
          <div class=""card-body"">
  ");
            WriteLiteral(@"  
    

    
              
    
    
          </div>
        </div>
      </div>`

      accordion.innerHTML += str;
    }
}

function showLessonResult(e) 
{
    
    let uniqueCourseId = e.target.getAttribute(""data"");
    let currentIndex = e.target.getAttribute(""index"");
    let relatedLessons = lessonResults.filter((l)=>l.Lesson.CourseId===uniqueCourseId);
    let currentCardBody       = document.getElementsByClassName(""card-body"")[currentIndex];
    currentCardBody.innerHTML = """";
    for (let index = 0; index < relatedLessons.length; index++) {
        const element = relatedLessons[index];
        currentCardBody.innerHTML+= `
        <div class=""d-flex justify-content-between"">
                  
<div>
    <h5>Lesson : ${element.Lesson.Name}</h5>
</div>

<div>
    <h5>Answerd Date : ${element.CreatedDate.split(""T"")[0]}</h5>
</div>

<div>
    <h5>Result : ${(element.ResultPercentage).toFixed(2)} %</h5>
</div>

</div>
        `;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
