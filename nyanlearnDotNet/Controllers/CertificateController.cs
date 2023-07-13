using System.IO;
using Microsoft.AspNetCore.Mvc;
using SelectPdf;

namespace nyanlearnDotNet.Controllers
{
    public class CertificateController : Controller
    {
        public CertificateController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCertificate()
        {
            string currentPath = Directory.GetCurrentDirectory();
            string htmlRawString = ReadHtmlFileAsString(currentPath + "/index.html");
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

        public string ReadHtmlFileAsString(string filePath)
        {
            string htmlContent = System.IO.File.ReadAllText(filePath);
            return htmlContent;
        }


    }
}