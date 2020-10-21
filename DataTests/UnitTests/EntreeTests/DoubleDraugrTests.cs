/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var DD = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(DD);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var DD = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(DD);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var DD = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(DD);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var DD = new DoubleDraugr();
            DD.Bun = false;
            Assert.False(DD.Bun);
            DD.Bun = true;
            Assert.True(DD.Bun);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Bun", () =>
            {
                DD.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "SpecialInstructions", () =>
            {
                DD.Bun = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var DD = new DoubleDraugr();
            DD.Ketchup = false;
            Assert.False(DD.Ketchup);
            DD.Ketchup = true;
            Assert.True(DD.Ketchup);
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Ketchup", () =>
            {
                DD.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "SpecialInstructions", () =>
            {
                DD.Ketchup = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var DD = new DoubleDraugr();
            DD.Mustard = false;
            Assert.False(DD.Mustard);
            DD.Mustard = true;
            Assert.True(DD.Mustard);
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Mustard", () =>
            {
                DD.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "SpecialInstructions", () =>
            {
                DD.Mustard = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var DD = new DoubleDraugr();
            DD.Pickle = false;
            Assert.False(DD.Pickle);
            DD.Pickle = true;
            Assert.True(DD.Pickle);
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Pickle", () =>
            {
                DD.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "SpecialInstructions", () =>
            {
                DD.Pickle = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var DD = new DoubleDraugr();
            DD.Cheese = false;
            Assert.False(DD.Cheese);
            DD.Cheese = true;
            Assert.True(DD.Cheese);
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Cheese", () =>
            {
                DD.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "SpecialInstructions", () =>
            {
                DD.Cheese = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var DD = new DoubleDraugr();
            DD.Tomato = false;
            Assert.False(DD.Tomato);
            DD.Tomato = true;
            Assert.True(DD.Tomato);
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Tomato", () =>
            {
                DD.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "SpecialInstructions", () =>
            {
                DD.Tomato = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var DD = new DoubleDraugr();
            DD.Lettuce = false;
            Assert.False(DD.Lettuce);
            DD.Lettuce = true;
            Assert.True(DD.Lettuce);
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Lettuce", () =>
            {
                DD.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "SpecialInstructions", () =>
            {
                DD.Lettuce = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var DD = new DoubleDraugr();
            DD.Mayo = false;
            Assert.False(DD.Mayo);
            DD.Mayo = true;
            Assert.True(DD.Mayo);
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Mayo", () =>
            {
                DD.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesSpecialInstructionsProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "SpecialInstructions", () =>
            {
                DD.Mayo = false;
            });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            double expectedPrice = 7.32;
            var DD = new DoubleDraugr();
            Assert.Equal(expectedPrice, DD.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint expectedCal = 843;
            var DD = new DoubleDraugr();
            Assert.Equal(expectedCal, DD.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            var DD = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo
            };

            if (!includeBun) Assert.Contains("Hold bun", DD.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", DD.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", DD.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", DD.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", DD.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", DD.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", DD.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", DD.SpecialInstructions);

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese
                    && includeTomato && includeLettuce && includeMayo) Assert.Contains("No special instructions", DD.SpecialInstructions);
        }

        [Fact]
        public void ToStringNameShouldReturnCorrectName()
        {
            var DD = new DoubleDraugr();
            Assert.Equal("Double Draugr", DD.ToStringName);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var DD = new DoubleDraugr();
            Assert.Equal("Double Draugr", DD.ToString());
        }
    }
}