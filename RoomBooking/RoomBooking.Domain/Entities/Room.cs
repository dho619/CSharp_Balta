using RoomBooking.Domain.Validation;
using System;

namespace RoomBooking.Domain.Entities
{
    public class Room
    {
        public Room(DateTime startDate, DateTime endDate, string title)
        {
            AssertionConcern.AssertArgumentNotNull(startDate, "Horário de ínicio inválido!");
            AssertionConcern.AssertArgumentNotNull(endDate, "Horário de término inválido!");
            AssertionConcern.AssertArgumentLength(title, 3, 40, "O nome da sala deve conter entre 3 e 40 caracteres!");

            this.Id = Guid.NewGuid();
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Title = title;
        }

        public Guid Id { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public String Title { get; private set; }

    }
}
