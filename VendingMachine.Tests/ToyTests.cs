using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachine.Model;

namespace VendingMachine.Tests
{
    public class ToyTests
    {
        [Fact]
        public void HasCorrectPrice()
        {
            Toy horse = new Toy("Horse", 50, "Pess button and hear a lovely neigh", true);

            int expectedPrice = 50;
            int actualPrice = horse.Price;

            Assert.Equal(expectedPrice, actualPrice);

        }

    }
}
