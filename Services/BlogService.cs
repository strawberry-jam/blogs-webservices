using System.Linq;
using Blogs.DataAccess;
using Blogs.Models;

namespace Blogs.Services
{
    public class BlogService : IBlogService
    {
        private readonly BlogDatabaseContext _dbContext;

        public BlogService(BlogDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Blog blog)
        {
            _dbContext.Blogs.Add(blog);
            _dbContext.SaveChanges();
        }

        public void Delete(string blogId)
        {
            var blog = Get(blogId);
            _dbContext.Blogs.Remove(blog);
            _dbContext.SaveChanges();
        }

        public Blog Get(string blogId)
        {
            return _dbContext.Blogs.Where(b => b.Id == blogId)
                                    .FirstOrDefault();
        }

        public void Update(Blog blog)
        {
            _dbContext.Blogs.Add(blog);
            _dbContext.SaveChanges();
        }
    }
}