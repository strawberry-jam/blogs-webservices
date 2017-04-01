using System;

namespace Blogs.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime PublishedTime { get; set; }
        public User Author { get; set; }
        public Post Post { get; set; }
    }
}