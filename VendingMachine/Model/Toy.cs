
using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    class Toy : Product
    {
        private bool batteryPowered;

        public Toy(bool batteryPowered, 
            int price, 
            string howToUse, 
            string info) 
            : base(price, howToUse, info)
        {
            this.BatteryPowered = batteryPowered;
        }

        public bool BatteryPowered { get => batteryPowered; set => batteryPowered = value; }
        public override string Examine()
        {
            return $"Info: {this.Info}\n Price: {this.Price}\n {IsBatteryPowered()}\n";
        }

        public string IsBatteryPowered()
        {
            if (BatteryPowered) return "Yes";
            else return "No";
        }
    }
}
