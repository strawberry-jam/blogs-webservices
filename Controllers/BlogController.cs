using System;
using Blogs.Models;
using Microsoft.AspNetCore.Mvc;
using Blogs.Services;

namespace Blogs.Controllers
{
    [RouteAttribute("api/v1/blogs/{blogId}")]
    public class BlogController : Blog
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("{blogId}")]
        public Blog Get(string blogId)
        {
            return _blogService.Get(blogId);
        }

        [HttpPost]
        public void Create(Blog blog)
        {
            blog.Id = Guid.NewGuid().ToString();
            _blogService.Create(blog);

        }

        [HttpPut]
        public void Update(Blog blog)
        {
            _blogService.Update(blog);
        }

        [HttpDeleteAttribute("{blogId}")]
        public void Delete(string blogId)
        {
            _blogService.Delete(blogId);
        }
    }
}
