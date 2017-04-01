using System;
using System.Collections.Generic;

namespace Blogs.Models 
{
    public class Blog 
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public User Owner { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}