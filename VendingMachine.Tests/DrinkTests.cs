using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachine.Model;

namespace VendingMachine.Tests
{
    public class DrinkTests
    {
        [Fact]
        public void HasCorrectPrice()
        {
            Drink drink = new Drink("Coffee", 10, "Let cool, then sip", "Cinnamon");

            int expectedPrice = 10;
            int actualPrice = drink.Price;

            Assert.Equal(expectedPrice,actualPrice);
            
        }
    }
}
