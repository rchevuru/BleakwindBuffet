/*
 * Author: Zachery Brunner
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using System.ComponentModel;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

using PointOfSale.CustomizationScreens;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var WW = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(WW);
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var WW = new WarriorWater();

            Assert.PropertyChanged(WW, "Price", () =>
            {
                WW.Size = Size.Medium;
            });

            Assert.PropertyChanged(WW, "Price", () =>
            {
                WW.Size = Size.Large;
            });

            Assert.PropertyChanged(WW, "Price", () =>
            {
                WW.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            var WW = new WarriorWater();

            Assert.PropertyChanged(WW, "Calories", () =>
            {
                WW.Size = Size.Medium;
            });

            Assert.PropertyChanged(WW, "Calories", () =>
            {
                WW.Size = Size.Large;
            });

            Assert.PropertyChanged(WW, "Calories", () =>
            {
                WW.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var WW = new WarriorWater();

            Assert.PropertyChanged(WW, "Ice", () =>
            {
                WW.Ice = true;
            });

            Assert.PropertyChanged(WW, "Ice", () =>
            {
                WW.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var WW = new WarriorWater();

            Assert.PropertyChanged(WW, "SpecialInstructions", () =>
            {
                WW.Ice = true;
            });

            Assert.PropertyChanged(WW, "SpecialInstructions", () =>
            {
                WW.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var WW = new WarriorWater();

            Assert.PropertyChanged(WW, "Lemon", () =>
            {
                WW.Lemon = true;
            });

            Assert.PropertyChanged(WW, "Lemon", () =>
            {
                WW.Lemon = false;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesSpecialInstructionsProperty()
        {
            var WW = new WarriorWater();

            Assert.PropertyChanged(WW, "SpecialInstructions", () =>
            {
                WW.Lemon = true;
            });

            Assert.PropertyChanged(WW, "SpecialInstructions", () =>
            {
                WW.Lemon = false;
            });
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var WW = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(WW);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var WW = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(WW);
        }

        [Fact]
        public void IceShouldBeTrueByDefault()
        {
            var WW = new WarriorWater();
            Assert.True(WW.Ice);
        }

        [Fact]
        public void LemonShouldBeFalseByDefault()
        {
            var WW = new WarriorWater();
            Assert.False(WW.Lemon);
        }

        [Fact]
        public void SizeShouldBeSmallByDefault()
        {
            var WW = new WarriorWater();
            Assert.Equal(Size.Small, WW.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetScreen()
        {
            var WW = new WarriorWater();
            object o = new object();

            WW.Screen = o;
            Assert.Equal(o, WW.Screen);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var WW = new WarriorWater();
            WW.Ice = false;
            Assert.False(WW.Ice);
            WW.Ice = true;
            Assert.True(WW.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            var WW = new WarriorWater();
            WW.Lemon = true;
            Assert.True(WW.Lemon);
            WW.Lemon = false;
            Assert.False(WW.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var WW = new WarriorWater();
            WW.Size = Size.Small;
            Assert.Equal(Size.Small, WW.Size);
            WW.Size = Size.Medium;
            Assert.Equal(Size.Medium, WW.Size);
            WW.Size = Size.Large;
            Assert.Equal(Size.Large, WW.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var WW = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(price, WW.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var WW = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(cal, WW.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            var WW = new WarriorWater()
            {
                Ice = includeIce,
                Lemon = includeLemon
            };
            if (!includeIce) Assert.Contains("Hold ice", WW.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", WW.SpecialInstructions);
            if (includeIce && !includeLemon) Assert.Contains("No special instructions", WW.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectToStringNameBasedOnSize(Size size)
        {
            var WW = new WarriorWater()
            {
                Size = size
            };
            if (size == Size.Small) Assert.Equal("Small Warrior Water", WW.ToStringName);
            if (size == Size.Medium) Assert.Equal("Medium Warrior Water", WW.ToStringName);
            if (size == Size.Large) Assert.Equal("Large Warrior Water", WW.ToStringName);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectNameBasedOnSize(Size size)
        {
            var WW = new WarriorWater()
            {
                Size = size
            };
            if (size == Size.Small) Assert.Equal("Small Warrior Water", WW.ToString());
            if (size == Size.Medium) Assert.Equal("Medium Warrior Water", WW.ToString());
            if (size == Size.Large) Assert.Equal("Large Warrior Water", WW.ToString());
        }
    }
}