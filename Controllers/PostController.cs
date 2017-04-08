using System;
using Blogs.Models;
using Microsoft.AspNetCore.Mvc;
using Blogs.Services;

namespace Blogs.Controllers
{
    [RouteAttribute("api/v1/posts")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("{id")]
        public Post Get(string id)
        {
            return _postService.Get(id);
        }

        [HttpPost]
        public void Create(Post post)
        {
            post.Id = Guid.NewGuid().ToString();
            _postService.Create(post);
        }

        [HttpPut]
        public void Update(Post post)
        {
            _postService.Update(post);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _postService.Delete(id);
        }
    }
}