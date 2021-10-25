using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Models
{
    interface IVending
    {
        void Purchase()
        {
            throw new NotImplementedException();
        }
        void ShowAll()
        {
            throw new NotImplementedException();
        }
        void InsertMoney()
        {
            throw new NotImplementedException();
        }
        void EndTransaction()
        {
            throw new NotImplementedException();
        }
    }

    interface ITest
    {
        void IFoo()
        {
            throw new NotImplementedException();
        }
    }
}
