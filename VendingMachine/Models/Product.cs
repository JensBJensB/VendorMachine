using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public abstract class Product 
    {
        public int Price { get; }
        public string Name { get; }

        public Product (string name, int price)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Product got no name");
            if (price <= 0)
                throw new ArgumentException("Hey, ain't nothing free in this world.");

            Name = name;
            Price = price;
        }
        public string Examine()
        {
            return $"(\n{Name} \n{Price})";
        }
    }
}


