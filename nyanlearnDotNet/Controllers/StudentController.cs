using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using nyanlearnDotNet.Models;
using nyanlearnDotNet.Models.DAO;
using nyanlearnDotNet.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace nyanlearnDotNet.Controllers
{
    [Authorize]
    [Route("Student")]
    public class StudentController : Controller
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<IdentityUser> _usermanager;
        private readonly ILogger<StudentController> _logger;

        private  string CurrentUserId;
        private  string CurrentStudentId;

        public StudentController(ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager,ILogger<StudentController> logger)
        {
            _applicationDbContext = applicationDbContext;
            _usermanager = userManager;
            _logger = logger;
        }
        public IActionResult Index()
        {
             CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            _logger.LogInformation(student.ImagePath);
            ViewData["profileUrl"] = student.ImagePath;
            return View("~/Views/Student/Index.cshtml");
        }


        [Authorize(Roles = "student")]

        public IActionResult ListInstructors()
        {
            IList<InstructorViewModel> instructors = _applicationDbContext.Instructors.Select
                (t => new InstructorViewModel
                {
                    Name = t.Name,
                    Email = t.Email,
                    FatherName = t.FatherName,
                    Position = t.Position,
                    DOB = t.DOB,
                    NRC = t.NRC,
                    Address = t.Address,
                    Phone = t.Phone
                }).ToList();



            return View("~/Views/Student/InstructorList.cshtml", instructors);
        }


        [Authorize(Roles = "student")]
        [Route("Course/All")]
        public IActionResult ListAllCourses()
        {
            IList<CourseViewModel> courses = _applicationDbContext.Courses.Select
                (t => new CourseViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    ImagePath    = t.ImagePath
                }).ToList();



            return View("~/Views/Student/ListAllCourses.cshtml", courses);
        }




        [Authorize(Roles = "student")]
        [Route("Course/Enrolled")]
        public IActionResult EnrolledCourses()
        {
            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            CurrentStudentId = student.Id;


            IList<CourseViewModel> courses =  _applicationDbContext.Enrollments
            .Where(enrollment => enrollment.StudentId == CurrentStudentId)
            .Select(enrollment => new CourseViewModel
                {
                Id = enrollment.Course.Id,
                Name = enrollment.Course.Name,
                Description = enrollment.Course.Description,
                ImagePath   = enrollment.Course.ImagePath
                    }).ToList();




            return View("~/Views/Student/EnrolledCourses.cshtml", courses);
        }


        [Authorize(Roles = "student")]
        [Route("Course/Enroll")]
        public IActionResult EnrollCourse(string courseId)
        {   
            
            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            CurrentStudentId = student.Id;

            Enrollment enrollment = new Enrollment();
            enrollment.Id = Guid.NewGuid().ToString();
            enrollment.StudentId = CurrentStudentId;
            enrollment.CourseId  = courseId;

            _applicationDbContext.Enrollments.Add(enrollment);
            _applicationDbContext.SaveChanges();
            return RedirectToAction("EnrolledCourses");
        }



    }
}