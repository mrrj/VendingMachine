using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine
{
    class VendingMachine : IVending
    {
        private readonly int[] DENOMINATIONS = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        private List<Product> products;
        private int moneyPool;

        public VendingMachine(List<Product> products, int moneyPool)
        {
            this.Products = products;
            this.MoneyPool = moneyPool;

        }

        public int MoneyPool { get => moneyPool; set => moneyPool = value; }
        public List<Product> Products { get => products; set => products = value; }

        public void InsertMoney(int amount)
        {
            if (IsInDenominations(amount))
            {
                MoneyPool += amount;
            }
            else
            {
                throw new ArgumentException("You must insert a valid denomination.");
            }
        }

        public void Purchase(Product product)
        {
            throw new NotImplementedException();
        }

        public string ShowAll()
        {
            StringBuilder showAll = new StringBuilder();

            foreach(Product prod in Products)
            {
                showAll.AppendLine(prod.Examine());
            }
            
            return showAll.ToString();
        }

        Dictionary<Product, int> EndTransaction()
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
