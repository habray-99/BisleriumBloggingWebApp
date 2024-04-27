using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BisleriumBloggingWebApp.Models
{
    public class UserMetric
    {
        [Key]
        public int UserMetricID { get; set; }
        [Required]
        public int UserID { get; set; }
        public int TotalBlogPosts { get; set; }
        public int TotalUpvotes { get; set; }
        public int TotalDownvotes { get; set; }
        public int TotalComments { get; set; }
        [ForeignKey("UserID")]
        public virtual User? User { get; set; }
    }
}
