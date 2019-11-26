using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSearchApplication.Models
{
    public class PostUser
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
