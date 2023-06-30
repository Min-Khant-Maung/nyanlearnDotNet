using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nyanlearnDotNet.Models;
using nyanlearnDotNet.Models.DAO;
using nyanlearnDotNet.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace nyanlearnDotNet.Controllers
{

    [Authorize]
    public class InstructorController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<InstructorController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<IdentityUser> _usermanager;

        private  string CurrentUserId;
        private  string CurrentInstructorId;

        public InstructorController(IWebHostEnvironment webHostEnvironment,ILogger<InstructorController>logger, ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager)
        {
                _applicationDbContext = applicationDbContext;
                _usermanager = userManager;
                _webHostEnvironment = webHostEnvironment;
                _logger = logger;
        }





        [Authorize(Roles = "instructor")]
        public IActionResult Index()
        {
            return View("~/Views/Instructor/Index.cshtml");
        }



[Authorize(Roles = "instructor")]
        public IActionResult AddCourse()
        {
            return View("~/Views/Instructor/AddCourse.cshtml");
        }
        

        [Authorize(Roles = "instructor")]
        public IActionResult ListCourses()
        {

                        CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
                var instructor = _applicationDbContext.Instructors.FirstOrDefault(i => i.UserId == CurrentUserId);
                CurrentInstructorId = instructor.Id;
        IList<String> courseIds=null;
        IList<CourseViewModel> courses=null;
            courseIds = _applicationDbContext.CourseInstructors
                        .Where(ci => ci.InstructorId == CurrentInstructorId)
                        .Select(ci => ci.CourseId)
                        .ToList();

            courses = _applicationDbContext.Courses
                        .Where(c => courseIds.Contains(c.Id))
                        .Select(course => new CourseViewModel { 
                        Name = course.Name,
                        Description = course.Description
                        })
                        .ToList();






            return View("~/Views/Instructor/ListCourses.cshtml",courses);
        }




[Authorize(Roles = "instructor")]
        [HttpPost]
        public IActionResult AddCourse(CourseViewModel courseViewModel)
        {

                            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
                var instructor = _applicationDbContext.Instructors.FirstOrDefault(i => i.UserId == CurrentUserId);
                CurrentInstructorId = instructor.Id;
            Course course = new Course();
            //audit columns
            var generatedCourseId = Guid.NewGuid().ToString();
            course.Id = generatedCourseId;
            course.CreatedDate = DateTime.Now;
            course.Name = courseViewModel.Name;
            course.Description = courseViewModel.Description;


            CourseInstructor courseInstructor = new CourseInstructor();
            courseInstructor.Id = Guid.NewGuid().ToString();
            courseInstructor.CourseId = generatedCourseId;
            courseInstructor.CreatedDate = DateTime.Now;

            // hard code for instructor( mr kyaing )
            courseInstructor.InstructorId = CurrentInstructorId;

            //Adding the record Students DBSet
            _applicationDbContext.Courses.Add(course);
            _applicationDbContext.CourseInstructors.Add(courseInstructor);

            _applicationDbContext.SaveChanges();//saving the record to the database
            return RedirectToAction("Index");
        }
        //       public IActionResult UploadSuccess()
        //     {
        //         return View();
        //     }


        // [HttpPost]
        // public IActionResult Index(IFormFile videoFile)
        // {
        //     if (videoFile != null && videoFile.Length > 0)
        //     {
        //         // Perform any necessary validation on the file (e.g., size, type)

        //         // Save the file to a desired location
        //         // string filePath = Path.Combine("/", );
        //          string projectRootPath = _webHostEnvironment.ContentRootPath;
        //         _logger.LogInformation(projectRootPath);
        //         using (var fileStream = new FileStream(projectRootPath + "/ "+videoFile.FileName, FileMode.Create))
        //         {
        //             videoFile.CopyTo(fileStream);
        //         }

        //         // Additional processing or redirect to a success page
        //         return RedirectToAction("UploadSuccess");
        //     }

        //     // If no file is uploaded or an error occurs, display an error message
        //     ModelState.AddModelError("", "Please choose a video file to upload.");
        //     return RedirectToAction("Index");
        // }
    }
}