using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BisleriumBloggingWebApp.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [Required]
        public int BlogID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public string? CommentText { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("BlogID")]
        public virtual Blog? Blog { get; set; }
        [ForeignKey("UserID")]
        public virtual User? User { get; set; }
    }
}
