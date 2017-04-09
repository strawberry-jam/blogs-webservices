using Microsoft.EntityFrameworkCore;
using Blogs.Models;

namespace Blogs.DataAccess
{
    public class BlogDatabaseContext : DbContext
    {
        public BlogDatabaseContext(DbContextOptions<BlogDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().HasKey(p => new
            {
                p.BlogId,
                p.UserId
            });
        }    
    }
}