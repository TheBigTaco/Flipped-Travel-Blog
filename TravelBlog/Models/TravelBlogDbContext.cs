using System;
using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
    public class TravelBlogDbContext : DbContext
    {
        public TravelBlogDbContext()
        {
        }

        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=TravelBlog;uid=root;pwd=root;");
        }

        public TravelBlogDbContext(DbContextOptions<TravelBlogDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
