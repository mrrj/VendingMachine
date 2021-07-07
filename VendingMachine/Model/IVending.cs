using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    interface IVending
    {
        public Product Purchase();
        public string ShowAll();
        public void InsertMoney(int amount);
        //public Dictionary<> EndTransaction()

    }
}
