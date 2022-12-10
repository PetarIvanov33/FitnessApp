using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Infrastructure.Data.Enities
{
    public class CustomerProgram
    {
        
        public int? ProgramId { get; set; }

        public Program Program { get; set; }

        public int? CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
