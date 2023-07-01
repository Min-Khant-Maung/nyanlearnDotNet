using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nyanlearnDotNet.Models;
using nyanlearnDotNet.Models.DAO;
using nyanlearnDotNet.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nyanlearnDotNet.Controllers
{
    // [Authorize]
    public class StudentController : Controller
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<IdentityUser> _usermanager;

        public StudentController(ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _usermanager = userManager;
        }
        public IActionResult Index()
        {
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
        public IActionResult ListAllCourse()
        {
            IList<CourseViewModel> courses = _applicationDbContext.Courses.Select
                (t => new CourseViewModel
                {
                    Name = t.Name,
                    Description = t.Description
                }).ToList();



            return View("~/Views/Student/ListAllCourse.cshtml", courses);
        }




    }
}