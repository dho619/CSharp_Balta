using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();            

            // var user = new User
            // {
            //     Name = "Teste",
            //     Slug = "teste",
            //     Email = "teste@teste.com",
            //     Bio = "teste de bio",
            //     Image = "https://balta.io",
            //     PasswordHash = "123456789"
            // };

            // var category = new Category{Name="Backend", Slug="backend"};

            // var post = new Post
            // {
            //     Author=user,
            //     Category=category,
            //     Body="<p>Hello Word</p>",
            //     Slug="comecando-com-ef-core",
            //     Summary="Neste artigo vamos aprender EF core",
            //     Title="Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now           
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            // var posts = context
            //     .Posts
            //     .AsNoTracking()
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     //    .ThenInclude(x => x.) //faz um subselect
            //     .OrderBy(x=> x.LastUpdateDate)
            //     .ToList();
            // foreach (var post in posts)
            // {
            //     Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
            // }

            var post = context
                .Posts
                .Include(x => x.Author)
                .Include(x => x.Category)
                .OrderByDescending(x=> x.LastUpdateDate)
                .FirstOrDefault(); //Pegando o primeiro
            
            post.Author.Name = "Teste Jr";
            context.Posts.Update(post);
            context.SaveChanges();
        }
    }
}