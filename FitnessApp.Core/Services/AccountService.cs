﻿using FitnessApp.Core.Contracts;
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
    }
}