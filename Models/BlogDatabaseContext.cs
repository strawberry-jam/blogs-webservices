using System;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Models
{
    public class BlogDatabaseContext : DbContext
    {
        public BlogDatabaseContext(DbContextOptions<BlogDatabaseContext> options) : base(options)
        { 
            
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}