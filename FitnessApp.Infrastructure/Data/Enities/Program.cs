using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Infrastructure.Data.Enities
{
    public class Program
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(400)]
        public string ImageURL { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Coach Author { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        [Required]
        [MaxLength(200)]
        public string ContentFileName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string ContentFileType { get; set; } = null!;

        [MaxLength]
        public byte[] Content { get; set; }

        public List<CustomerProgram> CustomerPrograms { get; set; } = new List<CustomerProgram>();
    }
}
