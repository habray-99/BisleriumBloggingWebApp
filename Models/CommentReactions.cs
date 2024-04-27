using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BisleriumBloggingWebApp.Models
{
    public class CommentReaction
    {
        [Key]
        public int CommentReactionID { get; set; }
        [Required]
        public int CommentID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int ReactionTypeID { get; set; }
        [ForeignKey("CommentID")]
        public virtual Comment? Comment { get; set; }
        [ForeignKey("UserID")]
        public virtual User? User { get; set; }
        [ForeignKey("ReactionTypeID")]
        public virtual ReactionType? ReactionType { get; set; }
    }
}
