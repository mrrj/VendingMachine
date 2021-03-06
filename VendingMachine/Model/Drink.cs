using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public class Drink : Product
    {
        private string taste;

        public Drink(
            string info,
            int price, 
            string howToUse,
            string taste
            ) 
            : base(info, price, howToUse)
        {
            this.Taste = taste;
        }

        public string Taste { get => taste; set => taste = value; }

        public override string Examine()
        {
            return $"Info: {this.Info}\nPrice: {this.Price}\nTaste: {this.Taste}\n";
        }
    }

    
}
