using FitnessApp.Infrastructure.Data.Configuration;
using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<User>(u =>
            {
                u.Property(u => u.UserName).HasMaxLength(25).IsRequired();
                u.Property(u => u.NormalizedUserName).HasMaxLength(25);
                u.Property(u => u.Email).HasMaxLength(25).IsRequired();
                u.Property(u => u.NormalizedEmail).HasMaxLength(25);
                u.Property(u => u.PhoneNumber).HasMaxLength(15).IsRequired();
            });

            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new CoachConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());


        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Coach> Coaches { get; set; } = null!;

        public DbSet<Customer> Customers { get; set; } = null!;

    }
}