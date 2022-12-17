using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Infrastructure.Data.Enities;

namespace FitnessApp.Infrastructure.Data.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<Role> CreateRoles()
        {
            var roles = new List<Role>();

            roles.Add(new Role()
            {
                Id = "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            roles.Add(new Role()
            {
                Id = "42196e3c-e72a-4778-994f-36c85380e060",
                Name = "Coach",
                NormalizedName = "COACH"
            });

            roles.Add(new Role()
            {
                Id = "9b325984-c63f-4dec-a00b-eeaab3d34035",
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            });

            return roles;
        }
    }
}
