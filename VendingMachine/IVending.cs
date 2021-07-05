using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public interface IVending
    {
        //public const int[] DENOMINATIONS = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public Product Purchase();
        public void ShowAll();
        public void InsertMoney(int amount);


    }
}
