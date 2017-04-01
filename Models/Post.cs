using System;

namespace Blogs.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public DateTime PublishTime { get; set; }
        public User Author { get; set; }
        public Blog Blog { get; set; }
    }
}