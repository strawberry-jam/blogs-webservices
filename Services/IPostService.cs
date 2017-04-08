using Blogs.Models;

namespace Blogs.Services
{
    public interface IPostService
    {
        Post Get(string id);
        void Create(Post post);
        void Update(Post post);
        void Delete(string id); 
    }
}