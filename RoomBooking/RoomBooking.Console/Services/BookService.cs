using RoomBooking.Domain.Contracts.Services;
using System;

namespace RoomBooking.Console.Services
{
    /// <summary>
    /// Orquestra a reserva de uma sala
    /// </summary>
    /// <remarks>
    /// Recupera a sala
    /// Tenta efetuar a reserva
    /// Notifica o usuário
    /// </remarks>
    public class BookService : IBookService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void PlaceBook(DateTime startDate, DateTime endDate, Guid room)
        {
            throw new NotImplementedException();
        }
    }
}
