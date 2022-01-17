using ModernStore.Shared.Commands;
using System;
using System.Collections.Generic;

namespace ModernStore.Domain.Commands
{
    public class RegisterOrderCommand : ICommand
    {
        public Guid Customer { get; set; }
        public Decimal DeliveryFee { get; set; }
        public Decimal Discount { get; set; }
        public IEnumerable<RegisterOrderItemCommand> Items { get; set; }
    }
}
