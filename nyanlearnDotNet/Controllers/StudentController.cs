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

        [Authorize(Roles = "student")]
        [Route("Course/Lesson/Quiz")]

        public IActionResult AnswerQuiz(string lessonId)
        {
            var quizs = _applicationDbContext.Quizs.Where(q=>q.LessonId==lessonId).Select(q=> new AnswerQuizViewModel
            {
                Question = q.Question,
                Option1 = q.Option1,
                Option2 = q.Option2,
                Option3 = q.Option3,
                Option4 = q.Option4,
                Answer = q.Answer,
            }).ToList();

            TempData["lessonId"] = lessonId;
            return View("~/Views/Student/Quiz.cshtml",quizs);
        }

        [Authorize(Roles = "student")]
        [Route("Course/Learn")]

        public IActionResult CourseLearn(string courseId)
        {
            var lessons = _applicationDbContext.Lessons.Where(l=> l.CourseId==courseId).Select(
                l=> new LessonViewModel
                {
                    Name = l.Name,
                    Id = l.Id,
                    CourseName = l.CourseName,
                    CourseId = l.CourseId,
                }
            ).ToList();
            return View("~/Views/Student/CourseLearn.cshtml",lessons);
        }




        [Authorize(Roles = "student")]
        [Route("Course/Lesson/Learn")]

        public IActionResult LessonLearn(string lessonId)
        {
            var l = _applicationDbContext.Lessons.FirstOrDefault(l=> l.Id==lessonId);
            LessonViewModel lesson = new LessonViewModel();

                    lesson.Name = l.Name;
                    lesson.Id = l.Id;
                    lesson.Description = l.Description;
                    lesson.CourseName = l.CourseName;
                    lesson.FilePath = l.FilePath;


            return View("~/Views/Student/CourseLessonLearn.cshtml",lesson);
        }

         [Authorize(Roles = "student")]
        [Route("Course/Lesson/Quiz/Result")]
        
        public IActionResult CheckQuiz(IList<AnswerQuizViewModel>answerQuizViewModels)
        {
            var result = answerQuizViewModels;
            return RedirectToAction("index");
        }
    }
}