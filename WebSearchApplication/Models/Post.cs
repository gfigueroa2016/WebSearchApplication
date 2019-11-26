using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSearchApplication.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public ICollection<PostUser> PostUsers { get; set; }
    }
}
