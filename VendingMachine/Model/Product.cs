using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    abstract class Product
    {
        int price;
        string info;
        string howToUse;

        public Product(int price, string info, string howToUse)
        {
            this.Price = price;
            this.Info = info;
            this.HowToUse = howToUse;
        }

        public int Price { get => price; set => price = value; }
        public string Info { get => info; set => info = value; }
        public string HowToUse { get => howToUse; set => howToUse = value; }

        public string Examine()
        {
            return $"info: {Info}\n price: {Price}\n";
        }
        public string Use()
        {
            return $"Instructions: {HowToUse}";
        }

    }
}
