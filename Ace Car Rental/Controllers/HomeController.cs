using Ace_Car_Rental.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Ace_Car_Rental.Controllers
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
        public ViewResult Home()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
       
       
        
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
        public ViewResult Services()
        {
            return View();
        }
        public ActionResult contactus()
        {
            return View();
        }
        public ViewResult cart ()
        {
            return View();
        }
        public ActionResult Booking()
        {
            return View();  
        }
        public ActionResult Admin()
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
    }
}