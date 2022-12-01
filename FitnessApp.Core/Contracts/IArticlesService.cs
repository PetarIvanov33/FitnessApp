using FitnessApp.Core.Models;
using FitnessApp.Infrastructure.Data.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Contracts
{
    public interface IArticlesService
    {
        Task AddArticleAsync(AddArticleModel model);

        Task<IEnumerable<Category>> GetCategoryAsync();
    }
}
