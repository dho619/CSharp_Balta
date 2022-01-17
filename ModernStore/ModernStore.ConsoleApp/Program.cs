﻿using ModernStore.Domain.Entities;
using ModernStore.Domain.ValueObjects;
using System;

namespace ModernStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new Name("Atim","Cabum");
            var email = new Email("atim@cabum.com");
            var document = new Document("33641846820");//gerado por gerado de CPF
            var user = new User("atimCabum", "atim123");
            var customer = new Customer(name,email,document,user);
            //if (!customer.IsValid())
            //{
            //    foreach (var notification in customer.Notifications)
            //    {
            //        Console.WriteLine(notification.Message);
            //    }
            //}
            //Console.WriteLine(customer.ToString());
            var mouse = new Product("Mouse", 299, "mouse.jpg", 20);
            var mousePad = new Product("Mouse Pad", 99, "mousePad.jpg", 20);
            var teclado = new Product("Teclado", 599, "teclado.jpg", 20);

            Console.WriteLine($"Mouses: {mouse.QuantityOnHand}");
            Console.WriteLine($"Mouse Pads: {mousePad.QuantityOnHand}");
            Console.WriteLine($"Teclados: {teclado.QuantityOnHand}");

            Console.WriteLine("");

            var order = new Order(customer, 8, 10);
            order.AddItem(new OrderItem(mouse, 2));
            order.AddItem(new OrderItem(mousePad, 2));
            order.AddItem(new OrderItem(teclado, 2));

            Console.WriteLine($"Número do Pedido: {order.Number}");
            Console.WriteLine($"Data: {order.CreateDate:dd/MM/yyyy}");
            Console.WriteLine($"Desconto: {order.Discount}");
            Console.WriteLine($"Taxa de Entrega: {order.DeliveryFee}");
            Console.WriteLine($"Sub total: {order.SubTotal()}");
            Console.WriteLine($"Sub total: {order.Total()}");
            Console.WriteLine($"Cliente: {order.Customer.ToString()}");

            Console.WriteLine("");

            Console.WriteLine($"Mouses: {mouse.QuantityOnHand}");
            Console.WriteLine($"Mouse Pads: {mousePad.QuantityOnHand}");
            Console.WriteLine($"Teclados: {teclado.QuantityOnHand}");
        }
    }
}
