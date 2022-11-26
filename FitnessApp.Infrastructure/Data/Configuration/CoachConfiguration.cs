using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Infrastructure.Data.Configuration
{
    internal class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.HasData(CreateCoaches());
        }

        private List<Coach> CreateCoaches()
        {
            List<Coach> coaches = new List<Coach>()
            {
                new Coach()
                {
                    Id = 1,
                    UserId="dea12856-c198-4129-b3f3-b893d8395082",
                    FirstName = "Dimitar",
                    LastName = "Petrov",
                    Age = 25
                },

                new Coach()
                {
                    Id = 2,
                    UserId="e4b69fce-458e-4234-be1d-852bebf15846",
                    FirstName = "Dimitar",
                    LastName = "Ivanov",
                    Age = 33
                },

                new Coach()
                {
                    Id = 3,
                    UserId="30b99904-02f5-4465-87a9-f7f12958029a",
                    FirstName = "Ivan",
                    LastName = "Petrov",
                    Age = 40
                }
            };

            return coaches;
        }
    }
}
