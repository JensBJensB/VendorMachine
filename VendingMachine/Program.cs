using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using VendingMachine.Models;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] denominations = { 1, 5, 10, 20, 50, 100, 500, 1000 };
            ReadOnlyCollection<int> ar = Array.AsReadOnly(denominations);
            

        }
    }
}



