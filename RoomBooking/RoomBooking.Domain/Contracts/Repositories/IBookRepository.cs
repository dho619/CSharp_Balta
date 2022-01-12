using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;

namespace RoomBooking.Domain.Contracts.Repositories
{
    public interface IBookRepository : IDisposable
    {
        IList<Book> GetBooksByDataRange(DateTime startDate, DateTime endDate);
    }
}
