using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    class Drink : Product
    {
        public Drink(int price, string info, string howToUse) : base(price, info, howToUse)
        {
        }
    }
}
