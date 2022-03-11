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

            context.Users.Add(new User
            {
                Name= "Pedro Teste",
                Bio = "MVP",
                Email = "pedro@teste.com",
                Image = "https://balta.io",
                PasswordHash = "1234",
                Slug = "pedro-teste",
                GitHub= "pedro123"
            });
            
            context.SaveChanges();
        }
    }
}