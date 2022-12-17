using FitnessApp.Infrastructure.Data.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Contracts
{
    public interface IRoleService
    { 
        Task<Role> GetRole(string roleName);

        Task AddToRole(User user, string roleName);

    }
}
