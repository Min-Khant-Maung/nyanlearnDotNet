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
    [Route("Instructor")]
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
        [Route("Course/Add")]
        public IActionResult AddCourse()
        {
            return View("~/Views/Instructor/AddCourse.cshtml");
        }

        // We need to fix this action to filter the courses by only current instructor.
        [Authorize(Roles = "instructor")]
        [Route("Lesson/Add")]
        public IActionResult AddLesson()
        {
            IList<Course> courses = _applicationDbContext.Courses.ToList();
            return View("~/Views/Instructor/AddLesson.cshtml",courses);
        }
        

        [Authorize(Roles = "instructor")]
        [Route("Course/List")]
        public IActionResult ListCourses()
        {

                CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
                var instructor = _applicationDbContext.Instructors.FirstOrDefault(i => i.UserId == CurrentUserId);
                CurrentInstructorId = instructor.Id;

                var courses = _applicationDbContext.CourseLessons.Where(cl => cl.InstructorId == CurrentInstructorId).Select(
                    cl=> new CourseViewModel{
                        Id = cl.Course.Id,
                        Name = cl.Course.Name,
                        Description = cl.Course.Description,
                        ImagePath = cl.Course.ImagePath,
                    }
                ).ToList();






            return View("~/Views/Instructor/ListCourses.cshtml",courses);
        }



        [Authorize(Roles = "instructor")]
        [Route("Lesson/List")]
        public IActionResult ListLessons()
        {

                CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
                var instructor = _applicationDbContext.Instructors.FirstOrDefault(i => i.UserId == CurrentUserId);
                CurrentInstructorId = instructor.Id;

                var lessons =  _applicationDbContext.CourseLessons
            .Where(cl => cl.InstructorId == CurrentInstructorId).Select(
                cl =>
                new LessonViewModel {
                    Id          = cl.Id,
                    Name        = cl.Lesson.Name,
                    Description = cl.Lesson.Description,
                    CourseName  = cl.Course.Name,
                    FilePath    = cl.Lesson.FilePath 
                }
            )
            .ToList();

                
                return View("~/Views/Instructor/ListLessons.cshtml",lessons);
        }

        // [Authorize(Roles = "instructor")]
        // public int FindNumberOfQuizs(string lessonId)
        // {
        //     var numberofquizs =  _applicationDbContext.Quizs.Where(q=> q.LessonId==lessonId).Count();            
        //     _logger.LogInformation(numberofquizs.ToString());
        //     return numberofquizs;
        // }


                
        [Authorize(Roles = "instructor")]
        [Route("Lesson/Delete/{lessonId}")]
        public async Task<IActionResult> LessonDelete(string lessonId)
        {
            var lesson = await _applicationDbContext.Lessons.FindAsync(lessonId);

            _applicationDbContext.Lessons.Remove(lesson);
            _applicationDbContext.SaveChanges();//Updating  the record to the database
            TempData["msg"] = "Delete process successed!!";
            
            return RedirectToAction("ListLessons");
        }




        [Authorize(Roles = "instructor")]
        [HttpPost]
        [Route("Course/Add")]
        public IActionResult AddCourse(CourseViewModel courseViewModel)
        {

             var generatedCourseId = Guid.NewGuid().ToString();
            // Process the uploaded file
            // For example, you can save it to a specific location or store it in a database
            var fileName = Path.GetFileName(courseViewModel.Photo.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads","course", generatedCourseId+fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                courseViewModel.Photo.CopyTo(fileStream);
            }

                CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
                var instructor = _applicationDbContext.Instructors.FirstOrDefault(i => i.UserId == CurrentUserId);
                CurrentInstructorId = instructor.Id;
                Course course = new Course();
                //audit columns
               
                course.Id = generatedCourseId;
                course.CreatedDate = DateTime.Now;
                course.Name = courseViewModel.Name;
                course.Description = courseViewModel.Description;
                course.ImagePath   =  generatedCourseId+fileName;
                course.InstructorId = CurrentInstructorId;


                CourseInstructor courseInstructor = new CourseInstructor();
                courseInstructor.Id = Guid.NewGuid().ToString();
                courseInstructor.CourseId = generatedCourseId;
                courseInstructor.CreatedDate = DateTime.Now;

                //  hard code for instructor( mr kyaing )
                courseInstructor.InstructorId = CurrentInstructorId;

                //Adding the record Students DBSet
                _applicationDbContext.Courses.Add(course);
                _applicationDbContext.CourseInstructors.Add(courseInstructor);

            _applicationDbContext.SaveChanges();//saving the record to the database
            return RedirectToAction("Index");
        }


        [Authorize(Roles = "instructor")]
        [HttpPost]
        [Route("Lesson/Add")]
        public IActionResult AddLesson(LessonViewModel lessonViewModel)
        {

                var generatedLessonId = Guid.NewGuid().ToString();
                 
                CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
                var instructor = _applicationDbContext.Instructors.FirstOrDefault(i => i.UserId == CurrentUserId);
                var course     = _applicationDbContext.Courses.FirstOrDefault(i => i.Id == lessonViewModel.CourseId);
                
                CurrentInstructorId = instructor.Id;
                var fileName = "";

                
                Lesson lesson = new Lesson();
                //audit columns

                 if (lessonViewModel.File == null)
                  {
                        lesson.FilePath = lessonViewModel.FilePath;
                  }
                  else
                  {
                        fileName = Path.GetFileName(lessonViewModel.File.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads","lesson", generatedLessonId+fileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            lessonViewModel.File.CopyTo(fileStream);
                        }
                        lesson.CourseName = course.Name;
                        lesson.FilePath = generatedLessonId+fileName;
                  }

                lesson.Id = generatedLessonId;
                lesson.CreatedDate = DateTime.Now;
                lesson.Name = lessonViewModel.Name;
                lesson.Description = lessonViewModel.Description;


                CourseLessons courseLesson = new CourseLessons();
                courseLesson.Id = Guid.NewGuid().ToString();
                courseLesson.LessonId = generatedLessonId;
                courseLesson.CourseId = lessonViewModel.CourseId;
                courseLesson.InstructorId = CurrentInstructorId;


                //Adding the record Students DBSet
                _applicationDbContext.Lessons.Add(lesson);
                _applicationDbContext.CourseLessons.Add(courseLesson);

            _applicationDbContext.SaveChanges();//saving the record to the database
            return RedirectToAction("Index");
        }

    [Authorize(Roles = "instructor")]
    [Route("Quiz/Add")]

        public IActionResult AddQuiz()
        {
                  IList<CreateQuizViewModel> courselessons = _applicationDbContext.CourseLessons.Select(
                cl => new CreateQuizViewModel
                {
                    CourseName = cl.Course.Name,
                    CourseId = cl.Course.Id,
                    LessonName = cl.Lesson.Name,
                    LessonId = cl.Lesson.Id,
                }
            ).ToList();
            return View("~/Views/Instructor/AddQuiz.cshtml",courselessons);
        }


        [HttpPost]
        [Authorize(Roles = "instructor")]
        [Route("Quiz/Add")]

        public IActionResult AddQuiz(CreateQuizViewModel createQuizViewModel)
        {
            
            Quiz quiz = new Quiz();
            quiz.Id =  Guid.NewGuid().ToString();
            quiz.LessonId = createQuizViewModel.LessonId;

            quiz.Question = createQuizViewModel.Question;
            quiz.Option1 = createQuizViewModel.Option1;
            quiz.Option2 = createQuizViewModel.Option2;
            quiz.Option3 = createQuizViewModel.Option3;
            quiz.Option4 = createQuizViewModel.Option4;

            quiz.Answer = createQuizViewModel.Answer;


            _applicationDbContext.Quizs.Add(quiz);
            _applicationDbContext.SaveChanges();



    

            return RedirectToAction("index");
        }






    }
}