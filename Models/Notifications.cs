using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BisleriumBloggingWebApp.Models
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public string? NotificationType { get; set; }
        [Required]
        public int EntityID { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("UserID")]
        public virtual User? User { get; set; }
    }
}
