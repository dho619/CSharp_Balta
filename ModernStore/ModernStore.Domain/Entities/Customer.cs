using FluentValidator;
using ModernStore.Domain.ValueObjects;
using ModernStore.Shared.Entities;
using System;
using System.Collections.Generic;

namespace ModernStore.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(Name name, Email email, Document document, User user)
        {
            Name = name;
            BirthDay = null;
            Email = email;
            Document = document;
            User = user;

            AddNotifications(name.Notifications);
            AddNotifications(email.Notifications);
            AddNotifications(document.Notifications);
        }

        public Name Name { get; private set; }
        public DateTime? BirthDay { get; private set; }
        public Email Email { get; private set; }
        public Document Document { get; private set; }
        public User User { get; private set; }

        public void Update(Name name, DateTime birthDay)
        {
            Name = name;
            BirthDay = birthDay;
        }
    }
}
