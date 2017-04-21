using System.Linq;
using Blogs.DataAccess;
using Blogs.Models;

namespace Blogs.Services
{
    public class PostService : IPostService
    {
        private readonly BlogDatabaseContext _dbContext;

        public PostService(BlogDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Create(string blogId, Post post)
        {
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();
        }

        public void Delete(string blogId, string id)
        {
            var post = Get(blogId, id);
            _dbContext.Posts.Remove(post);
            _dbContext.SaveChanges();
        }

        public Post Get(string blogId, string postId)
        {
            return _dbContext.Posts.Where(p => p.BlogId == blogId)
                                   .Where(p => p.Id == postId)
                                   .FirstOrDefault();
        }

        public void Update(string blogId, Post post)
        {
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();
        }
    }
}