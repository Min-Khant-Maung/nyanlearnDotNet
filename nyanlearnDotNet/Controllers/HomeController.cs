using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nyanlearnDotNet.Models;
using nyanlearnDotNet.Models.DAO;
using nyanlearnDotNet.Models.ViewModel;

namespace testLayout.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult PublicRegister()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PublicRegister(StudentViewModel studentViewModel)
        {
            Student student = new Student();
            student.Id = Guid.NewGuid().ToString();
            student.CreatedDate = DateTime.Now;
            student.Name = studentViewModel.Name;
            student.Email = studentViewModel.Email;
            student.Password ="";
            student.Phone = studentViewModel.Phone;
            student.Address = studentViewModel.Address;
            student.NRC = studentViewModel.NRC;
            student.DOB = studentViewModel.DOB;
            student.FatherName = studentViewModel.FatherName;
            _applicationDbContext.Students.Add(student);//Adding the record Students DBSet
            _applicationDbContext.SaveChanges();

            return View();
        }

    }
}