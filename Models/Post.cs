using System;

namespace Blogs.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string BlogId { get; set; }
        public string AuthorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public DateTime PublishTime { get; set; }
        
    }
}