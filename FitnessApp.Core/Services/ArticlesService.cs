﻿using FitnessApp.Core.Contracts;
using FitnessApp.Core.Models;
using FitnessApp.Infrastructure.Data.Common;
using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace FitnessApp.Core.Services
{
    public class ArticlesService : IArticlesService
    {
        private readonly IRepository repo;
      
        public ArticlesService(IRepository _repo)
        {
            repo = _repo;
            

        }

        public async Task AddArticleAsync(AddArticleModel model)
        {
       
            var article = new Article()
            {
                Title = model.Title,
                ImageURL = model.ImageURL,
                AuthorId = repo.AllReadonly<Coach>()
                .FirstOrDefault(x => x.UserId == model.UserIdOfAuthor)?.Id ?? 0,
                CategoryId = model.CategoryId,
                Content = model.Content

            };

            await repo.AddAsync<Article>(article);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoryAsync()
        {
            return await repo.All<Category>().ToListAsync();
        }
    }
}
