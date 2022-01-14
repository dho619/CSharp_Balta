using FluentValidator;
using ModernStore.Shared.Entities;
using System;
using System.Collections.Generic;

namespace ModernStore.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string firstName, string lastName, string email, User user)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = null;
            Email = email;
            User = user;

            //Validações
            new ValidationContract<Customer>(this)
                .IsRequired(x => x.FirstName, "Nome é obrigatório!")
                .HasMaxLenght(x => x.FirstName, 60)
                .HasMinLenght(x => x.FirstName, 3)
                .IsRequired(x => x.LastName, "Sobrenome é obrigatório!")
                .HasMaxLenght(x => x.LastName, 60)
                .HasMinLenght(x => x.LastName, 3)
                .IsEmail(x => x.Email, "Email inválido!");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime? BirthDay { get; private set; }
        public string Email { get; private set; }
        public User User { get; private set; }

        public void Update(string firstName, string lastName, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
