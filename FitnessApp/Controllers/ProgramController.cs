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
            return View(await programsService.GetLikeAddProgramModel(id));
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
        [Authorize(Roles = "Coach, Admin")]
        public async Task<IActionResult> AllForThisCoach()
        {
            var model = await programsService.GetAllForThisCoachAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Coach, Admin, Customer")]
        public async Task<FileResult> Export(int id) 
        {
            return File(await programsService.ExportProgram(id), "application/vnd.ms-word", "program.doc");
        }

        [HttpPost]
        [Authorize(Roles = "Coach, Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await programsService.DeleteProgram(id);

            return RedirectToAction("All");
        }
    }
}
