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
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<IdentityUser> CreateUsers()
        {
            var users = new List<IdentityUser>();
            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "coach1",
                NormalizedUserName = "coach1",
                Email = "coach1@mail.com",
                NormalizedEmail = "coach1@mail.com"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "coach_1");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "e4b69fce-458e-4234-be1d-852bebf15846",
                UserName = "coach2",
                NormalizedUserName = "coach2",
                Email = "coach2@mail.com",
                NormalizedEmail = "coach2@mail.com"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "coach_2");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "30b99904-02f5-4465-87a9-f7f12958029a",
                UserName = "coach3",
                NormalizedUserName = "coach3",
                Email = "coach3@mail.com",
                NormalizedEmail = "coach3@mail.com"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "coach_3");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                UserName = "client1",
                NormalizedUserName = "client1",
                Email = "client1@mail.com",
                NormalizedEmail = "client1@mail.com"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "client_1");

            users.Add(user);


            user = new IdentityUser()
            {
                Id = "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                UserName = "client2",
                NormalizedUserName = "client2",
                Email = "client2@mail.com",
                NormalizedEmail = "client2@mail.com"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "client_2");

            users.Add(user);

            return users;
        }

    }
}
