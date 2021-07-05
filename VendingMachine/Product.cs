using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class Product
    {
        int price;
        string info;
        string howToUse;

        public Product(int price, string info, string howToUse)
        {
            this.price = price;
            this.info = info;
            this.howToUse = howToUse;
        }

        public void Examine()
        {
            Console.Write(info + " \n price: " + price + "\n");
        }
        public void Use()
        {
            Console.WriteLine("Instructions: " + howToUse);
        }

    }
}
