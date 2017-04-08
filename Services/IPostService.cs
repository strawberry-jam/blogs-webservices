using Blogs.Models;

namespace Blogs.Services
{
    public interface IPostService
    {
        Post Get(string blogId, string postId);
        void Create(string BlogId, Post post);
        void Update(string blogId, Post post);
        void Delete(string blogId, string postId); 
    }
}