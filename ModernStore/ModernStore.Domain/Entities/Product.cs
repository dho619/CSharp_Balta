using ModernStore.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernStore.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string tittle, decimal price, string image, int quantityOnHand)
        {
            Tittle = tittle;
            Price = price;
            Image = image;
            QuantityOnHand = quantityOnHand;
        }

        public string Tittle { get; private set; }
        public decimal Price { get; private set; }
        public string Image { get; private set; }
        public int QuantityOnHand { get; private set; }

        public void DecreaseQuantity(int quantity) => QuantityOnHand -= quantity;

    }
}
