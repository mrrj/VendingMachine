using System;
using System.Collections.Generic;
using Xunit;
using VendingMachine.Model;

namespace VendingMachine.Tests
{
    public class VendingMachineTests
    {
        [Fact]
        public void NoMoneyBeforeInsert()
        {
            List<Product> prods = new List<Product>();

            Toy toy = new Toy("Car", 10, "Roll it on the floor", false);
            Drink drink = new Drink("Soda", 20, "Drink", "Orange");
            prods.Add(toy);
            prods.Add(drink);

            VendingMachine vm = new VendingMachine(prods);

            int expectedAmountOfMoney = 0;
            int actualAmountOfMoney = vm.TotalAmountOfMoney();

            Assert.Equal(expectedAmountOfMoney, actualAmountOfMoney);
        }

        [Fact]
        public void HasMoneyAfterInsert()
        {
            List<Product> prods = new List<Product>();

            Toy toy = new Toy("Car", 10, "Roll it on the floor", false);
            Drink drink = new Drink("Soda", 20, "Drink", "Orange");
            prods.Add(toy);
            prods.Add(drink);

            VendingMachine vm = new VendingMachine(prods);

            vm.InsertMoney(20);

            int expectedAmountOfMoney = 20;
            int actualAmountOfMoney = vm.TotalAmountOfMoney();

            Assert.Equal(expectedAmountOfMoney, actualAmountOfMoney);
        }

        [Fact]
        public void CannotInsertWrongAmountOfMoney()
        {
            List<Product> prods = new List<Product>();

            Toy toy = new Toy("Car", 10, "Roll it on the floor", false);
            Drink drink = new Drink("Soda", 20, "Drink", "Orange");
            prods.Add(toy);
            prods.Add(drink);

            VendingMachine vm = new VendingMachine(prods);

            Assert.Throws<Exception>(() => vm.InsertMoney(30));
        }

        [Fact]
        public void NoMoneyAfterTransaction()
        {
            List<Product> prods = new List<Product>();

            Toy toy = new Toy("Car", 10, "Roll it on the floor", false);
            Drink drink = new Drink("Soda", 20, "Drink", "Orange");
            prods.Add(toy);
            prods.Add(drink);

            VendingMachine vm = new VendingMachine(prods);

            vm.InsertMoney(10);
            vm.InsertMoney(20);
            vm.Purchase(toy);
            vm.EndTransaction();


            int expectedAmountOfMoney = 0;
            int actualAmountOfMoney = vm.TotalAmountOfMoney();

            Assert.Equal(expectedAmountOfMoney, actualAmountOfMoney);
        }
        [Fact]
        public void CorrectMoneyAfterPurchase()
        {
            List<Product> prods = new List<Product>();

            Toy toy = new Toy("Car", 10, "Roll it on the floor", false);
            Drink drink = new Drink("Soda", 20, "Drink", "Orange");
            prods.Add(toy);
            prods.Add(drink);

            VendingMachine vm = new VendingMachine(prods);

            vm.InsertMoney(10);
            vm.InsertMoney(20);
            vm.Purchase(toy);


            int expectedAmountOfMoney = 20;
            int actualAmountOfMoney = vm.TotalAmountOfMoney();

            Assert.Equal(expectedAmountOfMoney, actualAmountOfMoney);
        }
    }
}
