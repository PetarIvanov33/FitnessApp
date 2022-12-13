using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Models
{
    public class DisplayedProgramContentForCustomers
    {
        public int ProgramId { get; set; }

        public string Title { get; set; } = null!;

        public string ImageURL { get; set; } = null!;

        public decimal Price { get; set; }

        public string AuthorUserId { get; set; } = null!;

        public int AuthorId { get; set; }

        public string Author { get; set; } = null!; 

        public string Category { get; set; } = null!;   

        public bool IsBought { get; set; }
    }
}
