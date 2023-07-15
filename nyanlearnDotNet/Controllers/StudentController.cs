using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using nyanlearnDotNet.Models;
using nyanlearnDotNet.Models.DAO;
using nyanlearnDotNet.Models.ViewModel;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
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

        private const string alphanumericChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private const string specialChars = "!@#$%^&*";

        private static readonly Random random = new Random();

        private string CurrentUserId;
        private string CurrentStudentId;

        public StudentController(ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager, ILogger<StudentController> logger)
        {
            _applicationDbContext = applicationDbContext;
            _usermanager = userManager;
            _logger = logger;
        }
        public IActionResult Index()
        {
            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            ViewBag.profileUrl = student.ImagePath;
            return View("~/Views/Student/Index.cshtml");
        }



        [Authorize(Roles = "student")]
        [Route("Course/All")]
        public IActionResult ListAllCourses()
        {
            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            ViewBag.profileUrl = student.ImagePath;
            IList<CourseViewModel> courses = _applicationDbContext.Courses.Select
                (t => new CourseViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    ImagePath = t.ImagePath
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


            ViewBag.profileUrl = student.ImagePath;


            IList<CourseViewModel> courses = _applicationDbContext.Enrollments
            .Where(enrollment => enrollment.StudentId == CurrentStudentId)
            .Select(enrollment => new CourseViewModel
            {
                Id = enrollment.Course.Id,
                Name = enrollment.Course.Name,
                Description = enrollment.Course.Description,
                ImagePath = enrollment.Course.ImagePath
            }).ToList();




            return View("~/Views/Student/EnrolledCourses.cshtml", courses);
        }


        [Authorize(Roles = "student")]
        [Route("Course/Enroll")]
        public async Task<IActionResult> EnrollCourse(string courseId)
        {

            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = await _applicationDbContext.Students.FirstOrDefaultAsync(i => i.UserId == CurrentUserId);



            ViewBag.profileUrl = student.ImagePath;
            var enrolledCourse = await _applicationDbContext.Courses.FirstOrDefaultAsync(c => c.Id == courseId);











            int currentCourseNumOfLessons = await _applicationDbContext.Lessons.Where(l => l.CourseId == courseId).CountAsync();

            var instructorId = enrolledCourse.InstructorId;

            CurrentStudentId = student.Id;

            Enrollment enrollment = new Enrollment();
            enrollment.Id = Guid.NewGuid().ToString();
            enrollment.CreatedDate = DateTime.Now;
            enrollment.StudentId = CurrentStudentId;
            enrollment.CourseId = courseId;
            enrollment.numOfLessons = currentCourseNumOfLessons;


            CourseResult courseResult = new CourseResult();
            courseResult.Id = Guid.NewGuid().ToString();
            courseResult.CreatedDate = DateTime.Now;
            courseResult.StudentId = CurrentStudentId;
            courseResult.CourseId = courseId;
            courseResult.InstructorId = instructorId;
            courseResult.ResultPercentage = 0;

            await _applicationDbContext.Enrollments.AddAsync(enrollment);
            await _applicationDbContext.CourseResults.AddAsync(courseResult);
            await _applicationDbContext.SaveChangesAsync();
            return RedirectToAction("EnrolledCourses");
        }

        [Authorize(Roles = "student")]
        [Route("Course/Lesson/Quiz")]

        public IActionResult AnswerQuiz(string lessonId, string courseId)
        {
            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            ViewBag.profileUrl = student.ImagePath;
            var quizs = _applicationDbContext.Quizs.Where(q => q.LessonId == lessonId).Select(q => new AnswerQuizViewModel
            {
                Id = q.Id,
                Question = q.Question,
                Option1 = q.Option1,
                Option2 = q.Option2,
                Option3 = q.Option3,
                Option4 = q.Option4,
                Answer = q.Answer,
            }).ToList();

            TempData["lessonId"] = lessonId;
            TempData["courseId"] = courseId;
            TempData["numOfQuizs"] = _applicationDbContext.Quizs.Where(q => q.LessonId == lessonId).Count();
            return View("~/Views/Student/Quiz.cshtml", quizs);
        }

        [Authorize(Roles = "student")]
        [Route("Course/Learn")]

        public IActionResult CourseLearn(string courseId)
        {
            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            ViewBag.profileUrl = student.ImagePath;
            var lessons = _applicationDbContext.Lessons.Where(l => l.CourseId == courseId).Select(
                l => new LessonViewModel
                {
                    Name = l.Name,
                    Id = l.Id,
                    CourseName = l.CourseName,
                    CourseId = l.CourseId,
                }
            ).ToList();
            return View("~/Views/Student/CourseLearn.cshtml", lessons);
        }




        [Authorize(Roles = "student")]
        [Route("Course/Lesson/Learn")]

        public IActionResult LessonLearn(string lessonId, string courseId)
        {
            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            ViewBag.profileUrl = student.ImagePath;
            var l = _applicationDbContext.Lessons.FirstOrDefault(l => l.Id == lessonId);
            LessonViewModel lesson = new LessonViewModel();

            lesson.Name = l.Name;
            lesson.Id = l.Id;
            lesson.Description = l.Description;
            lesson.CourseName = l.CourseName;
            lesson.FilePath = l.FilePath;

            TempData["courseId"] = courseId;
            return View("~/Views/Student/CourseLessonLearn.cshtml", lesson);
        }

        [Authorize(Roles = "student")]
        [Route("Course/Lesson/Quiz/Result")]

        public IActionResult CheckQuiz(string lessonId, string courseId, string totalMarks)
        {
            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            CurrentStudentId = student.Id;


            ViewBag.profileUrl = student.ImagePath;

            LessonResult lessonResult = new LessonResult();
            lessonResult.Id = Guid.NewGuid().ToString();
            lessonResult.CreatedDate = DateTime.Now;
            lessonResult.StudentId = CurrentStudentId;
            lessonResult.LessonId = lessonId;
            lessonResult.ResultPercentage = double.Parse(totalMarks);


            //get current student'scourse total percentage
            var currentPercentage = _applicationDbContext.CourseResults.FirstOrDefault(cr => cr.CourseId == courseId && cr.StudentId == CurrentStudentId).ResultPercentage;





            //calculate num of leesons from course model beacuse we wanna calculate total result 
            var course = _applicationDbContext.Courses
                .Include(c => c.Lessons)
                .FirstOrDefault(c => c.Id == courseId);



            // update current student'scourse total percentage
            currentPercentage = (currentPercentage + double.Parse(totalMarks));



            // save data to course result table

            CourseResult courseResult = new CourseResult();
            courseResult.Id = Guid.NewGuid().ToString();
            courseResult.StudentId = CurrentStudentId;
            courseResult.CourseId = courseId;
            courseResult.ResultPercentage = currentPercentage;

            _applicationDbContext.LessonResults.Add(lessonResult);

            _applicationDbContext.SaveChanges();
            return RedirectToAction("UpdateStudentResult", courseResult);
        }




        [Authorize(Roles = "student")]
        [Route("Course/Lesson/Quiz/Result/UpdateDb")]
        public IActionResult UpdateStudentResult(CourseResult courseResult)
        {
            var result = _applicationDbContext.CourseResults.FirstOrDefault(c => c.CourseId == courseResult.CourseId);
            result.ResultPercentage = courseResult.ResultPercentage;
            _applicationDbContext.SaveChanges();
            return RedirectToAction("EnrolledCourses");
        }


        [Authorize(Roles = "student")]
        [Route("Course/Result")]
        public async Task<IActionResult> ResultLesson()
        {

            CurrentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var student = _applicationDbContext.Students.FirstOrDefault(i => i.UserId == CurrentUserId);
            CurrentStudentId = student.Id;


            ViewBag.profileUrl = student.ImagePath;


            IList<CourseResultPercentageViewModel> percentages = await _applicationDbContext.Enrollments.Where(
                e => e.StudentId == CurrentStudentId
            ).Select(
                e => new CourseResultPercentageViewModel
                {
                    CourseId = e.CourseId,
                    numOfLessons = e.numOfLessons
                }
            ).ToListAsync();



            IList<CourseResultViewModel> courseresults = _applicationDbContext.CourseResults.Where(cr => cr.StudentId == CurrentStudentId).Select
                (cv => new CourseResultViewModel
                {
                    Course = cv.Course,
                    CreatedDate = cv.CreatedDate,
                    ResultPercentage = cv.ResultPercentage,
                    Instructor = cv.Instructor
                }).ToList();



            IList<LessonResultViewModel> lessonresults = _applicationDbContext.LessonResults.Where(lr => lr.StudentId == CurrentStudentId).Select
                (s => new LessonResultViewModel
                {
                    Lesson = s.Lesson,
                    CreatedDate = s.CreatedDate,
                    ResultPercentage = s.ResultPercentage
                }).ToList();

            TempData["courseResults"] = courseresults;
            TempData["lessonResults"] = lessonresults;

            TempData["percentages"] = percentages;

            return View("~/Views/Student/Result.cshtml");
        }



        [Authorize(Roles = "student")]
        [Route("/Certificate")]
        public IActionResult GetCertificate(string studentName,string courseName,string instructorName)
        {
            string currentPath = Directory.GetCurrentDirectory();
            string htmlRawString = ReadHtmlFileAsString(currentPath + "/index.html");



            studentName = "John Doe";
            courseName = "Introduction to Programming";
            instructorName = "Jane Smith";
            string gaveDate = DateTime.Now.ToShortDateString();
            string certificateId = "nyanlearn"+GeneratePassword(10);

            // Replace placeholders in the HTML content
            htmlRawString = htmlRawString.Replace("{studentName}", studentName)
                                     .Replace("{courseName}", courseName)
                                     .Replace("{instructor}", instructorName)
                                     .Replace("{gaveDate}", gaveDate)
                                     .Replace("{certificateId}", certificateId);
            // _logger.LogInformation(htmlRawString);
            ConvertHtmlToPdf(htmlRawString, currentPath + "/generate.pdf");
            return View("~/Views/Home/Index.cshtml");
        }


        public void ConvertHtmlToPdf(string htmlContent, string outputPath)
        {
            // Create a new HTML to PDF converter
            HtmlToPdf converter = new HtmlToPdf();

            // Set converter options (optional)
            converter.Options.MarginTop = 10;
            converter.Options.MarginBottom = 10;

            // Convert HTML string to PDF
            PdfDocument document = converter.ConvertHtmlString(htmlContent);

            // Save the PDF document
            document.Save(outputPath);

            // Close the PDF document
            document.Close();
        }

        public static string ReadHtmlFileAsString(string filePath)
        {
            string htmlContent = System.IO.File.ReadAllText(filePath);
            return htmlContent;
        }



        public static string GeneratePassword(int length)
        {
            StringBuilder password = new StringBuilder();

            // Generate one uppercase letter
            password.Append(GenerateRandomChar("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));

            // Generate one lowercase letter
            password.Append(GenerateRandomChar("abcdefghijklmnopqrstuvwxyz"));

            // Generate one special character
            password.Append(GenerateRandomChar(specialChars));

            password.Append(GenerateRandomChar("0123456789"));

            // Generate the remaining random part of the password
            for (int i = 0; i < length - 4; i++)
            {
                password.Append(GenerateRandomChar(alphanumericChars));
            }

            // Shuffle the characters in the password
            string shuffledPassword = ShufflePassword(password.ToString());

            return shuffledPassword;
        }

        private static char GenerateRandomChar(string characters)
        {
            return characters[random.Next(characters.Length)];
        }

        private static string ShufflePassword(string password)
        {
            char[] passwordChars = password.ToCharArray();

            for (int i = passwordChars.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (passwordChars[i], passwordChars[j]) = (passwordChars[j], passwordChars[i]);
            }

            return new string(passwordChars);
        }


    }
}