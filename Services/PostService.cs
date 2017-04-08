using System;
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
        }

        public void Delete(string blogId, string postId)
        {
            throw new NotImplementedException();
        }

        public Post Get(string blogId, string postId)
        {
            return _dbContext.Blogs.Where(b => b.Id == blogId)
                                   .SelectMany(b => b.Posts)
                                   .Where(p => p.Id == postId)
                                   .FirstOrDefault();
        }

        public void Update(string blogId, Post post)
        {
            throw new NotImplementedException();
        }
    }
}