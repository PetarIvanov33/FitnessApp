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
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "coach1",
                NormalizedUserName = "COACH1",
                Email = "coach1@mail.com",
                NormalizedEmail = "COACH@MAIL.COM",
                PhoneNumber = "0123456789",
                ProfileImageURL = "https://media-exp1.licdn.com/dms/image/C4E03AQEZzVQV_QkXxA/profile-displayphoto-shrink_800_800/0/1607428598966?e=2147483647&v=beta&t=0usI7YAARf7h56Xdo_bv6xpYtc9y7pUfD7boyRXD9jk",
                FirstName = "Stanislav",
                LastName = "Chakurov",
                Age=25
            };

            user.PasswordHash =
                hasher.HashPassword(user, "coach_1");

            users.Add(user);

            user = new User()
            {
                Id = "e4b69fce-458e-4234-be1d-852bebf15846",
                UserName = "coach2",
                NormalizedUserName = "COACH2",
                Email = "coach2@mail.com",
                NormalizedEmail ="COACH2@MAIL.COM",
                PhoneNumber = "0222222222",
                ProfileImageURL = "https://media-exp1.licdn.com/dms/image/D4D03AQF2P7FxDvXL_w/profile-displayphoto-shrink_800_800/0/1665589049799?e=2147483647&v=beta&t=UaIubCn4CURIDtu8ZFqW--yzRz0fesLnjAeqUf_iaY0",
                FirstName = "Nikola",
                LastName = "Tomov",
                Age = 30
            };

            user.PasswordHash =
                hasher.HashPassword(user, "coach_2");

            users.Add(user);

            user = new User()
            {
                Id = "30b99904-02f5-4465-87a9-f7f12958029a",
                UserName = "admin1",
                NormalizedUserName = "ADMIN1",
                Email = "admin1@mail.com",
                NormalizedEmail = "ADMIN1@MAIL.COM",
                PhoneNumber = "0884810188",
                FirstName = "Petar",
                LastName = "Ivanov",
                Age = 33
            };

            user.PasswordHash =
                hasher.HashPassword(user, "admin_1");

            users.Add(user);

            user = new User()
            {
                Id = "f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                UserName = "client1",
                NormalizedUserName = "CLIENT1",
                Email = "client1@mail.com",
                NormalizedEmail = "CLIENT1@MAIL.COM",
                PhoneNumber = "0885554888",
                ProfileImageURL = "https://i.ytimg.com/vi/VpQCMU3Q0RU/maxresdefault.jpg",
                FirstName = "Stan",
                LastName = "Subev",
                Age = 29
            };

            user.PasswordHash =
                hasher.HashPassword(user, "client_1");

            users.Add(user);


            user = new User()
            {
                Id = "e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                UserName = "client2",
                NormalizedUserName = "CLIENT2",
                Email = "client2@mail.com",
                NormalizedEmail = "CLIENT2@MAIL.COM",
                PhoneNumber = "0256810188",
                ProfileImageURL = "https://yt3.ggpht.com/ytc/AMLnZu9ZGUZqNxqW_GYK3RGSeuYNdDfqO8M6mBgpRmZjDA=s800-c-k-c0x00ffffff-no-rj",
                FirstName = "Radostin",
                LastName = "Kuzmanov",
                Age = 22
            };

            user.PasswordHash =
                hasher.HashPassword(user, "client_2");

            users.Add(user);

            return users;
        }

    }
}
