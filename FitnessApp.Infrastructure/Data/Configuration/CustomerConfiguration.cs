using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Infrastructure.Data.Configuration
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(CreateCustomers());
        }

        private List<Customer> CreateCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                 new Customer()
                {
                    Id = 1,
                    UserId="f17f9cb5-f8ca-4462-85ff-ca3f59136189",
                    FirstName = "Dimitar",
                    LastName = "Marinov",
                    Age = 18
                },

                new Customer()
                {
                    Id = 2,
                    UserId="e999e7c1-d7e5-4fa4-a358-a54b3a3732a2",
                    FirstName = "Emil",
                    LastName = "Krustev",
                    Age = 22
                }
            };

            return customers;
        }
    }
}
