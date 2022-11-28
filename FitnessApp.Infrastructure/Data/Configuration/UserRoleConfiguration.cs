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
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(CreateUsersRoles());
        }

        private List<IdentityUserRole<string>> CreateUsersRoles()
        {
            var roles = new List<IdentityUserRole<string>>();

            roles.Add(new IdentityUserRole<string>()
            {
                //coach1
                RoleId = "42196e3c-e72a-4778-994f-36c85380e060",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            });

            roles.Add(new IdentityUserRole<string>()
            {
                //coach2
                RoleId = "42196e3c-e72a-4778-994f-36c85380e060",
                UserId = "e4b69fce-458e-4234-be1d-852bebf15846"
            });

            roles.Add(new IdentityUserRole<string>()
            {
                //admin1
                RoleId = "b4656095-c561-4bfa-a5ad-08f7678af1bf",
                UserId = "30b99904-02f5-4465-87a9-f7f12958029a"
            });

            roles.Add(new IdentityUserRole<string>()
            {
                //client1
                RoleId = "9b325984-c63f-4dec-a00b-eeaab3d34035",
                UserId = "f17f9cb5-f8ca-4462-85ff-ca3f59136189"
            });

            roles.Add(new IdentityUserRole<string>()
            {
                //client2
                RoleId = "9b325984-c63f-4dec-a00b-eeaab3d34035",
                UserId = "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2"
            });

            return roles;
        }
    }
}
