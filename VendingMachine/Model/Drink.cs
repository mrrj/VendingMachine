using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    class Drink : Product
    {
        private string taste;

        public Drink(string taste,
            int price, 
            string howToUse, 
            string info) 
            : base(price, howToUse, info)
        {
            this.Taste = taste;
        }

        public string Taste { get => taste; set => taste = value; }

        public override string Examine()
        {
            return $"Info: {this.Info}\n Price: {this.Price}\n Taste: {this.Taste}\n";
        }
    }

    
}
