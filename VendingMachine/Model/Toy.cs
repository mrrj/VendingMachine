
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    class Toy : Product
    {
        private bool batteryPowered;

        public Toy(
            string info,
            int price,
            string howToUse,
            bool batteryPowered
            ) 
            : base(info, price, howToUse)
        {
            this.BatteryPowered = batteryPowered;
        }

        public bool BatteryPowered { get => batteryPowered; set => batteryPowered = value; }
        public override string Examine()
        {
            return $"Info: {this.Info}\nPrice: {this.Price}\nRequires batteries: {IsBatteryPowered()}\n";
        }

        public string IsBatteryPowered()
        {
            if (BatteryPowered) return "Yes";
            else return "No";
        }
    }
}
