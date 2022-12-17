using FitnessApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Contracts
{
    public interface IAccountService
    {
        Task AddCustomer(string userIdOfCustomer);

        Task AddCoach(string userIdOfCoach);

        Task<IEnumerable<DisplayeUsersModel>> GetAllUsersAsync();
    }
}
