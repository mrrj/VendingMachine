using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachine.Model;

namespace VendingMachine.Tests
{
    public class SnackTests
    {
        [Fact]
        public void HasCorrectPrice()
        {
            Snack chocolate = new Snack("Chocolate", 20, "Munch it!", "Good for the soul");

            int expectedPrice = 20;
            int actualPrice = chocolate.Price;

            Assert.Equal(expectedPrice, actualPrice);

        }
    }
}
