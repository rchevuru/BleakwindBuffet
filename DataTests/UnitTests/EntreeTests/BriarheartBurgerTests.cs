/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var BB = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(BB);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var BB = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(BB);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var BB = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(BB);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var BB = new BriarheartBurger();
            BB.Bun = false;
            Assert.False(BB.Bun);
            BB.Bun = true;
            Assert.True(BB.Bun);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Bun", () =>
            {
                BB.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "SpecialInstructions", () =>
            {
                BB.Bun = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var BB = new BriarheartBurger();
            BB.Ketchup = false;
            Assert.False(BB.Ketchup);
            BB.Ketchup = true;
            Assert.True(BB.Ketchup);
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Ketchup", () =>
            {
                BB.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "SpecialInstructions", () =>
            {
                BB.Ketchup = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var BB = new BriarheartBurger();
            BB.Mustard = false;
            Assert.False(BB.Mustard);
            BB.Mustard = true;
            Assert.True(BB.Mustard);
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Mustard", () =>
            {
                BB.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "SpecialInstructions", () =>
            {
                BB.Mustard = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var BB = new BriarheartBurger();
            BB.Pickle = false;
            Assert.False(BB.Pickle);
            BB.Pickle = true;
            Assert.True(BB.Pickle);
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Pickle", () =>
            {
                BB.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "SpecialInstructions", () =>
            {
                BB.Pickle = false;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var BB = new BriarheartBurger();
            BB.Cheese = false;
            Assert.False(BB.Cheese);
            BB.Cheese = true;
            Assert.True(BB.Cheese);
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Cheese", () =>
            {
                BB.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "SpecialInstructions", () =>
            {
                BB.Cheese = false;
            });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            double expectedPrice = 6.32;
            var BB = new BriarheartBurger();
            Assert.Equal(expectedPrice, BB.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint expectedCal = 743;
            var BB = new BriarheartBurger();
            Assert.Equal(expectedCal, BB.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            var BB = new BriarheartBurger()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese
            };

            if (!includeBun) Assert.Contains("Hold bun", BB.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", BB.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", BB.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", BB.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", BB.SpecialInstructions);

            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese) Assert.Contains("No special instructions", BB.SpecialInstructions);
        }

        [Fact]
        public void ToStringNameShouldReturnCorrectName()
        {
            var BB = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", BB.ToStringName);
        }

        [Fact]
        public void ShouldReturnCorrectName()
        {
            var BB = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", BB.ToString());
        }
    }
}