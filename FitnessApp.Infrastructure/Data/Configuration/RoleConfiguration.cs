using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Infrastructure.Data.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<IdentityRole> CreateRoles()
        {
            var roles = new List<IdentityRole>();

            roles.Add(new IdentityRole()
            {
                Id = "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            roles.Add(new IdentityRole()
            {
                Id = "42196e3c-e72a-4778-994f-36c85380e060",
                Name = "Coach",
                NormalizedName = "COACH"
            });

            roles.Add(new IdentityRole()
            {
                Id = "9b325984-c63f-4dec-a00b-eeaab3d34035",
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            });

            return roles;
        }
    }
}
