using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using nyanlearn.Models;
using nyanlearn.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nyanlearn.Controllers
{
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


        public IActionResult ListStudents()
        {
            IList<StudentViewModel> stus = _applicationDbContext.Students.Select
                (s => new StudentViewModel
                {
                    Code = s.Code,
                    Name = s.Name,
                    DOB = s.DOB,
                    Email = s.Email,
                    NRC = s.NRC,
                    Address = s.Address,
                    Phone = s.Phone,
                    FatherName = s.FatherName
                }).ToList();


            return View("~/Views/Admin/StudentList.cshtml", stus);
        }

        public IActionResult AddStudent()
        {
            return View("~/Views/Admin/StudentRegForm.cshtml");
        }


        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentViewModel studentviewmodel)
        {
            var user = new IdentityUser { UserName = studentviewmodel.Name, Email = studentviewmodel.Email };
            var result = await _usermanager.CreateAsync(user, studentviewmodel.Password);
            if (result.Succeeded)
            {
                await _usermanager.AddToRoleAsync(user, "student");
            }
            Student student = new Student();
            //audit columns
            student.Id = Guid.NewGuid().ToString();
            student.CreatedDate = DateTime.Now;
            student.Code = studentviewmodel.Code;
            student.Name = studentviewmodel.Name;
            student.Email = studentviewmodel.Email;
            student.Password = "";
            student.Phone = studentviewmodel.Phone;
            student.Address = studentviewmodel.Address;
            student.NRC = studentviewmodel.NRC;
            student.DOB = studentviewmodel.DOB;
            student.FatherName = studentviewmodel.FatherName;
            student.UserId = user.Id;//for identity user
            _applicationDbContext.Students.Add(student);//Adding the record Students DBSet
            _applicationDbContext.SaveChanges();//saving the record to the database




            return RedirectToAction("ListStudents");
        }




        public IActionResult ListTeachers()
        {
            IList<TeacherViewModel> teachers = _applicationDbContext.Teachers.Select
                (t => new TeacherViewModel
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



            return View("~/Views/Admin/TeacherList.cshtml", teachers);
        }



        public IActionResult AddTeacher()
        {
            return View("~/Views/Admin/TeacherRegForm.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacher(TeacherViewModel teacherviewmodel)
        {
            var user = new IdentityUser { UserName = teacherviewmodel.Name, Email = teacherviewmodel.Email };
            var result = await _usermanager.CreateAsync(user, teacherviewmodel.Password);
            if (result.Succeeded)
            {
                await _usermanager.AddToRoleAsync(user, "teacher");
            }
            Teacher teacher = new Teacher();
            //audit columns
            teacher.Id = Guid.NewGuid().ToString();
            teacher.CreatedDate = DateTime.Now;
            teacher.Name = teacherviewmodel.Name;
            teacher.Email = teacherviewmodel.Email;
            teacher.Password = "";
            teacher.Phone = teacherviewmodel.Phone;
            teacher.Position = teacherviewmodel.Position;
            teacher.Address = teacherviewmodel.Address;
            teacher.NRC = teacherviewmodel.NRC;
            teacher.DOB = teacherviewmodel.DOB;
            teacher.FatherName = teacherviewmodel.FatherName;
            teacher.UserId = user.Id;//for identity user
            _applicationDbContext.Teachers.Add(teacher);//Adding the record Students DBSet
            _applicationDbContext.SaveChanges();//saving the record to the database
            return RedirectToAction("ListTeachers");
        }

    }
}