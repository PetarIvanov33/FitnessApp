using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Infrastructure.Data.Enities
{
    public class Role : IdentityRole
    {
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
