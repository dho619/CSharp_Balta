using System;
using Blog.Data.Mappings;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    class BlogDataContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        // public DbSet<PostWithTagsCount> PostWithTagsCount { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder options) {
                options.UseSqlServer("Server=localhost,1433;Database=Blog2;User ID=sa;Password=1q2w3e4r@#$");
                //options.LogTo(Console.WriteLine);
            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            // modelBuilder.Entity<PostWithTagsCount>(x => {
            //     x.ToSqlQuery(@"SELECT p.title as name, COUNT(pt.PostId) count  
            //                 FROM post p 
            //                 inner join PostTag pt on p.id=pt.PostId 
            //                 group by p.title;");
            // });
        }
    }
}