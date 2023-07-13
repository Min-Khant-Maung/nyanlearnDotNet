using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nyanlearnDotNet.Models;
using nyanlearnDotNet.Models.DAO;
using nyanlearnDotNet.Models.ViewModel;
using SelectPdf;

namespace testLayout.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult GetCerticiate()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads","certificates", "certificate.pdf");
            GenerateCertificate("Nyilynnhtwe","Javascript",filePath);
            return View();
        }

        public void GenerateCertificate(string name, string course, string filePath)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Add a page to the document
            PdfPage page = document.AddPage();

            // Create a new PDF font
            PdfFont font = document.AddFont(PdfStandardFont.HelveticaBold);

            // Set the font size
            font.Size = 24;

            // Create a new PDF text element
            PdfTextElement text = new PdfTextElement(50, 50, $"Certificate of Completion\n\nThis is to certify that {name} has successfully completed the course: {course}.");

            // Set the font for the text element
            text.Font = font;

            // Add the text element to the page
            page.Add(text);

            // Save the document
            document.Save(filePath);

            // Close the document
            document.Close();


            return View("~/Views/Home/Index.cshtml");
        }
    }
}