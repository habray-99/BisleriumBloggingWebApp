using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BisleriumBloggingWebApp.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Body { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public int UserID { get; set; }
        public string? ImagePath { get; set; }
        [ForeignKey("UserID")]
        public virtual User? User { get; set; }
    }
}
