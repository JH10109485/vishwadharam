using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using vishwadharam.Models;

namespace vishwadharam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        [HttpPost]
        public IActionResult Contact(string Name, string Email, string Message)
        {
            // Handle form data (e.g., send email, save to database)
            ViewBag.Message = "Thank you for contacting us!";
            return RedirectToAction("Index");
        }
    }
}
