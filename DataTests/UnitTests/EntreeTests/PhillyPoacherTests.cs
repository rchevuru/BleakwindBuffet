/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var PP = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(PP);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var PP = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(PP);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var PP = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(PP);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            var PP = new PhillyPoacher();
            Assert.True(PP.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            var PP = new PhillyPoacher();
            Assert.True(PP.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            var PP = new PhillyPoacher();
            Assert.True(PP.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            var PP = new PhillyPoacher();
            PP.Sirloin = false;
            Assert.False(PP.Sirloin);
            PP.Sirloin = true;
            Assert.True(PP.Sirloin);
        }

        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var PP = new PhillyPoacher();

            Assert.PropertyChanged(PP, "Sirloin", () =>
            {
                PP.Sirloin = false;
            });
        }

        [Fact]
        public void ChangingSirloinNotifiesSpecialInstructionsProperty()
        {
            var PP = new PhillyPoacher();

            Assert.PropertyChanged(PP, "SpecialInstructions", () =>
            {
                PP.Sirloin = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            var PP = new PhillyPoacher();
            PP.Onion = false;
            Assert.False(PP.Onion);
            PP.Onion = true;
            Assert.True(PP.Onion);
        }

        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var PP = new PhillyPoacher();

            Assert.PropertyChanged(PP, "Onion", () =>
            {
                PP.Onion = false;
            });
        }

        [Fact]
        public void ChangingOnionNotifiesSpecialInstructionsProperty()
        {
            var PP = new PhillyPoacher();

            Assert.PropertyChanged(PP, "SpecialInstructions", () =>
            {
                PP.Onion = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            var PP = new PhillyPoacher();
            PP.Roll = false;
            Assert.False(PP.Roll);
            PP.Roll = true;
            Assert.True(PP.Roll);
        }

        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var PP = new PhillyPoacher();

            Assert.PropertyChanged(PP, "Roll", () =>
            {
                PP.Roll = false;
            });
        }

        [Fact]
        public void ChangingRollNotifiesSpecialInstructionsProperty()
        {
            var PP = new PhillyPoacher();

            Assert.PropertyChanged(PP, "SpecialInstructions", () =>
            {
                PP.Roll = false;
            });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            double expectedPrice = 7.23;
            var PP = new PhillyPoacher();
            Assert.Equal(expectedPrice, PP.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint expectedCal = 784;
            var PP = new PhillyPoacher();
            Assert.Equal(expectedCal, PP.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            var PP = new PhillyPoacher()
            {
                Sirloin = includeSirloin,
                Onion = includeOnion,
                Roll = includeRoll
            };
            if (!includeSirloin) Assert.Contains("Hold sirloin", PP.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onion", PP.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", PP.SpecialInstructions);

            if (includeSirloin && includeOnion && includeRoll) Assert.Contains("No special instructions", PP.SpecialInstructions);
        }

        [Fact]
        public void ToStringNameShouldReturnCorrectName()
        {
            var PP = new PhillyPoacher();
            Assert.Equal("Philly Poacher", PP.ToStringName);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var PP = new PhillyPoacher();
            Assert.Equal("Philly Poacher", PP.ToString());
        }
    }
}