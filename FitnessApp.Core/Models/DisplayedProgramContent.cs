using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Models
{
    public class DisplayedProgramContent
    {
        public int ProgramId { get; set; }

        public string Title { get; set; }

        public string ImageURL { get; set; }

        public decimal Price { get; set; }

        public string AuthorUserId { get; set; }

        public int AuthorId { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

    }
}
