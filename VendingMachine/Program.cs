using System;
using System.Collections.Generic;
using VendingMachine.Model;


namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prods = new List<Product>();

            Toy toy = new Toy("Car", 10, "Roll it on the floor", false);
            Drink drink = new Drink("Soda", 20, "Drink", "Orange");
            prods.Add(toy);
            prods.Add(drink);

            VendingMachine vm = new VendingMachine(prods);

            string seeProds = vm.ShowAll();

            Console.WriteLine(seeProds);
            vm.InsertMoney(50);
            vm.Purchase(toy);

            Dictionary<int, int> change = vm.EndTransaction();

            foreach (var key in change.Keys)
            {
                Console.WriteLine("Key of the Dictionary Item is: {0}", key);
            }

            foreach (var value in change.Values)
            {
                Console.WriteLine("Value of the Dictionary Item is: {0}", value);
            }
        }
    }
}
