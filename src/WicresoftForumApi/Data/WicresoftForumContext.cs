using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace WicresoftForumApi.Data
{
    public class WicresoftForumContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<PostType> PostTypes { get; set; }

        public WicresoftForumContext(DbContextOptions<WicresoftForumContext> options)
        : base(options)
        {
        }
    }
}
