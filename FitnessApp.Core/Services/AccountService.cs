using FitnessApp.Core.Contracts;
using FitnessApp.Core.Models;
using FitnessApp.Infrastructure.Data.Common;
using FitnessApp.Infrastructure.Data.Enities;
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

        public async Task<IEnumerable<DisplayeUsersModel>> GetAllCoaches()
        {
            var users = await GetAllUsersAsync();
            var coaches = users.Where(x => x.Role == "Coach").ToList();

            return coaches;
        }

        public async Task<IEnumerable<DisplayeUsersModel>> GetAllCustomers()
        {
            var users = await GetAllUsersAsync();
            var customers = users.Where(x => x.Role == "Customer").ToList();

            return customers;
        }

        public async Task<IEnumerable<DisplayeUsersModel>> GetAllUsersAsync()
        {
            var users = await (from user in repo.All<User>()
                               join userRoles in repo.All<UserRole>()
                               on user.Id equals userRoles.UserId
                               join role in repo.All<Role>()
                               on userRoles.RoleId equals role.Id
                               where role.Name != "Admin"
                               select new DisplayeUsersModel()
                               {
                                   UserId = user.Id,
                                     ProfileImageURL = user.ProfileImageURL,
                                   FirstName = user.FirstName,
                                   LastName = user.LastName,
                                   Age = user.Age,
                                   UserName = user.UserName,
                                   Email = user.Email,
                                   PhoneNumber = user.PhoneNumber,
                                   Role = role.Name
                               })
                        .ToListAsync();
            return users;
        }

        public async Task<DisplayeUsersModel> GetCurrentUserProfile(string idOfCurrentUser)
        {
            var customers = await GetAllUsersAsync();

            return customers.First(x => x.UserId == idOfCurrentUser);
        }

        public async Task DeleteCustomer(string idOfCurrentUser)
        {           
            var customer = await repo.All<Customer>()
                .Include(x => x.CustomerPrograms)
                .FirstOrDefaultAsync(x => x.UserId == idOfCurrentUser);

            repo.DeleteRange(customer.CustomerPrograms);

            await repo.DeleteAsync<User>(idOfCurrentUser);

            await repo.SaveChangesAsync();
        }
    }
}
