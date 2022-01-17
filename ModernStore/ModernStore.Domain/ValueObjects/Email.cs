using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernStore.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            new ValidationContract<Email>(this)
                .IsEmail(x => x.Address, "Email inválido!");
        }

        public String Address { get; private set; }

    }
}
