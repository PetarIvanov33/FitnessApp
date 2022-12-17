using FitnessApp.Areas.Admin.Models;
using FitnessApp.Core.Contracts;
using FitnessApp.Core.Services;
using FitnessApp.Infrastructure.Data.Common;
using FitnessApp.Infrastructure.Data.Enities;
using FitnessApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAccountService accountService;

        private readonly IRoleService roleService;

        private readonly UserManager<User> userManager;

        public AccountController(
            UserManager<User> _userManager,
            IAccountService _accountService,
            IRoleService _roleService)
        {
            userManager = _userManager;
            accountService = _accountService;
            roleService = _roleService;
        }

        [HttpGet]
        public IActionResult AddCoach()
        {
            var model = new AddCoachModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddCoach(AddCoachModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                Email = model.Email,
                UserName = model.UserName,
                PhoneNumber = model.PhoneNumber,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age
            };

            if (model.ProfileImageURL != null)
            {
                user.ProfileImageURL = model.ProfileImageURL;
            }

            var result = await userManager.CreateAsync(user, model.Password);
           
            await roleService.AddToRole(user, "Coach");
            
            if (result.Succeeded)
            {             
                await accountService.AddCoach(user.Id);
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            var model = await accountService.GetAllUsersAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AllCoaches()
        {
            var model = await accountService.GetAllCoaches();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AllCustomers()
        {
            var model = await accountService.GetAllCustomers();

            return View(model);
        }


    }


}
