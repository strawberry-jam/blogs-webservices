using Microsoft.EntityFrameworkCore;
using Blogs.Models;

namespace Blogs.DataAccess
{
    public class BlogDatabaseContext : DbContext
    {
        public BlogDatabaseContext()
        {

        }

        public BlogDatabaseContext(DbContextOptions<BlogDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}