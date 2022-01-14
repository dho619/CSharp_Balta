using ModernStore.Domain.Entities;
using System;

namespace ModernStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("atimCabum", "atim");
            var customer = new Customer(
                "a", 
                "a", 
                null, 
                "atimcabum.com", 
                user);

            if (!customer.IsValid())
            {
                foreach (var notification in customer.Notifications)
                {
                    Console.WriteLine(notification.Message);
                }
            }
            Console.WriteLine(customer.ToString());
        }
    }
}
