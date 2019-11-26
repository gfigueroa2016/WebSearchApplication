using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSearchApplication.Models;

namespace WebSearchApplication.Data
{
    public class WebsiteContext : DbContext
    {
        public WebsiteContext(DbContextOptions<WebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostUser>()
                .HasKey(pu => new { pu.PostId, pu.UserId });
            modelBuilder.Entity<PostUser>()
                .HasOne(pu => pu.Post)
                .WithMany(p => p.PostUsers)
                .HasForeignKey(pu => pu.PostId);
            modelBuilder.Entity<PostUser>()
                .HasOne(pu => pu.User)
                .WithMany(u => u.PostUsers)
                .HasForeignKey(pu => pu.UserId);
        }

        public DbSet<WebSearchApplication.Models.PostUser> PostUser { get; set; }
    }
}
