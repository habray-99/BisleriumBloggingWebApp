using System.ComponentModel.DataAnnotations;

namespace BisleriumBloggingWebApp.Models
{
    public class ReactionType
    {
        [Key]
        public int ReactionTypeID { get; set; }
        [Required]
        public string? ReactionName { get; set; }
    }
}
