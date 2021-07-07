
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    class Toy : Product
    {
        public Toy(int price, string info, string howToUse) : base(price, info, howToUse)
        {
        }
    }
}
