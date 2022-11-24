using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using FitnessApp.Infrastructure.Data.Enities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Powerlifting"
                                   },

                new Category()
                {
                    Id = 2,
                    Name = "Olimpic weightlifting"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Streetlifting"

                },

                new Category()
                {
                    Id = 4,
                    Name = "Sprint running  brat"
                },

                new Category()
                {
                    Id = 5,
                    Name = "Long-distance running"
                }

             };

            return categories;
        }
    }


    
}
