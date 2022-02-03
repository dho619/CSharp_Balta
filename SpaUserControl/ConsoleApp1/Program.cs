using SpaUserControl.Domain.Contracts.Repositories;
using SpaUserControl.Domain.Models;
using SpaUserControl.Infraestructure.Repositories;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Dho","dho2@hotmail.com");

            user.SetPassword("dho619", "dho619");
            user.Validate();

            using (IUserRepository userRep = new UserRepository())
            {
                userRep.Create(user);
            }

            using (IUserRepository userRep = new UserRepository())
            {
                var usr = userRep.Get("dho2@hotmail.com");
                Console.WriteLine(usr.Name);
            }
        }
    }
}