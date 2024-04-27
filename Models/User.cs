using System.ComponentModel.DataAnnotations;

namespace BisleriumBloggingWebApp.Models
{

    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Role { get; set; }
    }
}
