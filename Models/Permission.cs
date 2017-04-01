using System;

namespace Blogs.Models
{
    public class Permission
    {
        public User User { get; set; }
        public Blog Blog { get; set; }
        public string Type { get; set; }
    }
}