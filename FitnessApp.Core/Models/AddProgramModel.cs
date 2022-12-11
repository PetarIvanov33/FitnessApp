using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Models
{
    public class AddProgramModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(400)]
        public string ImageURL { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), "0.0", "200.0", ConvertValueInInvariantCulture = true)]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public IFormFile Content { get; set; } = null!;

        public string? UserIdOfAuthor { get; set; }

    }
}
