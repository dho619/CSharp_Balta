using RoomBooking.Domain.Contracts.Repositories;
using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;

namespace RoomBooking.Console.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetBooksByDataRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
