﻿using FitnessApp.Areas.Admin.Models;
using FitnessApp.Core.Contracts;
using FitnessApp.Infrastructure.Data.Common;
using FitnessApp.Infrastructure.Data.Enities;
using FitnessApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Areas.Admin.Controllers
{
    public class CoachController : BaseController
    {
        private readonly ICoachesAndCustomersService coachesAndCustomersService;

        private readonly UserManager<User> userManager;

        public CoachController(
            UserManager<User> _userManager,
            ICoachesAndCustomersService _coachesAndCustomersService)
        {
            userManager = _userManager;
            coachesAndCustomersService = _coachesAndCustomersService;
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


            var result = await userManager.CreateAsync(user, model.Password);

            await userManager.AddToRoleAsync(user, "Coach");

            //var coach = new Coach()
            //{
            //    UserId = user.Id,
            //};

            //await repo.AddAsync(coach);


            if (result.Succeeded)
            {
                //await repo.AddAsync(coach);
                //await repo.SaveChangesAsync();
                await coachesAndCustomersService.AddCoach(user.Id);
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }


    }


}
