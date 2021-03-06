using Microsoft.AspNetCore.Mvc;
using RedStore.Models;
using System.Diagnostics;

namespace RedStore.Controllers
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

        public IActionResult Form(string fname, string lname, string email, string phNo, string message)
        {
            ViewBag.message = "";
            if(fname != null && lname != null && email != null && phNo != null && message != null)
            {
                ViewBag.message = "Data submitted successfully";
            }
            return View();
        }

        public IActionResult ProductDetails()
        {
            return View();
        }

        public IActionResult Accounts()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}