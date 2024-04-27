using Microsoft.EntityFrameworkCore;

namespace BisleriumBloggingWebApp.Models
{
    public class MyDbContext : DbContext // I have a class named MyDbContext which inherits from DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ReactionType> ReactionTypes { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentReaction> CommentReactions { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<BlogMetric> BlogMetrics { get; set; }
        public DbSet<UserMetric> UserMetrics { get; set; }
    }
}
