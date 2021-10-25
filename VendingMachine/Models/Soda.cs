using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    public class Soda : Product
    {
        private int calories;

        public Soda(string name, int price, int calories) : base(name, price)
        {
    if (price <= 0)
        throw new ArgumentException("You wish.");
    Calories = calories;
}

public int Calories
{
    get { return calories; }
    private set
    {
        if (value <= 0)
            throw new ArgumentException("You wish.");
        calories = value;
    }
}

public new string Examine()
{
    return base.Examine() + $"\nCalories: {Calories}";
}

    }
}