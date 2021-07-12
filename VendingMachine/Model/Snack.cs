using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    class Snack : Product
    {
        private string nutritionInfo;
        public Snack(
            string info,
            int price, 
            string howToUse,           
            string nutritionInfo
            ) 
            : base(info, price, howToUse)
        {
            this.NutritionInfo = nutritionInfo;
        }

        public string NutritionInfo { get => nutritionInfo; set => nutritionInfo = value; }

        public override string Examine()
        {
            return $"Info: {this.Info}\nPrice: {this.Price}\nNutrition info: {this.NutritionInfo}\n";
        }
    }
}
