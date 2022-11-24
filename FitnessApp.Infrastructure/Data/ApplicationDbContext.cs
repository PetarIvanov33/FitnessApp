using FitnessApp.Infrastructure.Data.Configuration;
using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; } = null!;
    }
}