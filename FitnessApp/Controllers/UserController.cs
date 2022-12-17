using FitnessApp.Core.Contracts;
using FitnessApp.Core.Services;
using FitnessApp.Infrastructure.Data.Common;
using FitnessApp.Infrastructure.Data.Enities;
using FitnessApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitnessApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IAccountService accountService;

        private readonly UserManager<User> userManager;

        private readonly SignInManager<User> signInManager;

        public UserController(
            UserManager<User> _userManager,
            SignInManager<User> _signInManager,
            IAccountService _accountService)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            accountService = _accountService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
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

            await userManager.AddToRoleAsync(user, "Customer");
         
            if (result.Succeeded)
            {             
                await accountService.AddCustomer(user.Id);
                return RedirectToAction("Login", "User");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = "Customer, Coach")]
        public async Task<IActionResult> DisplayedProfile()
        {
                try
                {
                    return View(await accountService.GetCurrentUserProfile(User.FindFirstValue(ClaimTypes.NameIdentifier)));
                }
                catch (Exception)
                {
                    return NotFound();
                }         
        }
    }
}
