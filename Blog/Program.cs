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

            // context.Users.Add(new User
            // {
            //     Name= "Marcos Teste",
            //     Bio = "9x Microsoft MVP",
            //     Email = "marcos@teste.com",
            //     Image = "https://balta.io",
            //     PasswordHash = "1234",
            //     Slug = "marcos-teste"
            // });

            var user = context.Users.FirstOrDefault();
            var post = new Post {
                Author = user,
                Body = "Meu artigo",
                Category = new Category{
                    Name="Backend mvp",
                    Slug="backend-mvp"
                },
                CreateDate = System.DateTime.Now,
                Slug = "meu-artigo",
                Summary = "Neste artigo vamos conferir",
                Title = "Meu artigo",
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}