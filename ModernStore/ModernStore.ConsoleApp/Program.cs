using ModernStore.Domain.Entities;
using ModernStore.Domain.Repositories;
using ModernStore.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace ModernStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateOrder(
                new FakeCustomerRepository(),
                new FakeProductRepository(),
                Guid.NewGuid(),
                new Dictionary<Guid, int> { { Guid.NewGuid(), 5 } },
                10,
                20);
        }

        public static void GenerateOrder(
            ICustomerRepository customerRepository,
            IProductRepository productRepository,
            Guid userId,
            IDictionary<Guid, int> items,
            decimal deliveryFee,
            decimal discount)
        {
            var customer = customerRepository.GetByUserId(userId);

            var order = new Order(customer, deliveryFee, discount);

            foreach (var item in items)
            {
                var product = productRepository.Get(item.Key);
                order.AddItem(new OrderItem(product, item.Value));
            }

            Console.WriteLine($"Número do Pedido: {order.Number}");
            Console.WriteLine($"Data: {order.CreateDate:dd/MM/yyyy}");
            Console.WriteLine($"Desconto: {order.Discount}");
            Console.WriteLine($"Taxa de Entrega: {order.DeliveryFee}");
            Console.WriteLine($"Sub total: {order.SubTotal()}");
            Console.WriteLine($"Sub total: {order.Total()}");
            Console.WriteLine($"Cliente: {order.Customer.Name.ToString()}");
        }
    }

    public class FakeProductRepository : IProductRepository
    {
        public Product Get(Guid id)
        {
            return new Product("Mouse", 299, "mouse.jpg", 20);
        }
    }

    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer Get(Guid id)
        {
            return null;
        }

        public Customer GetByUserId(Guid id)
        {
            return new Customer(
                new Name("Atim", "Cabum"), 
                new Email("atim@cabum.com"), 
                new Document("33641846820"), 
                new User("atimCabum", "atim"));
        }
    }
}
