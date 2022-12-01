using FitnessApp.Infrastructure.Data.Enities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Models
{
    public class AddArticleModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(400)]
        public string ImageURL { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        public string UserIdOfAuthor { get; set; } = null!;

        [Required]
        [MinLength(10)]
        public string Content { get; set; } = null!;
    }
}
