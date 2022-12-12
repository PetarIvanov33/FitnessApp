using FitnessApp.Core.Models;
using FitnessApp.Infrastructure.Data.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Contracts
{
    public interface IProgramsService
    {
        Task<IEnumerable<Category>> GetCategoryAsync();

        Task AddProgramAsync(AddProgramModel model);

        Task<IEnumerable<DisplayedProgramContent>> GetAllAsync();

        Task<IEnumerable<DisplayedProgramContent>> GetAllForThisCoachAsync(string idOfCurrentUser);

        Task<byte[]> ExportProgram(int id);

        Task DeleteProgram(int id);

        Task<AddProgramModel> GetLikeAddProgramModel(int id);

        Task EditProgramAsync(int id, AddProgramModel model);

    }
}
