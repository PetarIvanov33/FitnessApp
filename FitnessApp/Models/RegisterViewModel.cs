using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(60, MinimumLength = 10)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [MaxLength(400)]
        public string? ProfileImageURL { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string PhoneNumber { get; set; } = null!;


        [Required]
        [Range(12, 100)]
        public int Age { get; set; }


    }
}
