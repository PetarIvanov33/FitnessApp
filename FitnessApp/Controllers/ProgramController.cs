using FitnessApp.Core.Contracts;
using FitnessApp.Core.Models;
using FitnessApp.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitnessApp.Controllers
{
    public class ProgramController : Controller
    {
        private readonly IProgramsService programsService;

        public ProgramController(IProgramsService _programsService)
        {
            programsService = _programsService;
        }

        [HttpGet]
        [Authorize(Roles = "Coach, Admin")]
        public async Task<IActionResult> Add()
        {

            var model = new AddProgramModel()
            {
                Categories = await programsService.GetCategoryAsync()
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Coach, Admin")]
        public async Task<IActionResult> Add(AddProgramModel model)
        {
            if (!ModelState.IsValid)
            {

                model.Categories = await programsService.GetCategoryAsync();

                return View(model);
            }

            var __UserIdOfAuthor = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var modelEnd = model;
            modelEnd.UserIdOfAuthor = __UserIdOfAuthor;

            try
            {
                await programsService.AddProgramAsync(modelEnd);

                return RedirectToAction("All");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");

                return View(modelEnd);
            }
        }

        [HttpGet]
        [Authorize(Roles = "Coach, Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var model = await programsService.GetLikeAddProgramModel(id);
                return View(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Authorize(Roles = "Coach, Admin")]
        public async Task<IActionResult> Edit(int id, AddProgramModel model)
        {
            if (!ModelState.IsValid)
            {

                model.Categories = await programsService.GetCategoryAsync();

                return View(model);
            }


            try
            {
                await programsService.EditProgramAsync(id, model);

                return RedirectToAction("All");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");

                return View(model);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await programsService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> AllForCustomers()
        {
            var model = await programsService.GetAllForCustomersAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Coach, Admin")]
        public async Task<IActionResult> AllForThisCoach()
        {
            try
            {
                var model = await programsService.GetAllForThisCoachAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Authorize(Roles = "Coach, Admin, Customer")]
        public async Task<FileResult> Export(int id) 
        {
            var programContent = await programsService.ExportProgram(id);
           
            return File(programContent, "application/vnd.ms-word", "program.doc");        
        }

        [HttpPost]
        [Authorize(Roles = "Coach, Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await programsService.DeleteProgram(id);

            return RedirectToAction("All");
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Sell(int id)
        {
            if (this.User?.Identity != null && this.User.IsInRole("Customer"))
            {
                await programsService.Sell(id, User.FindFirstValue(ClaimTypes.NameIdentifier));

                return RedirectToAction("AllForThisCustomer");

            }
            else
            {
                return RedirectToAction("Login", "User");
            }
        }

        [HttpGet]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> AllForThisCustomer()
        {
            try
            {
                var model = await programsService.GetAllForThisCustomerAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(model);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
