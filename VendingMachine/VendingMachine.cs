using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class VendingMachine : IVending
    {
        private readonly int[] DENOMINATIONS = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        List<Product> products;
        int amountOfMoney;

        public void InsertMoney(int amount)
        {
            if (IsInDenominations(amount))
            {
                amountOfMoney += amount;
            }
            else
            {
                throw new ArgumentException("You must insert a valid denominaion.");
            }
        }

        public Product Purchase()
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            throw new NotImplementedException();
        }

        private bool IsInDenominations(int amount)
        {
            foreach(int i in DENOMINATIONS)
            {
                if (amount == DENOMINATIONS[i]) return true;
            }
            return false;
        }
    }
}
