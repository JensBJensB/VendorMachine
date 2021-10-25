using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Reading : Product
    {
        public Reading(string name, int price, string type) :base(name, price)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentException("Product must have a type.");

            Type = type;
        }

        public string Type { get; }

        public new string Examine()
        {
            return base.Examine() + $"\nType: {Type}";
        }
    }
}
