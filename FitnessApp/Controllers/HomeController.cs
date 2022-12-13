using FitnessApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FitnessApp.Controllers
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
            if (User.Identity?.IsAuthenticated == false)
            {
                return RedirectToAction("Start");
            }
            if (User.IsInRole("Coach"))
            {
                return RedirectToAction("HomeForCoach");
            }
            if (User.IsInRole("Customer"))
            {
                return RedirectToAction("HomeForCustomer");
            }
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            

            return View();
        }

        public IActionResult Start()
        {
            return View();
        }
        public IActionResult HomeForCoach()
        {
            return View();
        }
        public IActionResult HomeForCustomer()
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