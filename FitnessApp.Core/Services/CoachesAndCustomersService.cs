using FitnessApp.Core.Contracts;
using FitnessApp.Infrastructure.Data.Common;
using FitnessApp.Infrastructure.Data.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Services
{
    public class CoachesAndCustomersService : ICoachesAndCustomersService
    {
        private readonly IRepository repo;

        public CoachesAndCustomersService(IRepository _repo)
        {
            repo = _repo;

        }

        public async Task AddCoach(string userIdOfCoach)
        {
            var coach = new Coach()
            {
                UserId = userIdOfCoach
            };
            await repo.AddAsync<Coach>(coach);
            await repo.SaveChangesAsync();
        }

        public async Task AddCustomer(string userIdOfCustomer)
        {
            var customer = new Customer()
            {
                UserId = userIdOfCustomer
            };
            await repo.AddAsync<Customer>(customer);
            await repo.SaveChangesAsync();
        }
    }
}
