using System;
using System.Collections.Generic;
using System.Text;

namespace RoomBooking.Domain.Contracts.Services
{
    public interface IBookService : IDisposable
    {
        /// <summary>
        /// Orquestra a reserva de uma sala
        /// </summary>
        /// <remarks>
        /// Recupera a sala
        /// Tenta efetuar a reserva
        /// Notifica o usuário
        /// </remarks>
        void PlaceBook(DateTime startDate, DateTime endDate, Guid room);
    }
}
