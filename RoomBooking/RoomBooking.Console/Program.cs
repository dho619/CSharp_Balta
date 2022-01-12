//using RoomBooking.Console.Repositories;
//using RoomBooking.Console.Services;
//using RoomBooking.Domain.Contracts.Repositories;
//using RoomBooking.Domain.Contracts.Services;
using RoomBooking.Domain.Entities;
//using Unity;
//using Unity.Lifetime;
using System;
using System.Collections.Generic;

namespace RoomBooking.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new UnityContainer();
            //container.RegisterType<IBookRepository, BookRepository>(new HierarchicalLifetimeManager());
            //container.RegisterType<IBookService, BookService>(new HierarchicalLifetimeManager());

            //var bookRepository = container.Resolve<IBookRepository>();
            //var bookService = container.Resolve<IBookService>();

            //var room = new Room(DateTime.Now, DateTime.Now.AddHours(8), "Sala 1");
            //// roomRepository.Get...
            //// Ou vinda da tela do MVC
            //bookService.PlaceBook(DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), room.Id);

            //Criar uma sala
            var room = new Room(DateTime.Now.AddHours(1), DateTime.Now.AddHours(8), "Sala 2");
            System.Console.WriteLine("Criando uma sala");

            //Iniciar uma reserva
            var book = new Book(room, DateTime.Now.AddHours(4), DateTime.Now.AddHours(4));
            System.Console.WriteLine("Iniciando uma reserva");

            //Confirmar a reserva
            book.Confirm(new List<DateTime>(), new List<DateTime>());
            System.Console.WriteLine("Status da Reserva: " + book.Status);

            // Marcar como em progresso
            // O usuário chegou para usar a sala
            book.MarkInProgress();
            System.Console.WriteLine("Status da Reserva: " + book.Status);

            // Marcar como em Completa
            // O usuário saiu da sala
            book.MarkAsCompleted();
            System.Console.WriteLine("Status da Reserva: " + book.Status);

            System.Console.Read();
        }
    }
}
