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
using Microsoft.Extensions.Logging;
using nyanlearnDotNet.Library.Email;

namespace nyanlearnDotNet.Controllers
{
    // [Authorize]
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<IdentityUser> _usermanager;
        private readonly ILogger<AdminController> _logger;
        private readonly IEmailSender _emailSender;
        private static readonly Random random = new Random();
        private const string alphanumericChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private const string specialChars = "!@#$%^&*";


        public AdminController(ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager,ILogger<AdminController> logger,  IEmailSender emailSender)
        {
            _applicationDbContext = applicationDbContext;
            _usermanager = userManager;
            _logger = logger;
            _emailSender = emailSender;
        }
        public IActionResult Index()
        {
            return View("~/Views/Admin/Index.cshtml");
        }


        
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ListPublicRegister()
        {
            await _emailSender.SendEmailAsync("nyilynnhtwe@gmail.com", "testing", "Hello world");
            IList<PublicRegisterViewModel> publicRegisters = _applicationDbContext.PublicRegisters.Select
                (t => new PublicRegisterViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    Email = t.Email,
                    FatherName = t.FatherName,
                    DOB = t.DOB,
                    NRC = t.NRC,
                    Address = t.Address,
                    Phone = t.Phone
                }).ToList();



            return View("~/Views/Admin/PublicRegisterList.cshtml", publicRegisters);
        }

        [Authorize(Roles = "admin")]
        public IActionResult BanPublicRegister(string id)
        {
            _logger.LogInformation(id);
            var data = _applicationDbContext.PublicRegisters.Find(id);
            if (data != null) {
                _applicationDbContext.PublicRegisters.Remove(data);
                _applicationDbContext.SaveChanges();//Updating  the record to the database
                TempData["msg"] = "Delete process successed!!";
            }
            return RedirectToAction("ListPublicRegister");
        }



        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ApprovePublicRegister(string id)
        {

            var generatedEmail    = "nyanlearn_student_";
            var generatedPassword = GeneratePassword(8);
            var numOfStudents = _applicationDbContext.Students.Count()+1;

            _logger.LogInformation(generatedEmail);
            _logger.LogInformation(generatedPassword);
            for(int i=numOfStudents.ToString().Length;i<4;i++)
            {
                generatedEmail = generatedEmail + "0";
            }
            generatedEmail = generatedEmail + numOfStudents.ToString() + "@nyanlearn.com"; 


            var user = new IdentityUser { UserName = generatedEmail, Email = generatedEmail};
            var result = await _usermanager.CreateAsync(user,generatedPassword);
            if (result.Succeeded)
            {
                await _usermanager.AddToRoleAsync(user, "student");
            }



            var data = _applicationDbContext.PublicRegisters.Find(id);
            Student student = new Student();
            student.Id = Guid.NewGuid().ToString();
            student.Name = data.Name;
            student.DOB  = data.DOB;
            student.Email= generatedEmail;
            student.NRC  = data.NRC;
            student.Address = data.Address;
            student.Phone   = data.Phone;
            student.FatherName = data.FatherName;
            student.UserId     = user.Id;


            if (data != null) {
                

                _applicationDbContext.Students.Add(student);
                _applicationDbContext.PublicRegisters.Remove(data);



                _applicationDbContext.SaveChanges();//Updating  the record to the database
                TempData["msg"] = "Delete process successed!!";
            }
            return RedirectToAction("ListStudents");
        }

        [Authorize(Roles = "admin")]
        public IActionResult ListStudents()
        {
            IList<StudentViewModel> stus = _applicationDbContext.Students.Select
                (s => new StudentViewModel
                {
                    Name = s.Name,
                    DOB = s.DOB,
                    Email = s.Email,
                    NRC = s.NRC,
                    Address = s.Address,
                    Phone = s.Phone,
                    FatherName = s.FatherName,
                    IsApproved = s.IsApproved
                }).ToList();


            return View("~/Views/Admin/StudentList.cshtml", stus);
        }


        [Authorize(Roles = "admin")]
        public IActionResult AddStudent()
        {
            return View("~/Views/Admin/StudentRegForm.cshtml");
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentViewModel studentviewmodel)
        {
            var user = new IdentityUser { UserName = studentviewmodel.Email, Email = studentviewmodel.Email };
            var result = await _usermanager.CreateAsync(user,"Min12345");
            if (result.Succeeded)
            {
                await _usermanager.AddToRoleAsync(user, "student");
            }
            Student student = new Student();
            //audit columns
            student.Id = Guid.NewGuid().ToString();
            student.CreatedDate = DateTime.Now;
            student.Name = studentviewmodel.Name;
            student.Email = studentviewmodel.Email;
            student.Phone = studentviewmodel.Phone;
            student.Address = studentviewmodel.Address;
            student.NRC = studentviewmodel.NRC;
            student.DOB = studentviewmodel.DOB;
            student.FatherName = studentviewmodel.FatherName;
            student.IsApproved = studentviewmodel.IsApproved;
            student.UserId = user.Id;//for identity user
            _applicationDbContext.Students.Add(student);//Adding the record Students DBSet
            _applicationDbContext.SaveChanges();//saving the record to the database




            return RedirectToAction("ListStudents");
        }



        [Authorize(Roles = "admin")]
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


        [Authorize(Roles = "admin")]
        public IActionResult AddInstructor()
        {
            IList<NRCViewModel> nrcs = _applicationDbContext.NRCs.Select
              (n => new NRCViewModel
              {
                  name_en = n.name_en,
                  nrc_code = n.nrc_code,
              }).ToList();
            return View("~/Views/Admin/InstructorRegForm.cshtml",nrcs);
        }

        [Authorize(Roles = "admin")]
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




         public static string GeneratePassword(int length)
        {
            string chars = alphanumericChars + specialChars;
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}