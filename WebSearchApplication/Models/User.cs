﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSearchApplication.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public ICollection<PostUser> PostUsers { get; set; }
    }
}
