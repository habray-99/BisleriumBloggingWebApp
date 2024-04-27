using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BisleriumBloggingWebApp.Models
{
    public class Reaction
    {
        [Key]
        public int ReactionID { get; set; }
        [Required]
        public int BlogID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int ReactionTypeID { get; set; }
        [ForeignKey("BlogID")]
        public virtual Blog? Blog { get; set; }
        [ForeignKey("UserID")]
        public virtual User? User { get; set; }
        [ForeignKey("ReactionTypeID")]
        public virtual ReactionType? ReactionType { get; set; }
    }
}
