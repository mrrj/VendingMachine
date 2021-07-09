using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine
{
    class VendingMachine : IVending
    {
        private readonly int[] DENOMINATIONS = { 1000, 500, 100, 50, 20, 10, 5, 1 }; 
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
            if (products.Contains(product))
            {
                if (moneyPool >= product.Price)
                {
                    moneyPool -= product.Price;
                    Products.Remove(product);
                }
                else throw new Exception("You have not inserted enough money.");
            }
            else throw new Exception("The product does not exist.");
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

        public Dictionary<int, int> EndTransaction()
        {
            Dictionary<int, int> changeInDenominaions = new Dictionary<int, int>();

            for (int i = 0; i < DENOMINATIONS.Length)
            {
                int denomination = DENOMINATIONS[i];
                int numberOfCoins = moneyPool % DENOMINATIONS[i];
                changeInDenominaions.Add(denomination, numberOfCoins);
            }

            return changeInDenominaions;
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
