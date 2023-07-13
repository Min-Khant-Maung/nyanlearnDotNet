using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nyanlearnDotNet.Models;
using nyanlearnDotNet.Models.DAO;
using nyanlearnDotNet.Models.ViewModel;

namespace nyanlearnDotNet.Controllers
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

            var generatedPublicRegisterId = Guid.NewGuid().ToString();
            var fileName = Path.GetFileName(publicRegisterViewModel.Photo.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads","profile", generatedPublicRegisterId+fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                publicRegisterViewModel.Photo.CopyTo(fileStream);
            }


            PublicRegister publicRegister = new PublicRegister();
            publicRegister.Id = generatedPublicRegisterId;
            publicRegister.CreatedDate = DateTime.Now;
            publicRegister.Name = publicRegisterViewModel.Name;
            publicRegister.Email = publicRegisterViewModel.Email;
            publicRegister.Phone = publicRegisterViewModel.Phone;
            publicRegister.Address = publicRegisterViewModel.Address;
            publicRegister.NRC = publicRegisterViewModel.NRC;
            publicRegister.DOB = publicRegisterViewModel.DOB;
            publicRegister.FatherName = publicRegisterViewModel.FatherName;
            publicRegister.ImagePath  = generatedPublicRegisterId  + fileName;
            _applicationDbContext.PublicRegisters.Add(publicRegister);//Adding the record Students DBSet
            _applicationDbContext.SaveChanges();
            return View();
        }

    }
}