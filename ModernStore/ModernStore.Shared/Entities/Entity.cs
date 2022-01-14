using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernStore.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        protected Entity()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }
    }
}
