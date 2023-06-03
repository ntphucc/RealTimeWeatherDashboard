using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entity
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        public ICollection<Location> Locations { get; set; }
    }
}
