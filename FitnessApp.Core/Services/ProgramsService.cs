using FitnessApp.Core.Contracts;
using FitnessApp.Core.Models;
using FitnessApp.Infrastructure.Data.Common;
using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Services
{
    public class ProgramsService : IProgramsService
    {
        private readonly IRepository repo;

        public ProgramsService(IRepository _repo)
        {
            repo = _repo;

        }

        public async Task AddProgramAsync(AddProgramModel model)
        {

            if (model.Content != null)
            {
                if (model.Content.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(model.Content.FileName);
                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);
                    // concatenating  FileName + FileExtension
                    var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);

                    var obj = new Program()
                    {
                        Title = model.Title,
                        ImageURL = model.ImageURL,
                        Price = model.Price,
                        AuthorId = repo.AllReadonly<Coach>()
                       .FirstOrDefault(x => x.UserId == model.UserIdOfAuthor)?.Id ?? 0,
                        CategoryId = model.CategoryId,
                        ContentFileType = fileExtension,
                        ContentFileName = newFileName
                    };

                    using (var target = new MemoryStream())
                    {
                        model.Content.CopyTo(target);
                        obj.Content = target.ToArray();
                    }

                    await repo.AddAsync<Program>(obj);
                    await repo.SaveChangesAsync();
                }
            }
            
        }

        public async Task<byte[]> ExportProgram(int id)
        {
           var export = await repo.All<Program>()
                .FirstOrDefaultAsync(x => x.Id == id);

            return export.Content;
        }

        public async Task<IEnumerable<Category>> GetCategoryAsync()
        {
            return await repo.All<Category>().ToListAsync();
        }
    }
}
