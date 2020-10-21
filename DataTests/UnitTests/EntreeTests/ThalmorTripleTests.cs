/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var TT = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(TT);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var TT = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(TT);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var TT = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(TT);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var TT = new ThalmorTriple();
            TT.Bun = false;
            Assert.False(TT.Bun);
            TT.Bun = true;
            Assert.True(TT.Bun);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Bun", () =>
            {
                TT.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Bun = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var TT = new ThalmorTriple();
            TT.Ketchup = false;
            Assert.False(TT.Ketchup);
            TT.Ketchup = true;
            Assert.True(TT.Ketchup);
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Ketchup", () =>
            {
                TT.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Ketchup = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var TT = new ThalmorTriple();
            TT.Mustard = false;
            Assert.False(TT.Mustard);
            TT.Mustard = true;
            Assert.True(TT.Mustard);
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Mustard", () =>
            {
                TT.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Mustard = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var TT = new ThalmorTriple();
            TT.Pickle = false;
            Assert.False(TT.Pickle);
            TT.Pickle = true;
            Assert.True(TT.Pickle);
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Pickle", () =>
            {
                TT.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Pickle = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var TT = new ThalmorTriple();
            TT.Cheese = false;
            Assert.False(TT.Cheese);
            TT.Cheese = true;
            Assert.True(TT.Cheese);
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Cheese", () =>
            {
                TT.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Cheese = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var TT = new ThalmorTriple();
            TT.Tomato = false;
            Assert.False(TT.Tomato);
            TT.Tomato = true;
            Assert.True(TT.Tomato);
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Tomato", () =>
            {
                TT.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Tomato = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var TT = new ThalmorTriple();
            TT.Lettuce = false;
            Assert.False(TT.Lettuce);
            TT.Lettuce = true;
            Assert.True(TT.Lettuce);
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Lettuce", () =>
            {
                TT.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Lettuce = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var TT = new ThalmorTriple();
            TT.Mayo = false;
            Assert.False(TT.Mayo);
            TT.Mayo = true;
            Assert.True(TT.Mayo);
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Mayo", () =>
            {
                TT.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Mayo = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            var TT = new ThalmorTriple();
            TT.Bacon = false;
            Assert.False(TT.Bacon);
            TT.Bacon = true;
            Assert.True(TT.Bacon);
        }

        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Bacon", () =>
            {
                TT.Bacon = false;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Bacon = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var TT = new ThalmorTriple();
            TT.Egg = false;
            Assert.False(TT.Egg);
            TT.Egg = true;
            Assert.True(TT.Egg);
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Egg", () =>
            {
                TT.Egg = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesSpecialInstructionsProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "SpecialInstructions", () =>
            {
                TT.Egg = false;
            });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            double expectedPrice = 8.32;
            var TT = new ThalmorTriple();
            Assert.Equal(expectedPrice, TT.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint expectedCal = 943;
            var TT = new ThalmorTriple();
            Assert.Equal(expectedCal, TT.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            var TT = new ThalmorTriple()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo,
                Bacon = includeBacon,
                Egg = includeEgg
            };

            if (!includeBun) Assert.Contains("Hold bun", TT.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", TT.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", TT.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", TT.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", TT.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", TT.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", TT.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", TT.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", TT.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", TT.SpecialInstructions);

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese
                    && includeTomato && includeLettuce && includeMayo && includeBacon && includeEgg) Assert.Contains("No special instructions", TT.SpecialInstructions);
        }

        [Fact]
        public void ToStringNameShouldReturnCorrectName()
        {
            var TT = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", TT.ToStringName);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var TT = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", TT.ToString());
        }
    }
}