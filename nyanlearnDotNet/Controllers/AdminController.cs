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
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<IdentityUser> _usermanager;

        public AdminController(ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _usermanager = userManager;
        }
        public IActionResult Index()
        {
            return View("~/Views/Admin/Index.cshtml");
        }


        // public IActionResult ListStudents()
        // {
        //     IList<StudentViewModel> stus = _applicationDbContext.Students.Select
        //         (s => new StudentViewModel
        //         {
        //             Code = s.Code,
        //             Name = s.Name,
        //             DOB = s.DOB,
        //             Email = s.Email,
        //             NRC = s.NRC,
        //             Address = s.Address,
        //             Phone = s.Phone,
        //             FatherName = s.FatherName
        //         }).ToList();


        //     return View("~/Views/Admin/StudentList.cshtml", stus);
        // }

        // public IActionResult AddStudent()
        // {
        //     return View("~/Views/Admin/StudentRegForm.cshtml");
        // }


        // [HttpPost]
        // public async Task<IActionResult> AddStudent(StudentViewModel studentviewmodel)
        // {
        //     var user = new IdentityUser { UserName = studentviewmodel.Name, Email = studentviewmodel.Email };
        //     var result = await _usermanager.CreateAsync(user, studentviewmodel.Password);
        //     if (result.Succeeded)
        //     {
        //         await _usermanager.AddToRoleAsync(user, "student");
        //     }
        //     Student student = new Student();
        //     //audit columns
        //     student.Id = Guid.NewGuid().ToString();
        //     student.CreatedDate = DateTime.Now;
        //     student.Code = studentviewmodel.Code;
        //     student.Name = studentviewmodel.Name;
        //     student.Email = studentviewmodel.Email;
        //     student.Password = "";
        //     student.Phone = studentviewmodel.Phone;
        //     student.Address = studentviewmodel.Address;
        //     student.NRC = studentviewmodel.NRC;
        //     student.DOB = studentviewmodel.DOB;
        //     student.FatherName = studentviewmodel.FatherName;
        //     student.UserId = user.Id;//for identity user
        //     _applicationDbContext.Students.Add(student);//Adding the record Students DBSet
        //     _applicationDbContext.SaveChanges();//saving the record to the database




        //     return RedirectToAction("ListStudents");
        // }



        // [Authorize(Roles = "Admin")]
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



            return View("~/Views/Admin/InstructorList.cshtml", instructors);
        }


        // [Authorize(Roles = "Admin")]
        public IActionResult AddInstructor()
        {
            return View("~/Views/Admin/InstructorRegForm.cshtml");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddInstructor(InstructorViewModel instructorviewmodel)
        {
            var user = new IdentityUser { UserName = instructorviewmodel.Email, Email = instructorviewmodel.Email };
            var result = await _usermanager.CreateAsync(user, instructorviewmodel.Password);
            if (result.Succeeded)
            {
                await _usermanager.AddToRoleAsync(user, "instructor");
            }


            
            Instructor instructor = new Instructor();
            //audit columns
            instructor.Id = Guid.NewGuid().ToString();
            instructor.CreatedDate = DateTime.Now;
            instructor.Name = instructorviewmodel.Name;
            instructor.Email = instructorviewmodel.Email;
            instructor.Password = instructorviewmodel.Password;
            instructor.Phone = instructorviewmodel.Phone;
            instructor.Position = instructorviewmodel.Position;
            instructor.Address = instructorviewmodel.Address;
            instructor.NRC = instructorviewmodel.NRC;
            instructor.DOB = instructorviewmodel.DOB;
            instructor.FatherName = instructorviewmodel.FatherName;
            instructor.UserId = user.Id;//for identity user
            _applicationDbContext.Instructors.Add(instructor);//Adding the record Students DBSet
            _applicationDbContext.SaveChanges();//saving the record to the database
            return RedirectToAction("ListInstructors");
        }

    }
}