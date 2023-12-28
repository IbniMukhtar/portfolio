using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using myApp1.Models;
using System.Diagnostics;
namespace portfolio.Controllers;

public class HomeController : Controller
{
		private readonly IWebHostEnvironment _hostingEnvironment;

		public HomeController(IWebHostEnvironment hostingEnvironment)
		{
			_hostingEnvironment = hostingEnvironment;
		}
		
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
	public IActionResult DownloadCV()
	{
		// Replace "path/to/your/cv.pdf" with the relative path to your CV file
		string relativePath = "upload/MohsinResume.pdf";

		// Combine content root path with the relative path
		string filePath = System.IO.Path.Combine(_hostingEnvironment.WebRootPath, relativePath);

		// Replace "YourCV.pdf" with the desired file name for download
		string fileName = "MohsinResume.pdf";

		return PhysicalFile(filePath, "application/pdf", fileName);
	}

}
