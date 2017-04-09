using Blogs.Models;

namespace Blogs.Services
{
    public interface IBlogService
    {
        Blog Get(string blogId);
        void Create(Blog blog);
        void Update(Blog blog);
        void Delete(string blogId); 
    }
}