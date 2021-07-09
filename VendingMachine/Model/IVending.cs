using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    interface IVending
    {
        public void Purchase(Product product);
        public string ShowAll();
        public void InsertMoney(int amount);
        public Dictionary<int, int> EndTransaction();

    }
}
