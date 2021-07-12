using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class Product
    {
        int price;
        string howToUse;
        string info;

        public Product(string info, int price, string howToUse)
        {
            this.Price = price;
            this.HowToUse = howToUse;
            this.Info = info;
        }

        public int Price { get => price; set => price = value; }
        public string HowToUse { get => howToUse; set => howToUse = value; }
        public string Info { get => info; set => info = value; }

        public abstract string Examine();
        public string Use()
        {
            return $"Instructions: {HowToUse}";
        }

        public override string ToString()
        {
            return $"{Info}\n";
        }

    }
}
