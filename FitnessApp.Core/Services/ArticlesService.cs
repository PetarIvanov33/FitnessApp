using FitnessApp.Core.Contracts;
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

        public async Task DeleteArticle(int id)
        {
            await repo.DeleteAsync<Article>(id);
            await repo.SaveChangesAsync();
        }

        public async Task EditArticleAsync(int id_, AddArticleModel model)
        {
            var article = await repo.All<Article>()
                .Include(x => x.Category)
                .Include(x => x.Author)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id_);

            article.Title = model.Title;
            article.ImageURL = model.ImageURL;
            article.CategoryId = model.CategoryId;
            article.Content = model.Content;

           await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<DisplayedArticleContent>> GetAllAsync()
        {
            
            var entities = await repo.All<Article>()
                .Include(x => x.Category)
                .Include(x => x.Author)
                .ThenInclude(x => x.User)
                .ToListAsync();

            return entities.Select(x => new DisplayedArticleContent()
            {
                ArticleId = x.Id,
                Titel = x.Title,
                ImageURL = x.ImageURL,
                Author = $"{x.Author.User.FirstName} {x.Author.User.LastName}",
                Category = x.Category.Name,
                Content = x.Content
            });

        }

        public async Task<DisplayedArticleContent> GetAllForThisArticle(int id_)
        {
            var article = await repo.All<Article>()
                .Include(x => x.Category)
                .Include(x => x.Author)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id_);

            return new DisplayedArticleContent()
            {
                ArticleId = article.Id,
                Titel = article.Title,
                ImageURL = article.ImageURL,
                Author = $"{article.Author.User.FirstName} {article.Author.User.LastName}",
                AuthorUserId = article.Author.User.Id,
                Category = article.Category.Name,
                Content = article.Content

            };
                
        }

        public async Task<IEnumerable<DisplayedArticleContent>> GetAllForThisCoachAsync(string idOfCurrentUser)
        {
            var entities = await repo.All<Article>()
                .Include(x => x.Category)
                .Include(x => x.Author)
                .ThenInclude(x => x.User)
                .Where(x => x.Author.UserId == idOfCurrentUser)
                .ToListAsync();


            return entities.Select(x => new DisplayedArticleContent()
            {
                ArticleId = x.Id,
                Titel = x.Title,
                ImageURL = x.ImageURL,
                Author = $"{x.Author.User.FirstName} {x.Author.User.LastName}",
                Category = x.Category.Name,
                Content = x.Content
            });
        }

        public async Task<IEnumerable<Category>> GetCategoryAsync()
        {
            return await repo.All<Category>().ToListAsync();
        }

        public async Task<AddArticleModel> GetLikeAddArticleModel(int id_)
        {
            var article = await repo.All<Article>()
                .Include(x => x.Category)
                .Include(x => x.Author)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id_);

            return new AddArticleModel()
            {
                Title = article.Title,
                ImageURL = article.ImageURL,
                UserIdOfAuthor = article.Author.UserId,
                CategoryId = article.CategoryId,
                Content = article.Content,
                Categories = await GetCategoryAsync(),

            };
        }


    }
}
