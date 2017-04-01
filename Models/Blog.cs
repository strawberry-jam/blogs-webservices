using System;

namespace Blogs.Models 
{
    public class Blog 
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public User Owner { get; set; }
    }
}