using System;
using Blogs.Models;
using Microsoft.AspNetCore.Mvc;
using Blogs.Services;

namespace Blogs.Controllers
{
    [RouteAttribute("api/v1/blogs/{blogId}/posts")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("{postId}")]
        public Post Get(string blogId, string postId)
        {
            return _postService.Get(blogId, postId);
        }

        [HttpPost]
        public void Create(string blogId, Post post)
        {
            post.Id = Guid.NewGuid().ToString();
            _postService.Create(blogId, post);
        }

        [HttpPut]
        public void Update(string blogId, Post post)
        {
            _postService.Update(blogId, post);
        }

        [HttpDelete("{id}")]
        public void Delete(string blogId, string postId)
        {
            _postService.Delete(blogId, postId);
        }
    }
}