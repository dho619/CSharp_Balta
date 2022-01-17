using ModernStore.Domain.CommandHandlers;
using ModernStore.Domain.Commands;
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
            var command = new RegisterOrderCommand{ 
                Customer = Guid.NewGuid(),
                DeliveryFee = 9,
                Discount = 30,
                Items = new List<RegisterOrderItemCommand>
                {
                    new RegisterOrderItemCommand{
                        Product = Guid.NewGuid(),
                        Quantity = 3
                    }                
                }
            };
            GenerateOrder(
                new FakeCustomerRepository(),
                new FakeProductRepository(),
                new FakeOrderRepository(),
                command);
        }

        public static void GenerateOrder(
            ICustomerRepository customerRepository,
            IProductRepository productRepository,
            IOrderRepository orderRepository,
            RegisterOrderCommand command)
        {

            var handler = new OrderCommandHandler(customerRepository, productRepository, orderRepository);
            handler.Handle(command);

            if (handler.IsValid())
                Console.WriteLine("Pedido cadastrado com Sucesso!");
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

    public class FakeOrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            
        }
    }
}
