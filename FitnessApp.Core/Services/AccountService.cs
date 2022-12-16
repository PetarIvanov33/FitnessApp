using FitnessApp.Core.Contracts;
using FitnessApp.Core.Models;
using FitnessApp.Infrastructure.Data.Common;
using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace FitnessApp.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository repo;

        public AccountService(IRepository _repo)
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
