using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    class Snack : Product
    {
        private string nutritionInfo;
        public Snack(string nutritionInfo, 
            int price, 
            string howToUse, 
            string info) 
            : base(price, howToUse, info)
        {
            this.NutritionInfo = nutritionInfo;
        }

        public string NutritionInfo { get => nutritionInfo; set => nutritionInfo = value; }

        public override string Examine()
        {
            return $"Info: {this.Info}\n Price: {this.Price}\n Nutrition info: {this.NutritionInfo}\n";
        }
    }
}
