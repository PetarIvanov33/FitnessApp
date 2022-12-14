using FitnessApp.Models;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles ="Coach")]
        public IActionResult HomeForCoach()
        {
            return View();
        }
        [Authorize(Roles = "Customer")]
        public IActionResult HomeForCustomer()
        {
            return View();
        }


        public IActionResult Error(int? statusCode = null)
        {
            if (statusCode.HasValue)
            {
                if (statusCode == 404)
                {
                    var viewName = statusCode.ToString();
                    return View(viewName);
                }
            }

            return View();
        }

       
    }
}