using FitnessApp.Core.Contracts;
using FitnessApp.Core.Models;
using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitnessApp.Controllers
{
    [Authorize(Roles ="Coach")]
    public class ArticleController : Controller
    {
        private readonly IArticlesService articlesService;

        public ArticleController(IArticlesService _articlesService)
        {
            articlesService = _articlesService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {

            var model = new AddArticleModel()
            {
                Categories = await articlesService.GetCategoryAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddArticleModel model)
        {                    
            if (!ModelState.IsValid)
            {

                model.Categories = await articlesService.GetCategoryAsync();

                return View(model);
            }

            var __UserIdOfAuthor = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var modelEnd = model;
            modelEnd.UserIdOfAuthor = __UserIdOfAuthor;

            try
            {
                await articlesService.AddArticleAsync(modelEnd);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");

                return View(modelEnd);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await articlesService.GetAllAsync();

            return View(model);
        }
    }
}
