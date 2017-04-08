using System;
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

        void Create(string blogId, Post post)
        {
            throw new NotImplementedException();
        }

        void Delete(string blogId, string postId)
        {
            throw new NotImplementedException();
        }

        Post Get(string blogId, string postId)
        {
            throw new NotImplementedException();
        }

        void Update(string blogId, Post post)
        {
            throw new NotImplementedException();
        }
    }
}