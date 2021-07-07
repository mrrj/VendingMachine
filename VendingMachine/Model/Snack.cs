using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    class Snack : Product
    {
        public Snack(int price, string info, string howToUse) : base(price, info, howToUse)
        {
        }
    }
}
