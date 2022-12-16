using FitnessApp.Infrastructure.Data.Configuration;
using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

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

            //foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}

            builder.Entity<User>(u =>
            {
                u.Property(u => u.UserName).HasMaxLength(25).IsRequired();
                u.Property(u => u.NormalizedUserName).HasMaxLength(25);
                u.Property(u => u.Email).HasMaxLength(25).IsRequired();
                u.Property(u => u.NormalizedEmail).HasMaxLength(25);
                u.Property(u => u.PhoneNumber).HasMaxLength(15).IsRequired();
                u.Property(u => u.ProfileImageURL).HasDefaultValue("https://www.pngkey.com/png/detail/115-1150152_default-profile-picture-avatar-png-green.png");
            });

           

            builder.Entity<CustomerProgram>()
               .HasKey(x => new { x.ProgramId, x.CustomerId });

            builder.Entity<CustomerProgram>()
            .HasOne<Program>(sc => sc.Program)
            .WithMany(s => s.CustomerPrograms)
            .HasForeignKey(sc => sc.ProgramId)
            .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<CustomerProgram>()
                .HasOne<Customer>(sc => sc.Customer)
                .WithMany(s => s.CustomerPrograms)
                .HasForeignKey(sc => sc.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

           

            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new CoachConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new ArticleConfiguration());


        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Coach> Coaches { get; set; } = null!;

        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Article> Articles { get; set; } = null!;

        public DbSet<Program> Programs { get; set; } = null!;

        public DbSet<CustomerProgram> CustomersPrograms { get; set; } = null!;

        
    }
}