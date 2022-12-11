using FitnessApp.Core.Contracts;
using FitnessApp.Core.Models;
using FitnessApp.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitnessApp.Controllers
{
    [Authorize(Roles = "Coach, Admin")]
    public class ProgramController : Controller
    {
        private readonly IProgramsService programsService;

        public ProgramController(IProgramsService _programsService)
        {
            programsService = _programsService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {

            var model = new AddProgramModel()
            {
                Categories = await programsService.GetCategoryAsync()
            };

            return View(model);
        }

        [HttpPost]
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

                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");

                return View(modelEnd);
            }
        }

        [HttpGet]
        public async Task<FileResult> Export()
        {
            return File(await programsService.ExportProgram(1), "application/vnd.ms-word", "program.doc");
        }
    }
}
