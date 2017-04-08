using Blogs.Models;

namespace Blogs.Services
{
    public interface IPostServices
    {
        Post Get(string id);
        void Create(Post post);
        void Update(Post post);
        void Delete(string id); 
    }
}