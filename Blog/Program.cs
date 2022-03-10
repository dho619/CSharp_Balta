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
            using (var context = new BlogDataContext())
            {
                //CREATE
                // var tag = new Tag { Name="ASP.NET", Slug = "aspnet"};
                // context.Tags.Add(tag);
                // context.SaveChanges();

                //UPDATE
                // var tag = context.Tags.FirstOrDefault(x=> x.Id == 1);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";
                // context.Update(tag);
                // context.SaveChanges();

                //DELETE
                // var tag = context.Tags.FirstOrDefault(x=> x.Id == 1);
                // context.Remove(tag);
                // context.SaveChanges();
                
                // var tags = context
                //     .Tags
                //     .AsNoTracking() //REMOVER METADADOS
                //     //.Where(x => x.Name.Contains(".NET"))
                //     .ToList();

                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                // var tag = context
                //             .Tags
                //             .AsNoTracking()
                //             .FirstOrDefault(x=> x.Id == 2);
                // Console.WriteLine(tag?.Name); //"?" é que como é pra fim o primeiro ou o default, 
                //                              //se não achar o default é nullo, logo o "?" é para não dar erro
            
            }
            
        }
    }
}