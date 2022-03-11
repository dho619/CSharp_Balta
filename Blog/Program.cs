using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        //static async Task Main(string[] args)
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // var posts = await context.Posts.ToListAsync();
            // var users = await context.Users.ToListAsync();

            //var posts = await GetPosts(context);
            var posts1 = GetPosts2(context, 0, 25);
            var posts2 = GetPosts2(context, 25, 25);

            var posts = context
                .Posts
                .Include(x => x.Author)
                    .ThenInclude(x => x.Roles)
                .Include(x => x.Category)
                .ToListAsync();
            
            // var countPosts = context.PostWithTagsCount.ToList();

            Console.WriteLine("Teste");
        }

        public static async Task<List<Post>> GetPosts(BlogDataContext context)
        {
            return await context.Posts.ToListAsync();
        }

        public static List<Post> GetPosts2(BlogDataContext context, int skip = 0, int take = 25){
            var posts = context
                .Posts
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToList();
            return posts;
        }
    }
}