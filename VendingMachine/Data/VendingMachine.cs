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
        private Dictionary<int,int> moneyPool = new Dictionary<int, int>();

        public VendingMachine(List<Product> products)
        {
            this.Products = products;
            for(int i = 0; i < DENOMINATIONS.Length; i++)
            {
                moneyPool.Add(DENOMINATIONS[i], 0);
            }

        }

        public Dictionary<int,int> MoneyPool { get => moneyPool; set => moneyPool = value; }
        public List<Product> Products { get => products; set => products = value; }

        public void InsertMoney(int amount)
        {
            if (IsInDenominations(amount))
            {
                int value = MoneyPool.GetValueOrDefault(amount);
                value += amount;
                moneyPool[amount] = value;

            }
            else
            {
                throw new Exception("You must insert a valid denomination.");
            }
        }

        public void Purchase(Product product)
        {
            if (products.Contains(product))
            {
                if (this.TotalAmountOfMoney() >= product.Price)
                {
                    moneyPool[product.Price] -= product.Price;
                    Products.Remove(product);
                }
                else throw new Exception("You have not inserted enough money.");
            }
            else throw new Exception("The product does not exist.");
        }

        public string ShowAll()
        {
            StringBuilder showAll = new StringBuilder();

            foreach (Product prod in Products)
            {
                showAll.AppendLine(prod.Examine());
            }
            return showAll.ToString();
        }

        public Dictionary<int, int> EndTransaction()
        {
            Dictionary<int, int> change = new Dictionary<int, int>();

            foreach(KeyValuePair<int, int> pair in moneyPool)
            {
                if (pair.Value != 0)
                {
                    change.Add(pair.Key, pair.Value);
                }
            }
            return change;
        }


        private int TotalAmountOfMoney()
        {
            int sum = 0;

            foreach(int i in moneyPool.Values)
            {
                sum += i;
            }

            return sum;
        }


        private bool IsInDenominations(int amount)
        {
            for(int i = 0; i < DENOMINATIONS.Length; i++)
            {
                if (amount == DENOMINATIONS[i]) return true;
            }
            return false;
        }

    }
}
