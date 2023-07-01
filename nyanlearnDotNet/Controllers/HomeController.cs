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
        public IActionResult PublicRegister(PublicRegisterViewModel publicRegisterViewModel)
        {
            PublicRegister publicRegister = new PublicRegister();
            publicRegister.Id = Guid.NewGuid().ToString();
            publicRegister.CreatedDate = DateTime.Now;
            publicRegister.Name = publicRegisterViewModel.Name;
            publicRegister.Email = publicRegisterViewModel.Email;
            publicRegister.Phone = publicRegisterViewModel.Phone;
            publicRegister.Address = publicRegisterViewModel.Address;
            publicRegister.NRC = publicRegisterViewModel.NRC;
            publicRegister.DOB = publicRegisterViewModel.DOB;
            publicRegister.FatherName = publicRegisterViewModel.FatherName;
            _applicationDbContext.PublicRegisters.Add(publicRegister);//Adding the record Students DBSet
            _applicationDbContext.SaveChanges();
            return View();
        }

    }
}