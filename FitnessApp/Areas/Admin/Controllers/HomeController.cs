﻿using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
