using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BisleriumBloggingWebApp.Models
{
    public class BlogMetric
    {
        [Key]
        public int BlogMetricID { get; set; }
        [Required]
        public int BlogID { get; set; }
        public int TotalUpvotes { get; set; }
        public int TotalDownvotes { get; set; }
        public int TotalComments { get; set; }
        [ForeignKey("BlogID")]
        public virtual Blog? Blog { get; set; }
    }
}
